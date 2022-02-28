using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChallengeTopic.ApplicationCore.Intefaces;
using ChallengeTopic.ApplicationCore.Intefaces.Repository;
using ChallengeTopic.ApplicationCore.Models;
using ChallengeTopic.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace ChallengeTopic.Infrastructure.Repository
{
    public class TopicRepository : Repository<Topic>, ITopicRepository
    {
        public TopicRepository(ChallengeContext context) : base(context) { }

    }
}