using System;

namespace Core.Entities
{
   public class Owner : EntityBase

    {
        public string FullName { get; set; }
        public String Profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}
