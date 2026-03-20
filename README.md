# Spotify New Releases MVC

A lightweight ASP.NET Core MVC application that integrates with the [Spotify Web API](https://developer.spotify.com/documentation/web-api/) to fetch and display the latest music releases.

## Features

- **Spotify API Integration:** Connects securely to the Spotify Web API.
- **Client Credentials Flow:** Uses secure server-to-server authentication to acquire access tokens.
- **New Releases Dashboard:** Fetches the top 20 new album/track releases for the US market and displays them in a clean UI.
- **Dependency Injection:** Makes robust use of .NET Core's built-in `HttpClientFactory` and DI container for handling API services.

## Architecture

The project follows a standard Model-View-Controller (MVC) architectural pattern:

- **Controllers:** `HomeController` manages the web requests, orchestrates the Spotify Services, and renders the Razor Views.
- **Services:**
  - `SpotifyAccountService`: Handles the `client_credentials` authentication flow to retrieve an OAuth access token from Spotify's Accounts API.
  - `SpotifyService`: Interacts with the `browse/new-releases` endpoint of the Spotify Web API to fetch the latest music data.
- **Models:** Strongly-typed C# models (like `Release`, `GetNewReleaseResult`, and `AuthResult`) used to deserialize JSON responses from Spotify.

## Prerequisites

To run this application, you will need:
- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0) or later
- A [Spotify Developer Account](https://developer.spotify.com/dashboard/)

## Getting Started

### 1. Register a Spotify Integration
1. Go to the [Spotify Developer Dashboard](https://developer.spotify.com/dashboard/).
2. Log in and click on **Create an App**.
3. Give your app a name and description.
4. Once created, you will be provided with a **Client ID** and a **Client Secret**. Keep these secure!

### 2. Configure the Application
Open the application source code and locate the `appsettings.json` file in the `SportifyPlaylist` directory (or create it if it doesn't already exist). Add your Spotify credentials to the configuration:

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "Spotify": {
    "ClientId": "YOUR_SPOTIFY_CLIENT_ID",
    "ClientSecret": "YOUR_SPOTIFY_CLIENT_SECRET"
  }
}
```

*Note: In a development setting, you can use Secret Manager (`dotnet user-secrets`) to prevent committing sensitive keys to source control.*

### 3. Build and Run

1. Open a terminal or command prompt in the `SportifyPlaylist` directory.
2. Restore the dependencies:
   ```bash
   dotnet restore
   ```
3. Run the application:
   ```bash
   dotnet run
   ```
4. Open your web browser and navigate to the localhost port provided in the terminal (usually `https://localhost:5001`).

## Technologies Used

- **C# / .NET 5.0**
- **ASP.NET Core MVC**
- **System.Text.Json** for efficient JSON parsing
- **HTTP Client Factory** for resilient API calls
- **HTML/CSS/Bootstrap** (standard MVC template UI)

## License

This project is open-source and available under the terms of the [MIT License](LICENSE).
