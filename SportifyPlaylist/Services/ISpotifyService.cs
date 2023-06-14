using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SpotifyPlaylist.Models;

namespace SpotifyPlaylist.Services
{
	public interface ISpotifyService
	{
		Task<IEnumerable<Release>> GetNewReleases(string countryCode, int limit, string accessToken);
	}
}

