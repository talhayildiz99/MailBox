using MailBox.BusinessLayer.Abstract;
using MailBox.DataAccessLayer.Abstract;
using MailBox.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.BusinessLayer.Concrete
{
    public class MailManager : IMailService
    {
        private readonly IMailDal _mailDal;

        public MailManager(IMailDal mailDal)
        {
            _mailDal = mailDal;
        }

        public void TDelete(int id)
        {
            _mailDal.Delete(id);
        }

        public Mail TGetById(int id)
        {
            return _mailDal.GetById(id);
        }

        public List<Mail> TGetListAll()
        {
            return _mailDal.GetListAll();
        }

        public void TInsert(Mail entity)
        {
            _mailDal.Insert(entity);
        }

        public void TUpdate(Mail entity)
        {
            _mailDal.Update(entity);
        }
    }
}
