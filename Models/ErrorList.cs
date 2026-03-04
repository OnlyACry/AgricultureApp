using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AgricultureApp.Models
{
    public class ErrorModel
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Color { get; set; }
    }
}
