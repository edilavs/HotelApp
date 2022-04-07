using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Hotel
    {
        public string Name { get; set; }
        private Room[] _rooms=new Room[0];
        public Room[] Rooms { get=>_rooms;set {_rooms=value; } }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms, _rooms.Length + 1);
            _rooms[_rooms.Length - 1] = room;
        }
        public void MakeReservation(int? roomId)
        {
            if (roomId == null)
                throw new NotAvailableException();
            else
            {
                for (int i = 0; i < _rooms.Length; i++)
                {
                    if (_rooms[i].ID==roomId && !(_rooms[i].IsAvailable))
                        throw new NotAvailableException();
                    else
                    _rooms[i].IsAvailable = true;
                }
            }
        }
}
}
