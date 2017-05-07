using System;
using Alice.Platforms.Base;

namespace Alice.Platforms.Sun
{
    public class SunPlatformState : PlatformState
    {
        public TimeSpan SunsetTime
        {
            get => this.GetProperty<TimeSpan>();
            set => this.SetProperty(value);
        }

        public TimeSpan SunriseTime
        {
            get => this.GetProperty<TimeSpan>();
            set => this.SetProperty(value);
        }

        public SunStates Current
        {
            get => this.GetProperty<SunStates>();
            set => this.SetProperty(value);
        }


        public SunPlatformState(IState state) : base(state)
        {
        }
    }
}