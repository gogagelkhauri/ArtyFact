using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities.Basket;

namespace Web.ViewModels
{
    public class CustomerInformationViewModel
    {
        public Basket Basket { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

    }
}
