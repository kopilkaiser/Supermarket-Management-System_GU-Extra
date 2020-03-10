using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }
        public string Name { get; set; }
        public long Number { get; set; }
        public string Department { get; set; }
        public DateTime StartingDate { get; set; }

        public string Valid(string name, long number, string department, string startingDate)
        {
            throw new NotImplementedException();
        }

        public bool Find(int staffID)
        {
            throw new NotImplementedException();
        }

        public string Valid(string name, string number, string department, string startingDate)
        {
            throw new NotImplementedException();
        }
    }
}