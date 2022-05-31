using System;
using System.Collections.Generic;

#nullable disable

namespace WPFPersonalTracking.DB
{
    public partial class Permission
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public DateTime PermissionStartDay { get; set; }
        public DateTime PermissionEndDate { get; set; }
        public int PermissionState { get; set; }
        public string PermissionExplanation { get; set; }
        public int PermissionDay { get; set; }

        public virtual Emploee Employee { get; set; }
        public virtual Permissionstate PermissionStateNavigation { get; set; }
    }
}
