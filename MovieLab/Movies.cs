using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab
{
    internal class Movies
    {
        //properties
        public string Title { get; set; }
        public string Category { get; set; }
        //constructor
        public Movies(string _title, string _category)
        {
            Title = _title;
            Category = _category;
        }
        //Methods
        public virtual string TitleName (string name)
        {
            Title = name;
            return Title;
        }
        public virtual string CategoryName (string name2)
        {
            Category = name2;
            return Category;
        }
    }
}
