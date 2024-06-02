using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public static class Exts
    {
        public static IEnumerable<T> ToIEnumerable<Collection, T>(this Collection src) where Collection : ICollection
        {
            foreach (T item in src)
                yield return item;
        }
    }
}
