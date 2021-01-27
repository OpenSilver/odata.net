//---------------------------------------------------------------------
// <copyright file="MaterializationPolicy.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Services.Client.Materialization
#else
namespace Microsoft.OData.Client.Materialization
#endif
{
    using System;

#if OPENSILVER
    using System.Data.Services.Client;
#else
    using Microsoft.OData.Client;
#endif
    using Microsoft.OData.Edm;

    /// <summary>
    /// Class responsible for materializing from OData to Objects
    /// </summary>
    internal abstract class MaterializationPolicy
    {
        /// <summary>
        /// Creates the specified edm type.
        /// </summary>
        /// <param name="edmTypeReference">Type of the edm.</param>
        /// <param name="type">The type.</param>
        /// <remarks>In the future this class will have Materialize and Update will be adding this in upcoming changes</remarks>
        /// <returns>A created object</returns>
        public virtual object CreateNewInstance(IEdmTypeReference edmTypeReference, Type type)
        {
            return Util.ActivatorCreateInstance(type);
        }
    }
}
