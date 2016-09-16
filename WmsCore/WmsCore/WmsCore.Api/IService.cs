using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WmsCore.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        #region Goods Inwards

        #region Expected Receipts

        [OperationContract]
        object CreateExpectedReceipts(ExpectedReceiptRequest request);

        [OperationContract]
        void ViewExpectedReceipts(ExpectedReceiptRequest request);

        [OperationContract]
        void CloseExpectedReceipts(ExpectedReceiptRequest request);

        #endregion Expected Receipts

        #endregion Goods Inwards

        [OperationContract]
        void Putaway();

        [OperationContract]
        void Dispatching();
    }
}