using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutTimers.Lib
{
    public class VersionInfo : Services.IVersionInfo
    {
        public string GetOSVersion()
        {
            return Android.OS.Build.VERSION.Release;
        }
    }
}
