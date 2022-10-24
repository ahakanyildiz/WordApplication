using Microsoft.AspNetCore.Mvc;
using WordApplication_V1.Context;
using WordApplication_V1.Core;
using WordApplication_V1.Entities;

namespace WordApplication_V1.DataAccess.Abstract
{
    public interface IWordDal : IEntityDal<Word>
    {
        
    }
}
