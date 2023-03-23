using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IGenericService<Reservation>
    {
        List<Reservation> GetListApprovalReservation(int id); //bunu managardan ve buradan silebiliriz
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByAccepted(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
        
    }
}
