using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class DuplicateKeyException : System.ApplicationException
    {
        public DuplicateKeyException()
            : base()
        {
        }

        public DuplicateKeyException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public DuplicateKeyException(string strMessage)
            : base(strMessage)
        {
        }

        public DuplicateKeyException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}