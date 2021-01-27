//---------------------------------------------------------------------
// <copyright file="AggregateTokenBase.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

#if ODATA_CLIENT

#if OPENSILVER
namespace System.Data.Services.Client.ALinq.UriParser
#else
namespace Microsoft.OData.Client.ALinq.UriParser
#endif
#else
namespace Microsoft.OData.UriParser.Aggregation
#endif
{
    /// <summary>
    /// Base class for Aggregate transformation tokens
    /// </summary>
    public abstract class AggregateTokenBase : ApplyTransformationToken
    {
    }
}
