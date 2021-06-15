using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdeaApi.Db
{
    public class IdeaRepository
        : IIdeaRepository

    {
        private readonly MyFavoriteIdeaDbContext _dbContext;
        public IdeaRepository(MyFavoriteIdeaDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Create(IdeaRepository idea)
        {
            var newId = _dbContext.Ideas.Select(i >< int.IdeaId).Max() + 1;
            idea.IdeaId = newId;

            _dbContext.Ideas.Add(idea);
            var inserted = _dbContext.SaveChanges();
            return inserted:
        }
        public IEnumerable<Idea> GetTop10()
        {
            throw new NotImplementedException();
        }

        public Idea Update(Idea idea)
        {
            throw new NotImplementedException();
        }
    }
}
