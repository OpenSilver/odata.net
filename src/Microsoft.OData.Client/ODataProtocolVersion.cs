//---------------------------------------------------------------------
// <copyright file="ODataProtocolVersion.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Services.Client
#else
namespace Microsoft.OData.Client
#endif
{
    /// <summary>Represents the versions of the Open Data Protocol (OData) that the data service may support. </summary>
    public enum ODataProtocolVersion
    {
        /// <summary>Version 4</summary>
        V4,

        /// <summary>Version 4.01</summary>
        V401
    }
}
