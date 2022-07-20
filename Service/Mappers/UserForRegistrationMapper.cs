using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Models;

namespace Service.Mappers
{
    public class UserForRegistrationMapper
    {
        public static User Map(Service.Dtos.UserForRegistrationDto userForRegistrationDto)
        {
            return new User
            {
                FirstName = userForRegistrationDto.FirstName,
                LastName = userForRegistrationDto.LastName,
                Email = userForRegistrationDto.Email,
                PasswordHash = userForRegistrationDto.Password,
                UserName = userForRegistrationDto.Email
            };
        }

        public static Service.Dtos.AccountResponseDto<Service.Dtos.UserForRegistrationDto> Map(DataAccess.Models.AccountResponse<DataAccess.Entities.User> user)
        {

            if (user.Element == null) return null;  

            return new Service.Dtos.AccountResponseDto<Service.Dtos.UserForRegistrationDto>
            {
                Element = new Service.Dtos.UserForRegistrationDto
                {
                    FirstName = user.Element.FirstName,
                    LastName = user.Element.LastName,
                    Email = user.Element.Email,
                    Password = user.Element.PasswordHash,
                },
                Errors = user.Errors
            };
        }
    }
}
