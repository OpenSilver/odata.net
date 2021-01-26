//---------------------------------------------------------------------
// <copyright file="ActionDescriptor.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Client
#else
namespace Microsoft.OData.Client
#endif
{
    /// <summary> Holds information about a ServiceAction. </summary>
    public sealed class ActionDescriptor : OperationDescriptor
    {
    }
}
