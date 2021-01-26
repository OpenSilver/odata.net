//---------------------------------------------------------------------
// <copyright file="HasStreamAttribute.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Client
#else
namespace Microsoft.OData.Client
#endif
{
    using System;

    /// <summary>Indicates that a class that is an entity type has a default binary data stream. </summary>
    [AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
    public sealed class HasStreamAttribute : Attribute
    {
    }
}
