using SipayApi.Base;
using System.Linq.Expressions;
using static Dapper.SqlMapper;

namespace SipayApi.Data.Repository;

public class GenericRepository<Entity> : IGenericRepository<Entity> where Entity : BaseModel
{
    //GenericRepository sınıfı, IRepository arayüzünü uygular ve List<TEntity> koleksiyonunu kullanarak işlemleri gerçekleştirir. 
    private readonly List<Entity> _entities;

    //Where fonksiyonu, LINQ sorguları üzerinde çalışır ve verilen expression parametresini kullanarak uygun sonuçları döndürür.
    public IEnumerable<Entity> Where(Expression<Func<Entity, bool>> expression) 
    {
        return _entities.Where(expression.Compile());
    }
}
