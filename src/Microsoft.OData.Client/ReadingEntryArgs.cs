//---------------------------------------------------------------------
// <copyright file="ReadingEntryArgs.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Services.Client
#else
namespace Microsoft.OData.Client
#endif
{
    using Microsoft.OData;

    /// <summary>
    /// The reading entry args
    /// </summary>
    public sealed class ReadingEntryArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadingEntryArgs" /> class.
        /// </summary>
        /// <param name="entry">The entry.</param>
        public ReadingEntryArgs(ODataResource entry)
        {
            this.Entry = entry;
        }

        /// <summary>
        /// Gets the entry.
        /// </summary>
        /// <value>
        /// The entry.
        /// </value>
        public ODataResource Entry { get; private set; }
    }
}
