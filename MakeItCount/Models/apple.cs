using MakeItCount.Enums;
using MakeItCount.Interfaces;

namespace MakeItCount.Models
{
    public class apple : ICountable
    {
        public apple(Colour colour)
        {
            Colour = colour;
        }

        public Colour Colour { get; }
        public int Count { get { return 1; } }

    }
}
