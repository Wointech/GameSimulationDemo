using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationDemo
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsTheInformationcorrect { get; set; }
    }
}
