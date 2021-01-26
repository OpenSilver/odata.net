//---------------------------------------------------------------------
// <copyright file="FunctionDescriptor.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Client
#else
namespace Microsoft.OData.Client
#endif
{
    /// <summary> Holds information about a ServiceFunction. </summary>
    public sealed class FunctionDescriptor : OperationDescriptor
    {
    }
}
