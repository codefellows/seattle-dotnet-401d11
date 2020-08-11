using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsyncInn.Models.Interfaces
{
   public interface IRoomManager
    {
        Task<Room> CreateRoom(Room room);

        Task UpdateRoom(Room room);

        Task DeleteRoom(int id);

        Task<List<Room>> GetRooms();

        Task<Room> GetRoom(int id);

        Task AddAmenityToRoom(int roomId, int amenityId);

        Task RemoveAmenityFromRoom(int roomId, int amenityId);

    }
}
