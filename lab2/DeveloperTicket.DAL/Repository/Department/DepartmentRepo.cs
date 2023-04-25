using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DeveloperTicket.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace DeveloperTicket.DAL.Repository;

public class DepartmentRepo : IDepartmentRepo
{
    private readonly TicketDevContext context;
    public DepartmentRepo(TicketDevContext context)
    {
        this.context = context;
    }
    public void Add(Department entity)
    {
        context.Add(entity);
      
    }

    public void Delete(Department entity)
    {
       context.Remove(entity);
    }

    public IEnumerable<Department> GetAll()
    {
        return context.Set<Department>();
    }

    public Department? GetById(int id)
    {
        return context.Set<Department>().Find(id);
    }

    public Department GetWithDevelopers(int id)
    {
      return  context.Departments
            .Include(p=>p.Tickets)
            .ThenInclude(x=>x.Developers).FirstOrDefault(d=>d.Id == id);    
    }

    public void SaveChanges(Department entity)
    {
        context.SaveChanges();
    }


    public void Update(Department newentity,int id)
    {
        var oldEntity =GetById(id);
            oldEntity.Name=newentity.Name;
       

        
    }
}
