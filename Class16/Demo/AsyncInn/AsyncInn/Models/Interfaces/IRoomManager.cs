using System.Collections.Generic;

namespace AsyncInn.Models.Interfaces
{
    interface IRoomManager
    {
        void CreateRoom();

        void UpdateRoom(int id);

        void DeleteRoom(int id);

        List<Room> GetRooms();

        Room GetRoom(int id);

    }
}
