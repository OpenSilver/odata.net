
#if OPENSILVER
namespace System.Data.Services.Client
#else
namespace Microsoft.OData.Client
#endif
{
    internal interface IDataServiceRequestMessageFactory
    {
        DataServiceClientRequestMessage CreateRequestMessage(DataServiceClientRequestMessageArgs args, DataServiceContext dataServiceContext);
    }
}
