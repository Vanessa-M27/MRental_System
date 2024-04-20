using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRental_Model
{
    public class Movie
    {
        public int Code;
        public string Title;
        public string Genre;
        public double Price;
        public bool IsRented {  get; set; }
    }
}
