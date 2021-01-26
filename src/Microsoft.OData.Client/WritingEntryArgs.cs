//---------------------------------------------------------------------
// <copyright file="WritingEntryArgs.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Client
#else
namespace Microsoft.OData.Client
#endif
{
    using Microsoft.OData;

    /// <summary>
    /// Writing entry arguments
    /// </summary>
    public sealed class WritingEntryArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WritingEntryArgs"/> class.
        /// </summary>
        /// <param name="entry">The entry.</param>
        /// <param name="entity">The entity.</param>
        public WritingEntryArgs(ODataResource entry, object entity)
        {
            Util.CheckArgumentNull(entry, "entry");
            Util.CheckArgumentNull(entity, "entity");
            this.Entry = entry;
            this.Entity = entity;
        }

        /// <summary>
        /// Gets the entry.
        /// </summary>
        /// <value>
        /// The entry.
        /// </value>
        public ODataResource Entry { get; private set; }

        /// <summary>
        /// Gets the entity.
        /// </summary>
        public object Entity { get; private set; }
    }
}
