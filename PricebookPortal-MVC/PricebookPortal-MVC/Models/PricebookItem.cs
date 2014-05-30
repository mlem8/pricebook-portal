using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PricebookPortal_MVC.Models
{
    public class PricebookItem
    {
        public string ItemID { get; set; }
        
        public DateTime DateCreated { get; set; }
        
        public DateTime LastEditDate { get; set; }
        
        public string PartNumber { get; set; }
        
        public string ItemDescription { get; set; }
        
        public string Description2 { get; set; }

        public string Description3 { get; set; }

        public string UPC { get; set; }

        public string UsedItemID { get; set; }

        public string IVRPartNumber { get; set; }

        public bool Inactive { get; set; }

        public char Type { get; set; }

        public string ItemCategory { get; set; }

        public string Status { get; set; }

        public string UnitOfMeasure { get; set; }

        public bool Serialized { get; set; }

        public bool Taxable { get; set; }

        public bool GSTExempt { get; set; }

        public string Bin { get; set; }

        public string CaseItemID { get; set; }

        public string CaseDescription { get; set; }

        public string CaseUnitOfMeasure { get; set; }

        public double CaseQuantity { get; set; }

        public decimal CaseCost { get; set; }

        public double LaborHrsReq { get; set; }

        public int WarrantyDays { get; set; }

        public double MaintenancePercentage { get; set; }

        public decimal MaintenancePrice { get; set; }

        public decimal ExchangeValue { get; set; }

        public bool HotItem { get; set; }

        public bool AddToCustomerInventory { get; set; }

        public bool PayCommissions { get; set; }

        public string Comments { get; set; }

        public string Weight { get; set; }

        public string Features { get; set; }

        public string AccountingLinkSalesCode { get; set; }

        public bool AllowPriceChange { get; set; }

        public bool BatchPriceChange { get; set; }

        public DateTime LastPriceUpdate { get; set; }

        public bool UpdateBaseCostAndSellPrices { get; set; }

        public string PictureFile { get; set; }

        public string ItemURL { get; set; }

        public string ManufacturerName { get; set; }

        public string ManufacturerPartNumber { get; set; }

        public string ReceivingLocation { get; set; }

        public string ReceivingGLCode { get; set; }

        public string RepairGLCode { get; set; }

        public int LastAssemblyLineNumber { get; set; }

        public char AssemblyType { get; set; }

        public bool AddOnlyAssemblyDetailToCustomerInventory { get; set; }

        public bool UseAssemblyGLCodes { get; set; }

        public double AssemblyHoursEntered { get; set; }

        public bool ShowAssyHeader { get; set; }

        public bool ShowAssyHeaderQty { get; set; }

        public bool ShowAssyDetail { get; set; }

        public bool PrintOnInvoice { get; set; }

        public bool PrintOnCustWO { get; set; }

        public bool PrintOnTechWO { get; set; }

        public bool PrintSingleReceiptLabels { get; set; }

        public DateTime AuditStartDate { get; set; }

        public int AuditStartQuantity { get; set; }

        public DateTime LastSoldDate { get; set; }

        public DateTime LastReceivedDate { get; set; }

        public DateTime LastDateReturned { get; set; }

        public int QuantityOnHand { get; set; }

        public int QuantityReserved { get; set; }

        public int QuantityOnOrder { get; set; }

        public int QuantityNeededtoFillOrders { get; set; }

        public int MinimumQuantity { get; set; }

        public int MaximumQuantity { get; set; }

        public int ReorderQuantity { get; set; }

        public decimal BaseCost { get; set; }

        public decimal RepairCost { get; set; }

        public decimal LatestCost { get; set; }

        public decimal AverageCost { get; set; }

        public decimal TotalCost { get; set; }

        public decimal ManufacturerListPrice { get; set; }

        public bool PrintOnQuote { get; set; }

        public int DiscountTier { get; set; }

        public bool ApplyQuantityDiscountsToAssemblyDetail { get; set; }

        public string PrimaryVendorAccountNumber { get; set; }

        public int PriceBookKeyID { get; set; }

        public string ItemSubCategory { get; set; }

        public bool UpdateVendorCost { get; set; }

        public decimal VolumeBuy { get; set; }

        public int FKProviderTaxType { get; set; }

        public bool SubjectToProviderTax { get; set; }

        public bool ItemCanBeDiscounted { get; set; }

        public bool SubjectToSingleItemTax { get; set; }

        public int DefaultPhaseKeyID { get; set; }

        public bool PublicOnWebPortal { get; set; }

        public double MaxDiscountPercentLevel1 { get; set; }

        public string ApplyDiscountOffLevel1 { get; set; }

        public double MaxDiscountPercentLevel2 { get; set; }

        public string ApplyDiscountOffLevel2 { get; set; }

        public double MaxDiscountPercentLevel3 { get; set; }

        public string ApplyDiscountOffLevel3 { get; set; }
    }
}