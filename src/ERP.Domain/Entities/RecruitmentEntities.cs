using ERP.Domain.Common;
using System.Collections.Generic;

namespace ERP.Domain.Entities
{
    public class Job : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Requirements { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }

    public class Candidate : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ResumeUrl { get; set; } = string.Empty;
        public ICollection<Application> Applications { get; set; } = new List<Application>();
    }

    public class Application : BaseEntity
    {
        public int JobId { get; set; }
        public Job Job { get; set; } = null!;
        public int CandidateId { get; set; }
        public Candidate Candidate { get; set; } = null!;
        public string Status { get; set; } = "Applied"; // Applied, Interviewing, Offered, Rejected, Hired
    }
}
