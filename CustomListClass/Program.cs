using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            string actual = "";
            CustomList<string> intList = new CustomList<string>();
            intList.Add("Adam ");
            intList.Add("Connolly ");
            intList.Add("Adam ");
            intList.Add("Connolly ");
            intList.Add("Adam ");
            intList.Add("Connolly ");

            for (int i = 0; i < intList.Count; i++)
            {
                actual += intList[i];
            }
            //foreach(int number in intList)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.ReadLine();

            StringBuilder stringBuilder = new StringBuilder(actual);

            Console.WriteLine(stringBuilder.ToString());
            Console.ReadLine();
        }
    }
}
