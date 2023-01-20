import { Component, OnInit,Inject } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { FormControl, Validators } from '@angular/forms';
import {FormGroup } from '@angular/forms';
import { FormBuilder } from '@angular/forms';
import { ReserveService } from '../reserve.service';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';



@Component({
  selector: 'app-dialog',
  templateUrl: './dialog.component.html',
  styleUrls: ['./dialog.component.css']
})
export class DialogComponent implements OnInit {
  // registerform!:FormGroup;
  enable:any;
  unebale:any;
  gennumb:any;
  constructor(private dia:MatDialog,private fb:FormBuilder,private res:ReserveService, @Inject (MAT_DIALOG_DATA) public data:any) { }
  

  ngOnInit():void {
    //  this.registerform=this.fb.group({
      // Slno:[' ',[Validators.required]],
      // Hotel:[' ',Validators.required],
      // Arrival:[' ',Validators.required],
      // Departure:[' ',Validators.required],
      // Type:[' ',Validators.required],
      // Guests:[' ',Validators.required],
      // Price:[' ',Validators.required]
     
    //  })


    if(this.data == null)
   {
   this.enable="Save";
   this.unebale="Cancel";
   }else{
    this.enable="Update"; 
    this.unebale="Reset";
   }
  

    if(this.data){
      let Adate=this.data.Arrival.split('T')
      let Ddate= this.data.Departure.split('T')


      this.registerform.patchValue({
        Slno:this.data.Slno,
        Hostel:this.data.Hostel,
        Arrival:Adate[0],
        Departure:Ddate[0],
        Type:this.data.Type,
        Guests:this.data.Guests,
        Price:this.data.Price
      })
    }
  }
  registerform=new FormGroup({
    Slno:new FormControl(' '),
    Hostel :new FormControl(' '),
    Arrival:new FormControl(' '),
    Departure:new FormControl(' '),
    Type:new FormControl(' '),
    Guests:new FormControl(' '),
    Price:new FormControl(' '),

  })
  onSave(){
        let ser=JSON.stringify(this.registerform.value);
        console.log(ser);
    this.res.post(ser);
     window.location.reload();  
  }
  
Reset(){
  if(this.data){
    let Adate=this.data.Arrival.split('T')
    let Ddate= this.data.Departure.split('T')


    this.registerform.patchValue({
      Slno:this.data.Slno,
      Hostel:this.data.Hostel,
      Arrival:Adate[0],
      Departure:Ddate[0],
      Type:this.data.Type,
      Guests:this.data.Guests,
      Price:this.data.Price
    })
}
}

  




}
