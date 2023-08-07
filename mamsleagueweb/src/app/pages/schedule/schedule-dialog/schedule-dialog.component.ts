import { Component } from '@angular/core';
import { MatDialogRef } from '@angular/material/dialog';
import { first } from 'rxjs';
import { SchedulePlayDto } from 'src/app/model/dtos/schedule_play_dto';
import { AlertService } from 'src/app/service/alert.service';
import { ScheduleService } from 'src/app/service/schedule.service';

@Component({
  selector: 'app-schedule-dialog',
  templateUrl: './schedule-dialog.component.html',
  styleUrls: ['./schedule-dialog.component.css']
})
export class ScheduleDialogComponent {
  schedulePlayDto = {} as SchedulePlayDto;
  //password = '';

  constructor(public dialogRef: MatDialogRef<ScheduleDialogComponent>,
              private scheduleService: ScheduleService,
              private alertService: AlertService) {}

  onNoClick(): void {
    this.dialogRef.close();
  }

  saveSchedulePlay() : void
  {

    this.scheduleService.create(this.schedulePlayDto)
    .subscribe({
      next: (data)=>console.log('data',data),
    error: (error)=> this.alertService.error(error.error.message, { keepAfterRouteChange: false }),
      complete:()=>console.log('complete')
    });
    
    /*this.scheduleService.create(this.schedulePlayDto)
            .pipe(first())
            .subscribe(() => {
               // this.alertService.success('Schedule Sucessfully Created', { keepAfterRouteChange: false });
                //this.router.navigate(['../'], { relativeTo: this.route });
            });*/
            //.add(() => this.loading = false)
  }
}