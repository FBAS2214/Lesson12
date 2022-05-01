using Models;
using System;

namespace Lesson12_1
{
    static class ExtensionMethods
    {
        public static int CountOfWord(this string text)
            => text.Split(' ').Length;


        public static bool IsNegative(this int number)
            => number < 0;


        public static float TotalScore(this List<Student> students)
            => students.Sum(s => s.Score);


        public static void Print(this List<Student> students)
            => students.ForEach(s => Console.WriteLine(s));

    }



    class Program
    {
        static void Main()
        {
            List<Student> students = Student.GetStudents();



            ////////////////////////////////////////
            //// Extension methods



            // string str = "Salam gencler necesiz?";
            // Console.WriteLine(str.CountOfWord());



            // int number = -1;
            // Console.WriteLine(number.IsNegative());



            // // students.ForEach(s => Console.WriteLine(s));
            // students.Print();
            // 
            // Console.WriteLine(students.TotalScore());





            ////////////////////////////////////////
            //// Discard parameter

            // int _ = 123;
            // Console.WriteLine(_);


            // _ = 123;
            // _ = "Test";


            // int GetValue() => 10;
            // _ = GetValue();


            // Func<int, int, string> func =  (_, _) => "Result";









            ////////////////////////////////////////
            //// Linq


            // students.ForEach(delegate (Student s) { Console.WriteLine/ (s); });
            // students.ForEach(s => Console.WriteLine(s));



            // var fullNamesOfStudents = students.Select(s => $"{s.Name} {s.Surname}").ToList();
            // fullNamesOfStudents.ForEach(s => Console.WriteLine(s));



            // students.FindAll(s => s.Score < 10).Print();




            // int[] numbers = new int[] { 1, 3, 5, 7, 8, 65, 34 };
            // 
            // numbers.Where(n => n > 5)
            //     .ToList()
            //     .ForEach(n => Console.WriteLine(n));




            // int[] numbers = new int[] { 1, 3, 5, 7, 8, 65, 34 };
            // 
            // Func<int, bool> func = n => n > 5;
            // numbers.Where(func)
            //     .ToList()
            //     .ForEach(n => Console.WriteLine(n));



            // Console.WriteLine(students.Count(s => s?.Name?.StartsWith('N') ?? false));



            // Console.WriteLine(students.Sum(s => s.Id));



            // First, FirstOrDefault, Single, SingleOrDefault

            // students = new List<Student>();
            // Console.WriteLine(students.First());
            // Console.WriteLine(students.First(s => s.Id > 11));
            // Console.WriteLine(students.FirstOrDefault(s => s.Id > 11));


            // Console.WriteLine(students.Single(s => s?.Name?.Contains("Nihad") ?? false));
            // Console.WriteLine(students.SingleOrDefault(s => s?.Name?.Contains("Nihat") ?? false));


            // students
            //     .Skip(2)
            //     .Take(4)
            //     .ToList()
            //     .Print();



            // students
            // .SkipWhile(s => s.Score < 12)
            // .ToList()
            // .Print();



            //  students
            // .TakeWhile(s => s.Score != 12)
            // .ToList()
            // .Print();





            // var student = students[4];
            // Console.WriteLine(students.IndexOf(student));




            // Console.WriteLine(students.FindIndex(s => s.BirthDate.Year == 2006));



            // students.OrderBy(s=>s.Score).ToList().Print();
            // students.OrderByDescending(s=>s.Score).ToList().Print();




            // students.Where(s => s.BirthDate.Year > 2002)
            //     .OrderByDescending(s => s.Score)
            //     .Take(3)
            //     .ToList()
            //     .Print();





            // students.Where(s => s.BirthDate.Year > 2002)
            //     .OrderBy(s => s.Score)
            //     .DistinctBy(s=>s.BirthDate.Year)
            //     .ToList()
            //     .Print();

        }
    }
}