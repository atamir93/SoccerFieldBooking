using SoccerFieldBooking.Domain.Common;
using SoccerFieldBooking.Domain.Enums;
using SoccerFieldBooking.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace SoccerFieldBooking.Domain.Model
{
    public class Company : Entity, IAggregateRoot, ICreatedHistory
    {
        public string Name { get; set; }
        public decimal Rating { get; set; }
        public Address Address { get; set; }
        public ContactPerson ContactPerson { get; set; }
        public decimal PricePerHour { get; set; }
        public AccountState AccountState { get; set; }
        public List<Field> Fields { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
