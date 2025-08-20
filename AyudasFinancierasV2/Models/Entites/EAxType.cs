using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AyudasFinancierasV2.Models.Entites
{
    /// <summary>
    /// This object defines common types and constants used across many of
    /// the data transfer objects.
    /// </summary>
    public enum EAxType
    {
        /// <summary>
        /// Basic feature set that has everything except
        /// full-text search and AppXtender Reports Mgmt
        /// document viewing capabilities
        /// </summary>
        AxFeature_Basic,
        /// <summary>
        /// Basic feature set that also includes AppXtender 
        /// Reports Mgmt document viewing capability
        /// </summary>
        AxFeature_ERMXDocuments,
        /// <summary>
        /// Basic feature set that also includes full-text search capability
        /// </summary>
        AxFeature_FullTextSearch,
        /// <summary>
        /// Application name for overlay forms
        /// </summary>
        FormsApp,
        /// <summary>
        /// Application name for rubber stamps
        /// </summary>
        RubberStampsApp
    }

    public enum AxImageExportFormatData
    {
        PDF,
        TIFF,
        XPS,
        IMAGE
    }

    public enum AxFormTypes
    {
        None,
        Image,
        Text
    }


}