using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_Learning_4
{
    static class Extensions
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext())
            {
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }

        public static bool SequencesMatch<T>(this IEnumerable<T> first, IEnumerable<T> second)
        {
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while(firstIter.MoveNext() && secondIter.MoveNext())
            {
                if(!firstIter.Current.Equals(secondIter.Current))
                {
                    return false;
                }
            }

            return true;
        }
        public static IEnumerable<T> LogQuery<T>(this IEnumerable<T> sequence, string tag)
        {
            using (var writer = File.AppendText("debug.log"))
            {
                writer.WriteLine($"Executing querry {tag}");
            }

            return sequence;
        }
    }
}
