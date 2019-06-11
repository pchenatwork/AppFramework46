using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Framework.Core.ValueObjects
{
    /// <summary>
    /// Generic abstract base class for enumeration and lookup data. 
    /// PCHEN 201903 Introduced to replace EnumerationBase class, SOMEWHAT TESTED AND WORKED!
    /// </summary>
    [Serializable]
    public abstract class EnumBase<T> : ValueObjectBase, IXmlSerializable where T : EnumBase<T>
    {
        /* ============================================================================
         * PCHEN 201903 Created as a generic replacement to the none-generic "EnumerationBase"
         * Inspired by https://github.com/ardalis/SmartEnum
         * Adapted to VAS standard EnumerationBase interface such that EnumerationBase ( none-generic ) can be phased out
         * Dev notes: IXmlSerializable interface methods not tested yet
         * ============================================================================ */
        #region Private Variables
        private string _name;
        private string _description;

        private static readonly Lazy<IEnumerable<T>> _list = new Lazy<IEnumerable<T>>(() => _GetList());
        private static IEnumerable<T> _GetList()
        {
            Type type = typeof(T);
            foreach (var fieldInfo in type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy))
            {
                object obj = fieldInfo.GetValue(null);
                if (obj is T)
                {
                    yield return (T)obj;
                }
            }
        }
        #endregion

        #region Constructors
        private EnumBase() { }
        protected EnumBase(int id, string name, string description)
        {
            this._id = id;
            this._name = name;
            this._description = description;
        }
        #endregion

        #region Method Override 

        /// <summary>
        /// This standard override of the GetHashCode function
        /// hashes the Id member.
        /// </summary>
        /// <returns>hash value of the enumeration instance</returns>
        public override int GetHashCode()
        {
            return this._id.GetHashCode();
        }

        /// <summary>
        /// ToString() returns the Description of the enum
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            /* --------------------------------------------------------------------
             * EnumBase can not be object, so can't use IValueObject.ToString(), has to be overrided
             * -------------------------------------------------------------------- */
            return this.Name.ToString();
        }

        /// <summary>
        /// Copy the attributes of the given enumeration to the current instance values.
        /// </summary>
        public void CopyFrom(T enumObject)
        {
            if (IsNull(enumObject))
            {
                return;
            }
            base.CopyFrom(enumObject);
            this._name = enumObject._name;
            this._description = enumObject._description;
        }

        /// <summary>
        /// This function will determine whether the given
        /// enumeration object is equivalent (value-equivalence)
        /// to this enumeration instance.
        /// </summary>
        /// <param name="enumeration">the enumeration object to compare</param>
        /// <returns>true if they are equal</returns>
        public override bool Equals(object enumeration)
        {
            T temp = enumeration as T;
            if (temp == null) return false;
            return (this == temp);
        }

        #endregion

        #region Public GetBy Methods
        /// <summary>
        /// Get Enum by Name.
        /// </summary>
        public static T GetByName(string name)
        {
            for (int i = 0; i < _list.Value.Count(); i++)
            {
                try
                {
                    if (((T)_list.Value.ElementAt(i)).Name.Trim().ToLower().Equals(name.Trim().ToLower()))
                        return (T)_list.Value.ElementAt(i);
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return null;
        }

        /// <summary>
        /// Get Enum by Id.
        /// </summary>
        public static T GetById(int Id)
        {
            for (int i = 0; i < _list.Value.Count(); i++)
            {
                if (((T)_list.Value.ElementAt(i)).Id == Id)
                    return (T)_list.Value.ElementAt(i);
            }
            return null;
        }


        #endregion

        #region Properties
        /// <summary>
        /// Singleton list conaining all enumeration values.
        /// </summary>
        [XmlIgnore]
        public static IReadOnlyCollection<T> List
        {
            get { return _list.Value.ToList().AsReadOnly(); }
        }

        /// <summary>
        /// Name value of the Enum.
        /// </summary>
        [XmlIgnore]
        public string Name => _name;

        /// <summary>
        /// Description value of the Enum
        /// </summary>
        [XmlIgnore]
        public string Description => _description;

        /// <summary>
        /// Override the base Id and make it read only.
        /// </summary>
        [XmlIgnore]
        public override int Id => base._id;
        #endregion

        #region Conversion Operators

        /// <summary>
        /// Standard override of the EQUALS operator. The function
        /// will compare (by value) the given enumeration arguments
        /// for equivalence.
        /// </summary>
        /// <param name="enum1">first enum to compare</param>
        /// <param name="enum2">second enum to compare</param>
        /// <returns>true if the two are equal in value</returns>
        public static bool operator ==(EnumBase<T> enum1, EnumBase<T> enum2)
        {
            bool null1 = IsNull(enum1);
            bool null2 = IsNull(enum2);
            if (null1 && null2)
            {
                /// both null, so they are EQUAL
                return true;
            }
            if ((!null1 && null2) || (null1 && !null2))
            {
                /// one is null the other is not null, so NOT EQUAL
                return false;
            }

            try
            {
                if (enum1._id == enum2._id && enum1._name == enum2._name &&
                    enum1._description == enum2._description)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                /// ??? PCHEN 201903 ? Is it still the case ??
                /// A null pointer exception is thrown periodically during 
                /// the Xml Serialization process. The serializer attempts 
                /// to compare the value of a null enum instance. So, do 
                /// not remove this catch block.
                return false;
            }
        }

        /// <summary>
        /// Standard override of the NOT EQUALS operator. The function
        /// will compare (by value) the given enumeration arguments
        /// for the inverse of equivalence.
        /// </summary>
        /// <param name="enum1">first enum to compare</param>
        /// <param name="enum2">second enum to compare</param>
        /// <returns>true if the two are NOT EQUAL in value</returns>
        public static bool operator !=(EnumBase<T> enum1, EnumBase<T> enum2)
        {
            return !(enum1 == enum2);
        }

        /// <summary>
        /// Implicit operator to convert Enum to Int
        /// </summary>
        public static implicit operator int(EnumBase<T> value)
        {
            return value.Id;
        }
        private static bool IsNull(EnumBase<T> enumeration)
        {
            return object.ReferenceEquals(enumeration, null);
        }

        #endregion

        #region IXmlSerializable Implementation
        /* ==================================
         * PC Note 20190328. not tested 
         * ================================== */

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteString(this._id.ToString());
        }

        public void ReadXml(XmlReader reader)
        {
            string id = reader.ReadInnerXml();
            T enumeration = GetById(Convert.ToInt32(id));
            if (enumeration != null)
            {
                CopyFrom(enumeration);
            }
        }
        #endregion

    }
}
