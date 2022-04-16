<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> elementsList)
        {
            Elements = elementsList;
        }

        public List<T> Elements { get; }
        public T Element { get; }

        public void Swap(List<T> elements, int index1, int index2)
        {
            T firstEl = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = firstEl;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }
            return sb.ToString().TrimEnd();
            // return $"{ typeof(T)}: {Element}";
        }

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountOfGreaterElements<T>(List<T> list, T readLine) where T : IComparable
            => list.Count(word => word.CompareTo(readLine) > 0);
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Generics
{
    public class Box<T> : IComparable<T> where T : IComparable<T>
    {
        public Box(T element)
        {
            Element = element;
        }

        public Box(List<T> elementsList)
        {
            Elements = elementsList;
        }

        public List<T> Elements { get; }
        public T Element { get; }

        public void Swap(List<T> elements, int index1, int index2)
        {
            T firstEl = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = firstEl;
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (T element in Elements)
            {
                sb.AppendLine($"{element.GetType()}: {element}");
            }
            return sb.ToString().TrimEnd();
            // return $"{ typeof(T)}: {Element}";
        }

        public int CompareTo(T other) => Element.CompareTo(other);

        public int CountOfGreaterElements<T>(List<T> list, T readLine) where T : IComparable
            => list.Count(word => word.CompareTo(readLine) > 0);
    }
}
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
