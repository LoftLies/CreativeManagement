using System;
using System.ComponentModel.DataAnnotations;

namespace CMDataManager.DTOs
{
    public class ProjectUpdateDTO
    {
        [MaxLength(250)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string ProjectType { get; set; }

        [Required]
        public bool FinishedProject { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int HoursSpent { get; set; }
    }
}
