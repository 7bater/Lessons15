using System;
using System.Collections.Generic;

namespace Lessons15
{
    enum PlayGenre
    {
        Tragedy,
        Comedy,
        Drama,
        Musical,
        Opera
    }

    class Play : IDisposable
    {
        public string Title { get; set; }
        public string Theater { get; set; }
        public PlayGenre Genre { get; set; }
        public int Duration { get; set; }
        public List<string> Actors { get; set; } = new();
        private bool _isDisposed = false;

        public Play(string title, string theater, PlayGenre genre, int duration, List<string> actors)
        {
            Title = title;
            Theater = theater;
            Genre = genre;
            Duration = duration;
            Actors = actors ?? new List<string>();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Вистава: {Title}\nТеатр: {Theater}\nЖанр: {Genre}\nТривалість: {Duration} хв.");
            Console.WriteLine($"Актори: {string.Join(", ", Actors)}");
        }

        protected virtual void Cleaning(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"Звільнення керованих ресурсів вистави: \"{Title}\"");
                    Actors?.Clear();
                }
                Console.WriteLine($"Звільнення некерованих ресурсів вистави: \"{Title}\"");
                _isDisposed = true;
            }
        }

        public void Dispose()
        {
            Cleaning(true);
            GC.SuppressFinalize(this);
        }

        ~Play()
        {
            Cleaning(false);
            Console.WriteLine($"Знищено об'єкт вистави: \"{Title}\"");
        }
    }
}