using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.EntityLayer.Concrete
{
    public class Mail
    {
        public int MailId { get; set; }
        public string MailSubject { get; set; }
        public string MailContent { get; set; }
        public DateTime MailDate { get; set; }
        public TimeSpan MailTime { get; set; }
        public bool IsRead { get; set; }
        public bool IsStarred { get; set; }
        public bool IsDraft { get; set; }
        public bool IsSent { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsSpam { get; set; }
    }
}
