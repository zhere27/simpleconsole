using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class PageException : System.ApplicationException
    {
        public PageException()
            : base()
        {
        }

        public PageException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public PageException(string strMessage)
            : base(strMessage)
        {
        }

        public PageException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}