using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OtherMessageManager : IOtherMessageService
    {
        IOtherMessageDal _otherMessageDal;

        public OtherMessageManager(IOtherMessageDal otherMessageDal)
        {
            _otherMessageDal = otherMessageDal;
        }

        public OtherMessage GetById(int id)
        {
            return _otherMessageDal.GetByID(id);
        }

        public List<OtherMessage> GetInboxListByWriter(int id)
        {
            return _otherMessageDal.GetListAll(x => x.ReceiverID == id);
        }
        public List<OtherMessage> GetSendBoxListByWriter(int id)
        {
            return _otherMessageDal.GetListAll(x => x.SenderID == id);
        }
        public List<OtherMessage> GetList()
        {
            return _otherMessageDal.GetListAll();
        }
        public void TAdd(OtherMessage t)
        {
            _otherMessageDal.Insert(t);
        }

        public void TDelete(OtherMessage t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(OtherMessage t)
        {
            throw new NotImplementedException();
        }
    }
}
