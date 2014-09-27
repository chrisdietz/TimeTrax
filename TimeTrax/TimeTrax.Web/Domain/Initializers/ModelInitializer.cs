using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TimeTrax.Web.Models;

namespace TimeTrax.Web.Domain.Initializers
{
    public static class ModelInitializer
    {
        private static readonly DateTime SeedDate = DateTime.Now;
        const string SeedBy = "DbInitializer";

        public static List<Project> CreateProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    ProjectId = 1,
                    ProjectName = "Project Mayhem",
                    Description = "1st Rule of Project Mayhem: You do not ask questions about Project Mayhem",
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                }
            };
        }
                    
        public static List<Tasks> CreateTasks()
        {
            return new List<Tasks>
            {                
                new Tasks
                {
                    TasksId = 1,
                    TaskName= "Mischief Committee",
                    Description = "Setup for Mischief Committee: Meets on Wednesdays",
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                
                new Tasks
                {
                    TasksId = 2,
                    TaskName= "Misinformation Committee",
                    Description = "Setup for Misinformation Committee: Meets on Thursdays or whenever",
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                }, 
            };
        }

        public static List<Staff> CreateStaffs()
        {
            return new List<Staff>
            {
                new Staff
                {
                    StaffId = 1,
                    StaffType = "Employee",
                    FirstName = "Chris",
                    LastName = "Dietz",
                    EmailAddress = "chris@technologygrows.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 2,
                    StaffType = "Employee",
                    FirstName = "David",
                    LastName = "Beard",
                    EmailAddress = "david@technologygrows.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 3,
                    StaffType = "Employee",
                    FirstName = "Nathan",
                    LastName = "Sinclair",
                    EmailAddress = "Nathan.Sinclair@FloridaHousing.org",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 4,
                    StaffType = "Employee",
                    FirstName = "Blake",
                    LastName = "Bishop",
                    EmailAddress = "Blake.Bishop@FloridaHousing.org",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 5,
                    StaffType = "Employee",
                    FirstName = "Chester",
                    LastName = "Taylor",
                    EmailAddress = "Chester.Taylor@FloridaHousing.org",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 6,
                    StaffType = "Employee",
                    FirstName = "Roberto",
                    LastName = "Cuba",
                    EmailAddress = "cuba.rocha.roberto@gmail.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 7,
                    StaffType = "Employee",
                    FirstName = "Curtis",
                    LastName = "Johnson",
                    EmailAddress = "crjohnson3@fsu.edu",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 8,
                    StaffType = "Employee",
                    FirstName = "Brandon",
                    LastName = "Iglesias",
                    EmailAddress = "iglesias.brandon@gmail.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 9,
                    StaffType = "Employee",
                    FirstName = "Michael",
                    LastName = "Iglesias",
                    EmailAddress = "michael@technologygrows.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 10,
                    StaffType = "Employee",
                    FirstName = "Ryan",
                    LastName = "Whitney",
                    EmailAddress = "ryan@technologygrows.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 11,
                    StaffType = "Employee",
                    FirstName = "Thomas",
                    LastName = "Jackson",
                    EmailAddress = "thomas@technologygrows.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                },                                
                new Staff
                {
                    StaffId = 12,
                    StaffType = "Employee",
                    FirstName = "Lucas",
                    LastName = "vonHollan",
                    EmailAddress = "lucas@technologygrows.com",
                    DateOfBirth = SeedDate,
                    IsActive = true,
                    UpdatedDate = SeedDate,
                    UpdatedBy = SeedBy,
                    CreatedDate = SeedDate,
                    CreatedBy = SeedBy
                }
            };
        }
        
    }
}