using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sourceapi.Services;

namespace sourceapi.Controllers
{
    [ApiController]
    [Route("/api/Course")]
    public class CourseController : ControllerBase
    {
        private CourseService _course_service;

        public CourseController(CourseService _svc)
        {
            _course_service = _svc;
        }

        [HttpGet]
        public IActionResult GetCourses()
        {
            return Ok(_course_service.GetCourses());
        }
    }
}
