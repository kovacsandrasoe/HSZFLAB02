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
