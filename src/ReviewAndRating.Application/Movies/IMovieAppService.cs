using Abp.Application.Services.Dto;
using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewAndRating.Movies.Dtos;

namespace ReviewAndRating.Movies
{
    public interface IMovieAppService : IApplicationService
    {
        Task CreateMovie(CreateMovieDto input);
        Task UpdateMovie(UpdateMovieDto input);
        Task DeleteMovie(EntityDto<Guid> input);
        Task<MovieDto> GetMovie(EntityDto<Guid> input);
        Task<ListResultDto<MovieDto>> GetAllMovies();
    }
}
