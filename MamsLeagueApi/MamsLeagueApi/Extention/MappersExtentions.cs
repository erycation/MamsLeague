using AutoMapper;
using MamsLeagueApi.Models;
using MamsLeagueApi.Models.Dtos;

namespace MamsLeagueApi.Extention
{
    public class MappersExtentions : Profile
    {
        public MappersExtentions()
        {
            CreateMap<Player, PlayerDto>();
            CreateMap<Team, TeamDto>();
                 //.ForMember(s => s.PlayersDto, r => r.MapFrom(ur => ur.Players));
            CreateMap<SchedulePlay, SchedulePlayDto>();
            CreateMap<PlayTime, PlayTimeDto>();
            CreateMap<Ground, GroundDto>();
            //CreateMap<Fixture, FixtureDto>();

            CreateMap<Fixture, FixtureDto>()
               .ForMember(s => s.AwayTeamDto, r => r.MapFrom(ur => ur.AwayTeam))
               .ForMember(s => s.GroundDto, r => r.MapFrom(ur => ur.Ground))
               .ForMember(s => s.HomeTeamDto, r => r.MapFrom(ur => ur.HomeTeam))
               .ForMember(s => s.PlayTimeDto, r => r.MapFrom(ur => ur.PlayTime))
               .ForMember(s => s.SchedulePlayDto, r => r.MapFrom(ur => ur.SchedulePlay));


            //CreateMap<Person, PersonDto>();
            //CreateMap<RelationshipType, RelationshipTypeDto>();
            //CreateMap<EndPointPoInbox, EndPointPoInboxDto>();
            //CreateMap<AllocatedCaseProbationOfficer, AllocatedCaseProbationOfficerDto>();
            //CreateMap<AllocatedCaseSupervisor, AllocatedCaseSupervisorDto>();
            //CreateMap<Worklist, WorklistDto>();
            //CreateMap<ResponseMessage, ResponseMessageDto>();
            //CreateMap<AcceptedWorklist, AcceptedWorklistDto>();
            //CreateMap<MobileDashboard, MobileDashboardDto>();
            //CreateMap<CoAccusedDetails, CoAccusedDetailsDto>();
            //CreateMap<CoAccusedDetailsQuery, CoAccusedDetailsQueryDto>();
            //CreateMap<OffenceType, OffenceTypeDto>();
            //CreateMap<OffenceCategory, OffenceCategoryDto>();
            //CreateMap<OffenceSchedule, OffenceScheduleDto>();
            //CreateMap<OffenceDetail, OffenceDetailDto>()
            //   .ForMember(s => s.OffenceTypeDto, r => r.MapFrom(ur => ur.OffenceType))
            //   .ForMember(s => s.OffenceCategoryDto, r => r.MapFrom(ur => ur.OffenceCategory))
            //   .ForMember(s => s.OffenceScheduleDto, r => r.MapFrom(ur => ur.OffenceSchedule));

            //CreateMap<VictimOrganisationDetail, VictimOrganisationDetailDto>();
            //CreateMap<HealthStatus, HealthStatusDto>();
            //CreateMap<MedicalHealthDetail, MedicalHealthDetailDto>()
            //    .ForMember(s => s.HealthStatusDto, r => r.MapFrom(ur => ur.HealthStatus));
            //CreateMap<FamilyInformation, FamilyInformationDto>();
            //CreateMap<RecommendationType, RecommendationTypeDto>();
            //CreateMap<PlacementType, PlacementTypeDto>();
            //CreateMap<Recommendation, RecommendationDto>()
            //        .ForMember(s => s.RecommendationTypeDto, r => r.MapFrom(ur => ur.RecommendationType))
            //        .ForMember(s => s.PlacementTypeDto, r => r.MapFrom(ur => ur.PlacementType));
            //CreateMap<FamilyMember, FamilyMemberDto>()
            //    .ForMember(s => s.RelationshipTypeDto, r => r.MapFrom(ur => ur.RelationshipType))
            //    .ForMember(s => s.PersonDto, r => r.MapFrom(ur => ur.Person));
            //CreateMap<DevelopmentAssessment, DevelopmentAssessmentDto>();
            //CreateMap<AssessmentCountQuery, AssessmentCountQueryDto>();
            //CreateMap<GeneralDetail, GeneralDetailDto>();
            //CreateMap<SocioEconomic, SocioEconomicDto>();
            //CreateMap<FormOfNotification, FormOfNotificationDto>();
            //CreateMap<AssesmentRegister, AssesmentRegisterDto>()
            //     .ForMember(s => s.FormOfNotificationDto, r => r.MapFrom(ur => ur.FormOfNotification));

            //CreateMap<Diversion, DiversionDto>();
            //CreateMap<ProgrammeModule, ProgrammeModuleDto>();
            //CreateMap<PretrialDetail, PretrialDetailDto>();
            //CreateMap<PreliminaryDetail, PreliminaryDetailDto>()
            //   .ForMember(s => s.RecommendationTypeDto, r => r.MapFrom(ur => ur.RecommendationType))
            //   .ForMember(s => s.PlacementTypeDto, r => r.MapFrom(ur => ur.PlacementType));
            //CreateMap<ConversionRecommendation, ConversionRecommendationDto>();
            //CreateMap<VisitationOutcome, VisitationOutcomeDto>()
            //    .ForMember(k => k.ComplianceDto, p => p.MapFrom(er => er.Compliance));
            //CreateMap<HBSupervision, HBSupervisionDto>();
            //CreateMap<HBSupervisionQuery, HBSupervisionQueryDto>();
            //CreateMap<Conditions, ConditionsDto>();
            //CreateMap<Compliance, ComplianceDto>();
            //CreateMap<ProgramsEnrolled, ProgramsEnrolledDto>()
            //    .ForMember(s => s.ProvinceDto, r => r.MapFrom(ur => ur.Province))
            //    .ForMember(a => a.DistrictDto, b => b.MapFrom(ua => ua.District))
            //    .ForMember(s => s.OrganizationDto, r => r.MapFrom(ur => ur.Organization))
            //    .ForMember(c => c.LocalMunicipalityDto, d => d.MapFrom(ud => ud.LocalMunicipality))
            //    //.ForMember(f => f.UserDto, n => n.MapFrom(un => un.User))
            //    .ForMember(z => z.DiversionDto, x => x.MapFrom(ux => ux.Diversion))
            //    .ForMember(e => e.ProgrammesDto, f => f.MapFrom(uf => uf.Programme));
            //CreateMap<Province, ProvinceDto>();
            //CreateMap<District, DistrictDto>();
            //CreateMap<Organization, OrganizationDto>();
            //CreateMap<LocalMunicipality, LocalMunicipalityDto>();
            //CreateMap<User, UserDto>();
            //CreateMap<Programmes, ProgrammesDto>();
            //CreateMap<ProgramEnrolmentSessionOutcome, ProgramEnrolmentSessionOutcomeDto>();
            //CreateMap<Diversion, DiversionDto>();
            //CreateMap<ProgrammeLevels, ProgrammeLevelsDto>();
            //CreateMap<ProgrammeAgeGroup, ProgrammeAgeGroupDto>();

        }
    }
}

