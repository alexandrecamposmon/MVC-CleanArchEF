using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ChallengeTopic.ApplicationCore.Intefaces.Repository;
using ChallengeTopic.ApplicationCore.Models;
using ChallengeTopic.ApplicationCore.Intefaces.Services;

namespace ChallengeTopic.ApplicationCore.Services
{
    public class TopicService : Service<Topic>, ITopicService
    {
        private readonly ITopicRepository repository;

        public TopicService(ITopicRepository repository) : base(repository)
        {
            this.repository = repository;
        }

    }
}