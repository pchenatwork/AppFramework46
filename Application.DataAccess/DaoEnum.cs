using Application.Common.ValueObjects.Supplier;
using Application.DataAccess.Supplier;
using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DataAccess
{
    public class DaoEnum : EnumBase<DaoEnum>
    {

        #region Enumeration Elements
        /* ==========================================================================
         * Name: 
         * Description:  TypeName for reflection
         * ==========================================================================*/
        public static readonly DaoEnum SupplierLicense = new DaoEnum(1, typeof(SupplierLicense).Name, typeof(SupplierLicenseDao).AssemblyQualifiedName);
        public static readonly DaoEnum SupplierContact = new DaoEnum(1, typeof(SupplierAddress).Name, typeof(SupplierAddressDao).AssemblyQualifiedName);
        #endregion

        #region Constructors
        private DaoEnum(int id, string name, string description)
            : base(id, name, description)
        {
        }
        #endregion
    }
}