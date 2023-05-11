using Microsoft.EntityFrameworkCore;
using Movies.Data.Data;
using Movies.Entities;

namespace Movies.Data.Repositories
{
    public class EFMovieRepository : IMovieRepository
    {
        private readonly MoviesDbContext moviesDbContext;

        public EFMovieRepository(MoviesDbContext moviesDbContext)
        {
            this.moviesDbContext = moviesDbContext;
        }

        public void Create(Movie entity)
        {
            throw new NotImplementedException();
        }

        public async Task CreateAsync(Movie entity)
        {

            await moviesDbContext.Movies.AddAsync(entity);
            await moviesDbContext.SaveChangesAsync();//Persistence API
        }

        public async Task DeleteAsync(int id)
        {
            var product = await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);

            moviesDbContext.Movies.Remove(product);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task<IList<Movie>> GetAllAsync()
        {
            return await moviesDbContext.Movies.AsNoTracking()
                                               .Include(m => m.Director)
                                               .Include(m => m.Players)
                                               .ThenInclude(p => p.Player)
                                               .ToListAsync();
        }

        public async Task<Movie?> GetByIdAsync(int id)
        {
            return await moviesDbContext.Movies.AsNoTracking().FirstOrDefaultAsync(movie => movie.Id == id);
        }

        public async Task<IList<Movie>> SearchMoviesByTitle(string title)
        {
            return await moviesDbContext.Movies.AsNoTracking()
                                               .Where(movie => movie.Name.Contains(title))
                                               .ToListAsync();


        }

        public async Task AddPlayerToMovie(int movieId, List<int> selectedPlayers)
        {
            var movie = await moviesDbContext.Movies.FindAsync(movieId);
            selectedPlayers.ForEach(pl =>
            {
                movie.Players.Add(new MoviesPlayer
                {
                    MovieId = movie.Id,
                    PlayerId = pl
                });
            });

            await moviesDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Movie entity)
        {
            moviesDbContext.Movies.Update(entity);
            await moviesDbContext.SaveChangesAsync();
        }

        public async Task RemovePlayerFromMovieAsync(int movieId, int playerId)
        {
            var movie = await moviesDbContext.Movies.Where(m=>m.Id==movieId).Include(m => m.Players).FirstOrDefaultAsync();
            var player = movie.Players.FirstOrDefault(m => m.PlayerId == playerId);
            movie.Players.Remove(player);
            moviesDbContext.SaveChangesAsync();
        }

        public void RemovePlayerFromMovie(int movieId, int playerId)
        {
            var movie =  moviesDbContext.Movies.Where(m => m.Id == movieId).Include(m => m.Players).FirstOrDefault();
            
            var player = movie.Players.FirstOrDefault(m => m.PlayerId == playerId);
            movie.Players.Remove(player);
            moviesDbContext.SaveChanges();
        }
    }
}
