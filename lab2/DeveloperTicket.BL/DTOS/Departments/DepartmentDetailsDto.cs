using DeveloperTicket.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperTicket.BL.DTOS
{
    public class DepartmentDetailsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }=string.Empty;
        public List<TicketDetailsDto>? Tickets { get; set; }
    }
}
