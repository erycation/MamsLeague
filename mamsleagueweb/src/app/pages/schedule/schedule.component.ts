import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { ScheduleDialogComponent } from './schedule-dialog/schedule-dialog.component';
import { SchedulePlayDto } from 'src/app/model/dtos/schedule_play_dto';
import { ScheduleService } from 'src/app/service/schedule.service';
import { first } from 'rxjs';
import { Router } from '@angular/router';

@Component({
  selector: 'app-schedule',
  templateUrl: './schedule.component.html',
  styleUrls: ['./schedule.component.css']
})
export class ScheduleComponent implements OnInit {
  schedulePlayDto = {} as SchedulePlayDto;
  schedulePlaysDto : SchedulePlayDto[] | undefined;

 // secret to validate the password
 ///secret = 'YESRUNFUNCTION';


 constructor(public dialog: MatDialog,
             private router: Router,
             private scheduleService: ScheduleService) {
           
             }

 ngOnInit() {
     this.scheduleService.getAll()
         .pipe(first())
         .subscribe(schedulePlaysDto => this.schedulePlaysDto = schedulePlaysDto);      
 }

 
 goToFixtureUrl(id : string) {
  this.router.navigate(['/fixture', id]);
}

 addSchedulePlay(): void {
  console.log('test' + this.schedulePlaysDto);
  const dialogRef = this.dialog.open(ScheduleDialogComponent, {
    width: '600px',
  });

  dialogRef.afterClosed().subscribe(schedulePlayDto => {

    console.log('Response Malekutu' + this.schedulePlayDto);
    
    /*const isPwdValid = password === this.secret;
    console.log('test eric after close' + isPwdValid);
    if (isPwdValid) {
      // run code for correct password 
    } else {
      // run code for wrong password
    }*/
  });
}


 /*
 generate(): void {
  const dialogRef = this.dialog.open(ScheduleDialogComponent, {
    width: '600px',
  });

  dialogRef.afterClosed().subscribe(password => {
    const isPwdValid = password === this.secret;
    console.log('test eric after close' + isPwdValid);
    if (isPwdValid) {
      // run code for correct password 
    } else {
      // run code for wrong password
    }
  });
}
*/
}