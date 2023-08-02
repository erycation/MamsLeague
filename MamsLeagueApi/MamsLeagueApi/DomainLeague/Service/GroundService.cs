using AutoMapper;
using MamsLeagueApi.DomainLeague.Repository.Interface;
using MamsLeagueApi.DomainLeague.Service.Interface;
using MamsLeagueApi.Models;
using MamsLeagueApi.Models.Dtos;
using MamsLeagueApi.Shared.Helpers;

namespace MamsLeagueApi.DomainLeague.Service
{
    public class GroundService : IGroundService
    {
        private readonly IMapper _mapper;
        private readonly IGroundRepository _groundRepository;

        public GroundService(IMapper mapper,
                           IGroundRepository groundRepository)
        {
            _mapper = mapper;
            _groundRepository = groundRepository;
        }

        public async Task<GroundDto> AddGround(GroundDto groundDto)
        {
            var requestGround = new Ground
            {
                GroundName = groundDto.GroundName
            };
            var groundResponse = await _groundRepository.AddAsync(requestGround);
            if (groundResponse == null)
                throw new AppException($"Error Adding Ground.");
            return _mapper.Map<GroundDto>(groundResponse);
        }

        public async Task<List<GroundDto>> GetAllGrounds()
        {
            var groundResponse = await _groundRepository.GetAllAsync();
            return _mapper.Map<List<GroundDto>>(groundResponse.OrderByDescending(t => t.GroundName));
        }

        public async Task<GroundDto> GetGroundById(Guid groundId)
        {
            var groundResponse = await _groundRepository.GetByIdAsync(groundId);
            if (groundResponse == null)
                throw new AppException($"Ground Not Found");
            return _mapper.Map<GroundDto>(groundResponse);
        }
    }
}
        