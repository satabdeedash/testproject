using System;
using Test_Taste_Console_Application.Domain.DataTransferObjects;

namespace Test_Taste_Console_Application.Domain.Objects
{
    public class Moon
    {
        public string Id { get; set; }
        public float MassValue { get; set; }
        public float MassExponent { get; set; }
        public float Gravity { get; set; }


        public Moon(MoonDto moonDto)
        {
            if (moonDto == null) throw new ArgumentNullException(nameof(moonDto));
            Id = moonDto.Id;
            MassValue = moonDto.MassValue;
            MassExponent = moonDto.MassExponent;
            Gravity = CalculateGravity(MassValue, MassExponent);
        }
        private float CalculateGravity(float massValue, float massExponent)
        {
            // Hypothetical formula for gravity calculation
            return massValue * (float)Math.Pow(10, massExponent);
        }
    }
}
