using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LunarCore;
using LunarCore.util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyLunar.Models;

namespace MyLunar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetMonthJson(DateTime date)
        {
            var monthStart = new DateTime(date.Year, date.Month, 1);
            var firstWeek = monthStart.DayOfWeek;
            var offsetCells = (int)firstWeek;

            var mainDays = new List<CalendarDay>();

            var validDaysCount = (int)(monthStart.AddMonths(1) - monthStart).TotalDays;
            for (int i = 0; i < validDaysCount; i++)
            {
                var thisDay = monthStart.AddDays(i);
                mainDays.Add(CalendarDay.Build(thisDay));
            }

            // 上个月不可用的日期
            var prependDays = new List<CalendarDay>();
            var preDate = monthStart.AddDays(-offsetCells);
            while (preDate < monthStart)
            {
                prependDays.Add(CalendarDay.Build(preDate));
                preDate = preDate.AddDays(1);

            };

            // 下个月不可用的日期
            var appendDays = new List<CalendarDay>();

            var appendDate = monthStart.AddMonths(1);
            while (appendDate.DayOfWeek != DayOfWeek.Sunday)
            {
                appendDays.Add(CalendarDay.Build(appendDate));
                appendDate = appendDate.AddDays(1);
            }

            return Json(new { mainDays, appendDays, prependDays });

        }

    }

    public class CalendarDay
    {
        public static CalendarDay Build(DateTime solarDate)
        {
            var dest = new CalendarDay()
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
}
