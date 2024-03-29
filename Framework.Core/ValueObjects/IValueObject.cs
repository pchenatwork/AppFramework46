﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Framework.Core.ValueObjects
{
    #region	Header
    ///	<summary>
    ///	Interface definition for Value Object.
    ///	</summary>
    #endregion Header
    public interface IValueObject
    {
        #region	Public Methods
        //	*************************************************************************
        //				   Public methods
        //	*************************************************************************

        /// <summary>
        /// Copy all the member variables from the source object.
        /// Call base.CopyFrom first in the implementation.
        /// </summary>
        /// <param name="source">The source object.</param>
        void CopyFrom(IValueObject source);
        /// <summary>
        /// Serializes the value object into a string.
        /// </summary>
        /// <returns></returns>
        String ToString();

        #endregion Public Methods

        #region	Properties
        //	*************************************************************************
        //				   Properties
        //	*************************************************************************
        /// <summary>
        /// Id property - every value object should have an identity.
        /// </summary>
        int Id
        {
            get;
            set;
        } // end property - Id

        /// <summary>
        /// CreateUser property
        /// </summary>
        string CreateUser
        {
            get;
            set;
        }

        /// <summary>
        /// CreateDate property
        /// </summary>
        DateTime CreateDate
        {
            get;
            set;
        }

        /// <summary>
        /// ChangeUser property
        /// </summary>
        string ChangeUser
        {
            get;
            set;
        }

        /// <summary>
        /// ChangeDate property
        /// </summary>
        DateTime ChangeDate
        {
            get;
            set;
        }

        /// <summary>
        /// property for extra meta data 
        /// </summary>
        string Extra
        {
            get;
            set;
        }
        #endregion Properties
    } // end class	- IValueObject
} 