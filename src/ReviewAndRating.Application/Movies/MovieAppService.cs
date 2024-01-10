using Abp.Application.Services.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using ReviewAndRating.Models.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewAndRating.Movies.Dtos;
using Abp.Authorization;
using ReviewAndRating.Authorization;

namespace ReviewAndRating.Movies
{
    [AbpAuthorize(PermissionNames.Pages_Movies)]
    public class MovieAppService : ApplicationService, IMovieAppService
    {
        private readonly IRepository<Movie, Guid> _movieRepository;

        public MovieAppService(IRepository<Movie, Guid> movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public async Task CreateMovie(CreateMovieDto input)
        {
            var movie = new Movie
            {
                TenantId = input.TenantId,
                Title = input.Title,
                Description = input.Description,
                ReleaseYear = input.ReleaseYear,
                Rating = input.Rating,
                Genre = input.Genre,
                Country = input.Country,
                Language = input.Language
            };

            await _movieRepository.InsertAsync(movie);
        }

        public async Task UpdateMovie(UpdateMovieDto input)
        {
            var movie = await _movieRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, movie);
            await _movieRepository.UpdateAsync(movie);
        }

        public async Task DeleteMovie(EntityDto<Guid> input)
        {
            await _movieRepository.DeleteAsync(input.Id);
        }

        public async Task<MovieDto> GetMovie(EntityDto<Guid> input)
        {
            var movie = await _movieRepository.GetAsync(input.Id);

            return new MovieDto
            {
                Id = movie.Id,
                TenantId = movie.TenantId,
                Title = movie.Title,
                Description = movie.Description,
                ReleaseYear = movie.ReleaseYear,
                Rating = movie.Rating,
                Genre = movie.Genre,
                Country = movie.Country,
                Language = movie.Language
            };
        }
        public async Task<ListResultDto<MovieDto>> GetAllMovies()
        {
            var movies = await _movieRepository.GetAllListAsync();
            var movieDtos = ObjectMapper.Map<List<MovieDto>>(movies);

            return new ListResultDto<MovieDto>(movieDtos);
        }
    }
}
