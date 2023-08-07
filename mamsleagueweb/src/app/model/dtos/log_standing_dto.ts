export interface LogStandingDto {
    teamName?: string | undefined;
    numberGamePlayed: number;
    won: number;
    draw: number;
    loose: number;
    goalForward: number;
    goalAgainst: number;
    goalDiffer: number;
    points: number;
}