//---------------------------------------------------------------------
// <copyright file="MessageWriterSettingsArgs.cs" company="Microsoft">
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
    /// Arguments used to configure the odata message writer settings.
    /// </summary>
    public class MessageWriterSettingsArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageWriterSettingsArgs"/> class.
        /// </summary>
        /// <param name="settings">The settings.</param>
        public MessageWriterSettingsArgs(ODataMessageWriterSettings settings)
        {
            WebUtil.CheckArgumentNull(settings, "settings");

            this.Settings = settings;
        }

        /// <summary>
        /// Gets the settings.
        /// </summary>
        public ODataMessageWriterSettings Settings { get; private set; }
    }
}
