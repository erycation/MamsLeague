using AutoMapper;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models;
using MamsLeagueApi.Models.Dtos;
using MamsLeagueApi.Shared.Helpers;

namespace MamsLeagueApi.DomainLeague.Service
{
    public class SchedulePlayService : ISchedulePlayService
    {
        private readonly IMapper _mapper;
        private readonly ISchedulePlayRepository _schedulePlayRepository;

        public SchedulePlayService(IMapper mapper,
                           ISchedulePlayRepository schedulePlayRepository)
        {
            _mapper = mapper;
            _schedulePlayRepository = schedulePlayRepository;
        }

        public async Task<SchedulePlayDto> AddSchedulePlay(SchedulePlayDto schedulePlayDto)
        {
            var requestSchedulePlay = new SchedulePlay
            {
                ScheduleDate = schedulePlayDto.ScheduleDate
            };
            var requestScheduleResponse = await _schedulePlayRepository.AddAsync(requestSchedulePlay);
            if (requestScheduleResponse == null)
                throw new AppException($"Error Adding SchedulePlay.");
            return _mapper.Map<SchedulePlayDto>(requestScheduleResponse);
        }

        public async Task<List<SchedulePlayDto>> GetAllSchedulePlays()
        {
            var requestScheduleResponse = await _schedulePlayRepository.GetAllAsync();
            return _mapper.Map<List<SchedulePlayDto>>(requestScheduleResponse.OrderByDescending(t => t.ScheduleDate));
        }

        public async Task<SchedulePlayDto> GetSchedulePlayId(Guid schedulePlayId)
        {
            var requestScheduleResponse = await _schedulePlayRepository.GetByIdAsync(schedulePlayId);
            if (requestScheduleResponse == null)
                throw new AppException($"SchedulePlay Not Found");
            return _mapper.Map<SchedulePlayDto>(requestScheduleResponse);
        }
    }
}
