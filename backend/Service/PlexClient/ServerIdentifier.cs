using System;

namespace Your2020.Service.PlexClient
{
    public class ServerIdentifier : ValueType<string>
    {
        public ServerIdentifier(string id) : base(id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                throw new ArgumentException("Provided identifier cannot be null or empty");
            }
        }
    }
}
