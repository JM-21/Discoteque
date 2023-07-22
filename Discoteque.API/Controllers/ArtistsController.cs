using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discoteque.Business.IServices;
using Discoteque.API.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Discoteque.Data.Models;

namespace Discoteque.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;

        public ArtistsController(IArtistService artistService)
        {
            _artistService = artistService;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            var result = await _artistService.GetArtistsAsync();
            return Ok(result);
        }

        [HttpPost("CreateArtist")]
        public async Task<IActionResult> CreateArtist(Artist artist)
        {
            var artista = await _artistService.CreateArtist(artist);

            return Ok(artista);
        }
    }
}
