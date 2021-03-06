//---------------------------------------------------------------------
// <copyright file="ODataItemWrapper.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

using Microsoft.OData;

#if ODATA_SERVICE
namespace Microsoft.OData.Service
#elif ODATA_CLIENT

#if OPENSILVER
namespace System.Data.Services.Client
#else
namespace Microsoft.OData.Client
#endif
#else
namespace Microsoft.Test.OData
#endif
{
#if ODATA_SERVICE
    internal abstract class ODataItemWrapper
#elif ODATA_CLIENT
    internal abstract class ODataItemWrapper
#else
    public abstract class ODataItemWrapper
#endif
    {
        public abstract ODataItem Item { get; }
    }
}
