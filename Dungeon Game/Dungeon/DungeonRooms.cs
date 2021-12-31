using System;
using System.Collections.Generic;
using System.Text;

namespace Dungeon
{
    public class DungeonRooms
    {
        public string RoomName { get; set; }
        public string RoomDescription { get; set; }

        public DungeonRooms(string name, string description)
        {
            RoomName = name;
            RoomDescription = description;
        }
        public override string ToString()
        {
            string returnString = String.Format("Room: {0}\nDesription: {1}\n", this.RoomName, this.RoomDescription);
            return returnString;
        }
    }
}
