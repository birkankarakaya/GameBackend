using System;
using System.Collections.Generic;
using System.Text;

namespace GameBackend
{
    public class Player
    {
        public int Id { get; set; }
        public string TcNo { get; set; }
        public string FirstName { get; set; }
        public string Nickname { get; set; }
        public string EMail { get; set; }
        public string Age { get; set; }
        public DateTime DateofRegistration { get; set; }
        public DateTime DateofBirth { get; set; }
    }
}
