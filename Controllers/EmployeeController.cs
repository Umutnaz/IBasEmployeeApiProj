namespace IBASEmployeeService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using IBASEmployeeService.Models;
    
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ILogger<EmployeeController> _logger;
        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }
        [HttpGet("GetEmployees")]
      public IEnumerable<Employee> Get()
{
    var employees = new List<Employee>() {
        new Employee() {
            Id = "21",
            Name = "Mette Bangsbo",
            Email = "meba@ibas.dk",
            Department = new Department() {
                Id = 1,
                Name = "Salg"
            }
        },
        new Employee() {
            Id = "22",
            Name = "Hans Merkel",
            Email = "hame@ibas.dk",
            Department = new Department() {
                Id = 2,
                Name = "Support"
            }
        },
        new Employee() {
            Id = "23",
            Name = "Karsten Mikkelsen",
            Email = "kami@ibas.dk",
            Department = new Department() {
                Id = 2,
                Name = "Support"
            }
        },
        // IT-afdelingen
        new Employee() {
            Id = "24",
            Name = "Jonas Andersen",
            Email = "joan@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "IT"
            }
        },
        new Employee() {
            Id = "25",
            Name = "Sofie Holm",
            Email = "soho@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "IT"
            }
        },
        new Employee() {
            Id = "26",
            Name = "Martin Kjær",
            Email = "makj@ibas.dk",
            Department = new Department() {
                Id = 3,
                Name = "IT"
            }
        },
        // Kantinen
        new Employee() {
            Id = "27",
            Name = "Lone Rasmussen",
            Email = "lora@ibas.dk",
            Department = new Department() {
                Id = 4,
                Name = "Kantinen"
            }
        },
        new Employee() {
            Id = "28",
            Name = "Peter Madsen",
            Email = "pema@ibas.dk",
            Department = new Department() {
                Id = 4,
                Name = "Kantinen"
            }
        }
    };

    return employees;
}
        [HttpGet("GetByDepartment/{departmentName}")]
        public IEnumerable<Employee> GetByDepartment(string departmentName)
        {
            var allEmployees = Get();
            var result = allEmployees
                .Where(e => e.Department.Name.Equals(departmentName, StringComparison.OrdinalIgnoreCase));
            return result;
        }
        //how to i postman: http://localhost:5194/api/Employee/GetByDepartment/IT
        //opstil i /side/port/(ln7) routenavn som er "api"/hvilken controller/endpoint/input
    }
}