using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Configuration
{
    public class ConfigMaster
    {
       public int ID { get; set; }  
        public string ConfigName { get; set; }  
        public string ConfigValue { get; set; }
        public string ConfigCatagory { get; set; }  
    }
}
