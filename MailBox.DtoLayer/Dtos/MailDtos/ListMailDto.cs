using MailBox.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailBox.DtoLayer.Dtos.MailDtos
{
    public class ListMailDto
    {
        public int MailId { get; set; }
        public int SenderId { get; set; } // Gönderici AppUser'ın Id'sini temsil eder
        public int ReceiverId { get; set; } // Alıcı AppUser'ın Id'sini temsil eder
        public string ReceiverEmail { get; set; } // Alıcı AppUser'ın Id'sini temsil eder
        public string SenderEmail { get; set; } // Alıcı AppUser'ın Id'sini temsil eder
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
        public AppUser Sender { get; set; } // Gönderici AppUser nesnesi
        public AppUser Receiver { get; set; } // Alıcı AppUser nesnesi
    }
}
