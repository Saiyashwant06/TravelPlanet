import { HttpClient ,HttpHeaders} from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class ReserveService {

  httpoptions={
    headers:new HttpHeaders({
      'Content-Type':'application/json'
    })
  }

  constructor(private http:HttpClient) { }

 public getusers(){
     return this.http.get("https://localhost:44389/api/MyReservationsController/GetMyReservations");
  }
  public post(data:any){
    return this.http.post("https://localhost:44389/api/MyReservationsController/Create",data,this.httpoptions).subscribe();
    
  }
  public delete(Slno:number){
    return this.http.delete("https://localhost:44389/api/MyReservationsController/Delete/"+Slno);
  } 
  // public Edit(Slno:number){
  //   return this.http.post("https://localhost:44389/api/MyReservationsController/Edit"+Slno,this.httpoptions).subscribe();
  // }
  
}
