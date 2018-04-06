using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Logging;
using MvvmCross.Plugin;
using Serilog;

namespace TestApp.Droid
{
    public class Setup : MvxFormsAndroidSetup<CoreApp, FormsApp>
    {
        protected override MvxLogProviderType GetDefaultLogProviderType()
            => MvxLogProviderType.Serilog;

        protected override IMvxLogProvider CreateLogProvider()
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.AndroidLog()
                .CreateLogger();
            return base.CreateLogProvider();
        }

        protected override void InitializePlatformServices()
        {
            base.InitializePlatformServices();
            //Mvx.RegisterType<IDeviceService, DeviceService>();
            //Mvx.RegisterType<IOfflineStorageService, OfflineStorageService>();
            //Mvx.RegisterType<ISleepMode, SleepMode>();
            //Mvx.RegisterType<ILatestVersion, LatestVersionImplementation>();
        }
    }
}