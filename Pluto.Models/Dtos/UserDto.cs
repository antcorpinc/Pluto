using System;
using Pluto.Models.Enums;

namespace Pluto.Models.Dtos{
    public class UserDto{
        public Guid Id {get;set;}

        public string UserName{get;set;}

        public string Email {get;set;}

        public UserType UserType { get; set; }

         public bool Disabled { get; set; }

         //ToDO Add FormUserDto
    }
}
