//---------------------------------------------------------------------
// <copyright file="IgnoreClientPropertyAttribute.cs" company="Microsoft">
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

    /// <summary>Indicates that an attribute should not be serialized while inserting or updating an entity. </summary>
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public sealed class IgnoreClientPropertyAttribute : Attribute
    {
    }
}
