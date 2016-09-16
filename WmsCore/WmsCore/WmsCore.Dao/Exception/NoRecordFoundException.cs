using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class NoRecordFoundException : System.ApplicationException
    {
        public NoRecordFoundException()
            : base()
        {
        }

        public NoRecordFoundException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public NoRecordFoundException(string strMessage)
            : base(strMessage)
        {
        }

        public NoRecordFoundException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}