using SoccerFieldBooking.Domain.Common;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoccerFieldBooking.Domain.ValueObjects
{
    public class FieldSize : ValueObject
    {
        public int Length { get; private set; }
        public int Width { get; private set; }

        [NotMapped]
        public int Perimeter { get; private set; }

        public FieldSize()
        {
        }

        public FieldSize(int length, int width)
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
