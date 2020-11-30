using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LunarWeb.Data
{
    public class CalendarService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };



        public Task<CalendarInfo> GetMonthJson(DateTime date)
        {
            var monthStart = new DateTime(date.Year, date.Month, 1);
            var firstWeek = monthStart.DayOfWeek;
            var offsetCells = (int)firstWeek;

            var mainDays = new List<CalendarDate>();

            var validDaysCount = (int)(monthStart.AddMonths(1) - monthStart).TotalDays;
            for (int i = 0; i < validDaysCount; i++)
            {
                var thisDay = monthStart.AddDays(i);
                mainDays.Add(CalendarDate.Build(thisDay));
            }

            // 上个月不可用的日期
            var prependDays = new List<CalendarDate>();
            var preDate = monthStart.AddDays(-offsetCells);
            while (preDate < monthStart)
            {
                prependDays.Add(CalendarDate.Build(preDate));
                preDate = preDate.AddDays(1);

            };

            // 下个月不可用的日期
            var appendDays = new List<CalendarDate>();

            var appendDate = monthStart.AddMonths(1);
            while (appendDate.DayOfWeek != DayOfWeek.Sunday)
            {
                appendDays.Add(CalendarDate.Build(appendDate));
                appendDate = appendDate.AddDays(1);
            }
            return Task.FromResult(new CalendarInfo { MainDays = mainDays, AppendDays = appendDays, PrependDays = prependDays });

        }

    }
}
