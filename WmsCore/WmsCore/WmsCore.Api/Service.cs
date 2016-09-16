using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using WmsCore.Api.Common.Constants;

namespace WmsCore.Api
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class Service : IService
    {
        public bool MixedEnd { get; set; }

        public object CreateExpectedReceipts(ExpectedReceiptRequest request)
        {
            object response = null;
            /*validate subbatch for production based*/
            if (request.ExpectedReceiptType == Resources.PlannedProduction)
            {
                if (string.IsNullOrEmpty(request.BatchCode))
                {
                    response = new
                    {
                        ResponseMessage = MessageAlert.InvalidBatchCode
                    };
                }
            }

            /*validate customer batch/item for customer based*/
            if (request.ExpectedReceiptType == Resources.PlannedProduction || request.ExpectedReceiptType == Resources.UnplannedProduction)
            {
                if (string.IsNullOrEmpty(request.BatchCode))
                {
                    response = new
                    {
                        ResponseMessage = MessageAlert.InvalidBatchCode
                    };
                }
            }

            /*for a mixed transfer receipt don't validate quantity*/
            if ((request.ExpectedReceiptType == Resources.PlannedProduction || request.ExpectedReceiptType == Resources.UnplannedProduction) && true)
            {
                MixedEnd = true;
            }

            return response;
        }

        public void ViewExpectedReceipts(ExpectedReceiptRequest request)
        {
            throw new NotImplementedException();
        }

        public void CloseExpectedReceipts(ExpectedReceiptRequest request)
        {
            throw new NotImplementedException();
        }

        public void Putaway()
        {
            throw new NotImplementedException();
        }

        public void Dispatching()
        {
            throw new NotImplementedException();
        }
    }
}