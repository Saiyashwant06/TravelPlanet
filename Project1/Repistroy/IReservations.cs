using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Repistroy
{
    public interface IReservations
    {
       List<MyReservatonsMode> GetMyReservations();

        string Create(MyReservatonsMode res);

        string Edit(MyReservatonsMode res);

        string Delete(int Slno);


    }
}
