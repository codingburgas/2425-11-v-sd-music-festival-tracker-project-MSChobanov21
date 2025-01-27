using Festival.DAL.Repositories;
using Festival.DAL.Models;

namespace Festival.BLL
{
    public class ArtistService
    {
        private readonly ArtistRepository _artistRepository;

        public ArtistService(ArtistRepository artistRepository)
        {
            _artistRepository = artistRepository;
        }

        public List<Artist> GetAllArtists()
        {
            return _artistRepository.GetAllArtists();
        }
    }
}