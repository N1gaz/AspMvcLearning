using AspMvcLearning.Models;
using System.Collections.Generic;

namespace AspMvcLearning.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Phone> Phones { get; set; }
        public IEnumerable<CompanyModel> Companies { get; set; }
    }
}
