import { Component, ElementRef, HostListener, OnInit, ViewChild } from '@angular/core';
import {MatDialog, MatDialogRef} from '@angular/material/dialog';
import { ReserveService } from '../reserve.service';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Inject } from '@angular/core';

@HostListener('click',['onOk()'])
@Component({
  selector: 'app-delpop',
  templateUrl: './delpop.component.html',
  styleUrls: ['./delpop.component.css']
})
export class DelpopComponent implements OnInit {
  gets:any[]=[]
  @ViewChild('ref')eleRef!:ElementRef

  constructor(private dialog:MatDialog, private res:ReserveService, @Inject (MAT_DIALOG_DATA)  public data:any) { }

  ngOnInit(): void {
    console.log(this.data)

  }
  
  onNo(){
    
  }

  onOk(){
    this.res.delete(this.data.Slno).subscribe();
    this.eleRef.nativeElement.style.backgroundColor= 'red';
    window.location.reload();
  }
}