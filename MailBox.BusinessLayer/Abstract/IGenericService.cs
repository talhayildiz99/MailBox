using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TInsert(T entity);
        void TDelete(int id);
        void TUpdate(T entity);
        List<T> TGetListAll();
        T TGetById(int id);
    }
}
