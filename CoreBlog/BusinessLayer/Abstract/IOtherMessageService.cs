using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOtherMessageService: IGenericService<OtherMessage>
    {
        List<OtherMessage> GetInboxListByWriter(int p);

        List<OtherMessage> GetSendBoxListByWriter(int p);
    }
}
