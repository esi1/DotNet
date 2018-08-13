using DataLayer.Interfases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Classes
{
   public class Genre : IGenre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public Genre() { }

        public Genre(IGenre genre)
        {
            Id = genre.Id;
            Name = genre.Name; 
        }
    }
}
