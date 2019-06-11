using Framework.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Framework.Core.ValueObjects
{

    [Serializable]
    public abstract class ValueObjectBase : IValueObject
    {

        #region	Private Members
        protected int _id;
        protected string _createUser = string.Empty;
        protected DateTime _createDate = new DateTime(1900, 1, 1);
        protected string _changeUser = string.Empty;
        protected DateTime _changeDate = new DateTime(1900, 1, 1);
        protected string _extra = string.Empty;
        #endregion
        #region constructor
        ///	<summary>
        ///	default	constructor	
        ///	</summary>
        public ValueObjectBase()
        {
        }

        [XmlAttribute()]
        public virtual int Id { get => this._id; set => _id=value; }
        [XmlAttribute()]
        public virtual string CreateUser { get => _createUser; set => _createUser=value; }
        [XmlAttribute()]
        public virtual DateTime CreateDate { get => _createDate; set => _createDate=value; }
        [XmlAttribute()]
        public virtual string ChangeUser { get => _changeUser; set => _changeUser=value; }
        [XmlAttribute()]
        public virtual DateTime ChangeDate { get => _changeDate; set => _changeDate=value; }
        [XmlAttribute()]
        public virtual string Extra { get =>_extra; set => _extra=value; }

        public virtual void CopyFrom(IValueObject source)
        {
            _id = source.Id;
            _createUser = source.CreateUser;
            _createDate = source.CreateDate;
            _changeUser = source.ChangeUser;
            _changeDate = source.ChangeDate;
            _extra = source.Extra;
        }
        public override String ToString()
        {
            return XMLUtility.ToXml(this);
        }
        public string ToJSON()
        {
            return " Newtonsoft.Json.JsonConvert.SerializeObject(this) ";
        }
        #endregion

    }

}
