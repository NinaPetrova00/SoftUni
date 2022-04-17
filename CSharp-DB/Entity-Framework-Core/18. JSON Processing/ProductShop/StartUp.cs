using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ProductShop.Data;
using ProductShop.Dtos.Input;
using ProductShop.Dtos.Output;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        private static IMapper mapper;
        public static void Main(string[] args)
        {
            var context = new ProductShopContext();
            //context.Database.EnsureDeleted();
            //context.Database.EnsureCreated();

            //var usersJsonAsString = File.ReadAllText("../../../Datasets/users.json");
            //var productsJsonAsString = File.ReadAllText("../../../Datasets/products.json");
            //var categoriesJsonAsString = File.ReadAllText("../../../Datasets/categories.json");
            //var categoryProductJsonAsString = File.ReadAllText("../../../Datasets/categories-products.json");

            //Console.WriteLine(ImportUsers(context, usersJsonAsString));
            //Console.WriteLine(ImportProducts(context, productsJsonAsString));
            //Console.WriteLine(ImportCategories(context, categoriesJsonAsString));
            //Console.WriteLine(ImportCategoryProducts(context, categoryProductJsonAsString));

            Console.WriteLine(GetProductsInRange(context));
            Console.WriteLine(GetSoldProducts(context));
            //Console.WriteLine(GetCategoriesByProductsCount(context));
        }
        // Auto-mapping

        //Import data 01-04 problem

        //Problem 01 
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            IEnumerable<UserInputDto> users = JsonConvert.DeserializeObject<IEnumerable<UserInputDto>>(inputJson);
            InitializeMapper();

            IEnumerable<User> mappedUsers = mapper.Map<IEnumerable<User>>(users);

            context.Users.AddRange(mappedUsers);
            context.SaveChanges();

            return $"Successfully imported {mappedUsers.Count()}";
        }

        // Problem 02
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            IEnumerable<ProductImputDto> products = JsonConvert.DeserializeObject<IEnumerable<ProductImputDto>>(inputJson);
            InitializeMapper();

            IEnumerable<Product> mappedProducts = mapper.Map<IEnumerable<Product>>(products);

            context.Products.AddRange(mappedProducts);
            context.SaveChanges();

            return $"Successfully imported {mappedProducts.Count()}";
        }

        //Problem 03
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            IEnumerable<CategoryInputDto> categories = JsonConvert
                .DeserializeObject<IEnumerable<CategoryInputDto>>(inputJson)
                .Where(x => !string.IsNullOrEmpty(x.Name));

            InitializeMapper();

            IEnumerable<Category> mappedCategories = mapper.Map<IEnumerable<Category>>(categories);

            context.Categories.AddRange(mappedCategories);
            context.SaveChanges();
            return $"Successfully imported {mappedCategories.Count()}";
        }

        // Problem 04
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            IEnumerable<CategoryProductInputDto> categoryProducts = JsonConvert
                .DeserializeObject<IEnumerable<CategoryProductInputDto>>(inputJson);

            InitializeMapper();

            IEnumerable<CategoryProduct> mappedCategoryProducts = mapper.Map<IEnumerable<CategoryProduct>>(categoryProducts);

            context.CategoryProducts.AddRange(mappedCategoryProducts);
            context.SaveChanges();
            return $"Successfully imported {mappedCategoryProducts.Count()}";
        }
        private static void InitializeMapper()
        {
            var mapperConfuguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ProductShopProfile>();
            });
            mapper = new Mapper(mapperConfuguration);
        }


        // Export data 05-08 problem

        // Problem 05
        public static string GetProductsInRange(ProductShopContext context)
        {

            var products = context
                .Products
                .Include(x => x.Seller)
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .OrderBy(x => x.Price)
                .Select(x => new ProductOutputDto
                {
                    Name = x.Name,
                    Price = x.Price,
                    Seller = $"{x.Seller.FirstName} {x.Seller.LastName}"
                })
                .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };
            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string productAsJson = JsonConvert.SerializeObject(products, jsonSettings);

            return productAsJson;
        }

        //Problem 06
        public static string GetSoldProducts(ProductShopContext context)
        {
            var usersWithSoldProducts = context.Users
                .Include(p => p.ProductsSold)
                .Where(x => x.ProductsSold.Any(y => y.Buyer != null))
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Select(x => new UserSoldProductOutputDto
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    SoldProducts = x.ProductsSold
                    .Select(p => new SoldProductOutputDto
                    {
                        Name = p.Name,
                        Price = p.Price,
                        BuyerFirstName = p.Buyer.FirstName,
                        BuyerLastName = p.Seller.LastName
                    })
                    .ToList()
                })
                .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };
            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string usersWithSoldProductsAsJson = JsonConvert.SerializeObject(usersWithSoldProducts, jsonSettings);

            return usersWithSoldProductsAsJson;
        }

        //Problem 07
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var result = context.Categories
                .OrderByDescending(x => x.CategoryProducts.Count())
                .Select(x => new
                {
                    Category = x.Name,
                    ProductsCount = x.CategoryProducts.Count(),
                    AveragePrice = $"{x.CategoryProducts.Average(cp => cp.Product.Price):f2}",
                    TotalRevenue = $"{x.CategoryProducts.Sum(cp => cp.Product.Price):f2}"
                })
                .ToList();

            DefaultContractResolver contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };
            var jsonSettings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = contractResolver
            };

            string resultAsJson = JsonConvert.SerializeObject(result, jsonSettings);

            return resultAsJson;
        }
    }
}