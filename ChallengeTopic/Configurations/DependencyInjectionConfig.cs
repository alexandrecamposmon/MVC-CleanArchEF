using ChallengeTopic.ApplicationCore.Intefaces.Repository;
using ChallengeTopic.ApplicationCore.Intefaces.Services;
using ChallengeTopic.ApplicationCore.Services;
using ChallengeTopic.Infrastructure.Context;
using ChallengeTopic.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;

namespace ChallengeTopic.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            //CONTEXT
            services.AddScoped<ChallengeContext>();

            //REPOSITORIES
            services.AddScoped<ITopicRepository, TopicRepository>();

            //SERVICES
            services.AddScoped<ITopicService, TopicService>();

            return services;
        }
    }
}