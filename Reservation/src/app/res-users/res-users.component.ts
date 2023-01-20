import { Component, ElementRef, HostBinding, HostListener, Input, OnInit, ViewChild } from '@angular/core';
import { ReserveService } from '../reserve.service';
import { Router } from '@angular/router';
import { MatDialogRef,MAT_DIALOG_DATA,MatDialog } from '@angular/material/dialog';
import { DialogComponent } from '../dialog/dialog.component';
import { DelpopComponent } from '../delpop/delpop.component';
import {MatTableDataSource} from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort  } from '@angular/material/sort';




@Component({
  selector: 'app-res-users',
  templateUrl: './res-users.component.html',
  styleUrls: ['./res-users.component.css']
})



export class ResUsersComponent implements OnInit {
  @ViewChild(MatPaginator) paginator !: MatPaginator;
  @ViewChild(MatSort)sort!: MatSort;
  @HostListener('Click',(['onAdd()']))
  @ViewChild('Aks')eleref!:ElementRef;
  @HostBinding()
    users:any;
  close=true;
  matdata =  new MatTableDataSource();
  displayedColumns=['Slno','Hostel','Arrival','Departure','Type','Guests','Price','Manage'];

  constructor(private resser:ReserveService,private route:Router,private dia:MatDialog ) { }


  ngOnInit(): void {
    this.resser.getusers().subscribe((s:any)=>{console.log(s)
      this.matdata= new MatTableDataSource(s);
      this.matdata.paginator=this.paginator;
      this.matdata.sort =this.sort;


      this.eleref.nativeElement.style.backgroundColor='red';
          })

   
   
     this.resser.getusers().subscribe(re =>{
      this.users=re;
      console.log(re);
     });
     }

  applyFilter(ab : any){
    let flitervalue=(ab.target as HTMLInputElement).value;
    this.matdata.filter=flitervalue.trim().toLowerCase();
    if(this.matdata.paginator){
      this.matdata.paginator.firstPage();
    }
    

  }

  onAdd(){
    this.dia.open(DialogComponent,{

      width :'500px',
      height:'600px'     
    });
  }
  Ondelete(value:any){
    this.dia.open(DelpopComponent,{
      width:'250px',
      data:value
    })
  }

  onEdit(value:any){
    this.dia.open(DialogComponent,{
      width :'50%',
      height:'100%',
      data:value,
    });
  }

  logout(){
    this.route.navigate(['']);
  }
}


