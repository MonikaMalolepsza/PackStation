using System;
namespace PackStation
{
    public class PackageLabel
    {

        #region atributes

        private Guid _packageId;
        private Guid _clientId;

        #endregion

        #region properties

        public Guid PackageId { get => _packageId; set => _packageId = value; }
        public Guid ClientId { get => _clientId; set => _clientId = value; }

        #endregion

        #region constructors

        public PackageLabel(Guid packageId, Guid clientId)
        {
            PackageId = packageId;
            ClientId = clientId;
        }

        #endregion
    }
}
