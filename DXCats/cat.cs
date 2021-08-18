using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
namespace DXCats
{
    public class Cat
    {
         
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
    }

    public static class Data 
    {
        public static List<Cat> GetCats()
        {

            var cats = new List<Cat>
            {
                new Cat {Id = 1, Name = "Anakin", Breed = "Moggy"},
                new Cat {Id = 2, Name = "Anakin2", Breed = "Moggy"},
                new Cat {Id = 3, Name = "Anakin3", Breed = "Moggy"},
                new Cat {Id = 4, Name = "Anakin4", Breed = "Moggy"},
                new Cat {Id = 5, Name = "Anakin5", Breed = "Moggy"},
            };

            return cats;
        }

    }

}
