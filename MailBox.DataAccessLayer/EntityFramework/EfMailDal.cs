using MailBox.DataAccessLayer.Abstract;
using MailBox.DataAccessLayer.Repositories;
using MailBox.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.DataAccessLayer.EntityFramework
{
    public class EfMailDal : GenericRepository<Mail> , IMailDal
    {
    }
}
