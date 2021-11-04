using CeilingFanCSharp5.Enums;

namespace CeilingFanCSharp5.Models
{
    class Fan
    {
        protected FanSpeed currentSpeed;
        protected SpinDirection currentDirection;

        public string Speed => SpeedAsString();
        public string Direction => DirectionAsString();

        public Fan()
        {
            currentDirection = SpinDirection.Clockwise;
            currentSpeed = FanSpeed.Off;
        }

        public string SpeedAsString()
        {
            return currentSpeed switch
            {
                FanSpeed.Off => "OFF",
                FanSpeed.Low => "LOW",
                FanSpeed.Medium => "MEDIUM",
                FanSpeed.High => "HIGH",
                _ => "UNKNOWN"
            };
        }

        public string DirectionAsString()
        {
            return currentDirection switch
            {
                SpinDirection.Clockwise => "CLOCKWISE",
                SpinDirection.CounterClockwise => "COUNTER-CLOCKWISE",
                _ => "UNKNOWN"
            };
        }
    }
}
