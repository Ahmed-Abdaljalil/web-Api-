using DeveloperTicket.BL.DTOS;

using DeveloperTicket.DAL;
using DeveloperTicket.DAL.Data;
//using DeveloperTicket.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTicket.BL
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepo deptRepo;
        public DepartmentManager(IDepartmentRepo _deptRepo)
        {
            deptRepo= _deptRepo;
        }
        public DepartmentDetailsDto? GetDetails(int id)
        {
            Department? deptFromDB = deptRepo.GetWithDevelopers(id);
            if (deptFromDB is null)
            {
                return null;
            }
            return new DepartmentDetailsDto
            {
                Id = id,
                Name = deptFromDB.Name,
                Tickets = deptFromDB.Tickets
                .Select(dbdept => new TicketDetailsDto
                {
                    Id = dbdept.Id,
                    Description = dbdept.Description,
                    DevelpersCount = dbdept.Developers.Count
                }).ToList(),
            };
        }

        //for practise
        public IEnumerable<Department> GetDepts()
        {
            return deptRepo.GetAll();
        }
    }
}
