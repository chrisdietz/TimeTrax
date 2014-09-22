﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeTrax.Web.Models
{
    
    public class Staff
    {
        [Display(Name = "Staff Id")]
        public int StaffId { get; set; }

        [Required]
        [Display(Name = "Staff Type")]
        [StringLength(50)]
        public string StaffType { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [StringLength(100)]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "The Email field is not a valid format.")]
        public string EmailAddress { get; set; }


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

    }

    //Enum Values
    public enum StaffType
    {
        Employee,
        Contractor
    }

}