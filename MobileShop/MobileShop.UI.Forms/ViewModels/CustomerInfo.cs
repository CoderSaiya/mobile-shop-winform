using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShop.UI.Forms.ViewModels
{
    public class CustomerInfo
    {
        public string Name { get; }
        public string Mobile { get; }
        public string Email { get; }
        public string Address { get; }

        public CustomerInfo(string name, string mobile, string email, string address)
        {
            Name = name;
            Mobile = mobile;
            Email = email;
            Address = address;
        }
    }
}
