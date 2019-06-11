using Application.Common.ValueObjects.Supplier;
using Application.DataAccess;
using Framework.Core.BusinessLogic;
using Framework.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BusinessLogic.Supplier
{
    public class SupplierAddressManager : ManagerBase<SupplierAddressManager, SupplierAddress>
    {
        #region	Constants
        // *************************************************************************
        //				 constants
        // *************************************************************************

        private SupplierAddressManager() : base()
        {
            string DbConnectionTypeName = "SqlClient";
            string ConnectionString = "server=scazvassqldev01.nycsca.org; user id=aec; password=brApHa7B; database=NYCSCA_VAS;"; // SCAZVASSQLDEV01          SCAVASSQLTEST01

            _DataSource = new DataSourceSettingObject("MySupplier", DbConnectionTypeName, ConnectionString);
            _DaoTypeName = DaoEnum.GetByName(nameof(SupplierAddress)).Description;
        }
        static SupplierAddressManager()
        {
            /// Static logger puts here
        }
        #endregion Constants

    }
}
