using System.Collections.Generic;
using LiskovSubstitutionExample.Enums;

namespace LiskovSubstitutionExample.Models
{

    public class Customer :IModel
    {
        public string Name { get; set; }

        public CustomerType TypeCustomer {get;set;}

    }
}