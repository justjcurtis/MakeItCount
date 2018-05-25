using System.Collections.Generic;
using System.Linq;
using MakeItCount.Interfaces;

namespace MakeItCount.Models
{
    public class cart<T> : box<box<T>> where T : ICountable
    {
        public cart(List<box<T>> _items = null)
        {
            items = new List<box<T>>();

            if (_items != null)
            {
                items = _items.ToList();
            }
        }
        

    }
}
