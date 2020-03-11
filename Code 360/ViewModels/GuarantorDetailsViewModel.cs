using Code_360.Models.Guarantor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.ViewModels
{
    public class GuarantorDetailsViewModel
    {
        public Guarantor Guarantor { get; set; }
        public List<Guarantor> GetGuarantors { get; set; }
        public string PageTitle { get; set; }
    }
}
