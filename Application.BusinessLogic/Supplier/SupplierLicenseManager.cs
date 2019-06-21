using Application.Common.ValueObjects.Supplier;
using Framework.Core.DataAccess;
using Framework.Core.BusinessLogic;
using Framework.Core.Common;
using Application.DataAccess.Supplier;
using Application.DataAccess;

namespace Application.BusinessLogic.Supplier
{
    public class SupplierLicenseManager : ManagerBase<SupplierLicenseManager, SupplierLicense>
    {
        #region	Constants
        // *************************************************************************
        //				 constants
        // *************************************************************************
        public const string FIND_LICENSE_BY_SUPPLIER = "FindLicenseBySupplier";
        public const string FIND_LICENSE_BY_STATUS = "FindLicenseByStatus";
        public const string FIND_LICENSE_BY_BATCHJOB = "FindLicenseByBatchJob";

        private SupplierLicenseManager() : base()
        {
            string DbConnectionTypeName ="SqlClient";
            //string ConnectionString = "server=scazvassqldev01.nycsca.org; user id=aec; password=brApHa7B; database=NYCSCA_VAS; MultipleActiveResultSets=True;";  // SCAZVASSQLDEV01          SCAVASSQLTEST01
            string ConnectionString = "server=scazvassqldev01.nycsca.org; user id=aec; password=brApHa7B; database=NYCSCA_VAS;";

            _DataSource = new DataSourceParams("MySupplier", DbConnectionTypeName, ConnectionString);
            _DaoTypeName = DaoEnum.GetByName(nameof(SupplierLicense)).Description;

            /// _DaoTypeName = typeof(SupplierLicenseDao).AssemblyQualifiedName;  // FullName only works when the type is found in either mscorlib.dll or the currently executing assembly.

            //this.base<SupplierLicense>(dataSource);
        }
        static SupplierLicenseManager() 
        {
            /// Static logger puts here
            //_DaoTypeName = "asdfa asdf";
        }
        #endregion Constants

    }
}
