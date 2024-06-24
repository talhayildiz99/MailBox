using AutoMapper;
using MailBox.BusinessLayer.Abstract;
using MailBox.DataAccessLayer.Abstract;
using MailBox.DataAccessLayer.EntityFramework;
using MailBox.DtoLayer.Dtos.MailDtos;
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
        private readonly IMapper _mapper;

        public MailManager(IMailDal mailDal, IMapper mapper)
        {
            _mailDal = mailDal;
            _mapper = mapper;
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
        public void TDraftDeletebyId(int id)
        {
            _mailDal.DraftDeletebyId(id);
        }

        public ListMailDto TGetDraftMailbyId(int? id)
        {
            var mail = _mailDal.GetDraftMailbyId(id);
            return _mapper.Map<ListMailDto>(mail);
        }

        public ListMailDto TGetByIddto(int id)
        {
            var mail = _mailDal.GetByIdMailId(id);
            return _mapper.Map<ListMailDto>(mail);
        }

        public List<ListMailDto> TGetSendandReceiverMailnameListAllbyReceiverId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbyReceiverId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }

        public List<ListMailDto> TGetSendandReceiverMailnameListAllbySenderId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbySenderId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }

       
        List<ListMailDto> IMailService.TGetSendandReceiverMailnameListAllbyDeletedId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbyDeletedId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }

        List<ListMailDto> IMailService.TGetSendandReceiverMailnameListAllbyDraftSenderId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbyDraftSenderId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }

        List<ListMailDto> IMailService.TGetSendandReceiverMailnameListAllbyReadId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbyReadId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }

        List<ListMailDto> IMailService.TGetSendandReceiverMailnameListAllbySpamId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbySpamId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }

        List<ListMailDto> IMailService.TGetSendandReceiverMailnameListAllbyStarredId(int id)
        {
            var mail = _mailDal.GetSendandReceiverMailnameListAllbyStarredId(id);
            return _mapper.Map<List<ListMailDto>>(mail);
        }
    }
}
