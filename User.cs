using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegisterApp
{
    internal class User
    {
        private static int id=1;
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Surname { get; set; }
        public string NotRobotCode { get; set; }
       
        public enum RegistrationMonth { January=1,February,March,April,May,June,July,August,September,October,November,December };
        public RegistrationMonth Month  { get; set; }

    public User(string name, string surname,string notRobotCode,RegistrationMonth month)
        {
            Id = id++;
            Name = name;
            Surname = surname;
            this.Month=month;
            this.NotRobotCode = notRobotCode;
            
        }
        public (int,string,string,string, RegistrationMonth) GetDetails()
        {
           
            if (Extention.IsRobotCode(NotRobotCode))
            {
                return (Id, Name, Surname, NotRobotCode, Month);
            }
            else
            {
                Console.WriteLine("not a correct password entered for below registered student");
                return (Id, Name, Surname, NotRobotCode, Month);
                
              
            }
           
        }
        


    }
    
    }

