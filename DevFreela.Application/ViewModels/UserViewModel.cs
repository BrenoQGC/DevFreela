using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string username, string email)
        {
            FullName = username;
            Email = email;
        }

        public string FullName { get; set; }
        public string Email { get; set; }
    }
}
