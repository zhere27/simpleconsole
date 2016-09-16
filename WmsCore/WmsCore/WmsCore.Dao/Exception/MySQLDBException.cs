using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class MySQLDBException : System.ApplicationException
    {
        public MySQLDBException()
            : base()
        {
        }

        public MySQLDBException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public MySQLDBException(string strMessage)
            : base(strMessage)
        {
        }

        public MySQLDBException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}