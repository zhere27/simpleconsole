using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class SearchException : System.ApplicationException
    {
        public SearchException()
            : base()
        {
        }

        public SearchException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public SearchException(string strMessage)
            : base(strMessage)
        {
        }

        public SearchException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}