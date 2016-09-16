using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class ActionExceptions : System.ApplicationException
    {
        public ActionExceptions()
            : base()
        {
        }

        public ActionExceptions(string strMessage)
            : base(strMessage)
        {
        }
    }
}