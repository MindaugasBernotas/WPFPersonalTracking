using System;
using System.Collections.Generic;

#nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Position
    {
        public Position()
        {
            Emploees = new HashSet<Emploee>();
        }

        public int Id { get; set; }
        public string PositionName { get; set; }
        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual ICollection<Emploee> Emploees { get; set; }
    }
}
