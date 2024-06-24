using MailBox.DtoLayer.Dtos.MailDtos;
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
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbyReceiverId(int id);
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbySenderId(int id);
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbyReadId(int id);
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbyStarredId(int id);
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbyDraftSenderId(int id);
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbyDeletedId(int id);
        public List<ListMailDto> TGetSendandReceiverMailnameListAllbySpamId(int id);
        ListMailDto TGetByIddto(int id);
        public ListMailDto TGetDraftMailbyId(int? id);
        public void TDraftDeletebyId(int id);

    }
}
