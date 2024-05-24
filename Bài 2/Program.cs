using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Userdatalab4> list = new List<Userdatalab4>();
            list.Add(new Userdatalab4("GTA 5", 10));
            list.Add(new Userdatalab4("Genshin Impact", 60));
            list.Add(new Userdatalab4("Counter Strike 2", 15));
            list.Add(new Userdatalab4("LOL", 125));

            // a
            var selectedData = list.Select(u => new { u.Name, u.Level });
            foreach (var item in selectedData)
            {
                Console.WriteLine("Name: " + item.Name + " | Level: " + item.Level);
            }
            // b
            var sortedList = list.OrderByDescending(u => u.Level);
            Console.WriteLine("\nDanh sach userData sau khi sap xep theo thu tu giam dan cua Level: ");
            foreach (var item in sortedList)
            {
                Console.WriteLine("Name: " + item.Name + " | Level: " + item.Level);
            }
        }
    }
}
