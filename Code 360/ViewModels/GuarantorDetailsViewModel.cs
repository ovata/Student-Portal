using Code_360.Models.Guarantor;
using System.Collections.Generic;

namespace Code_360.ViewModels
{
    public class GuarantorDetailsViewModel
    {
        public Guarantor Guarantor { get; set; }
        public List<Guarantor> GetGuarantors { get; set; }
        public string PageTitle { get; set; }
    }
}
