using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CW.COMMON
{
    public partial class CWConfiguration
    {
        public static string ConnectionString { get { return ConfigurationManager.AppSettings["ConnectionString"].ToString(); } }

        public static string Company { get { return ConfigurationManager.AppSettings["Company"].ToString(); } }
    }
}
