//---------------------------------------------------------------------
// <copyright file="ISendingRequest2.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------


#if OPENSILVER
namespace System.Data.Client
#else
namespace Microsoft.OData.Client
#endif
{
    internal interface ISendingRequest2
    {
        void BeforeSendingRequest2Event();
        void AfterSendingRequest2Event();
    }
}
