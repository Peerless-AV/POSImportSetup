using System;
using PX.Data;
using PX.Objects.GL;

namespace PRLPOSSales
{
  [Serializable]
  [PXCacheName("PRL_POS_Sales")]
  public class PRL_POS_Sales : PXBqlTable, IBqlTable
    {
        #region RecordID
        [PXDBIdentity(IsKey = true)]
        public virtual int? RecordID { get; set; }
        public abstract class recordID : PX.Data.BQL.BqlInt.Field<recordID> { }
        #endregion

        #region CompanyID
        [PXDBInt]
        [PXUIField(DisplayName = "Company ID", Visible = false, Enabled = false)]
        public virtual int? CompanyID { get; set; }
        public abstract class companyID : PX.Data.BQL.BqlInt.Field<companyID> { }
        #endregion
          
        #region branchID
        [PXDBInt]
        [PXDefault(typeof(AccessInfo.branchID))]
        [PXUIField(DisplayName = "Branch")]
        [PXSelector(typeof(Branch.branchID), SubstituteKey = typeof(Branch.branchCD))]
        public virtual int? BranchID { get; set; }
        public abstract class branchID : PX.Data.BQL.BqlInt.Field<branchID> { }
 
        #endregion

        #region Customer
        [PXDBString(100)]
        public virtual string Customer { get; set; }
        public abstract class customer : PX.Data.BQL.BqlString.Field<customer> { }
        #endregion

        #region SoldToName
        [PXDBString(100)]
        public virtual string SoldToName { get; set; }
        public abstract class soldToName : PX.Data.BQL.BqlString.Field<soldToName> { }
        #endregion

        #region SaleDate
        [PXDBDate]
        public virtual DateTime? SaleDate { get; set; }
        public abstract class saleDate : PX.Data.BQL.BqlDateTime.Field<saleDate> { }
        #endregion

        #region PiiPartNumber
        [PXDBString(50)]
        public virtual string PiiPartNumber { get; set; }
        public abstract class piiPartNumber : PX.Data.BQL.BqlString.Field<piiPartNumber> { }
        #endregion

        #region PiiCategory
        [PXDBString(50)]
        public virtual string PiiCategory { get; set; }
        public abstract class piiCategory : PX.Data.BQL.BqlString.Field<piiCategory> { }
        #endregion

        #region ShipQuantity
        [PXDBInt]
        public virtual int? ShipQuantity { get; set; }
        public abstract class shipQuantity : PX.Data.BQL.BqlInt.Field<shipQuantity> { }
        #endregion

        #region ExtendedSales
        [PXDBDecimal]
        public virtual decimal? ExtendedSales { get; set; }
        public abstract class extendedSales : PX.Data.BQL.BqlDecimal.Field<extendedSales> { }
        #endregion

        #region BillToCustomerZip
        [PXDBString(20)]
        public virtual string BillToCustomerZip { get; set; }
        public abstract class billToCustomerZip : PX.Data.BQL.BqlString.Field<billToCustomerZip> { }
        #endregion

        #region BillToCustomerState
        [PXDBString(20)]
        public virtual string BillToCustomerState { get; set; }
        public abstract class billToCustomerState : PX.Data.BQL.BqlString.Field<billToCustomerState> { }
        #endregion

        #region SalesRep
        [PXDBString(50)]
        public virtual string SalesRep { get; set; }
        public abstract class salesRep : PX.Data.BQL.BqlString.Field<salesRep> { }
        #endregion

        #region ShipToState
        [PXDBString(20)]
        public virtual string ShipToState { get; set; }
        public abstract class shipToState : PX.Data.BQL.BqlString.Field<shipToState> { }
        #endregion

        #region ShipToZip
        [PXDBString(20)]
        public virtual string ShipToZip { get; set; }
        public abstract class shipToZip : PX.Data.BQL.BqlString.Field<shipToZip> { }
        #endregion

        #region SalesRepAssignedRule
        [PXDBString(100)]
        public virtual string SalesRepAssignedRule { get; set; }
        public abstract class salesRepAssignedRule : PX.Data.BQL.BqlString.Field<salesRepAssignedRule> { }
        #endregion

        #region PeriodDate
        [PXDBDate]
        public virtual DateTime? PeriodDate { get; set; }
        public abstract class periodDate : PX.Data.BQL.BqlDateTime.Field<periodDate> { }
        #endregion

        #region Audit Fields
        [PXDBCreatedByID]
        public virtual Guid? CreatedByID { get; set; }
        public abstract class createdByID : PX.Data.BQL.BqlGuid.Field<createdByID> { }

        [PXDBCreatedDateTime]
        public virtual DateTime? CreatedDateTime { get; set; }
        public abstract class createdDateTime : PX.Data.BQL.BqlDateTime.Field<createdDateTime> { }

        [PXDBLastModifiedByID]
        public virtual Guid? LastModifiedByID { get; set; }
        public abstract class lastModifiedByID : PX.Data.BQL.BqlGuid.Field<lastModifiedByID> { }

        [PXDBLastModifiedDateTime]
        public virtual DateTime? LastModifiedDateTime { get; set; }
        public abstract class lastModifiedDateTime : PX.Data.BQL.BqlDateTime.Field<lastModifiedDateTime> { }
        #endregion
    }
}