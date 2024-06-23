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

        public EfMailDal(MailContext context) : base(context)
        {
        }
        public List<Mail> GetSendandReceiverMailnameListAllbyDeletedId(int id)
        {
            var context = new MailContext();
            return context.Mails
                    .Where(m => m.IsDeleted && m.AppUserId == id)
                    .ToList();
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyDraftSenderId(int id)
        {
            var context = new MailContext();
            return context.Mails
                    .Where(m => m.IsDraft && m.AppUserId == id)
                    .ToList();
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyReadId(int id)
        {
            var context = new MailContext();
            return context.Mails
                    .Where(m => m.IsRead && m.AppUserId == id)
                    .ToList();
        }

        public List<Mail> GetSendandReceiverMailnameListAllbySpamId(int id)
        {
            var context = new MailContext();
            return context.Mails
                    .Where(m => m.IsSpam && m.AppUserId == id)
                    .ToList();
        }

        public List<Mail> GetSendandReceiverMailnameListAllbyStarredId(int id)
        {
            var context = new MailContext();
            return context.Mails.Where(m => m.IsStarred && m.AppUserId == id).ToList();
        }
    }
}
