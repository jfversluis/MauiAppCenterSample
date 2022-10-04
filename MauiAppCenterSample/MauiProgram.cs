using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace MauiAppCenterSample;

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

        AppCenter.Start("windowsdesktop={Your Windows App secret here};" +
                "android={Your Android App secret here};" +
                "ios={Your iOS App secret here};" +
                "macos={Your macOS App secret here};",
                typeof(Analytics), typeof(Crashes));

        return builder.Build();
	}
}
