//---------------------------------------------------------------------
// <copyright file="EntityTypeAttribute.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Services.Client
#else
namespace Microsoft.OData.Client
#endif
{
    using System;

    /// <summary>Marks a class as an entity type in WCF Data Services.</summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class EntityTypeAttribute : System.Attribute
    {
        /// <summary>Creates a new instance of the <see cref="Microsoft.OData.Client.EntityTypeAttribute" /> class.</summary>
        public EntityTypeAttribute()
        {
        }
    }
}
