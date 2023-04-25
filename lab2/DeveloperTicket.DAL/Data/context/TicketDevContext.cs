using DeveloperTicket.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DeveloperTicket.DAL
{
    public class TicketDevContext:DbContext
    {
        public TicketDevContext()
        {
                
        }
        public TicketDevContext(DbContextOptions<TicketDevContext> options) : base(options)
        {

        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Developer> Developers { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seeding :initial data values in database;

            List<Ticket> TicketList = new List<Ticket>()
        {
            new Ticket
            {
                Id= 1,
                Title="TicketOne",
                Description="very cool ticket",
                DepartmentId= 1
            },
             new Ticket
            {
                Id= 2,
                Title="TicketTwo",
                Description="Weird Dubg",
                DepartmentId= 1
            },
              new Ticket
            {
                Id= 3,
                Title="TicketThree",
                Description="Not Bad Ticket",
                 DepartmentId= 2

            }
        };

            List<Developer> DevList = new List<Developer>()
        {
            new Developer
            {
                Id= 1,
                Name="Ahmed"
            },
              new Developer
            {
                Id= 2,
                Name="Ali"
            },
        };

            List<Department> DeptList = new List<Department>()
        {
            new Department
            {
                Id= 1,
                Name="Sd"
            },
              new Department
            {
                Id= 2,
                Name="Gis"
            },
        };



            #endregion

            modelBuilder.Entity<Ticket>().HasData(TicketList);
            modelBuilder.Entity<Developer>().HasData(DevList);
            modelBuilder.Entity<Department>().HasData(DeptList);



        }

      

    }
}
