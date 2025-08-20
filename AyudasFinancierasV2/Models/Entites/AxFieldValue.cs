using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    public class AxFieldValue
    {
        int id;

        bool isNull;

        string value;

        /// <summary>
        /// 1-based field ID
        /// </summary>
        public int Id { get => id; set => id = value; }
        /// <summary>
        /// Indicates whether the value has been set; a value of True
        /// indicates that this field is empty; use this property to
        /// determine if the value is an empty string or whether it's not
        /// set
        /// When performing a search, set this value to True to indicate
        /// that you wish to search for all instances where this field has
        /// not been set yet.
        /// </summary>
        public bool IsNull { get => isNull; set => isNull = value; }
        /// <summary>
        /// Field value for either query or index field
        /// </summary>
        public string Value { get => value; set => this.value = value; }

        override public string ToString()
        {
            return " <ax:Field id=\"" + this.Id +
                "\" value=\"" + this.Value +
                "\" isNull=\"" + this.IsNull.ToString().ToLower() + "\" /> ";
        }
    }
}