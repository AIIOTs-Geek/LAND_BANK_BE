
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.ViewModels
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string Token { get; set; }
        public string? MobilePhone { get; set; }
        public DateTime Expiration { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Displayname { get; set; }
        public string Position { get; set; }
        public bool PhysicalSignature { get; set; }

    }
}

