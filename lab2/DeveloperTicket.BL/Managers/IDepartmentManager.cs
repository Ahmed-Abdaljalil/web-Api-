using DeveloperTicket.BL.DTOS;
using DeveloperTicket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTicket.BL
{
    public interface IDepartmentManager
    {
        DepartmentDetailsDto? GetDetails(int id);

        // for practise 
         IEnumerable<Department> GetDepts();
    }
}
