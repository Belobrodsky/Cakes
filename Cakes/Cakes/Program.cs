using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cakes
{
    class Program
    {

        private static double ChangeList(List<double> src)
        {


            src[0] = 777;

            return src[0];
        
        }
        
        static void Main(string[] args)
        {

            List<double> a = new List<double>() { 12,12,41,14,14,14,542,63};


            Console.WriteLine(a[0]);
            Console.WriteLine(ChangeList(a));
            Console.WriteLine(a[0]); //и мы видим что наша прекрасная функция "испортила" коллекцию, так как коллекция являеться ссылочным типом данных


            //как этого избежать, например так
            //вернем все назад
            a[0] = 12;

            Console.WriteLine(a[0]);
            Console.WriteLine(ChangeList(new List<double>(a)));
            Console.WriteLine(a[0]);

           





            Console.ReadKey();


        }
    }
}
