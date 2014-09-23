using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace TimeTrax.Web.Models
{
    public class Project
    {
        public Project()
        {
            IsActive = true;
        }

        [Display(Name = "Project Id")]
        public int ProjectId { get; set; }

        [Required]
        [Display(Name = "Project Name")]
        [StringLength(50)]
        public string ProjectName { get; set; }

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