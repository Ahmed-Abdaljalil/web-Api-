using DeveloperTicket.BL;
using DeveloperTicket.BL.DTOS;
using DeveloperTicket.DAL;
using DeveloperTicket.DAL.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperTicket.APIS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentManager deptManager;
        private readonly IDepartmentRepo deptrepo;
        public DepartmentController(IDepartmentManager _deptManager,IDepartmentRepo _deptrepo)
        {
            deptManager= _deptManager;
            deptrepo = _deptrepo;
               
        }

        //for practise
        [HttpGet]
        public ActionResult<IEnumerable<Department>> getall()
        {
            return Ok(deptManager.GetDepts());
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<DepartmentDetailsDto> getDetails(int id)
        {
            DepartmentDetailsDto? dept=deptManager.GetDetails(id);
            if(dept is null)
            {
                return NotFound();
            }
            return dept;
        }
    }
}
