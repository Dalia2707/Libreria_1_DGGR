using System;
using System.Runtime.Serialization;

namespace Libreria_DGGR.Controllers
{
    [Serializable]
    internal class PublisherNameExceptions : Exception
    {
        public PublisherNameExceptions()
        {
        }

        public PublisherNameExceptions(string message) : base(message)
        {
        }

        public PublisherNameExceptions(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PublisherNameExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}