using System;

namespace CateringBackend.Exceptions
{
    public class MissingAddressForClientException : Exception
    {
        public MissingAddressForClientException(Guid clientId) : base($"Missing address for client with id: {clientId}")
        {
        }
    }
}
