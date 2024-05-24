using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            List<StudentLab4> list = new List<StudentLab4>();
            list.Add(new StudentLab4("1", "Tuan Dat", 20));
            list.Add(new StudentLab4("2", "Huy Duy", 12));
            list.Add(new StudentLab4("3", "Van Tiu", 14));
            list.Add(new StudentLab4("4", "Trong Cuong", 15));
            list.Add(new StudentLab4("5", "Anh Khoa", 18));
            // a
            var querySyntax = from student in list
                              where student.Age >= 12 && student.Age <= 20
                              select student;
            Console.WriteLine("cac hs co do tuoi tu 12 den 20 bang querysyntax:  ");
            foreach (var student in querySyntax)
            {
                Console.WriteLine($"ID: {student.ID} | Ten: {student.Name} | Tuoi: {student.Age}");

            }
            // b
            var methodSyntax = list.Where(student => student.Age >= 12 && student.Age <= 20);
            Console.WriteLine("cac hs co do tuoi tu 12 den 20 bang methodsyntax: ");
            foreach (var student in methodSyntax)
            {
                Console.WriteLine($"ID: {student.ID} | Ten: {student.Name} | Tuoi: {student.Age}");
            }    
        }
    }
}
