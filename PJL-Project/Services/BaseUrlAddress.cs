using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJL_Project.Services
{
    internal class BaseUrlAddress
    {
        private const string Url = "http://10.0.2.2:5214";

        public static string UrlRotaApi => $"{Url}/api/";
    }
}
