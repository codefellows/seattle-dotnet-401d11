using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEnrollmentAPI.Data;
using StudentEnrollmentAPI.Models;
using StudentEnrollmentAPI.Models.Interfaces;

namespace StudentEnrollmentAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TranscriptsController : ControllerBase
    {
        private readonly ITranscript _transcript;

        public TranscriptsController(ITranscript context)
        {
            _transcript = context;
        }

        // GET: api/Transcripts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transcript>>> GetTranscript()
        {
            return await _transcript.GetTranscripts();
        }

        // GET: api/Transcripts/{studentId}/Course/{courseId}
        [HttpGet("{studentId}/Course/{courseId}")]
        public async Task<ActionResult<Transcript>> GetTranscript(int studentId, int courseId)
        {
            var transcript = await _transcript.GetTranscript(studentId, courseId);

            return transcript;
        }

        // PUT: api/Transcripts/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTranscript(int id, Transcript transcript)
        {
            if (id != transcript.ID)
            {
                return BadRequest();
            }

            await _transcript.Update(transcript);

            return NoContent();
        }

        // POST: api/Transcripts
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Transcript>> PostTranscript(Transcript transcript)
        {
            await _transcript.Create(transcript);

            return CreatedAtAction("GetTranscript", new { id = transcript.ID }, transcript);
        }

        //// DELETE: api/Transcripts/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Transcript>> DeleteTranscript(int id)
        //{
        //    await _transcript.Delete(id);

        //    return transcript;
        //}

        //private bool TranscriptExists(int id)
        //{
        //    return _context.Transcript.Any(e => e.ID == id);
        //}
    }
}
