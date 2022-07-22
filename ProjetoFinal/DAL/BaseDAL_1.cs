using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinal.DAL
{
    static class BaseDAL
    {
        public static string connStr { get;} = "datasource=localhost;port=3306;username=root;password=;database=osteo_spa;SslMode=none";
    }
}
