using Models;
using System;

namespace HotelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room1 = new Room("No1",50,1);
            Room room2 = new Room("No3", 40,2);

            Hotel hotel = new Hotel();
            hotel.AddRoom(room1);
            hotel.AddRoom(room2);

            Room[] Rooms = new Room[0];
            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room1;

            Array.Resize(ref Rooms, Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room2;

            Console.WriteLine(hotel.MakeReservation(0));
            Console.WriteLine(hotel.MakeReservation(2)); 
        }
    }
}
