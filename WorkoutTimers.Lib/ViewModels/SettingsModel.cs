

using WorkoutTimers.Lib.Services;

namespace WorkoutTimers.Lib.ViewModels
{
    public class SettingsModel
    {

        string _version = null;
        IVersionInfo _versionInfo;

        public SettingsModel(IVersionInfo info)
        {
            _versionInfo = info;
        }
        public string OSVersion
        {
            get
            {
                if (_version == null)
                {
                    _version = _versionInfo.GetOSVersion();
                }
                return _version;
            }
        }
    }
}
