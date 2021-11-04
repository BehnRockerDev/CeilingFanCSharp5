using CeilingFanCSharp5.Enums;
using System;

namespace CeilingFanCSharp5.Models
{
    class CeilingFan : Fan
    {
        //This method increments the speed of the fan by one. If on top speed, the method will turn the fan off.
        public void PullSpeedCord()
        {
            _ = currentSpeed switch
            {
                FanSpeed.Off => currentSpeed = FanSpeed.Low,
                FanSpeed.Low => currentSpeed = FanSpeed.Medium,
                FanSpeed.Medium => currentSpeed = FanSpeed.High,
                FanSpeed.High => currentSpeed = FanSpeed.Off,
                _ => throw new ArgumentOutOfRangeException(nameof(currentSpeed), $"Not expected speed value: {currentSpeed}")
            };
        }

        //As the fan can only go clockwise and counter-clockwise, this method switches the direction.
        public void PullDirectionCord()
        {
            _ = currentDirection.Equals(SpinDirection.Clockwise)
                ? currentDirection = SpinDirection.CounterClockwise
                : currentDirection = SpinDirection.Clockwise;
        }
    }
}
