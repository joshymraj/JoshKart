using System;
using System.Collections.Generic;

public class Util
{
    public static DateTime TimeStampToDateTime(long timeStamp) {
        DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        return epochStart.AddSeconds(timeStamp);
    }

    public static List<string> FormatTimeDuration(double seconds) {
        List<string> arr = new List<string>();
        int days = (int)(seconds / 86400.0f);
        seconds -= days * 86400;
        int hours = (int)(seconds / 3600.0f);
        seconds -= hours * 3600;
        int minutes = (int)(seconds / 60.0f);
        seconds -= minutes * 60;

        if (days > 0) {
            arr.Add(days + "d");
        }
        if (days < 2) {
            if (hours > 0) {
                arr.Add(hours + "h");
            }
            if (hours < 2) {
                if (minutes > 0) {
                    arr.Add(minutes + "m");
                }
                if (minutes < 2) {
                    if (seconds > 0) {
                        arr.Add((int)seconds + "s");
                    }
                }
            }
        }
        return arr;
    }

    public static string FormatTimeRemaining(double seconds) {
        List<string> arr = new List<string>();
        int hours = (int)(seconds / 3600f);
        seconds -= hours * 3600;
        int minutes = (int)(seconds / 60f);
        seconds -= minutes * 60;

        if (hours > 0) {
            arr.Add(hours.ToString());
        }
        arr.Add(minutes.ToString("D2"));
        arr.Add(((int)seconds).ToString("D2"));
        return String.Join(":", arr.ToArray());
    }

    public static string FormatTimeRemainingMicro(double remainingTime) {
        List<string> arr = new List<string>();
        int days = (int)(remainingTime / 86400f);
        remainingTime -= days * 86400;
        int hours = (int)(remainingTime / 3600f);
        remainingTime -= hours * 3600;
        int minutes = (int)(remainingTime / 60f);
        remainingTime -= minutes * 60;
        if (days > 0) {
            arr.Add(days.ToString() + "d");
        }

        if (hours > 0) {
            arr.Add(hours.ToString() + "h");
        }
        arr.Add(minutes.ToString("D2") + "m");
        arr.Add(((int)remainingTime).ToString("D2") + "s");
        return String.Join(":", arr.ToArray());
    }

    public static string FormatTimeRemainingShort(long remainingTime) {
        if (remainingTime > 0) {
            string pluralLetter;
            if (remainingTime > 86400) {
                int days = (int)(remainingTime / 86400);
                pluralLetter = days > 1 ? "s" : "";
                return string.Format("{0} Day{1}", days, pluralLetter);
            } else if (remainingTime > 3600) {
                int hours = (int)(remainingTime / 3600);
                pluralLetter = hours > 1 ? "s" : "";
                return string.Format("{0} Hour{1}", hours, pluralLetter);
            } else if (remainingTime > 60) {
                int minutes = (int)(remainingTime / 60);
                pluralLetter = minutes > 1 ? "s" : "";
                return string.Format("{0} Minute{1}", minutes, pluralLetter);
            } else {
                pluralLetter = remainingTime > 1 ? "s" : "";
                return string.Format("{0} Second{1}", remainingTime, pluralLetter);
            }
        } else {
            return "";
        }
    }


    public static string FormatTimeRemainingEasy(long seconds) {
        List<string> arr = FormatTimeRemainingArr(seconds);
        return String.Join(" ", arr.ToArray());
    }

    public static string FormatTimeRemainingSuperShort(long seconds) {
        List<string> arr = FormatTimeRemainingArr(seconds);
        if (arr.Count > 1) {
            return arr[0] + "+";
        } else {
            return arr[0];
        }
    }

    public static List<string> FormatTimeRemainingArr(long seconds) {
        List<string> arr = new List<string>();
        int hours = (int)(seconds / 3600.0f);
        seconds -= hours * 3600;
        int minutes = (int)(seconds / 60.0f);
        seconds -= minutes * 60;

        if (hours > 0) {
            arr.Add(hours.ToString() + "h");
        }
        if (minutes > 0) {
            arr.Add(minutes.ToString() + "m");
        }
        if (seconds > 0) {
            arr.Add(((int)seconds).ToString() + "s");
        }
        if (arr.Count == 0) {
            arr.Add("0s");
        }
        return arr;
    }


    public static string FormatTimeRemainingMinutes(double seconds) {
        int minutes = (int)(seconds / 60.0f);
        return minutes.ToString() + " Minutes";
    }
}
