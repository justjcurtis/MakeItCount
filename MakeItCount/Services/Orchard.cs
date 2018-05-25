using System;
using System.Collections.Generic;
using MakeItCount.Enums;
using MakeItCount.Models;

namespace MakeItCount.Services
{
    public class Orchard
    {
        public int countApplesula = 0;
        Random randy = new Random();

        /// <summary>
        /// Generates a list of apples.
        /// </summary>
        /// <returns>between 32 & 48 apples</returns>
        public List<apple> JuicedDeCidered()
        {
            var apu = new List<apple>();
            for (int j = 0; j < randy.Next(32, 48); j++)
            {
                apu.Add(new apple(RandomColour()));
                countApplesula++;
            }
            return apu;
        }

        public Colour RandomColour()
        {
            Array values = Enum.GetValues(typeof(Colour));
            return (Colour)values.GetValue(randy.Next(values.Length));
            
        }

        /// <summary>
        /// many boxes of apples are aquired from an unwitting orchard
        /// </summary>
        /// <returns>between 14 & 26 boxed of apples</returns>
        public List<box<apple>> PommeDeTerror()
        {
            var AppleicationOfForce = new List<box<apple>>();


            for (int i = 0; i < randy.Next(14, 26); i++)
            {
                AppleicationOfForce.Add(new box<apple>(JuicedDeCidered()));
            }
            return AppleicationOfForce;
        }
        /// <summary>
        /// apples are removed from their homeland as aggresively as possible 
        /// i wont go into detail here, but it's not pretty sarge.
        /// </summary>
        /// <returns>List of between 7 & 13 Carts full of boxed full of apples</returns>
        public List<cart<apple>> GenoCider()
        {
            var AppleicationOfForce = new List<cart<apple>>();


            for (int i = 0; i < randy.Next(7, 13); i++)
            {
                AppleicationOfForce.Add(new cart<apple>(PommeDeTerror()));
            }

            return AppleicationOfForce;
        }

    }
}
