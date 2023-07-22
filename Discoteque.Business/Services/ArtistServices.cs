using Discoteque.Business.IServices;
using Discoteque.Data.Models;

namespace Discoteque.Business.Services;

public class ArtistService : IArtistService
{
    async Task<Artist> IArtistService.CreateArtist(Artist artista)
    {
        List<Artist> listArtists = new();
        var rand = new Random();

        artista.Id = rand.Next(0, 100);


        listArtists.Add(artista);

        return artista;
    }

    public async Task<IEnumerable<Artist>> GetArtistsAsync()
    {
        List<Artist> artists = new();
        var rand = new Random();

        artists.Add(new Artist() { Id = rand.Next(0, 100), Name = "arca", Label = "PinaRecords", IsOnTour = true });
        artists.Add(new Artist() { Id = rand.Next(0, 100), Name = "delagetto", Label = "nn", IsOnTour = true });
        artists.Add(new Artist() { Id = rand.Next(0, 100), Name = "anuel", Label = "realg", IsOnTour = true });
        artists.Add(new Artist() { Id = rand.Next(0, 100), Name = "coscu", Label = "rottwailers", IsOnTour = true });
        artists.Add(new Artist() { Id = rand.Next(0, 100), Name = "lele", Label = "secret family", IsOnTour = true });

        return artists;

    }

    public Task<Artist> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Artist> UpdateArtist(Artist artist)
    {
        throw new NotImplementedException();
    }

}