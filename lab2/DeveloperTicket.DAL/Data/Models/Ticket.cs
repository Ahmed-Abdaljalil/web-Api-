using DeveloperTicket.DAL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTicket.DAL.Data
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public List<Developer>? Developers { get; set; }
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }


    }
}
