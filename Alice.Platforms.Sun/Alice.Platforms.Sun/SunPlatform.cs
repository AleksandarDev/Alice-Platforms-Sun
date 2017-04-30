using System;
using Alice.Platforms.Base;
using SunSetRiseLib;

namespace Alice.Platforms.Sun
{
    public class SunPlatform : IPlatform
    {
        private const string PlatformName = "Sun";
        private const string PlatformFriendlyName = "Sun";

        private int timeZone;
        private double longitude;
        private double latitude;

        public string Name => PlatformName;

        public string FriendlyName => PlatformFriendlyName;

        private void CheckCurrentState()
        {

        }

        private DateTime? GetSunrise() => 
            this.GetSunRiseSet(Util.calcSunRiseUTC);

        private DateTime? GetSunset() => 
            this.GetSunRiseSet(Util.calcSunSetUTC);

        private DateTime? GetSunRiseSet(Func<double, double, double, double> function)
        {
            return Util.getDateTime(
                function(
                    Util.calcJD(this.GetDate()),
                    this.longitude,
                    this.latitude),
                this.timeZone,
                this.GetDate(),
                this.IsDailightSaving());
        }

        private bool IsDailightSaving() => true;

        private DateTime GetDate() => DateTime.Today;
    }
}
