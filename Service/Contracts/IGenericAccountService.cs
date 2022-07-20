using Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Contracts
{
    public interface IGenericAccountService<T> where T : class
    {
        Task<AccountResponseDto<T>> CreateAsync(T entity);
        Task<LoginResposeDto<UserForAuthenticationDto>> LoginAsync(UserForAuthenticationDto entity);

        Task LogOutAsync();

        Task<AccountResponseDto<T>> ForgotPasswordAsync(string email);

        Task<bool> ResetPasswordAsync(T entity);

        Task<AccountResponseDto<T>> EmailConfirmationAsync(string email, string token);

        Task<T> FindByNameAsync(string email);

        Task<bool> IsEmailConfirmedAsync(T entity);
    }
}
