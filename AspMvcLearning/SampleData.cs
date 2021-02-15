using AspMvcLearning.Models;
using System.Collections.Generic;
using System.Linq;

namespace AspMvcLearning
{
    public static class SampleData
    {
        public static void Initialize(MobileContext context)
        {
                Company apple = new Company { Id = 1, Name = "Apple", Country = "США" };
                Company microsoft = new Company { Id = 2, Name = "Microsoft", Country = "США" };
                Company google = new Company { Id = 3, Name = "Google", Country = "США" };
                Company samsung = new Company { Id = 4, Name = "Samsung", Country = "Республика Корея" };

                context.Companies.AddRange(apple, microsoft, google, samsung);

                List<Phone> phones = new List<Phone>
                {
                new Phone { Id=1, Manufacturer= apple, Name="iPhone X", Price=56000},
                new Phone { Id=2, Manufacturer= apple, Name="iPhone XZ", Price=41000},
                new Phone { Id=3, Manufacturer= samsung, Name="Galaxy 9", Price=9000},
                new Phone { Id=4, Manufacturer= samsung, Name="Galaxy 10", Price=40000},
                new Phone { Id=5, Manufacturer= google, Name="Pixel 2", Price=30000},
                new Phone { Id=6, Manufacturer= google, Name="Pixel XL", Price=50000}
                };
                context.Phones.AddRange(phones.ToArray());
                
                context.SaveChanges();
            
        }
    }
}
