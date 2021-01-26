//---------------------------------------------------------------------
// <copyright file="InvokeResponse.cs" company="Microsoft">
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
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

#if OPENSILVER
    using System.Data.Client;
#else
    using Microsoft.OData.Client;
#endif

    /// <summary> Response from an Invoke call. </summary>
    public class InvokeResponse : OperationResponse
    {
        /// <summary> Constructs an InvokeResponse identical to an OperationResponse. </summary>
        /// <param name="headers">The HTTP headers.</param>
        public InvokeResponse(Dictionary<string, string> headers)
            : base(new HeaderCollection(headers))
        {
        }
    }
}
