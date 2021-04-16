using System;
using LiskovSubstitutionExample.Invoices;
using LiskovSubstitutionExample.Models;

namespace LiskovSubstitutionExample
{
    public class BestCustomerInvoice : Invoice
    {
        public BestCustomerInvoice(Order order)
        {
            Order = order;
            Discount = 20;
            Debreviation ="Best";
        }
        public override decimal GetTotalAmount()
        {
            var total = (Order.Amount * Order.Product.Price) * (100 - Discount);
            return total;
        }

        public override void SetInvoiceNumber(int number)
        {
            if(number == 0 || number > 1000.000) throw new ArgumentException(nameof(number));
            InvoiceNumber = Debreviation + number.ToString();
        }
    }
}