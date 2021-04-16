using System;
using LiskovSubstitutionExample.Models;

namespace LiskovSubstitutionExample.Invoices
{
    public class Invoice
    {
        public string Debreviation { get; set; } ="Normal";
        public Order Order { get; set; }
        public int Discount { get; set; } = 5;
        public Decimal Total { get; set; }
        public string InvoiceNumber { get; set; }

        public virtual decimal GetTotalAmount()
        {
            var total = (Order.Amount * Order.Product.Price) * (100 - Discount);
            return total;
        }

        public virtual void SetInvoiceNumber(int number)
        {
            if(number == 0 || number > 1000.000) throw new ArgumentException(nameof(number));
            InvoiceNumber = number.ToString();
        }
    }
}