using AsyncInn.Data;
using AsyncInn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models.Services
{
    public class RoomRepository : IRoomManager
    {
        private HotelDbContext _context;
        private IAmenityManager _amenities;

        public RoomRepository(HotelDbContext context, IAmenityManager amenities)
        {
            _context = context;
            _amenities = amenities;
        }
        public async Task<Room> CreateRoom(Room room)
        {
            _context.Entry(room).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            await _context.SaveChangesAsync();
            return room;
        }

        public Task DeleteRoom(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Room> GetRoom(int id)
        {
            var room = await _context.Rooms.Where(x => x.ID == id)
                                            .Include(x => x.RoomAmenities)
                                            .ThenInclude(x => x.Amenities)
                                            .FirstOrDefaultAsync();

            // Convert the whole Room a RoomDTO
            // some foreach loop
           // for every amentity thats in there call
          //  _amenities.GetAmentity(id)
          // which will return you a DTO
            return room;
        }

        public async Task<List<Room>> GetRooms()
        {
            var rooms = await _context.Rooms.ToListAsync();
            return rooms;
        }

        public async Task UpdateRoom(Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        // Add AMenity To Room
        public async Task AddAmenityToRoom(int roomId, int amenityId)
        {
            RoomAmenities amenity = new RoomAmenities
            {
                AmenitiesID = amenityId,
                RoomID = roomId
            };

            _context.Entry(amenity).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAmenityFromRoom(int roomId, int amenityId)
        {
            var amenity = await _context.RoomAmenities.FindAsync(roomId, amenityId);

            if (amenity != null)
            {
                _context.Entry(amenity).State = EntityState.Deleted;
                await _context.SaveChangesAsync();
            }
        }
    }
}
