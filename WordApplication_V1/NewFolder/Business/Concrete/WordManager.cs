using Microsoft.AspNetCore.Cors.Infrastructure;
using WordApplication_V1.Business.Abstract;
using WordApplication_V1.Entities;

namespace WordApplication_V1.Business.Concrete
{
    public class WordManager : IWordService<Word>
    {
        public void Add(Word entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Word> GetAll()
        {
            throw new NotImplementedException();
        }

        public Word GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Word t)
        {
            throw new NotImplementedException();
        }
    }
}
