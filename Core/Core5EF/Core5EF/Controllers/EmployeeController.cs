using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core5EF.Models;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Core5EF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private const string employeecache = "employeeList";
        private readonly IEmployeeRepository _datarepository;
        private IMemoryCache _cache;
        private ILogger<EmployeeController> _logger;

        public EmployeeController(IEmployeeRepository erepo, IMemoryCache cache, ILogger<EmployeeController> logger)
        {
            _datarepository = erepo;
            _cache = cache;
            _logger = logger;
        }

        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            _logger.Log(LogLevel.Information, "Trying to Fetch the list of Employees from Cache");
            if(_cache.TryGetValue(employeecache, out IEnumerable<Employee> employees))
            {
                _logger.Log(LogLevel.Information, "Employees List found in the Cache");
            }
            else
            {
                _logger.Log(LogLevel.Information, "Employee list not found in the cache, Fetching from the Database");
                employees = _datarepository.GetAllEmployees();
                var cacheEntryOptions = new MemoryCacheEntryOptions()
                    .SetSlidingExpiration(TimeSpan.FromSeconds(60))
                    .SetAbsoluteExpiration(TimeSpan.FromSeconds(3000))
                    .SetPriority(CacheItemPriority.Normal)
                    .SetSize(1024);
                _cache.Set(employeecache, cacheEntryOptions);
            }
            return Ok(employees);
                
        }
            
    }
}
