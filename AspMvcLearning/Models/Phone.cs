using Microsoft.EntityFrameworkCore.Storage;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMvcLearning.Models
{
    public class Phone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ManufacturerId { get; set; }
        public Company Manufacturer { get; set; }
        public int Price { get; set; }
    }
}
