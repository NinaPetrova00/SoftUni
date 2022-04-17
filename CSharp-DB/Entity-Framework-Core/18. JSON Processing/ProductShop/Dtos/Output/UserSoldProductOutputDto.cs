namespace ProductShop.Dtos.Output
{
    using System.Collections.Generic;
    public class UserSoldProductOutputDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<SoldProductOutputDto> SoldProducts { get; set; }
    }
}
