using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.Models;
using StudentEnrollmentAPI.Models.Interfaces;

namespace StudentEnrollmentAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourse _course;

        public CoursesController(ICourse course)
        {
            _course = course;
        }

        // GET: api/Courses
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<Course>>> GetCourses()
        {
            return await _course.GetCourses();
        }

        // GET: api/Courses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Course>> GetCourse(int id)
        {
            return await _course.GetCourse(id);
        }

        // PUT: api/Courses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCourse(int id, Course course)
        {
            // Call the user service

            
            if (id != course.Id)
            {
                return BadRequest();
            }

            var updatedCourse = await _course.Update(course);

            return Ok(updatedCourse);
        }

        // POST: api/Courses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Course>> PostCourse(Course course)
        {
            await _course.Create(course);

            return CreatedAtAction("GetCourse", new { id = course.Id }, course);
        }

        [HttpPost]
        [Route("{courseId}/{studentId}")]
        // POST: {courseId}/{studentId}
        // Model Binding
        public async Task<IActionResult> AddStudentToCourse(int courseId, int studentId)
        {
            await _course.AddStudent(studentId, courseId);
            return Ok();
        }

        [HttpDelete]
        [Route("{courseId}/{studentId}")]
        public async Task<IActionResult> RemoveStudentFromCourse(int courseId, int studentId)
        {
            await _course.RemoveStudentFromCourse(courseId, studentId);
            return Ok();
        }

        // DELETE: api/Courses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Course>> DeleteCourse(int id)
        {
            await _course.Delete(id);

            return NoContent();
        }


    }
}
