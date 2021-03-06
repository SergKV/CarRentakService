﻿namespace CarRental.Business.Entities
{
    using Core.Common.Contract;
    using Core.Common.Core;
    using System.Runtime.Serialization;

    [DataContract]
    public class Account : EntityBase, IIdentifiableEntity
    {
        [DataMember]
        public int AccountId { get; set; }

        [DataMember]
        public string LoginEmail { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string State { get; set; }

        [DataMember]
        public string ZipCode { get; set; }

        public int EntityId
        {
            get { return AccountId; }
            set { AccountId = value; }
        }
    }
}
