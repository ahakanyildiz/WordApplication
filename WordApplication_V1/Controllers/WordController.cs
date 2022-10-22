using Microsoft.AspNetCore.Mvc;
using WordApplication_V1.Context;
using WordApplication_V1.Entities;

namespace WordApplication_V1.Controllers
{
    public class WordController : Controller
    {
        private readonly WordDbContext _dbContext ;

   
        public WordController()
        {
            _dbContext = new WordDbContext();
        }

        [HttpGet]
        public IActionResult Index()
        {
            var list = _dbContext.Words.ToList();
            return View(list);
        }

        [HttpGet]
        public IActionResult AddWord()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddWord(Word word)
        {
            _dbContext.Words.Add(word);
            _dbContext.SaveChanges();
            return View(word);
        }
    }
}
