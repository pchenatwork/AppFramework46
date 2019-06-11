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
    ///	License value object.
    ///	</summary>
    #endregion Header

    [Serializable]
    public class SupplierLicense : ValueObjectBase
    {
        #region	Private Members
        // *************************************************************************
        //				 Private Members
        // *************************************************************************
        private Guid _licenseId;
        private int _supplierId;
        private string _name = string.Empty;
        private string _location = string.Empty;
        private string _licenseAgent = string.Empty;
        private string _licenseType = string.Empty;
        private string _licenseNo = string.Empty;
        private DateTime _effectiveDate = new DateTime(1900, 1, 1);
        private DateTime _expirationDate = new DateTime(1900, 1, 1);
        private string _faxIn = string.Empty;
        private string _filename = string.Empty;
        private byte[] _certificate = null;
        private long _certificateId;

        private int _transactionId;
        private int _status;
        private int _personnelId;
        private string _corporation = string.Empty;

        private long _fileSize;
        #endregion

        #region	Constructors
        // *************************************************************************
        //				 Constructors
        // *************************************************************************
        /// <summary>
        /// class constructor 
        /// initializes logging
        /// </summary>
        static SupplierLicense()
        {
        }

        ///	<summary>
        ///	default	constructor	
        ///	</summary>
        public SupplierLicense()
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
        /// Property LicenseAgent (string)
        /// </summary>
        [XmlAttribute()]
        public string LicenseAgent
        {
            get
            {
                return this._licenseAgent;
            }
            set
            {
                this._licenseAgent = value;
            }
        }

        /// <summary>
        /// Property LicenseType (string)
        /// </summary>
        [XmlAttribute()]
        public string LicenseType
        {
            get
            {
                return this._licenseType;
            }
            set
            {
                this._licenseType = value;
            }
        }

        /// <summary>
        /// Property LicenseNo (string)
        /// </summary>
        [XmlAttribute()]
        public string LicenseNo
        {
            get
            {
                return this._licenseNo;
            }
            set
            {
                this._licenseNo = value;
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

        /// <summary>
        /// Property ExpirationDate (DateTime)
        /// </summary>
        [XmlAttribute()]
        public DateTime ExpirationDate
        {
            get
            {
                return this._expirationDate;
            }
            set
            {
                this._expirationDate = value;
            }
        }

        /// <summary>
        /// Property FaxIn (string)
        /// </summary>
        [XmlAttribute()]
        public string FaxIn
        {
            get
            {
                return this._faxIn;
            }
            set
            {
                this._faxIn = value;
            }
        }

        /// <summary>
        /// Property Filename (string)
        /// </summary>
        [XmlAttribute()]
        public string Filename
        {
            get
            {
                return this._filename;
            }
            set
            {
                this._filename = value;
            }
        }

        /// <summary>
        /// Property Certificate (byte[])
        /// </summary>
        public byte[] Certificate
        {
            get
            {
                return this._certificate;
            }
            set
            {
                this._certificate = value;
            }
        }
        /// <summary>
        /// Property CertificateId (long)
        /// </summary>
        [XmlAttribute()]
        public long CertificateId
        {
            get
            {
                return _certificateId;
            }
            set
            {
                _certificateId = value;
            }
        }
        /// <summary>
        /// Property TransactionId (int)
        /// </summary>
        [XmlAttribute()]
        public int TransactionId
        {
            get
            {
                return this._transactionId;
            }
            set
            {
                this._transactionId = value;
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
        /// Property PersonnelId (int)
        /// </summary>
        [XmlAttribute()]
        public int PersonnelId
        {
            get
            {
                return this._personnelId;
            }
            set
            {
                this._personnelId = value;
            }
        }

        /// <summary>
        /// Property Corporation (string)
        /// </summary>
        [XmlAttribute()]
        public string Corporation
        {
            get
            {
                return this._corporation;
            }
            set
            {
                this._corporation = value;
            }
        }

        /// <summary>
        /// Property Name (string)
        /// </summary>
        [XmlAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        /// <summary>
        /// Property Location (string)
        /// </summary>
        [XmlAttribute()]
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }

        /// <summary>
        /// Property LicenseId (Guid)
        /// </summary>
        [XmlAttribute()]
        public Guid LicenseId
        {
            get
            {
                return this._licenseId;
            }
            set
            {
                this._licenseId = value;
            }
        }

        /// <summary>
        /// Property FileSize (long)
        /// <summary>
        [XmlAttribute()]
        public long FileSize
        {
            get
            {
                return this._fileSize;
            }
            set
            {
                this._fileSize = value;
            }
        }
        #endregion

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
            SupplierLicense sourceLicense = (SupplierLicense)source;
            base.CopyFrom(source);
            _supplierId = sourceLicense._supplierId;
            _licenseAgent = sourceLicense._licenseAgent;
            _licenseType = sourceLicense._licenseType;
            _licenseNo = sourceLicense._licenseNo;
            _effectiveDate = sourceLicense._effectiveDate;
            _expirationDate = sourceLicense._expirationDate;
            _faxIn = sourceLicense._faxIn;
            _filename = sourceLicense._filename;
            _certificate = sourceLicense._certificate;
            _transactionId = sourceLicense._transactionId;
            _status = sourceLicense._status;
            _personnelId = sourceLicense._personnelId;
            _corporation = sourceLicense._corporation;
            _name = sourceLicense._name;
            _location = sourceLicense._location;
            _licenseId = sourceLicense._licenseId;
        }
        #endregion
    }
}
