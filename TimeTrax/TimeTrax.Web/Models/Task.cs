using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.DynamicData;

namespace TimeTrax.Web.Models
{
    [TableName("Tasks")]
    public class Tasks
    {
        [Display(Name = "Task Id")]
        public int TasksId { get; set; }

        [Required]
        [Display(Name = "Task Name")]
        [StringLength(50)]
        public string TaskName { get; set; }

        [Required]
        [Display(Name = "Description")]
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        // Audit fields
        [ScaffoldColumn(false)]
        [Required]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Updated Date")]
        [DataType(DataType.DateTime)]
        public DateTime? UpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Updated By")]
        [StringLength(100)]
        public string UpdatedBy { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Created Date")]
        [DataType(DataType.DateTime)]
        public DateTime? CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Created By")]
        [StringLength(100)]
        public string CreatedBy { get; set; }

        // Navigation properties
        public virtual ICollection<TimeEntry> TimeEntries { get; set; }

    }
}