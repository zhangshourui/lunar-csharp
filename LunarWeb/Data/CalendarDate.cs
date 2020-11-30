using System;
using System.Collections.Generic;
using System.Linq;
using LunarCore;
using LunarCore.util;

namespace LunarWeb.Data
{
    public class CalendarDate
    {
        public static CalendarDate Build(DateTime solarDate)
        {
            var dest = new CalendarDate()
            {
                SolarDate = solarDate,
                SolarDay = solarDate.Day
            };
            Solar solar = new Solar(solarDate);
            Lunar lunar = solar.getLunar();
            var jieQi = lunar.getCurrentJieQi();
            if (jieQi != null)
            {
                dest.SolarTerm = jieQi.getName();
            }
            dest.LunarDay = lunar.getDayInChinese();
            dest.LunarMonth = lunar.getMonthInChinese();
            var holidayList = HolidayUtil.getHolidaysByTarget(solarDate.Year, solarDate.Month, solarDate.Day);
            if (holidayList != null && holidayList.Count > 0)
            {
                var holidayStr = string.Join(" ", holidayList.Select(m => m.getName()));
                dest.Holiday = holidayStr;
            }


            return dest;
        }
        public DateTime SolarDate { get; set; }
        public int SolarDay { get; set; }
        public string LunarDay { get; set; }
        public string LunarMonth { get; set; }
        /// <summary>
        /// 节气
        /// </summary>
        public string SolarTerm { get; set; }
        public string Holiday { get; set; }
    }

    public class CalendarInfo
    {
        public List<CalendarDate> PrependDays { get; set; }

        public List<CalendarDate> MainDays { get; set; }

        public List<CalendarDate> AppendDays { get; set; }

    }
}
