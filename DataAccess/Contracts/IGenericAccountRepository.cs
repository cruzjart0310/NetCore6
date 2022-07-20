using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public interface IGenericAccountRepository
    {
        public interface IGenericAccountRepository<T> where T : class
        {
            Task<AccountResponse<T>> CreateAsync(T entity);
            Task<TokenRespose<T>> LoginAsync(UserForAuthentication userForAuthentication);

            Task LogOutAsync();

            Task<AccountResponse<T>> ForgotPasswordAsync(string email, string clientUrl);

            Task<AccountResponse<T>> ResetPasswordAsync(ResetPassword entity);

            Task<AccountResponse<T>> EmailConfirmationAsync(string email, string token);

            Task<T> FindByNameAsync(string email);

            Task<AccountResponse<T>> EmailConfirmedAsync(string email, string token);
        }
    }
}
