using AutoMapper;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models;
using MamsLeagueApi.Models.Dtos;
using MamsLeagueApi.Shared.Helpers;

namespace MamsLeagueApi.DomainLeague.Service
{
    public class PlayTimeService : IPlayTimeService
    {
        private readonly IMapper _mapper;
        private readonly IPlayTimeRepository _playTimeRepository;

        public PlayTimeService(IMapper mapper,
                           IPlayTimeRepository playTimeRepository)
        {
            _mapper = mapper;
            _playTimeRepository = playTimeRepository;
        }

        public async Task<PlayTimeDto> AddPlayTime(PlayTimeDto playTimeDto)
        {
            var requestPlayTime = new PlayTime
            {
                Time = playTimeDto.Time
            };
            var playTimeResponse = await _playTimeRepository.AddAsync(requestPlayTime);
            if (playTimeResponse == null)
                throw new AppException($"Error Adding Time.");
            return _mapper.Map<PlayTimeDto>(playTimeResponse);
        }

        public async Task<List<PlayTimeDto>> GetAllPlayTimes()
        {
            var playTimeResponse = await _playTimeRepository.GetAllAsync();
            return _mapper.Map<List<PlayTimeDto>>(playTimeResponse.OrderByDescending(t => t.Time));
        }

        public async Task<PlayTimeDto> GetPlayTimeById(Guid playTimeId)
        {
            var playTimeResponse = await _playTimeRepository.GetByIdAsync(playTimeId);
            if (playTimeResponse == null)
                throw new AppException($"Time Not Found");
            return _mapper.Map<PlayTimeDto>(playTimeResponse);
        }
    }
}