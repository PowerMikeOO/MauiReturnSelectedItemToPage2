using MauiReturnSelectedItemToPage2.Services;
using MauiReturnSelectedItemToPage2.ViewModels;
using MauiReturnSelectedItemToPage2.Views;
using Microsoft.Extensions.Logging;

namespace MauiReturnSelectedItemToPage2;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        // Register services
        builder.Services.AddSingleton<ISelectionState, SelectionState>();

        // Register viewmodels
        builder.Services.AddTransient<MainViewModel>();
        builder.Services.AddTransient<SelectionViewModel>();

        // Register pages
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<SelectionPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
