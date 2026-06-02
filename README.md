# CSUMB Portfolio Site

Static Blazor WebAssembly rebuild of Bijan Pourazari's recovered CSUMB Computer Science portfolio.

The original scraped pages and uploads are preserved in `old-scrape/`. Public assets used by the Blazor app are served from `wwwroot/portfolio/`.

## Local Development

```powershell
dotnet restore
dotnet run --launch-profile http
```

The development server runs at:

```text
http://localhost:5163
```

## Static Publish

```powershell
dotnet publish CSUMBPortfolioSite.csproj -c Release
```

The static site output is generated at:

```text
bin/Release/net8.0/publish/wwwroot
```

If you use a generic static server, serve this published `wwwroot` folder, not the source `wwwroot` folder.

## Netlify

Netlify settings are defined in `netlify.toml`:

- Build command: `dotnet publish CSUMBPortfolioSite.csproj -c Release`
- Publish directory: `bin/Release/net8.0/publish/wwwroot`
- SPA fallback: all routes serve `/index.html`
