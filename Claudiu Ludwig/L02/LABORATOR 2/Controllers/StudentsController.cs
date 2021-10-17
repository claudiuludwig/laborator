using System;
using System.Collections.Generic;
using System.Linq;
using Repositories;
using Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace L02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentsController : ControllerBase
    {
        public StudentsController()
        {
        }

        public IEnumerable<Students> Get(){
            return StudentsRepo.Students;
        }

        [HttpGet("{id}")]
        public Students GetStudent(int id)
        {
        return StudentsRepo.Students.FirstOrDefault(s=>s.Id == id);
        }
    }
}