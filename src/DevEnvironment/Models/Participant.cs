using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEnvironment
{
    public class Participant
    {
        public string Name;
        public string Username;
        public string Password;
        public string Birthday;
        public string Gender;
        public string Email;
        public string HSName;
        public string NextCollege;
        public string Awards;
        public string Experience;

        public void NP(string Name, string Username, string Password, string Birthday, string Gender, string Email, string HSName, string NextCollege, string Awards, string Experience)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.Birthday = Birthday;
            this.Gender = Gender;
            this.Email = Email;
            this.HSName = HSName;
            this.NextCollege = NextCollege;
            this.Awards = Awards;
            this.Experience = Experience;
        }

    }
}
