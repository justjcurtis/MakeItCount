using System.Collections.Generic;
using System.Linq;
using MakeItCount.Interfaces;

namespace MakeItCount.Models
{
    public class box<T> : ICountable where T : ICountable
    {
        public box(List<T> _items = null)
        {

            if (_items != null)
            {
                items = _items;
            }
        }

        public List<T> items = new List<T>();
        public void Add(T item)
        {
            items.Add(item);
        }
        public int Count
        {
            get
            {
                return items.Sum(i => i.Count); 
            }
        }

    }
}
