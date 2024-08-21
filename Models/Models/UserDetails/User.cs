using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Models.Models.UserDetails
{
    public class User
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public string LName { get; set; }
        public string DisplayName { get; set; }
        public string JobTitle { get; set; }
        public string AdId { get; set; }
        public string Email { get; set; }
        public string MobilePhone { get; set; }
        public DateTime LastLogin { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }       
        public int CompanyId { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }       
        public string Password { get; set; }
       
    }
}
