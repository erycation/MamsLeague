import { TeamDto } from "./team_dto";

export interface PlayerDto {
    id: string;
    teamId: string;
    firstname?: string | undefined;
    surname?: string | undefined;
    identityNumber?: string | undefined;
    cardNumber?: string | undefined;
    teamDto?: TeamDto | undefined;
}