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

### Option A: Netlify build (netlify.toml)

`netlify.toml` installs .NET 8, publishes the app, copies the built files into `wwwroot/`, and publishes that folder. The build fails if `index.html` still contains the unpublished `#[.{fingerprint}]` script placeholder.

In the Netlify UI (**Site configuration → Build & deploy**), clear any custom build command and publish directory so `netlify.toml` is used, or set publish directory to **`wwwroot`** only (do not point at the repo’s source `wwwroot` without running the build).

### Option B: GitHub Actions (recommended if Netlify builds keep failing)

1. In Netlify: **Site configuration → Build & deploy → Continuous deployment → Build settings**, set **Build command** to empty and enable **Stop builds** (or ignore Netlify builds).
2. In GitHub: add repository secrets `NETLIFY_AUTH_TOKEN` and `NETLIFY_SITE_ID` (from Netlify **User settings → Applications** and **Site configuration → General**).
3. Push to `main`; `.github/workflows/deploy-netlify.yml` publishes `release/wwwroot` to production.

### Verify a deploy

- `https://<your-site>/_framework/blazor.boot.json` should return JSON.
- View page source for `/`; the script tag should reference `_framework/blazor.webassembly.js`, not `#[.{fingerprint}]`.
