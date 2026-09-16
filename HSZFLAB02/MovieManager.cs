using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSZFLAB02
{
    public class MovieManager
    {
        //publikusságot átírni később
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public MovieManager()
        {
            Load();
        }

        public void Add(Movie m)
        {
            Movies.Add(m);
            Save();
        }

        public void MoviesAfter2000()
        {
            Console.WriteLine("2000 utáni filmek címe: ");
            var q = Movies.Where(m => m.Year > 2000);
            foreach (var m in q)
            {
                Console.WriteLine(m.Title);
            }
        }

        public void SearchMovie()
        {
            Console.WriteLine("2000 után jelent meg és 2 órás");
            var q = Movies.FirstOrDefault(m => m.Year > 2000 && m.Duration >= 120);
            if (q == null)
            {
                Console.WriteLine("Nincs ilyen film");
            }
            else
            {
                Console.WriteLine(q.Title);
            }
        }

        public void ShortMovie()
        {
            Console.WriteLine("1 óránál rövidebb film: ");
            var q = Movies.Any(m => m.Duration < 60);
            Console.WriteLine(q);
        }

        public void LongMovie()
        {
            Console.WriteLine("Minden film hosszabb-e mint fél óra: ");
            var q = Movies.All(m => m.Duration > 30);
            Console.WriteLine(q);
        }

        public void SortByDuration()
        {
            Console.WriteLine("Hossz szerint növekvő sorrend: ");
            var q = Movies.OrderBy(m => m.Duration);
            foreach(var m in q)
            {
                Console.WriteLine(m.Title);
            }
        }

        public void Load()
        {
           if (File.Exists("movies.json"))
           {
                string data = File.ReadAllText("movies.json");
                Movies = JsonConvert.DeserializeObject<List<Movie>>(data) 
                    ?? new List<Movie>();
           }
        }

        public void Save()
        {
            string data = JsonConvert
                .SerializeObject(Movies, Formatting.Indented);
            File.WriteAllText("movies.json", data);
        }
    }
}
