using Microsoft.Extensions.Logging;
using PJL_Project;

internal static class MauiProgramHelpers
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("LibreBaskerville-Regular.ttf", "LBRegular");
                fonts.AddFont("LibreBaskerville-Bold.ttf", "LBBold");
                fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
                fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");

            });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}