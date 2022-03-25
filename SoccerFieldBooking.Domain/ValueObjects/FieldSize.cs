using SoccerFieldBooking.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldBooking.Domain.ValueObjects
{
    public class FieldSize : ValueObject
    {
        public decimal Length { get; private set; }
        public decimal Width { get; private set; }

        [NotMapped]
        public decimal Perimeter { get; private set; }

        public FieldSize()
        {
        }

        public FieldSize(decimal length, decimal width)
        {
            Length = length;
            Width = width;
            Perimeter = 2 * (length + width);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Perimeter;
        }
    }
}
