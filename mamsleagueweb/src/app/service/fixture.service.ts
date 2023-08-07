import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { environment } from 'src/environment/environment';
import { SchedulePlayDto } from '../model/dtos/schedule_play_dto';
import { FixtureDto } from '../model/dtos/fixture_dto';

const baseUrl = `${environment.apiUrl}/Fixture`;

@Injectable({
  providedIn: 'root'
})
export class FixtureService {
  constructor(private http: HttpClient) { }

    getFixturesByScheduleId(scheduleId : string) {
        return this.http.get<FixtureDto[]>(`${baseUrl}/Schedule/${scheduleId}`);
    }

    getById(id: string) {
        return this.http.get<SchedulePlayDto>(`${baseUrl}/${id}`);
    }

    create(params: any) {
        return this.http.post(`${baseUrl}/Add`, params);
    }

    update(id: string, params: any) {
        return this.http.put(`${baseUrl}/${id}`, params);
    }

    delete(id: string) {
        return this.http.delete(`${baseUrl}/${id}`);
    }
}


