using System;
using System.Threading.Tasks;

namespace SpotifyPlaylist.Services
{
    public interface ISpotifyAccountService
    {
        Task<string> GetToken(string clientId, string clientSecret);
    }
}

