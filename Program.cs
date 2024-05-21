using System;
using System.Linq;


namespace ConsoleApp2
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var context = new PlutoContext();

            // Linq Syntax
            /* var query=
                 from c in context.Courses
                 where c.Name.Contains("c#")
                 orderby c.Name
                 select c;

             foreach (var cource in query)
             {
                 Console.WriteLine(cource.Name);
             }*/

            //Extension Method 
            /* var Course=context.Courses
                 .Where(c=>c.Name.Contains("C#"))
                 .OrderBy(c=>c.Name);

             foreach(var cour in Course)
                 Console.WriteLine(cour.Name);*/


            // Restrictions

            /*var query =
                from c in context.Courses
                where c.Level == 1 && c.Author.Id == 1
                select c;

            foreach (var item in query)
            {

                Console.WriteLine(item.Level);
            }*/

            //Order BY
            /*var query =
                from c in context.Courses
                where c.Author.Id == 1
                orderby c.Level descending, c.Author.Name ascending
                select c;

            foreach (var item in query)
            {

                Console.WriteLine(item.Level);
                Console.WriteLine(item.Author.Name);
            }*/

            //Projection
            /*var query =
                from c in context.Courses
                where c.Author.Id == 1
                orderby c.Level descending, c.Name
                select new { Name = c.Name ,Author=c.Author.Name};

            foreach (var item in query)
            {

                Console.WriteLine(item.Name);
                Console.WriteLine(item.Author);
            }*/

            //Grouping
            var query =
                from c in context.Courses
                group c by c.Level
                into g
                select g;

            foreach (var item in query)
            {
                Console.WriteLine(item.Key);
                foreach (var course in item)
                {
                    Console.WriteLine("\t{0}",course.Name);
                }
            }

        }
    }
}
