using DataAccess.Contracts;
using Service.Contracts;
using Service.Dtos;
using Service.Mappers;
using System;
using System.Threading.Tasks;

namespace Talent.Backend.Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<AccountResponseDto<UserForRegistrationDto>> CreateAsync(UserForRegistrationDto userDto)
        {
            var userMap = UserForRegistrationMapper.Map(userDto);
            var userBussiness = await _accountRepository.CreateAsync(userMap);
            return UserForRegistrationMapper.Map(userBussiness);
        }

        public async Task<AccountResponseDto<UserForRegistrationDto>> EmailConfirmationAsync(string email, string token)
        {
            var userBussiness = await _accountRepository.EmailConfirmationAsync(email, token);
            return UserForRegistrationMapper.Map(userBussiness);
        }

        public Task<UserForRegistrationDto> FindByNameAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<AccountResponseDto<UserForRegistrationDto>> ForgotPasswordAsync(string email)
        {
            return null;
        }

        public Task<bool> IsEmailConfirmedAsync(UserForRegistrationDto entity)
        {
            throw new NotImplementedException();
        }

        public async Task<LoginResposeDto<UserForAuthenticationDto>> LoginAsync(UserForAuthenticationDto entity)
        {
            var map = UserForAuthenticationMapper.Map(entity);
            var userLogin = await _accountRepository.LoginAsync(map);
            return null;
        }

        public async Task LogOutAsync()
        {
            await _accountRepository.LogOutAsync();
        }

        public Task<bool> ResetPasswordAsync(UserForRegistrationDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
