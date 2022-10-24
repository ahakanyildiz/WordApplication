namespace WordApplication_V1.Core
{
    public interface IEntityDal<T> where T : class, IEntity
    {
        List<T> GetAll();
        T GetById(Guid id);
        void Add(T entity);
        void Delete(Guid id);
        void Update(T t);
    }
}
