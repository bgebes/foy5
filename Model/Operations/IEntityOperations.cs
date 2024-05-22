using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foy5.Model.Operations
{
    public interface IEntityOperations<T, I>
    {
        T create(T entity);
        List<T> list();
        T read(I ID);
        T update(T entity);
        T delete(I ID);
    }
}
