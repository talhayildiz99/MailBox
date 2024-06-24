using MailBox.DataAccessLayer.Abstract;
using MailBox.DataAccessLayer.Context;
using MailBox.DataAccessLayer.Repositories;
using MailBox.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.DataAccessLayer.EntityFramework
{
    public class EfMailDal : GenericRepository<Mail>, IMailDal
    {

        MailContext context = new MailContext();

        public EfMailDal(MailContext context) : base(context)
        {

        }

        public void DraftDeletebyId(int id)
        {
            var deleteDraft = context.Mails.FirstOrDefault(x => x.MailId == id && x.IsDraft);
            if (deleteDraft != null)
            {
                context.Mails.Remove(deleteDraft);
                context.SaveChanges();
            }
        }

        public Mail GetByIdMailId(int id)
        {
            var values = context.Mails.Include(X => X.Sender).Where(x => x.MailId == id).Include(x => x.Receiver).FirstOrDefault();
            return values;
        }

        public Mail GetDraftMailbyId(int? id)
        {
            var draft = context.Mails.FirstOrDefault(x => x.MailId == id && x.IsDraft);
            return draft;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyDeletedId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(y => y.SenderId == id || y.ReceiverId == id).Where(x => x.IsDeleted == true).Include(y => y.Sender).ToList();
            return values;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyDraftSenderId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(y => y.SenderId == id && y.IsDraft && !y.IsDeleted && !y.IsSpam).Include(y => y.Sender).ToList();
            return values;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyReadId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(y => y.ReceiverId == id && !y.IsDraft && !y.IsDeleted && !y.IsSpam && !y.IsRead).Include(y => y.Sender).ToList();
            return values;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyReceiverId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(y => y.ReceiverId == id && !y.IsDraft && !y.IsDeleted && !y.IsSpam).Include(y => y.Sender).ToList();
            return values;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbySenderId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(y => y.SenderId == id && !y.IsDraft && !y.IsDeleted && !y.IsSpam).Include(y => y.Sender).ToList();
            return values;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbySpamId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(x => x.ReceiverId == id && x.IsDeleted && !x.IsSpam && !x.IsDraft).Include(y => y.Sender).ToList();
            return values;
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyStarredId(int id)
        {
            var values = context.Mails.Include(x => x.Receiver).Where(y => (y.SenderId == id || y.ReceiverId == id) && !y.IsDraft && !y.IsDeleted && y.IsStarred).Include(y => y.Sender).ToList();
            return values;
        }
    }
}
