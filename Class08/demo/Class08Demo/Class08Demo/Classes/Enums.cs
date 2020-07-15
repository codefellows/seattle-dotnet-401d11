using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Class08Demo.Classes
{
    // "Enumerations" ("enum")
    // sets of data that can be pre-chosen
    public enum Months : byte
    {
        Janurary = 1,
        February,
        March,
        April,
        May,
        June,
        July
    }

    public enum Days
    {
        [Display(Name="Monday Monday Monday!")]
        Monday = 1,
        Tuesday = 45,
        Wednesday,
        Thursday = 12,
        Friday = 7,
        Saturday = 10,
        Sunday = Tuesday + Wednesday
    }
}
