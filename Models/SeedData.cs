using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HRM_Practice.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeeDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Employees.Any())
            {
                context.Employees.AddRange(
                    new Employee
                    {
                        Name = "Nguyen Van Thuan",
                        General = "Male",
                        Country = "Viet Nam"
                    },
                    new Employee
                    {
                        Name = "John Smith",
                        General = "Male",
                        Country = "American"
                    },
                    new Employee
                    {
                        Name = "Daisy",
                        General = "Female",
                        Country = "Australia"
                    },
                    new Employee
                    {
                        Name = "Nguyen Thi Doan",
                        General = "Female",
                        Country = "Viet Nam"
                    },
                    new Employee
                    {
                        Name = "Nhu Hoang Minh Duc",
                        General = "Male",
                        Country = "Viet Nam"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
