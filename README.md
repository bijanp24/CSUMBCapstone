# CSUMB Portfolio Site

Static Blazor WebAssembly rebuild of Bijan Pourazari's recovered CSUMB Computer Science portfolio.

## Overview

A professional portfolio site showcasing coursework from California State University, Monterey Bay's Computer Science program. Built with .NET 8.0 Blazor WebAssembly and Bootstrap styling.

**Live Routes:**
- `/` — Home page with hero section and course overview
- `/courses` — Catalog of 10+ courses with descriptions
- `/courses/<slug>` — Individual course detail pages with projects and artifacts

**Featured Coursework:**
- Multimedia Design & Programming (image processing, Python)
- Software Design (Android game development, UML)
- Database Management (Java servlets, SQL)
- Computer Networking, Internet Programming, Algorithms
- Directed Group Capstone with proposal and report

**Course Assets:**
- Project descriptions and documentation
- Downloadable files (PDFs, Word docs, Java source code)
- Gallery images from multimedia projects
- External links to archived Heroku deployments

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
