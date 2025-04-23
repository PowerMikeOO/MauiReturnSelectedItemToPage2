### Line Endings & `.gitattributes`

To ensure consistent line endings on Windows, macOS, and Linux, this repository includes a committed [`.gitattributes`](https://git-scm.com/docs/gitattributes) file configured like this:

text=auto (detects text files and normalizes them to LF on commit)

*.sln text eol=crlf (keeps solution files in CRLF for Visual Studio compatibility)

*.cs text eol=lf (ensures C# source files use LF everywhere)

*.csproj text eol=lf (ensures project files use LF in cross-platform .NET Core/.NET 5+ projects)

*.xml text eol=lf (ensures all XML-based files use LF)

*.xaml text eol=lf (ensures XAML UI-markup uses LF)

*.json text eol=lf (ensures configuration/data files use LF)

*.svg text eol=lf (treats SVG graphics as text and normalizes to LF)

*.ttf binary (marks font files as binary to prevent any EOL conversion)

If you ever update .gitattributes, run these commands in your repo root before committing:
git add --renormalize .
git commit -m "Apply updated line-ending rules"

Then restart or reload your editor so it picks up the new settings.