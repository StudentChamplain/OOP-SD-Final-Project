using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_SD_Final_Project
{
    internal class Room
    {
        private int roomId;
        private string roomName;
        private int maxSeats;

        public Room()
        {

        }

        public int RoomId { get { return roomId; } }

        public string RoomName { get { return roomName; } set { roomName = value; } }

        public int MaxSeats { get { return maxSeats; } set { maxSeats = value; } }
    }
}
