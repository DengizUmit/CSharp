using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> sehirler = new List<string>();
            Console.WriteLine(sehirler.Count);
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.MyCount);
            sehirler2.Add("İstanbul");
            sehirler2.Add("Bursa");
            sehirler2.Add("Diyarbakır");
            Console.WriteLine(sehirler2.MyCount);

            Console.ReadLine();

        }
    }

    class MyList<T>  // Generic Class
    {

        T[] _array;
        T[] _tempArray;

        public MyList()
        {

            _array = new T[0];

        }
        public void Add(T item)
        {

            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for(int i=0; i<-_tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;

        }

        public int MyCount
        {

            get { return _array.Length; }

        }

    }
}
