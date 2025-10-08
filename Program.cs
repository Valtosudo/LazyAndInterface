using System.Runtime.ExceptionServices;

namespace LazyAndInterface;

// IEnumerable ja Lazy evaluation

class Program
{
    static void Main(string[] args)
    {
        foreach (int luku in SuuretLuvut())
        {
            if (luku > 1000000)
            {
                break;
            }
            else
            {
                Console.WriteLine(luku);
            }

        }
    }

    // static List<int> SuuretLuvut()
    // {
    //     List<int> lista = new List<int>();

    //     for (int i = 0; i < int.MaxValue; i++)
    //     {
    //         lista.Add(i);
    //     }
    //     return lista;
    // }

    static IEnumerable<int> SuuretLuvut()
    {
        for (int i = 0; i < int.MaxValue; i++)
        {
            yield return i;
        }
    }
}
