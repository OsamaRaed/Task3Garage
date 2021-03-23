using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task3Garage.Data.Models;

namespace Task3Garage.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<CarDbEntity> Cars { get; set; }
        public DbSet<EmployeeDbEntity> Employees { get; set; }
        public DbSet<MaintenanceReportDbEntity> MaintenanceReports { get; set; }
        public DbSet<MaintenanceServiceDbEntity> MaintenanceServices { get; set; }
        public DbSet<CustomerDbEntity> Customers { get; set; }

    }
}
