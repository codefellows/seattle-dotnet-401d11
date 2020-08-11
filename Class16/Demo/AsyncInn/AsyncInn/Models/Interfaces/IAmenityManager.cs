using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
    public interface IAmenityManager
    {
        void CreateAmenity();
        void UpdateAmentity(int id);
        void DeleteAmentity(int id);
        List<Hotel> GetAmenities();
        Room GetAmentity(int id);
    }
}
