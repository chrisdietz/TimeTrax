using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using TimeTrax.Web.Domain.Initializers;
using TimeTrax.Web.Models;

namespace TimeTrax.Web.Data.Commands
{
    public class SeedDatabaseCommand
    {
        private readonly ApplicationDbContext db;
        public SeedDatabaseCommand(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void SeedDatabase()
        {

            var projects = ModelInitializer.CreateProjects();
            db.Projects.AddOrUpdate(p => p.ProjectId, projects.ToArray());

            var tasks = ModelInitializer.CreateTasks();
            db.Tasks.AddOrUpdate(t => t.TasksId, tasks.ToArray());

            // User & Role manager
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));

            string adminRoleName = "Admin";
            string password = "P@ssword1"; // Default Password

            //Create Role Admin if it does not exist            
            if (!RoleManager.RoleExists(adminRoleName))
            {
                var roleresult = RoleManager.Create(new IdentityRole(adminRoleName));
            }

            var staffs = ModelInitializer.CreateStaffs();

            foreach (var staff in staffs)
            {
                //Create User with staff info from initializer
                var user = new ApplicationUser()
                    {
                        UserName = staff.EmailAddress,
                        Email = staff.EmailAddress,
                        Staff = new Staff()
                        {
                            EmailAddress = staff.EmailAddress,
                            FirstName = staff.FirstName,
                            LastName = staff.LastName,
                            DateOfBirth = staff.DateOfBirth,
                            StaffType = staff.StaffType,
                            IsActive = true,
                            CreatedDate = staff.CreatedDate,
                            UpdatedDate = staff.UpdatedDate,
                            CreatedBy = staff.CreatedBy,
                            UpdatedBy = staff.UpdatedBy,
                        }
                    };
                
                // Create User with Default Password
                var userResult = UserManager.Create(user, password);
                
                //Add User Admin to Role Admin
                if (userResult.Succeeded)
                {
                    var result = UserManager.AddToRole(user.Id, adminRoleName);
                }

            }



            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var error = ex.EntityValidationErrors.First().ValidationErrors.First();
            }

        }

    }
}