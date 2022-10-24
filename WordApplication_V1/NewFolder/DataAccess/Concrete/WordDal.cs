using WordApplication_V1.Context;
using WordApplication_V1.DataAccess.Abstract;
using WordApplication_V1.Entities;

namespace WordApplication_V1.DataAccess.Concrete
{
    public class WordDal : IWordDal
    {
        private readonly WordDbContext _context;

        public WordDal(WordDbContext context)
        {
            _context = context;
        }

        public void Add(Word entity)
        {
            var wordNew = new Word()
            {
                Id = new Guid(),
                EnName = entity.EnName,
                TrName = entity.TrName,
                ImageUrl = entity.ImageUrl
            };
            _context.Add(wordNew);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var selectedWord = _context.Words.Find(id);
            _context.Words.Remove(selectedWord);
            _context.SaveChanges();
        }

        public List<Word> GetAll()
        {
            var list = _context.Words.ToList();
            return list;
        }

        public Word GetById(Guid id)
        {
            var word = _context.Words.Where(x => x.Id == id).FirstOrDefault();
            return word;
        }

        public void Update(Word word)
        {
            var findedWord = _context.Words.Find(word.Id);
            findedWord.EnName = word.EnName;
            findedWord.TrName = word.TrName;
            findedWord.ImageUrl = word.ImageUrl;
            _context.SaveChanges();
        }
    }
}
