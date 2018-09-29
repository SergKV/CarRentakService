namespace CarRental.Business.Entities
{
    using Core.Common.Contract;
    using Core.Common.Core;
    using System;
    using System.Runtime.Serialization;

    [DataContract]
    public class Reservation : EntityBase, IIdentifiableEntity, IAccountOwnEntity
    {
        [DataMember]
        public int ReservationId { get; set; }

        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public int CarId { get; set; }

        [DataMember]
        public DateTime RentalTime { get; set; }

        [DataMember]
        public DateTime ReturnDate { get; set; }

        public int EntityId
        {
            get { return ReservationId; }
            set { ReservationId = value; }
        }

        int IAccountOwnEntity.OwnerAccountId
        {
            get { return AccountId; }
        }
    }
}
