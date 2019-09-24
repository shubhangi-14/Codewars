// Write a function, which takes a non-negative integer (seconds) as input and returns the time in a human-readable format (HH:MM:SS)
using System;
public static class TimeFormat
{
    public static string GetReadableTime(int seconds)
    {
        int hours = seconds / 3600;
        int min = (seconds%3600) / 60;
        seconds = seconds%60;
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hours, min, seconds);
    }
}