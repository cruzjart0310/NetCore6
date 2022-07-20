using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mappers
{
    public class UserForAuthenticationMapper
    {
        public static UserForAuthentication Map(Service.Dtos.UserForAuthenticationDto userForAuthenticationDto)
        {
            return new UserForAuthentication
            {
                Email = userForAuthenticationDto.Email,
                Password = userForAuthenticationDto.Password,
                ClientUri = userForAuthenticationDto.ClientUri,
            };
        }

        public static Service.Dtos.LoginResposeDto<Service.Dtos.UserForAuthenticationDto> Map(DataAccess.Models.TokenRespose<DataAccess.Models.UserForAuthentication> tokenResponse)
        {
            if (tokenResponse == null)
                return null;

            return new Service.Dtos.LoginResposeDto<Service.Dtos.UserForAuthenticationDto>
            {
                Element = null,
                Token = tokenResponse.Token,
                Expiration = tokenResponse.Expiration,
                Errors = tokenResponse.Errors,
            };
        }
    }
}
