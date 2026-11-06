//using System;
//using System.Collections.Generic;
//using System.Text;
//using static System.Console;

//namespace Lessons15
//{
//    internal class Program
//    {
//        private static void Main(string[] args)
//        {
//            OutputEncoding = Encoding.UTF8;
//            {
//                Film film1 = new Film("Inception", "Warner Bros.", "Sci-Fi", 148, 2010);
//                film1.PrintInfo();
//            }

//            CreateTemporaryFilms();

//            GC.Collect();
//            GC.WaitForPendingFinalizers();

//            //exx2
//using (Play play1 = new Play("Ромео і Джульєтта", "Національна Опера", "Трагедія", 150, new List<string> { "Артем", "Софія" }))
//{
//    play1.PrintInfo();
//}

//WriteLine();
//Play play2 = new Play("За двома зайцями", "Театр ім. Франка", "Комедія", 135, new List<string> { "Микола", "Нонна" });
//play2.PrintInfo();
//play2.Dispose();

//ReadKey();
//        }

//        static void CreateTemporaryFilms()
//{
//    new Film("Avatar", "20th Century Fox", "Sci-Fi", 162, 2009);
//    new Film("Titanic", "Paramount Pictures", "Drama", 195, 1997);
//}
//    }
//}

//exx3
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Lessons15
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            OutputEncoding = Encoding.UTF8;

            WriteLine("тест фільму");
            using (Film film1 = new Film("Interstellar", "Paramount", FilmGenre.SciFi, 169, 2014))
            {
                film1.PrintInfo();
            }

            WriteLine("\nтест театру");
            using (Play play1 = new Play("Гамлет", "Театр ім. Франка", PlayGenre.Tragedy, 180, new List<string> { "Олександр", "Марія" }))
            {
                play1.PrintInfo();
            }

            ReadKey();
        }
    }
}