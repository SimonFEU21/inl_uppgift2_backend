using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;



namespace Inl.Uppgift_2_WebApi_CosmosDB.Models
{
    public class Product
    {
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string Description { get; set; } = null!;

    }
}
