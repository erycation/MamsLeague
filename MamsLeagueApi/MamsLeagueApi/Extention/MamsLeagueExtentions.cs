using AutoMapper;
using MamsLeagueApi.DomainLeague.Persistance;
using MamsLeagueApi.DomainLeague.Repository;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.DomainLeague.Service;
using MamsLeagueApi.DomainLeague.Service.Interface;
using Microsoft.EntityFrameworkCore;

namespace MamsLeagueApi.Extention
{
    public static class MamsLeagueExtentions
    {
        public static void ConfigureDomainLeagueExtention(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MamsLeagueDBContext>(options =>
            options.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ITeamRepository, TeamRepository>();
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ISchedulePlayRepository, SchedulePlayRepository>();
            services.AddScoped<ISchedulePlayService, SchedulePlayService>();
            services.AddScoped<IPlayTimeRepository, PlayTimeRepository>();
            services.AddScoped<IPlayTimeService, PlayTimeService>();
            services.AddScoped<IGroundRepository, GroundRepository>();
            services.AddScoped<IGroundService, GroundService>();
            

             //services.AddScoped<IEndPointPoInboxService, EndPointPoInboxService>();
             //services.AddScoped<IMobileDashboardService, MobileDashboardService>();
             //services.AddScoped<ICoAccusedDetailsService, CoAccusedDetailsService>();
             //services.AddScoped<IOffenceDetailService, OffenceDetailService>();
             //services.AddScoped<IVictimOrganisationDetailService, VictimOrganisationDetailService>();
             //services.AddScoped<IVictimDetailService, VictimDetailService>();
             //services.AddScoped<IMedicalHealthDetailsService, MedicalHealthDetailsService>();
             //services.AddScoped<IRecommendationService, RecommendationService>();
             //services.AddScoped<IFamilyInformationService, FamilyInformationService>();
             //services.AddScoped<IDevelopmentAssessmentService, DevelopmentAssessmentService>();
             //services.AddScoped<IFamilyMemberService, FamilyMemberService>();
             //services.AddScoped<IAssessmentCountService, AssessmentCountService>();
             //services.AddScoped<IGeneralDetailService, GeneralDetailService>();
             //services.AddScoped<IGeneralDetailService, GeneralDetailService>();
             //services.AddScoped<ISocioEnomicService, SocioEconomicService>();
             //services.AddScoped<IDiversionService, DiversionService>();
             //services.AddScoped<IProgrammeModuleService, ProgrammeModuleService>();
             //services.AddScoped<IPreliminaryDetailsService, PreliminaryDetailsService>();
             //services.AddScoped<IPretrialDetailService, PretrialDetailService>();
             //services.AddScoped<IConversionRecommandationService, ConversionRecommandationService>();
             //services.AddScoped<IComplianceService, ComplianceService>();
             //services.AddScoped<IConditionsService, ConditionsService>();
             //services.AddScoped<IProgramEnrolmentSessionOutcomeService, ProgramEnrolmentSessionOutcomeService>();
             //services.AddScoped<IProgrammeLevelsService, ProgrammeLevelsService>();
             //services.AddScoped<IProgrammesService, ProgrammesService>();
             //services.AddScoped<IProgramsEnrolledService, ProgramsEnrolledService>();
             //services.AddScoped<IVisitationOutcomeService, VisitationOutcomeService>();
             //services.AddScoped<IHomeBasedSupervisionService, HomeBasedSupervisionService>();
             //services.AddScoped<IAssessmentRegisterService, AssessmentRegisterService>();
             //services.AddScoped<IPersonService, PersonService>();
             //
             var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappersExtentions());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}

