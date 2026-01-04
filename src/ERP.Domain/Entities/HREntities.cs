using ERP.Domain.Common;
using System.Collections.Generic;

namespace ERP.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class Designation : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class Employee : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        
        public int DepartmentId { get; set; }
        public Department Department { get; set; } = null!;
        
        public int DesignationId { get; set; }
        public Designation Designation { get; set; } = null!;
        
        public decimal BaseSalary { get; set; }
    }
}
