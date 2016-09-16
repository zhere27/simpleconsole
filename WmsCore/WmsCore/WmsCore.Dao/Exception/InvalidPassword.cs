using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class InvalidPassword : System.ApplicationException
    {
        public InvalidPassword()
            : base()
        {
        }

        public InvalidPassword(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public InvalidPassword(string strMessage)
            : base(strMessage)
        {
        }

        public InvalidPassword(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}