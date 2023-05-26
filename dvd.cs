using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public class dvd : libaryItem
    {
        protected string material { get; set; }

        public dvd(string title, string author, int pubicationYear, string material) : base(title, author, pubicationYear)
        {
            this.material = material;
        }
        public override string ToString()
        {
            return "Type: " + GetType().Name + ",Title: " + title + ",by Auhthor: " + author + ",Publication Year: " + publicationYear+",Material: "+material;
        }
    }
}
