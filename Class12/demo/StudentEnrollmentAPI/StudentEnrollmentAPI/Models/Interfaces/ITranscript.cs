using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Interfaces
{
    public interface ITranscript
    {
        // Create a transcript
        // get all transcripts

        // get a single transcript
        // delete a trancript
        // update a transcript

        Task<Transcript> Create(Transcript transcript);

        // Read
        // Get All
        Task<List<Transcript>> GetTranscripts();

        // Get individually (by Id)
        Task<Transcript> GetTranscript(int studentId, int courseId);

        // Update
        Task<Transcript> Update(Transcript transcript);

        // Delete
        Task Delete(int studentId, int courseId);
    }
}
