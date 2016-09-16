﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace WmsCore.Dao.Exception
{
    [Serializable()]
    public class DeleteException : System.ApplicationException
    {
        public DeleteException()
            : base()
        {
        }

        public DeleteException(string strMessage, System.Exception excException)
            : base(strMessage, excException)
        {
        }

        public DeleteException(string strMessage)
            : base(strMessage)
        {
        }

        public DeleteException(SerializationInfo serialization, StreamingContext stream)
            : base(serialization, stream)
        {
        }
    }
}