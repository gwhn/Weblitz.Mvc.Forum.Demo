using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Weblitz.Mvc.Forum.Core.Interfaces;
using Weblitz.Mvc.Forum.Db;

namespace Weblitz.Mvc.Forum.Infrastructure.Services
{
    public class ForumRepository : Repository<Db.Forum>
    {
        public ForumRepository(IObjectContext adapter) : base(adapter)
        {
        }

        public override IEnumerable<Db.Forum> GetAll()
        {
            return ObjectSet
                .ToList();
        }
    }
}
