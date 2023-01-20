using Project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Project1.Repistroy
{
    public class ReservationsClass : IReservations
    {
        SamplesEntities1 reser = new SamplesEntities1();


        List<MyReservatonsMode> IReservations.GetMyReservations()
        {
            var rec = reser.MyReservations.Select(r => new MyReservatonsMode()
            {
                Slno = r.Slno,
                Hostel = r.Hostel,
                Arrival = r.Arrival,
                Departure = r.Departure,
                Type = r.Type,
                Guests = r.Guests,
                Price = r.Price
            }).ToList<MyReservatonsMode>();
            reser.Dispose();
            return rec;
        }

        string IReservations.Create(MyReservatonsMode res)
        {
            var rec = reser.MyReservations.Where(r => r.Slno == res.Slno).FirstOrDefault();
            if (rec == null)
            {
                reser.MyReservations.Add(new MyReservation()
                {
                    Slno = res.Slno,
                    Hostel = res.Hostel,
                    Arrival = res.Arrival,
                    Departure = res.Departure,
                    Type = res.Type,
                    Guests = res.Guests,
                    Price = res.Price
                });
                 reser.SaveChanges();
                reser.Dispose();
                return "User added";
            }
            else
            {
                rec.Slno = res.Slno;
                rec.Hostel = res.Hostel;
                rec.Arrival = res.Arrival;
                rec.Departure = res.Departure;
                rec.Type = res.Type;
                rec.Guests = res.Guests;
                rec.Price = res.Price;


                reser.SaveChanges();
                reser.Dispose();
                return "User Updated";

            }
           
        }
        string IReservations.Edit(MyReservatonsMode res)
        {
            var reclist = reser.MyReservations.Find(res.Slno);
            if (reclist != null) 
            {

                reclist.Slno = res.Slno;
                reclist.Hostel = res.Hostel;
                reclist.Arrival = res.Arrival;
                reclist.Departure = res.Departure;
                reclist.Type = res.Type;
                reclist.Guests = res.Guests;
                reclist.Price = res.Price;


                reser.SaveChanges();
                reser.Dispose();
                return "User Updated";
            }
            
            
            return "not Updated";
        }
        
    
            

        string IReservations.Delete(int Slno)
        {
            var reclist = reser.MyReservations.Where(r => r.Slno == Slno).FirstOrDefault();
            if (reclist != null)
            {
                reser.MyReservations.Remove(reclist);
            };
            reser.SaveChanges();
            reser.Dispose();
            return "Deleted";

        }
       
    }
}