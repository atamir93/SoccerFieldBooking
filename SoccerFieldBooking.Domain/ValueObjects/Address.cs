using SoccerFieldBooking.Domain.Common;
using System.Collections.Generic;

namespace SoccerFieldBooking.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public string Country { get; private set; }
        public string State { get; private set; }
        public string City { get; private set; }
        public string Street { get; private set; }
        public string PostalCode { get; private set; }

        public Address()
        {
        }

        public Address(string country, string state, string city, string street, string postalCode)
        {
            Country = country;
            State = state;
            City = city;
            Street = street;
            PostalCode = postalCode;
        }
        public override string ToString()
        {
            return $"{Street}, {City}, {State} {PostalCode}";
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Country;
            yield return State;
            yield return City;
            yield return Street;
            yield return PostalCode;
        }
    }
}
