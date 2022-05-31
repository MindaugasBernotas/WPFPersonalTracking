using System;
using System.Collections.Generic;

#nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Department
    {
        public Department()
        {
            Emploees = new HashSet<Emploee>();
            Positions = new HashSet<Position>();
        }

        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Emploee> Emploees { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
    }
}
