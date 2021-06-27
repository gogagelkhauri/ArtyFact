using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Web.ViewModels
{
    public class MyOrdersViewModel
    {
        public List<Order> Order { get; set; }
    }
}
