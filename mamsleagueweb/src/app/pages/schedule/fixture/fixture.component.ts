import { Component } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs';
import { FixtureDto } from 'src/app/model/dtos/fixture_dto';
import { FixtureService } from 'src/app/service/fixture.service';

@Component({
  selector: 'app-fixture',
  templateUrl: './fixture.component.html',
  styleUrls: ['./fixture.component.css']
})
export class FixtureComponent {

  fixturesDto : FixtureDto[] | undefined;

  constructor(public dialog: MatDialog,
    router: Router,
    private route: ActivatedRoute,
              private fixtureService: FixtureService) {
    }

    ngOnInit() {      
      this.fixtureService.getFixturesByScheduleId(this.route.snapshot.params['scheduleId'])
          .pipe(first())
          .subscribe(fixturesDto => this.fixturesDto = fixturesDto);      
  }

  
}
