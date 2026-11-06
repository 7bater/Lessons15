using System;

namespace Lessons15
{
    class Film : IDisposable
    {
        public string Title { get; set; }
        public string Studio { get; set; }
        public FilmGenre Genre { get; set; }
        public int Duration { get; set; }
        public int Year { get; set; }

        private bool _isDisposed = false;

        public Film(string title, string studio, FilmGenre genre, int duration, int year)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            Duration = duration;
            Year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Фільм: {Title}, Кіностудія: {Studio}, Жанр: {Genre}, Тривалість: {Duration} хв., Рік: {Year}");
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    Console.WriteLine($"Звільнення керованих ресурсів фільму: \"{Title}\"");
                }
                Console.WriteLine($"Звільнення некерованих ресурсів фільму: \"{Title}\"");
                _isDisposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        ~Film()
        {
            Dispose(false);
            Console.WriteLine($"Знищено об'єкт фільму: \"{Title}\"");
        }
    }
}