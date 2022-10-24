using WordApplication_V1.Core;

namespace WordApplication_V1.Business.Abstract
{
    public interface IWordService<T> where T : class,IEntity
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Delete(Guid id);
        void Update(T t);
    }
}
