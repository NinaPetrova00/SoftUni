namespace CarDealer
{
    using CarDealer.Data;
    using CarDealer.DTO.ExportDto;
    using CarDealer.DTO.ImportDto;
    using CarDealer.Models;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml.Serialization;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext dbContext = new CarDealerContext();

            //ResetDb(dbContext);

            //string inputXml = File.ReadAllText("../../../Datasets/suppliers.xml");
            //string result = ImportSuppliers(dbContext, inputXml);
            //Console.WriteLine(result);

            //string inputXml = File.ReadAllText("../../../Datasets/parts.xml");
            //string result = ImportParts(dbContext, inputXml);
            //Console.WriteLine(result);

            //string inputXml = File.ReadAllText("../../../Datasets/cars.xml");
            //string result = ImportCars(dbContext, inputXml);
            //Console.WriteLine(result);

            //string inputXml = File.ReadAllText("../../../Datasets/customers.xml");
            //string result = ImportCustomers(dbContext, inputXml);
            //Console.WriteLine(result);

            //string inputXml = File.ReadAllText("../../../Datasets/sales.xml");
            //string result = ImportSales(dbContext, inputXml);
            //Console.WriteLine(result);

            //string result = GetCarsWithDistance(dbContext);
            //Console.WriteLine(result);

            //string result = GetSalesWithAppliedDiscount(dbContext);
            //Console.WriteLine(result);

            //string result = GetCarsFromMakeBmw(dbContext);
            //Console.WriteLine(result);

            //string result = GetLocalSuppliers(dbContext);
            //Console.WriteLine(result);

            string result = GetCarsWithTheirListOfParts(dbContext);
            Console.WriteLine(result);

        }
        //----->Import data 09-13

        //Problem 09
        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Suppliers"); //suppliers - xmlrootName
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportSupplierDto[]), xmlRoot);  //whole document(supplier.html) contains
                                                                                                    //a lot of Dtos,that's why we make array []
            using StringReader stringReader = new StringReader(inputXml);

            ImportSupplierDto[] dtos = (ImportSupplierDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Supplier> suppliers = new HashSet<Supplier>();

            foreach (ImportSupplierDto supplierDto in dtos)
            {
                Supplier s = new Supplier()
                {
                    Name = supplierDto.Name,
                    IsImporter = bool.Parse(supplierDto.IsImporter)
                };

                suppliers.Add(s);
            }

            context.Suppliers.AddRange(suppliers);
            context.SaveChanges();

            return $"Successfully imported {suppliers.Count}";
        }

        //Problem 10
        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute("Parts");
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ImportPartsDto[]), xmlRoot);

            using StringReader stringReader = new StringReader(inputXml);

            ImportPartsDto[] dtos = (ImportPartsDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Part> parts = new HashSet<Part>();

            foreach (ImportPartsDto partDto in dtos)
            {
                Supplier supplier = context
                    .Suppliers
                    .Find(partDto.SupplierId);

                if (supplier == null)
                {
                    continue;
                }

                Part p = new Part()
                {
                    Name = partDto.Name,
                    Price = decimal.Parse(partDto.Price),
                    Quantity = partDto.Quantity,
                    Supplier = supplier
                };

                parts.Add(p);
            }

            context.Parts.AddRange(parts);
            context.SaveChanges();

            return $"Successfully imported {parts.Count}";
        }

        //Problem 11
        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlSerializer("Cars", typeof(ImportCarDto[]));
            using StringReader stringReader = new StringReader(inputXml);

            ImportCarDto[] carDtos = (ImportCarDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Car> cars = new HashSet<Car>();

            foreach (ImportCarDto carDto in carDtos)
            {
                Car car = new Car()
                {
                    Make = carDto.Make,
                    Model = carDto.Model,
                    TravelledDistance = carDto.TraveledDistance
                };

                ICollection<PartCar> currentCarParts = new HashSet<PartCar>();

                foreach (int partId in carDto.Parts.Select(p => p.Id).Distinct())
                {
                    Part part = context.Parts.Find(partId);

                    if (part == null)
                    {
                        continue;
                    }

                    PartCar partCar = new PartCar()
                    {
                        Car = car,
                        Part = part
                    };

                    currentCarParts.Add(partCar);
                }
                car.PartCars = currentCarParts;
                cars.Add(car);
            }
            context.Cars.AddRange(cars);
            context.SaveChanges();

            return $"Successfully imported {cars.Count}";
        }

        //Problem 12
        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlSerializer("Customers", typeof(ImportCustomerDto[]));
            using StringReader stringReader = new StringReader(inputXml);

            ImportCustomerDto[] customerDtos = (ImportCustomerDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Customer> customers = new HashSet<Customer>();

            foreach (ImportCustomerDto customerDto in customerDtos)
            {
                Customer customer = new Customer
                {
                    Name = customerDto.Name,
                    BirthDate = DateTime.Parse(customerDto.BirthDate),
                    IsYoungDriver = customerDto.IsYoungDriver
                };
                customers.Add(customer);
            }
            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Count}";
        }

        //Problem 13
        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = GenerateXmlSerializer("Sales", typeof(ImportSaleDto[]));
            using StringReader stringReader = new StringReader(inputXml);

            ImportSaleDto[] salesDto = (ImportSaleDto[])xmlSerializer.Deserialize(stringReader);

            ICollection<Sale> sales = new HashSet<Sale>();

            foreach (ImportSaleDto saleDto in salesDto)
            {
                if (context.Cars.Any(c => c.Id == saleDto.CarId))
                {
                    Sale sale = new Sale
                    {
                        CarId = saleDto.CarId,
                        CustomerId = saleDto.CustomerId,
                        Discount = saleDto.CarId
                    };
                    sales.Add(sale);
                }
            }
            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Count}";
        }

        //----->Export data 14-19

        //Problem 14
        public static string GetCarsWithDistance(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("cars", typeof(ExportCarsWithDistanceDto[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty); //prefix ->empty, namespace ->empty

            ExportCarsWithDistanceDto[] carsDtos = context.Cars
                .Where(c => c.TravelledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .Select(c => new ExportCarsWithDistanceDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance.ToString()
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, carsDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem 15
        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("cars", typeof(ExportCarsFromMakeBmwDto[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            ExportCarsFromMakeBmwDto[] bmwDtos = context
                .Cars
                .Where(c => c.Make == "BMW")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TravelledDistance)
                .Select(c => new ExportCarsFromMakeBmwDto()
                {
                    Id = c.Id,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, bmwDtos, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem 16
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("suppliers", typeof(ExportLocalSuppliersDto[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            ExportLocalSuppliersDto[] suppliersDto = context
                .Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new ExportLocalSuppliersDto()
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, suppliersDto, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem 17
        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("cars", typeof(ExportCarsWithTheirListOfPartsDto[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(String.Empty, String.Empty);

            ExportCarsWithTheirListOfPartsDto[] carsDto = context
                .Cars
                .OrderByDescending(c => c.TravelledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .Select(c => new ExportCarsWithTheirListOfPartsDto()
                {
                    Make = c.Make,
                    Model = c.Model,
                    TravelledDistance = c.TravelledDistance,
                    Parts = c.PartCars.Select(p => new ExportCarsWithPartsDto()
                    {
                        Name = p.Part.Name,
                        Price = p.Part.Price
                    })
                    .OrderByDescending(p => p.Price)
                    .ToArray()
                })
                .ToArray();


            xmlSerializer.Serialize(stringWriter, carsDto, namespaces);

            return sb.ToString().TrimEnd();
        }

        //Problem 18
        //public static string GetTotalSalesByCustomer(CarDealerContext context)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    using StringWriter stringWriter = new StringWriter(sb);

        //    XmlSerializer xmlSerializer = GenerateXmlSerializer("customer", typeof(ExportTotalSalesByCustomerDto[]));

        //    XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
        //    namespaces.Add(String.Empty, String.Empty);

        //    ExportTotalSalesByCustomerDto[] customerDtos = context
        //        .Customers
        //        .Select(c => new ExportTotalSalesByCustomerDto()
        //        {
        //            FullName = c.Name,
        //            BoughtCars = c.Sales.Count,
                   
        //        }).
 
        //}


        //Problem 19
        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            StringBuilder sb = new StringBuilder();
            using StringWriter stringWriter = new StringWriter(sb);

            XmlSerializer xmlSerializer = GenerateXmlSerializer("sales", typeof(ExportSalesWithDiscountDto[]));

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add(string.Empty, string.Empty);

            ExportSalesWithDiscountDto[] dtos = context.Sales
                .Select(s => new ExportSalesWithDiscountDto()
                {
                    Car = new ExportSalesWithDiscountCarDto()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TravelledDistance = s.Car.TravelledDistance.ToString()
                    },
                    Discount = s.Discount.ToString(CultureInfo.InvariantCulture),
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartCars.Sum(pc => pc.Part.Price).ToString(CultureInfo.InvariantCulture),
                    PriceWithDiscount = (s.Car.PartCars.Sum(pc => pc.Part.Price) -
                    s.Car.PartCars.Sum(pc => pc.Part.Price) * s.Discount / 100).ToString(CultureInfo.InvariantCulture)
                })
                .ToArray();

            xmlSerializer.Serialize(stringWriter, dtos, namespaces);

            return sb.ToString().TrimEnd();
        }
        private static XmlSerializer GenerateXmlSerializer(string rootName, Type dtoType)
        {
            XmlRootAttribute xmlRoot = new XmlRootAttribute(rootName); //suppliers - xmlrootName
            XmlSerializer xmlSerializer = new XmlSerializer(dtoType, xmlRoot);  //whole document(supplier.html) contains
                                                                                //a lot of Dtos,that's why we make array []
            return xmlSerializer;
        }
        private static void ResetDb(CarDealerContext dbContext)
        {
            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            System.Console.WriteLine("Db reset was successful!");
        }
    }
}