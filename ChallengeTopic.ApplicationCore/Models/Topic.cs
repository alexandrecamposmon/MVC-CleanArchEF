using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeTopic.ApplicationCore.Models
{
    public class Topic: Entity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string CriationUser { get; set; }
        public DateTime CriationDate { get; set; }
    }
}
