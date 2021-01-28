
#if OPENSILVER
namespace System.Data.Services.Common
{
    using System;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class DataServiceKeyAttribute : System.Attribute
    {

        public DataServiceKeyAttribute(params string[] list)
        {
            
        }

        public string[] List { get; }
    }
}
#endif
