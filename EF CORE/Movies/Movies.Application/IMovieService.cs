using Movies.Application.DTOs.Requests;
using Movies.Application.DTOs.Responses;

namespace Movies.Application
{
    public interface IMovieService
    {
        Task<int> CreateNewMovie(CreateNewMovieRequest createNewMovie);
        Task UpdateMovie(UpdateMovieRequest updateMovie);
        Task<IEnumerable<MovieListResponse>> GetAllMovies();
        Task RemovePlayerFromMovieAsync(int movieId, int playerId);

        void RemovePlayerFromMovie(int movieId, int playerId);

        Task AddPlayerToMovie(int movieId, List<int> players);

    }
}
