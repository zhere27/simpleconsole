using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WmsCore.Api
{
    public class ExpectedReceiptRequest
    {
        public string ExpectedReceiptType { get; set; }
        public string CustomerCode { get; set; }
        public string HaulierCode { get; set; }
        public string ContainerCode { get; set; }
        public string ContainerType { get; set; }
        public string ControlOrganization { get; set; }
        public string Owner { get; set; }
        public string OrderRef { get; set; }
        public string ProductCode { get; set; }
        public string CustomerBatch { get; set; }
        public string BatchCode { get; set; }
        public string SubBatchCode { get; set; }
        public DateTime ExpectedDateTime { get; set; }
        public DateTime EarliestReceiptDate { get; set; }
        public DateTime LatestReceiptDate { get; set; }
        public DateTime UseByDate { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal ExpectedNumberOff { get; set; }
        public decimal MinQuantity { get; set; }
        public decimal MaxQuantity { get; set; }
        public decimal PercentOver { get; set; }
    }
}