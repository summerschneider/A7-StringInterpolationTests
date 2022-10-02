using System;

namespace StringInterpolationTemplate.Utils;

public class SystemDate : ISystemDate
{
    public DateTime Now => DateTime.Now;  //=> means goes to  //it returns the date and time thats current
}
