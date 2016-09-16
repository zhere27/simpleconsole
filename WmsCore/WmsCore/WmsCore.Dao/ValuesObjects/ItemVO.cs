using System;
using System.ComponentModel.DataAnnotations;

namespace WmsCore.Dao.ValuesObjects
{
    internal class ItemVo
    {
        [Required]
        [StringLength(20)]
        public string ItemCode { get; set; }

        [StringLength(25)]
        public string ProductCode { get; set; }

        public DateTime ReceiptDate { get; set; }
        public DateTime ManufactureDate { get; set; }

        [StringLength(20)]
        public string WorksOrderCode { get; set; }

        public DateTime PutAwayDate { get; set; }

        [StringLength(10)]
        public string WarehouseCode { get; set; }

        [StringLength(10)]
        public string LocationCode { get; set; }

        [StringLength(10)]
        public string WhseGroupCode { get; set; }

        [StringLength(10)]
        public string OriginCode { get; set; }

        [StringLength(10)]
        public string StatusCode { get; set; }

        [StringLength(10)]
        public string BuildCode { get; set; }

        [StringLength(10)]
        public string BatchCode { get; set; }

        [StringLength(10)]
        public string SubBatchCode { get; set; }

        [StringLength(10)]
        public bool ConfLocation { get; set; }

        public decimal Wideness { get; set; }
        public decimal Longness { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public decimal NumberOff { get; set; }
        public string StdNumberOff { get; set; }

        [StringLength(20)]
        public string ClientPalletRef { get; set; }

        public decimal OddNumberOff { get; set; }
        public DateTime UseByDate { get; set; }
        public string CustomerPallet { get; set; }
        public decimal BoxQuantity { get; set; }
        public string CustomerBatch { get; set; }
        public decimal PalletQuantity { get; set; }

        [StringLength(10)]
        public string SupplierCode { get; set; }

        [StringLength(20)]
        public string ClientBatch { get; set; }

        public decimal Temperature { get; set; }

        [StringLength(25)]
        public string UserProductCode { get; set; }

        [StringLength(40)]
        public string UserItemCode { get; set; }

        [StringLength(20)]
        public string PurchaseOrderNumber { get; set; }

        public int PurchaseOrderLineNo { get; set; }
        public DateTime RotationDate { get; set; }

        [StringLength(30)]
        public string ProductGrade { get; set; }

        [StringLength(30)]
        public string FactoryCode { get; set; }

        [StringLength(320)]
        public string VesselName { get; set; }

        [StringLength(320)]
        public string VoyageCode { get; set; }

        [StringLength(20)]
        public string LotNumber { get; set; }

        public int SubLotRef { get; set; }

        [StringLength(30)]
        public string ProductCipher { get; set; }

        public string ImaNumber { get; set; }

        [StringLength(20)]
        public string CustomerCode { get; set; }

        [StringLength(10)]
        public string GoodsReceivedNumber { get; set; }

        [StringLength(10)]
        public string HaulierCode { get; set; }

        public string Vehicle { get; set; }

        [StringLength(10)]
        public string ContainerCode { get; set; }

        [StringLength(10)]
        public string SupplierBatch { get; set; }

        [StringLength(10)]
        public string SupplierPallet { get; set; }

        [StringLength(10)]
        public string UserOwnCode { get; set; }

        [StringLength(40)]
        public string Description { get; set; }

        public string ShortDescription { get; set; }
        public string IteCode1 { get; set; }
        public string IteCode2 { get; set; }
        public string IteCode3 { get; set; }
        public DateTime IteDate1 { get; set; }
        public DateTime IteDate2 { get; set; }
        public DateTime IteDate3 { get; set; }
        public decimal IteDeci1 { get; set; }
        public decimal IteDeci2 { get; set; }
        public decimal IteDeci3 { get; set; }
        public int IteInte1 { get; set; }
        public int IteInte2 { get; set; }
        public int IteInte3 { get; set; }
        public bool IteLogi1 { get; set; }
        public bool IteLogi2 { get; set; }
        public bool IteLogi3 { get; set; }
        public string IteText1 { get; set; }
        public string IteText2 { get; set; }
        public string IteText3 { get; set; }
        public string Memo { get; set; }
        public bool MemoUsed { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdOperator { get; set; }
        public string CreationOperator { get; set; }
        public DateTime CreationDate { get; set; }
        public bool WorkFlag { get; set; }
        public string InboundDeliveryReference { get; set; }
        public DateTime LastPiDate { get; set; }
        public string LocationPosition { get; set; }
        public string ControlOrganization { get; set; }
        public string OwnerOrganization { get; set; }
        public decimal NumberOff2 { get; set; }
        public string GlobalTradingIdNumber { get; set; }
        public string Grai { get; set; }
        public string CountryOfOrigin { get; set; }
        public int WorkOrderLineNo { get; set; }
        public string ClientReference { get; set; }
        public decimal ItemVolume { get; set; }
        public decimal ItemArea { get; set; }
        public string ExrText1 { get; set; }
        public string ExrText2 { get; set; }
        public string ExrText3 { get; set; }
        public decimal ItemValue { get; set; }
        public decimal ItemCifValue { get; set; }
        public string DocumentReference1 { get; set; }
        public string DocumentReference2 { get; set; }
        public string DocumentReference3 { get; set; }
        public string DocumentReference4 { get; set; }
        public string DocumentReference5 { get; set; }
        public string DocumentReference6 { get; set; }
        public string DocumentReference7 { get; set; }
        public string DocumentReference8 { get; set; }
        public string DocumentReference9 { get; set; }
        public string DocumentReference10 { get; set; }
        public decimal InvoiceCif { get; set; }
        public string InvoiceCurrencyCode { get; set; }
        public decimal InvoiceLineCif { get; set; }
        public decimal InvoiceLineValue { get; set; }
        public decimal InvoiceValue { get; set; }
        public decimal InvoiceUnitValue { get; set; }
        public decimal InvoiceUnitValueCif { get; set; }
        public decimal AllocateQuantity { get; set; }
        public decimal RecervedQuantity { get; set; }
        public bool AllocatedFully { get; set; }
        public bool ReservedFully { get; set; }
        public DateTime BoeExpire { get; set; }
        public DateTime DocRefDate1 { get; set; }
        public DateTime DocRefDate2 { get; set; }
        public DateTime DocRefDate3 { get; set; }
        public DateTime DocRefDate4 { get; set; }
        public DateTime DocRefDate5 { get; set; }
        public DateTime DocRefDate6 { get; set; }
        public DateTime DocRefDate7 { get; set; }
        public DateTime DocRefDate8 { get; set; }
        public DateTime DocRefDate9 { get; set; }
        public DateTime DocRefDate10 { get; set; }
        public string TransTypeCode { get; set; }
        public bool Active { get; set; }
        public bool Archive { get; set; }
        public DateTime ArchiveOkDate { get; set; }
        public string ItemType { get; set; }
        public DateTime BestBeforeDate { get; set; }
        public DateTime DespatchByDate { get; set; }
        public string BuiPhyGrCode { get; set; }
        public string PackagingCode { get; set; }
        public string GradeCode { get; set; }
        public string DocumentType1 { get; set; }
        public string DocumentType2 { get; set; }
        public string DocumentType3 { get; set; }
        public string DocumentType4 { get; set; }
        public string DocumentType5 { get; set; }
        public string DocumentType6 { get; set; }
        public string DocumentType7 { get; set; }
        public string DocumentType8 { get; set; }
        public string DocumentType9 { get; set; }
        public string DocumentType10 { get; set; }
        public string ImageUrl { get; set; }
    }
}