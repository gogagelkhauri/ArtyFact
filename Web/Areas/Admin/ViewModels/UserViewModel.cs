using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web.Areas.Admin.ViewModels
{
    public class UserViewModel
    {
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}