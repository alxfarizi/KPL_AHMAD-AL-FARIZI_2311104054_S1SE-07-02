using Avalonia;
using System;

namespace tpmodul12_2311104054
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp().StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp() => AppBuilder.Configure<App>().UsePlatformDetect();
    }
}
