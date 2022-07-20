using Microsoft.Extensions.DependencyInjection;
using Talent.Backend.DataAccessEF.Repositories;
using Talent.Backend.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Service.Contracts;
using DataAccess.Contracts;

namespace Talent.Backend.API
{
    public static class DependencyInjectionRegister
    {
        public static void AddRegistration(this IServiceCollection services)
        {
            //[Singleton] Genera una sola instancia y simpre devuelve la misma
            //[Trasient] Genera una sola instancia cada vez que se invoca
            //[Scope] Genera una sola instancia dentro de un contexto determinado

            AddRegistrationServices(services);
            AddRegistrationBussines(services);
            AddRegistrationRepositories(services);
        }

        private static void AddRegistrationServices(IServiceCollection services)
        {
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<ISurveyService, SurveyService>();
            //services.AddTransient<IQuestionService, QuestionService>();
            //services.AddTransient<IQuestionTypeService, QuestionTypeService>();
            //services.AddTransient<IAnswerService, AnswerService>();
            //services.AddTransient<IUserAnswerService, UserAnswerService>();
            services.AddTransient<IAccountService, AccountService>();

            services.AddHttpContextAccessor();
            //services.AddSingleton<IUriService>(o =>
            //{
            //    var accesor = o.GetService<IHttpContextAccessor>();
            //    var request = accesor.HttpContext.Request;
            //    var uri = $"{request.Scheme}{"://"}{request.Host.ToUriComponent()}";
            //    return new UriService(uri);
            //});
        }

        private static void AddRegistrationBussines(IServiceCollection services)
        {
            //services.AddTransient<IUserBussiness, UserBussiness>();
            //services.AddTransient<ISurveyBussiness, SurveyBussiness>();
            //services.AddTransient<IQuestionBussiness, QuestionBussiness>();
            //services.AddTransient<IQuestionTypeBussiness, QuestionTypeBussiness>();
            //services.AddTransient<IAnswerBussiness, AnswerBussiness>();
            //services.AddTransient<IUserAnswerBussiness, UserAnswerBussiness>();
            //services.AddTransient<IAccountBussiness, AccountBussiness>();
        }

        private static void AddRegistrationRepositories(IServiceCollection services)
        {
            //services.AddTransient<IUserRepository, UserRepository>();
            //services.AddTransient<ISurveyRepository, SurveyRepository>();
            //services.AddTransient<IQuestionRepository, QuestionRepository>();
            //services.AddTransient<IQuestionTypeRepository, QuestionTypeRepository>();
            //services.AddTransient<IAnswerRepository, AnswerRepository>();
            //services.AddTransient<IUserAnswerRepository, UserAnswerRepository>();
            services.AddTransient<IAccountRepository, AccountRepository>();
        }
    }
}
