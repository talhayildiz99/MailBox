using MailBox.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.BusinessLayer.Abstract
{
    public interface IMailService : IGenericService<Mail>
    {
        public List<Mail> TGetSendandReceiverMailnameListAllbyReadId(int id);
        public List<Mail> TGetSendandReceiverMailnameListAllbyStarredId(int id);
        public List<Mail> TGetSendandReceiverMailnameListAllbyDraftSenderId(int id);
        public List<Mail> TGetSendandReceiverMailnameListAllbyDeletedId(int id);
        public List<Mail> TGetSendandReceiverMailnameListAllbySpamId(int id);
       
    }
}
