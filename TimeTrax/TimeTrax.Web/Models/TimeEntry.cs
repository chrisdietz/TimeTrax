using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeTrax.Web.Models
{
    public class TimeEntry
    {
        public int TimeEntryId { get; set; }

        [Required]
        [Display(Name = "Staff")]
        public int StaffId { get; set; }

        [Required]
        [Display(Name = "Project")]
        public int ProjectId { get; set; }

        [Required]
        [Display(Name = "Task")]
        public int TaskId { get; set; }

        [Required]
        [Display(Name = "Hours")]
        [DisplayFormat(DataFormatString = "{0:#.##}")]
        [Range(0, 24)]
        public decimal Hours { get; set; }

        [Required]
        [Display(Name = "Notes")]
        [StringLength(200)]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime TimeEntryDate { get; set; }

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
        public virtual Staff Staff { get; set; }
        public virtual Project Project { get; set; }
        public virtual Tasks Tasks { get; set; }

    }
}