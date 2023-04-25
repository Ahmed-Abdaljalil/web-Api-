using DeveloperTicket.DAL.Data;
//using DeveloperTicket.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTicket.DAL
{
    public interface IDepartmentRepo
    {
            IEnumerable<Department> GetAll();

            Department? GetById(int id);
            void Add(Department entity);
            void Update(Department entity,int id);
            void Delete(Department entity);
            void SaveChanges(Department entity);
        Department? GetWithDevelopers(int id);
    }
}
