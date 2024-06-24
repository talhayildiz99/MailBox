using MailBox.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.DataAccessLayer.Abstract
{
    public interface IMailDal : IGenericDal<Mail>
    {
        List<Mail> GetSendandReceiverMailnameListAllbyReceiverId(int id);
        List<Mail> GetSendandReceiverMailnameListAllbySenderId(int id);
        List<Mail> GetSendandReceiverMailnameListAllbyReadId(int id);
        List<Mail> GetSendandReceiverMailnameListAllbyStarredId(int id);
        List<Mail> GetSendandReceiverMailnameListAllbyDraftSenderId(int id);
        List<Mail> GetSendandReceiverMailnameListAllbyDeletedId(int id);
        List<Mail> GetSendandReceiverMailnameListAllbySpamId(int id);
        public Mail GetByIdMailId(int id);
        Mail GetDraftMailbyId(int? id);
        void DraftDeletebyId(int id);
    }
}
