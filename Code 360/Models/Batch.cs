using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models.Batch
{
    public class Batch
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Supervisor { get; set; }
        [Required]
        public string Project { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime  StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public Guid ProgrammeId { get; set; }
        public Programs.Programme Programme { get; set; }

        public IList<StudentBatch> StudentBatches { get;set; }
    }
}
