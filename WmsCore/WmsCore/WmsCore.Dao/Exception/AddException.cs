using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class AddException : System.ApplicationException
    {
        public AddException()
            : base()
        {
        }

        public AddException(string strMessage)
            : base(strMessage)
        {
        }
    }
}