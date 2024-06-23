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

        public List<Mail> TGetSendandReceiverMailnameListAllbyDeletedId(int id)
        {
            return _mailDal.GetSendandReceiverMailnameListAllbyDeletedId(id);
        }

        public List<Mail> TGetSendandReceiverMailnameListAllbyDraftSenderId(int id)
        {
            return _mailDal.GetSendandReceiverMailnameListAllbyDraftSenderId(id);
        }

        public List<Mail> TGetSendandReceiverMailnameListAllbyReadId(int id)
        {
            return _mailDal.GetSendandReceiverMailnameListAllbyReadId(id);
        }

        public List<Mail> TGetSendandReceiverMailnameListAllbySpamId(int id)
        {
            return _mailDal.GetSendandReceiverMailnameListAllbySpamId(id);
        }

        public List<Mail> TGetSendandReceiverMailnameListAllbyStarredId(int id)
        {
            return _mailDal.GetSendandReceiverMailnameListAllbyStarredId(id);
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
