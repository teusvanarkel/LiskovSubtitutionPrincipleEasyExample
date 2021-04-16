namespace LiskovSubstitutionExample.Models
{
    public class Order:IModel
    {
        public Product Product { get; set; }

        public int Amount { get; set; }

        public Customer Customer { get; set; }
    }
}