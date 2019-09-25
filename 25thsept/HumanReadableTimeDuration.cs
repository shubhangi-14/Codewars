// Your task in order to complete this Kata is to write a function which formats a duration, given as a number of seconds, in a human-friendly way.

// The function must accept a non-negative integer. If it is zero, it just returns "now". Otherwise, the duration is expressed as a combination of years, days, hours, minutes and seconds.
using System;
public class HumanTimeFormat{
  public static string formatDuration(int seconds){
      if (seconds == 0) {return "now";}
  string duration = null;
  int years   = seconds / (60 * 60 * 24 * 365);
  int days    = seconds / (60 * 60 * 24) % 365;
  int hours   = seconds / (60 * 60) % 24;
  int minutes = seconds / 60 % 60;
  seconds = seconds %  60;
  if(years>0)
    duration+= years + " years, ";
  if(days>0)
    duration+= days + " days, ";
  if(hours>0)
  {
    duration+= hours + " hours";
    if(minutes>0 && seconds>0)
      duration+= ", ";
    else if(minutes>0)
      duration+= " and ";
  }
  if(minutes>0)
  {
    duration+= minutes + " minutes";
    if(seconds>0)
      duration+= " and ";
  }
  if(seconds>0)
    duration+= seconds + " seconds";
    if (duration.Contains("1 seconds"))
        duration = duration.Replace("1 seconds", "1 second");

    if (duration.Contains("1 minutes") && minutes == 1)
        duration = duration.Replace("1 minutes", "1 minute");

    if (duration.Contains("1 hours"))
        duration = duration.Replace("1 hours", "1 hour");
        
    if (duration.Contains("1 days"))
        duration = duration.Replace("1 days", "1 day");
        
    if (duration.Contains("1 years"))
        duration = duration.Replace("1 years", "1 year");

    if (duration.StartsWith("1 days"))
        duration = duration.Replace("1 days", "1 day");
    return duration;
  }
}