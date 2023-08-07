using AutoMapper;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models;
using MamsLeagueApi.Models.Dtos;
using MamsLeagueApi.Shared.Helpers;

namespace MamsLeagueApi.DomainLeague.Service
{
    public class FixtureService : IFixtureService
    {
        private readonly IMapper _mapper;
        private readonly IFixtureRepository _fixtureRepository;

        public FixtureService(IMapper mapper,
                           IFixtureRepository fixtureRepository)
        {
            _mapper = mapper;
            _fixtureRepository = fixtureRepository;
        }

        public async Task<FixtureDto> AddFixture(FixtureDto fixtureDto)
        {
            var requestFixture = new Fixture
            {
                SchedulePlayId = fixtureDto.SchedulePlayId,
                GroundId = fixtureDto.GroundId,
                PlayTimeId = fixtureDto.PlayTimeId,
                AwayTeamId = fixtureDto.AwayTeamId,
                HomeTeamId = fixtureDto.HomeTeamId,
                AwayTeamScore = null,
                HomeTeamScore = null
            };
            var fixtureResponse = await _fixtureRepository.AddAsync(requestFixture);
            if (fixtureResponse == null)
                throw new AppException($"Error Adding Ficture.");
            return _mapper.Map<FixtureDto>(fixtureResponse);
        }

        public async Task<List<FixtureDto>> GetFixturesByScheduleId(Guid scheduleId)
        {
            var fixtureResponse = await _fixtureRepository.GetFixturesByScheduleId(scheduleId);
            return _mapper.Map<List<FixtureDto>>(fixtureResponse);
        }

        public async Task<List<FixtureDto>> GetResultsByScheduleId(Guid scheduleId)
        {
            var fixtureResponse = await _fixtureRepository.GetResultsByScheduleId(scheduleId);
            return _mapper.Map<List<FixtureDto>>(fixtureResponse);
        }

        public async Task<FixtureDto> AddResults(FixtureDto fixtureDto)
        {
            if (fixtureDto.AwayTeamScore == null)
                throw new AppException($"AwayTeam Score Required.");
            if (fixtureDto.AwayTeamScore == null)
                throw new AppException($"HomeTeam Score Required.");
            var fixtureResponse = await _fixtureRepository.GetByIdAsync(fixtureDto.Id);
            if (fixtureResponse == null)
                throw new AppException($"Match Not Found.");

            fixtureResponse.AwayTeamScore = fixtureDto.AwayTeamScore;
            fixtureResponse.HomeTeamScore = fixtureDto.HomeTeamScore;

            var responseUpdateFixture = await _fixtureRepository.UpdateAsync(fixtureResponse);
            if (responseUpdateFixture == null)
                throw new AppException($"Error Adding Results.");
            return _mapper.Map<FixtureDto>(responseUpdateFixture);
        }


        //public async Task<FixtureDto> GetFixtureById(Guid fixtureId)
        //{
        //    var fixtureResponse = await _fixtureRepository.GetByIdAsync(fixtureId);
        //    return _mapper.Map<FixtureDto>(fixtureResponse);
        //}

        //public async Task<SchedulePlayDto> AddSchedulePlay(SchedulePlayDto schedulePlayDto)
        //{
        //    var requestSchedulePlay = new SchedulePlay
        //    {
        //        ScheduleDate = schedulePlayDto.ScheduleDate
        //    };
        //    var requestScheduleResponse = await _schedulePlayRepository.AddAsync(requestSchedulePlay);
        //    if (requestScheduleResponse == null)
        //        throw new AppException($"Error Adding SchedulePlay.");
        //    return _mapper.Map<SchedulePlayDto>(requestScheduleResponse);
        //}

        //public async Task<List<SchedulePlayDto>> GetAllSchedulePlays()
        //{
        //    var requestScheduleResponse = await _schedulePlayRepository.GetAllAsync();
        //    return _mapper.Map<List<SchedulePlayDto>>(requestScheduleResponse.OrderByDescending(t => t.ScheduleDate));
        //}

        //public async Task<SchedulePlayDto> GetSchedulePlayId(Guid schedulePlayId)
        //{
        //    var requestScheduleResponse = await _schedulePlayRepository.GetByIdAsync(schedulePlayId);
        //    if (requestScheduleResponse == null)
        //        throw new AppException($"SchedulePlay Not Found");
        //    return _mapper.Map<SchedulePlayDto>(requestScheduleResponse);
        //}
    }
}
