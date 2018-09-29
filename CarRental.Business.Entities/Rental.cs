
namespace CarRental.Business.Entities
{
    using Core.Common.Contract;
    using Core.Common.Core;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Rental : EntityBase, IIdentifiableEntity, IAccountOwnEntity
    {
        [DataMember]
        public int RentalId { get; set; }

        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public DateTime DateRented { get; set; }

        [DataMember]
        public DateTime DateDue { get; set; }

        [DataMember]
        public DateTime? DateReturned { get; set; }
        
        public int EntityId
        {
            get { return RentalId; }
            set { RentalId = value; }
        }

        int IAccountOwnEntity.OwnerAccountId
        {
            get { return AccountId; }
        }
    }
}
