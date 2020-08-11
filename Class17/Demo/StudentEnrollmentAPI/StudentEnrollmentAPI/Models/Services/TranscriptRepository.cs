using StudentEnrollmentAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentEnrollmentAPI.Models.Services
{
    public class TranscriptRepository : ITranscript
    {
        public Task<Transcript> Create(Transcript transcript)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<Transcript> GetTranscript(int studentId, int courseId)
        {
            throw new NotImplementedException();
        }

        public Task<List<Transcript>> GetTranscripts()
        {
            throw new NotImplementedException();
        }

        public Task<Transcript> Update(Transcript transcript)
        {
            throw new NotImplementedException();
        }
    }
}
