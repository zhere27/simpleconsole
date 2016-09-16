using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class RevokeUserException : System.ApplicationException
    {
        public RevokeUserException()
            : base()
        {
        }

        public RevokeUserException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public RevokeUserException(string strMessage)
            : base(strMessage)
        {
        }

        public RevokeUserException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}