﻿// 以下代码由 Microsoft Visual Studio 2005 生成。
// 测试所有者应该检查每个测试的有效性。
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;
using System.Collections.Generic;
using com.nlf.calendar;
using com.nlf.calendar.util;
namespace test
{
    /// <summary>
    ///这是 com.nlf.calendar.util.HolidayUtil 的测试类，旨在
    ///包含所有 com.nlf.calendar.util.HolidayUtil 单元测试
    ///</summary>
    [TestClass()]
    public class HolidayUtilTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        #region 附加测试属性
        // 
        //编写测试时，可使用以下附加属性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///getHoliday (int, int, int) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidayTest()
        {
            int year = 2020;

            int month = 5;

            int day = 1;

            string expected = "2020-05-01 劳动节 2020-05-01";
            string actual = null;

            actual = com.nlf.calendar.util.HolidayUtil.getHoliday(year, month, day).ToString();

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHoliday 未返回所需的值。");
        }

        /// <summary>
        ///getHoliday (string) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidayTest1()
        {
            string ymd = "2011-05-02";

            string expected = "2011-05-02 劳动节 2011-05-01";
            string actual;

            actual = com.nlf.calendar.util.HolidayUtil.getHoliday(ymd).ToString();

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHoliday 未返回所需的值。");
        }

        /// <summary>
        ///getHolidays (int) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidaysTest()
        {
            int year = 2012;

            int expected = 35;
            int actual;

            actual = com.nlf.calendar.util.HolidayUtil.getHolidays(year).Count;

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHolidays 未返回所需的值。");
        }

        /// <summary>
        ///getHolidays (int, int) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidaysTest1()
        {
            int year = 2013;

            int month = 5;

            int expected = 1;
            int actual;

            actual = com.nlf.calendar.util.HolidayUtil.getHolidays(year, month).Count;

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHolidays 未返回所需的值。");
        }

        /// <summary>
        ///getHolidays (string) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidaysTest2()
        {
            string ymd = "2012";

            int expected = 35;
            int actual;

            actual = com.nlf.calendar.util.HolidayUtil.getHolidays(ymd).Count;

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHolidays 未返回所需的值。");
        }

        /// <summary>
        ///getHolidaysByTarget (int, int, int) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidaysByTargetTest()
        {
            int year = 2018;

            int month = 5;

            int day = 1;

            int expected = 4;
            int actual;

            actual = com.nlf.calendar.util.HolidayUtil.getHolidaysByTarget(year, month, day).Count;

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHolidaysByTarget 未返回所需的值。");
        }

        /// <summary>
        ///getHolidaysByTarget (string) 的测试
        ///</summary>
        [TestMethod()]
        public void getHolidaysByTargetTest1()
        {
            string ymd = "2018-05-01";

            int expected = 4;
            int actual;

            actual = com.nlf.calendar.util.HolidayUtil.getHolidaysByTarget(ymd).Count;

            Assert.AreEqual(expected, actual, "com.nlf.calendar.util.HolidayUtil.getHolidaysByTarget 未返回所需的值。");
        }

    }


}