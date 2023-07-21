using static Dapper.SqlMapper;
using System.Linq.Expressions;

namespace SipayApi.Data.Repository;

public interface IGenericRepository<Entity> where Entity : class
{
    //Where fonksiyonu, Expression<Func<Entity, bool>> tipinde bir parametre alır ve bunu kullanarak kriterleri dinamik olarak uygular.
    IEnumerable<Entity> Where(Expression<Func<Entity, bool>> expression);
}
