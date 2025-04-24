# MauiReturnSelectedItemToPage2

This is a simple sample project that demonstrates how to share a selected item from a ListView between different pages using .NET MAUI. The goal of this project is to provide an easy-to-understand example for managing shared state (the selected item) across multiple views. Although there are many advanced scenarios on the web, you might find few samples that focus on this particular use case with a straightforward approach.

### Key Features

-	**Shared Selection State:** Uses an **ISelectionState service** to share and update the selected item between pages.
-	**Navigation:** Demonstrates how to navigate between pages and pass view models.
-	**Simple MVVM Implementation:** Provides an example using the MVVM pattern to keep the UI synchronized with the shared state.
-	**Cross-Platform:** Targets Android, iOS, MacCatalyst, and Windows. (Note: the Mac and iOS versions have not been tested yet.)

This sample is intended for individuals looking to explore how to manage and return a selected item from a list in a multi-page .NET MAUI application.


### Line Endings & `.gitattributes`

To ensure consistent line endings on Windows, macOS, and Linux, this repository includes a committed [`.gitattributes`](https://git-scm.com/docs/gitattributes) file configured like this:

- text=auto (detects text files and normalizes them to LF on commit)

- *.sln text eol=crlf (keeps solution files in CRLF for Visual Studio compatibility)

- *.cs text eol=lf (ensures C# source files use LF everywhere)

- *.csproj text eol=lf (ensures project files use LF in cross-platform .NET Core/.NET 5+ projects)

- *.xml text eol=lf (ensures all XML-based files use LF)

- *.xaml text eol=lf (ensures XAML UI-markup uses LF)

- *.json text eol=lf (ensures configuration/data files use LF)

- *.svg text eol=lf (treats SVG graphics as text and normalizes to LF)

- *.ttf binary (marks font files as binary to prevent any EOL conversion)


If you ever update .gitattributes, run these commands in your repo root before committing:

    git add --renormalize .<br>
    git commit -m "Apply updated line-ending rules"

Then restart or reload your editor so it picks up the new settings.
