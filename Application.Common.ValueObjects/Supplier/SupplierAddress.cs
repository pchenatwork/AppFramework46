using Framework.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Common.ValueObjects.Supplier
{
    #region	Header
    ///	<summary>
    ///	SupplierAddress value object.
    ///	</summary>
    #endregion Header

    [Serializable]
    public class SupplierAddress : ValueObjectBase
    {
        #region	Constants
        // *************************************************************************
        //				 constants
        // *************************************************************************
        public const string PHYSICAL_ADDRESS = "PHYSICAL";
        public const string MAILING_ADDRESS = "MAILING";
        public const string REMIT_ADDRESS = "REMIT";
        public const string PURCHASING_ADDRESS = "PURCHASING";
        #endregion Constants

        #region	Private Members
        // *************************************************************************
        //				 Private Members
        // *************************************************************************
        private Guid _addressId;
        private int _supplierId;
        private int _contactId;
        private string _addressType = string.Empty;
        private string _fromSupplier = string.Empty;
        private string _addressLine1 = string.Empty;
        private string _addressLine2 = string.Empty;
        private string _addressLine3 = string.Empty;
        private string _addressLine4 = string.Empty;
        private string _city = string.Empty;
        private string _state = string.Empty;
        private string _zipCode = string.Empty;
        private string _country = string.Empty;
        private string _county = string.Empty;
        private string _countryName = string.Empty;
        private int _status;
        private int _deleteFlag;
        private int _blockFlag;
        private DateTime _effectiveDate = new DateTime(1900, 1, 1);

        private string _taxType = string.Empty;
        private string _taxId = string.Empty;
        private string _description = string.Empty;
        #endregion Private Members

        #region	Constructors
        // *************************************************************************
        //				 Constructors
        // *************************************************************************
        /// <summary>
        /// class constructor 
        /// initializes logging
        /// </summary>
        static SupplierAddress()
        {
        }

        ///	<summary>
        ///	default	constructor	
        ///	</summary>
        public SupplierAddress()
        {
        }

        #endregion Constructors

        #region	Properties
        //	*************************************************************************
        //				   Properties
        //	*************************************************************************
        /// <summary>
        /// Property SupplierId (int)
        /// </summary>
        [XmlAttribute()]
        public int SupplierId
        {
            get
            {
                return this._supplierId;
            }
            set
            {
                this._supplierId = value;
            }
        }

        /// <summary>
        /// Property ContactId (int)
        /// </summary>
        [XmlAttribute()]
        public int ContactId
        {
            get
            {
                return this._contactId;
            }
            set
            {
                this._contactId = value;
            }
        }

        /// <summary>
        /// Property AddressType (string)
        /// </summary>
        [XmlAttribute()]
        public string AddressType
        {
            get
            {
                return this._addressType;
            }
            set
            {
                this._addressType = value;
            }
        }

        /// <summary>
        /// Property FromSupplier (string)
        /// </summary>
        [XmlAttribute()]
        public string FromSupplier
        {
            get
            {
                return this._fromSupplier;
            }
            set
            {
                this._fromSupplier = value;
            }
        }

        /// <summary>
        /// Property AddressLine1 (string)
        /// </summary>
        [XmlAttribute()]
        public string AddressLine1
        {
            get
            {
                return this._addressLine1;
            }
            set
            {
                this._addressLine1 = value;
            }
        }

        /// <summary>
        /// Property AddressLine2 (string)
        /// </summary>
        [XmlAttribute()]
        public string AddressLine2
        {
            get
            {
                return this._addressLine2;
            }
            set
            {
                this._addressLine2 = value;
            }
        }

        /// <summary>
        /// Property AddressLine3 (string)
        /// </summary>
        [XmlAttribute()]
        public string AddressLine3
        {
            get
            {
                return this._addressLine3;
            }
            set
            {
                this._addressLine3 = value;
            }
        }

        /// <summary>
        /// Property AddressLine4 (string)
        /// </summary>
        [XmlAttribute()]
        public string AddressLine4
        {
            get
            {
                return this._addressLine4;
            }
            set
            {
                this._addressLine4 = value;
            }
        }

        /// <summary>
        /// Property City (string)
        /// </summary>
        [XmlAttribute()]
        public string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }

        /// <summary>
        /// Property State (string)
        /// </summary>
        [XmlAttribute()]
        public string State
        {
            get
            {
                return this._state;
            }
            set
            {
                this._state = value;
            }
        }

        /// <summary>
        /// Property ZipCode (string)
        /// </summary>
        [XmlAttribute()]
        public string ZipCode
        {
            get
            {
                return this._zipCode;
            }
            set
            {
                this._zipCode = value;
            }
        }

        /// <summary>
        /// Property Country (string)
        /// </summary>
        [XmlAttribute()]
        public string Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }

        /// <summary>
        /// Property CountryName (string)
        /// </summary>
        [XmlAttribute()]
        public string CountryName
        {
            get
            {
                return this._countryName;
            }
            set
            {
                this._countryName = value;
            }
        }

        /// <summary>
        /// Property County (string)
        /// </summary>
        [XmlAttribute()]
        public string County
        {
            get
            {
                return this._county;
            }
            set
            {
                this._county = value;
            }
        }

        /// <summary>
        /// Property TaxType (string)
        /// </summary>
        [XmlAttribute()]
        public string TaxType
        {
            get
            {
                return this._taxType;
            }
            set
            {
                this._taxType = value;
            }
        }

        /// <summary>
        /// Property TaxId (string)
        /// </summary>
        [XmlAttribute()]
        public string TaxId
        {
            get
            {
                return this._taxId;
            }
            set
            {
                this._taxId = value;
            }
        }

        /// <summary>
        /// Property Description (string)
        /// </summary>
        [XmlAttribute()]
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        /// <summary>
        /// Property AddressId(Guid)
        /// </summary>
        [XmlAttribute()]
        public Guid AddressId
        {
            get
            {
                return this._addressId;
            }
            set
            {
                this._addressId = value;
            }
        }

        /// <summary>
        /// Property Status (int)
        /// </summary>
        [XmlAttribute()]
        public int Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }

        /// <summary>
        /// Property DeleteFlag (int)
        /// </summary>
        [XmlAttribute()]
        public int DeleteFlag
        {
            get
            {
                return this._deleteFlag;
            }
            set
            {
                this._deleteFlag = value;
            }
        }

        /// <summary>
        /// Property BlockFlag (int)
        /// </summary>
        [XmlAttribute()]
        public int BlockFlag
        {
            get
            {
                return this._blockFlag;
            }
            set
            {
                this._blockFlag = value;
            }
        }

        /// <summary>
        /// Property EffectiveDate (DateTime)
        /// </summary>
        [XmlAttribute()]
        public DateTime EffectiveDate
        {
            get
            {
                return this._effectiveDate;
            }
            set
            {
                this._effectiveDate = value;
            }
        }
        #endregion Properties

        #region	Public Methods
        //	*************************************************************************
        //				   Public methods
        //	*************************************************************************

        /// <summary>
        /// Copy all the member variables from the source object.
        /// Call base.CopyFrom first in the implementation.
        /// </summary>
        /// <param name="source">The source object.</param>
        public override void CopyFrom(IValueObject source)
        {
            SupplierAddress sourceSupplierAddress = (SupplierAddress)source;
            base.CopyFrom(source);
            _supplierId = sourceSupplierAddress._supplierId;
            _contactId = sourceSupplierAddress._contactId;
            _addressType = sourceSupplierAddress._addressType;
            _fromSupplier = sourceSupplierAddress._fromSupplier;
            _addressLine1 = sourceSupplierAddress._addressLine1;
            _addressLine2 = sourceSupplierAddress._addressLine2;
            _city = sourceSupplierAddress._city;
            _state = sourceSupplierAddress._state;
            _zipCode = sourceSupplierAddress._zipCode;
            _country = sourceSupplierAddress._country;
            _county = sourceSupplierAddress._county;
            _addressId = sourceSupplierAddress._addressId;
        }
        #endregion Public Methods
    }
}
