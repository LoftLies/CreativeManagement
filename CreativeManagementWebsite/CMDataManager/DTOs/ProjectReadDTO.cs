using System;

namespace CMDataManager.DTOs
{
    public class ProjectReadDTO
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ProjectType { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int HoursSpent { get; set; }
    }
}
