using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class EditException : System.ApplicationException
    {
        public EditException()
            : base()
        {
        }

        public EditException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public EditException(string strMessage)
            : base(strMessage)
        {
        }

        public EditException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}