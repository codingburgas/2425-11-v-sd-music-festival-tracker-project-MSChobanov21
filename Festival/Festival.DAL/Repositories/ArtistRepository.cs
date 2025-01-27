using Festival.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Festival.DAL.Data;

namespace Festival.DAL.Repositories
{
    public class ArtistRepository
    {
        private readonly FestivalDbContext _context;

        public ArtistRepository(FestivalDbContext context)
        {
            _context = context;
        }

        // Get all artists
        public List<Artist> GetAllArtists()
        {
            return _context.Artists.ToList();
        }

        // Get artist by ID
        public Artist GetArtistById(int id)
        {
            return _context.Artists.Find(id);
        }

        // Add a new artist
        public void AddArtist(Artist artist)
        {
            _context.Artists.Add(artist);
            _context.SaveChanges();
        }

        // Update an existing artist
        public void UpdateArtist(Artist artist)
        {
            _context.Entry(artist).State = EntityState.Modified;
            _context.SaveChanges();
        }

        // Delete an artist
        public void DeleteArtist(int id)
        {
            var artist = _context.Artists.Find(id);
            if (artist != null)
            {
                _context.Artists.Remove(artist);
                _context.SaveChanges();
            }
        }
    }
}