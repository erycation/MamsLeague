import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TeamComponent } from './pages/team/team.component';
import { ScheduleComponent } from './pages/schedule/schedule.component';

const routes: Routes = [
  { path: 'login', component: TeamComponent },
  { path: 'schedule', component: ScheduleComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
