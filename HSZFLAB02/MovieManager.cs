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

        public void Add(Movie m)
        {
            Movies.Add(m);
        }

        public void Load()
        {

        }

        public void Save()
        {

        }
    }
}
