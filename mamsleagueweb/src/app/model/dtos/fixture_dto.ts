import { GroundDto } from "./ground_dto";
import { PlayTimeDto } from "./play_time_dto";
import { SchedulePlayDto } from "./schedule_play_dto";
import { TeamDto } from "./team_dto";

export interface FixtureDto {
    id: string;
    schedulePlayId: string;
    groundId: string;
    playTimeId: string;
    awayTeamId: string;
    awayTeamScore?: number | undefined;
    homeTeamId: string;
    homeTeamScore?: number | undefined;
    awayTeamDto?: TeamDto | undefined;
    groundDto?: GroundDto | undefined;
    homeTeamDto?: TeamDto | undefined;
    playTimeDto?: PlayTimeDto | undefined;
    schedulePlayDto?: SchedulePlayDto | undefined;
}
