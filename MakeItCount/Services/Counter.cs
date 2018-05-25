using MakeItCount.Interfaces;
using System;

namespace MakeItCount.Services
{
    public class Counter<T> where T : ICountable
    {

        public Counter(Func<T, bool> isColour)
        {
            CountIf = isColour;
        }
        public Counter() : this(x => true)
        {
        
        }

        public int Count { get; private set; }
        
        public void Add(T item)
        {
            Count += CountIf(item) ? item.Count : 0;
        }
        
        private readonly Func<T, bool> CountIf;

    }
}
