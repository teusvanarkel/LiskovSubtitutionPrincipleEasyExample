namespace LiskovSubstitutionExample.Models
{
    public class Product:IModel
    {
        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}