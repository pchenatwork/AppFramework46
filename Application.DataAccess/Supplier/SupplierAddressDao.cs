using Application.Common.ValueObjects.Supplier;
using Framework.Core.DataAccess;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Application.DataAccess.Supplier
{
    public class SupplierAddressDao : DaoBase<SupplierAddress>
    {
        #region	Constants
        // *************************************************************************
        //				 constants
        // *************************************************************************
        public const string FIND_CONTACT_BY_SUPPLIER = "FindSupplierContactBySupplier";
        public const string FIND_OTHERCONTACT_BY_SUPPLIER = "FindOtherSupplierContactBySupplier";
        public const string FIND_SUPPLIERCONTACT = "FindSupplierContact";
        public const string SEARCH_CONTACT_NOT_SELECTED = "SearchSupplierContactNotSelected";
        public const string FIND_CONTACT_NOT_SELECTED = "FindSupplierContactNotSelected";
        public const string FIND_CONTACT_BY_GROUP = "FindSupplierContactByGroup";
        public const string FIND_CONTACT_BY_POST = "FindSupplierContactByPost";
        public const string MATCH_CONTACT = "MatchSupplierContact";
        public const string FIND_CONTACT_BY_EMAIL = "FindSupplierContactByEmail";
        public const string SEARCH_CONTACT_BY_LETTER = "SearchSupplierContactByLetter";
        public const string SEARCH_CONTACT = "SearchSupplierContact";
        #endregion Constants

        #region Constructors
        // *************************************************************************
        //				 Constructors
        // *************************************************************************
        /// <summary>
        /// class constructor 
        /// initializes logging
        /// </summary>
        static SupplierAddressDao()
        {
            //_logger = LoggingUtility.GetLogger(typeof(LicenseDao).FullName);
        }

        ///	<summary>
        ///	default	constructor	
        ///	inits with default
        ///	</summary>
        public SupplierAddressDao(DataSourceParams dataSource) : base(dataSource)
        {
        }

        #endregion

        public override int Create(SupplierAddress newObject)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<SupplierAddress> FindByCriteria(string finderType, object[] criteria)
        {
            throw new NotImplementedException();
        }

        public override SupplierAddress Get(int id)
        {
            using (SqlConnection connection = (SqlConnection)_dataSource.Value.DbConnection)
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@id", SqlDbType.Int);
                parameters[0].Value = id;
                parameters[1] = new SqlParameter("@ReturnValue", SqlDbType.Int);
                parameters[1].Direction = ParameterDirection.ReturnValue;

                XmlReader reader = SqlHelper.ExecuteXmlReader(connection, CommandType.StoredProcedure, "GetSupplierAddressXml", parameters);
                return Deserialize(reader);
            }
        }

        public override IEnumerable<SupplierAddress> GetAll()
        {
            throw new NotImplementedException();
        }

        public override bool Update(SupplierAddress newObject)
        {
            throw new NotImplementedException();
        }
    }
}
