import { PlayerDto } from "./player_dto";

export interface TeamDto {
    id: string;
    teamName?: string | undefined;
    playersDto?: PlayerDto[] | undefined;
}
