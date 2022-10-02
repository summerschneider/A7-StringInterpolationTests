using System;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.MM.dd");
        Console.WriteLine(date);

        return date;
    }

    public string Number03()
    {
        var date = _date.Now.ToString("dd");
        var date1 = _date.Now.ToString("MMMM");
        var date2 = _date.Now.ToString("yyyy");
        var answer = $"Day {date} of {date1}, {date2}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number04()
    {
        var date = _date.Now.ToString("yyyy");
        var date1 = _date.Now.ToString("MM");
        var date2 = _date.Now.ToString("dd");
        var answer = $"Year: {date}, Month: {date1}, Day: {date2}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number05()
    {
        var date = _date.Now.ToString("dddd");
        var answer = $"{date,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number06()
    {
        var date = _date.Now.ToString("t");
        var date1 = _date.Now.ToString("dddd");
        var answer = $"{date,10}{date1,10}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number07()
    {
        var date = _date.Now.ToString("hh");
        var date1 = _date.Now.ToString("mm");
        var date2 = _date.Now.ToString("ss");
        var answer = $"h:{date}, m:{date1}, s:{date2}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number08()
    {
        var date = _date.Now.ToString("yyyy");
        var date1 = _date.Now.ToString("MM");
        var date2 = _date.Now.ToString("dd");
        var date3 = _date.Now.ToString("hh");
        var date4 = _date.Now.ToString("mm");
        var date5 = _date.Now.ToString("ss");
        var answer = $"{date}.{date1}.{date2}.{date3}.{date4}.{date5}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number09()
    {
        var pi = Math.PI;
        var answer = $"{pi:C2}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number10()
    {
        var pi = Math.PI;
        var answer = $"{pi,10:N3}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number11()
    {
        var date = $"{DateTime.Now:yyyy}";
        var answer = Convert.ToInt64(date).ToString("X");
        Console.WriteLine(answer);

        return answer;
    }
}
