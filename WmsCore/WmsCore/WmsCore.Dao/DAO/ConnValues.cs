using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace WmsCore.Dao.DAO
{
    public class ConnValues
    {
        public string conn()
        {
            string connstring = null;

            connstring = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            return connstring;
        }
    }
}