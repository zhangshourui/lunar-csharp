﻿// ------------------------------------------------------------------------------
//<autogenerated>
//        此代码是由 Microsoft Visual Studio Team System 2005 生成的。
//
//        对此文件的更改
// 可能导致不正确的行为，如果重新生成代码，所做修改将丢失。
//</autogenerated>
//------------------------------------------------------------------------------
using LunarCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace test
{
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class BaseAccessor {
    
    protected Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject m_privateObject;
    
    protected BaseAccessor(object target, Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type) {
        m_privateObject = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(target, type);
    }
    
    protected BaseAccessor(Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType type) : 
            this(null, type) {
    }
    
    internal virtual object Target {
        get {
            return m_privateObject.Target;
        }
    }
    
    public override string ToString() {
        return this.Target.ToString();
    }
    
    public override bool Equals(object obj) {
        if (typeof(BaseAccessor).IsInstanceOfType(obj)) {
            obj = ((BaseAccessor)(obj)).Target;
        }
        return this.Target.Equals(obj);
    }
    
    public override int GetHashCode() {
        return this.Target.GetHashCode();
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class com_nlf_calendar_SolarAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType("lunar", "LunarCore.Solar");
    
    internal com_nlf_calendar_SolarAccessor(object target) : 
            base(target, m_privateType) {
    }
    
    internal int year {
        get {
            int ret = ((int)(m_privateObject.GetField("year")));
            return ret;
        }
        set {
            m_privateObject.SetField("year", value);
        }
    }
    
    internal int month {
        get {
            int ret = ((int)(m_privateObject.GetField("month")));
            return ret;
        }
        set {
            m_privateObject.SetField("month", value);
        }
    }
    
    internal int day {
        get {
            int ret = ((int)(m_privateObject.GetField("day")));
            return ret;
        }
        set {
            m_privateObject.SetField("day", value);
        }
    }
    
    internal int hour {
        get {
            int ret = ((int)(m_privateObject.GetField("hour")));
            return ret;
        }
        set {
            m_privateObject.SetField("hour", value);
        }
    }
    
    internal int minute {
        get {
            int ret = ((int)(m_privateObject.GetField("minute")));
            return ret;
        }
        set {
            m_privateObject.SetField("minute", value);
        }
    }
    
    internal global::System.DateTime calendar {
        get {
            global::System.DateTime ret = ((global::System.DateTime)(m_privateObject.GetField("calendar")));
            return ret;
        }
        set {
            m_privateObject.SetField("calendar", value);
        }
    }
    
    internal static object CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("lunar", "LunarCore.Solar", new System.Type[0], args);
        return priv_obj.Target;
    }
    
    internal static object CreatePrivate(int year, int month, int day) {
        object[] args = new object[] {
                year,
                month,
                day};
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("lunar", "LunarCore.Solar", new System.Type[] {
                    typeof(int),
                    typeof(int),
                    typeof(int)}, args);
        return priv_obj.Target;
    }
    
    internal static object CreatePrivate(int year, int month, int day, int hour, int minute) {
        object[] args = new object[] {
                year,
                month,
                day,
                hour,
                minute};
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("lunar", "LunarCore.Solar", new System.Type[] {
                    typeof(int),
                    typeof(int),
                    typeof(int),
                    typeof(int),
                    typeof(int)}, args);
        return priv_obj.Target;
    }
    
    internal static object CreatePrivate(global::System.DateTime date) {
        object[] args = new object[] {
                date};
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject("lunar", "LunarCore.Solar", new System.Type[] {
                    typeof(global::System.DateTime)}, args);
        return priv_obj.Target;
    }
    
    internal static global::test.com_nlf_calendar_SolarAccessor fromYmd(int year, int month, int day) {
        object[] args = new object[] {
                year,
                month,
                day};
        object _ret_val = m_privateType.InvokeStatic("fromYmd", new System.Type[] {
                    typeof(int),
                    typeof(int),
                    typeof(int)}, args);
        global::test.com_nlf_calendar_SolarAccessor _ret = null;
        if ((_ret_val != null)) {
            _ret = new global::test.com_nlf_calendar_SolarAccessor(_ret_val);
        }
        global::test.com_nlf_calendar_SolarAccessor ret = _ret;
        return ret;
    }
    
    internal static global::test.com_nlf_calendar_SolarAccessor fromYmdHm(int year, int month, int day, int hour, int minute) {
        object[] args = new object[] {
                year,
                month,
                day,
                hour,
                minute};
        object _ret_val = m_privateType.InvokeStatic("fromYmdHm", new System.Type[] {
                    typeof(int),
                    typeof(int),
                    typeof(int),
                    typeof(int),
                    typeof(int)}, args);
        global::test.com_nlf_calendar_SolarAccessor _ret = null;
        if ((_ret_val != null)) {
            _ret = new global::test.com_nlf_calendar_SolarAccessor(_ret_val);
        }
        global::test.com_nlf_calendar_SolarAccessor ret = _ret;
        return ret;
    }
    
    internal static global::test.com_nlf_calendar_SolarAccessor fromDate(global::System.DateTime date) {
        object[] args = new object[] {
                date};
        object _ret_val = m_privateType.InvokeStatic("fromDate", new System.Type[] {
                    typeof(global::System.DateTime)}, args);
        global::test.com_nlf_calendar_SolarAccessor _ret = null;
        if ((_ret_val != null)) {
            _ret = new global::test.com_nlf_calendar_SolarAccessor(_ret_val);
        }
        global::test.com_nlf_calendar_SolarAccessor ret = _ret;
        return ret;
    }
    
    internal bool isLeapYear() {
        object[] args = new object[0];
        bool ret = ((bool)(m_privateObject.Invoke("isLeapYear", new System.Type[0], args)));
        return ret;
    }
    
    internal int getWeek() {
        object[] args = new object[0];
        int ret = ((int)(m_privateObject.Invoke("getWeek", new System.Type[0], args)));
        return ret;
    }
    
    internal string getWeekInChinese() {
        object[] args = new object[0];
        string ret = ((string)(m_privateObject.Invoke("getWeekInChinese", new System.Type[0], args)));
        return ret;
    }
    
    internal string getXingzuo() {
        object[] args = new object[0];
        string ret = ((string)(m_privateObject.Invoke("getXingzuo", new System.Type[0], args)));
        return ret;
    }
    
    internal string getXingZuo() {
        object[] args = new object[0];
        string ret = ((string)(m_privateObject.Invoke("getXingZuo", new System.Type[0], args)));
        return ret;
    }
    
    internal System.Collections.Generic.List<string> getFestivals() {
        object[] args = new object[0];
        System.Collections.Generic.List<string> ret = ((System.Collections.Generic.List<string>)(m_privateObject.Invoke("getFestivals", new System.Type[0], args)));
        return ret;
    }
    
    internal System.Collections.Generic.List<string> getOtherFestivals() {
        object[] args = new object[0];
        System.Collections.Generic.List<string> ret = ((System.Collections.Generic.List<string>)(m_privateObject.Invoke("getOtherFestivals", new System.Type[0], args)));
        return ret;
    }
    
    internal int getYear() {
        object[] args = new object[0];
        int ret = ((int)(m_privateObject.Invoke("getYear", new System.Type[0], args)));
        return ret;
    }
    
    internal int getMonth() {
        object[] args = new object[0];
        int ret = ((int)(m_privateObject.Invoke("getMonth", new System.Type[0], args)));
        return ret;
    }
    
    internal int getDay() {
        object[] args = new object[0];
        int ret = ((int)(m_privateObject.Invoke("getDay", new System.Type[0], args)));
        return ret;
    }
    
    internal int getHour() {
        object[] args = new object[0];
        int ret = ((int)(m_privateObject.Invoke("getHour", new System.Type[0], args)));
        return ret;
    }
    
    internal int getMinute() {
        object[] args = new object[0];
        int ret = ((int)(m_privateObject.Invoke("getMinute", new System.Type[0], args)));
        return ret;
    }
    
    internal global::System.DateTime getCalendar() {
        object[] args = new object[0];
        global::System.DateTime ret = ((global::System.DateTime)(m_privateObject.Invoke("getCalendar", new System.Type[0], args)));
        return ret;
    }
    
    public override string ToString() {
        object[] args = new object[0];
        string ret = ((string)(m_privateObject.Invoke("ToString", new System.Type[0], args)));
        return ret;
    }
    
    internal string toFullString() {
        object[] args = new object[0];
        string ret = ((string)(m_privateObject.Invoke("toFullString", new System.Type[0], args)));
        return ret;
    }
    
    internal global::test.com_nlf_calendar_SolarAccessor next(int days) {
        object[] args = new object[] {
                days};
        object _ret_val = m_privateObject.Invoke("next", new System.Type[] {
                    typeof(int)}, args);
        global::test.com_nlf_calendar_SolarAccessor _ret = null;
        if ((_ret_val != null)) {
            _ret = new global::test.com_nlf_calendar_SolarAccessor(_ret_val);
        }
        global::test.com_nlf_calendar_SolarAccessor ret = _ret;
        return ret;
    }
}
[System.Diagnostics.DebuggerStepThrough()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TestTools.UnitTestGeneration", "1.0.0.0")]
internal class com_nlf_calendar_util_HolidayUtilAccessor : BaseAccessor {
    
    protected static Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType m_privateType = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateType(typeof(global::LunarCore.util.HolidayUtil));
    
    internal com_nlf_calendar_util_HolidayUtilAccessor(global::LunarCore.util.HolidayUtil target) : 
            base(target, m_privateType) {
    }
    
    internal static int SIZE {
        get {
            int ret = ((int)(m_privateType.GetStaticField("SIZE")));
            return ret;
        }
        set {
            m_privateType.SetStaticField("SIZE", value);
        }
    }
    
    internal static char ZERO {
        get {
            char ret = ((char)(m_privateType.GetStaticField("ZERO")));
            return ret;
        }
        set {
            m_privateType.SetStaticField("ZERO", value);
        }
    }
    
    internal static string[] NAMES {
        get {
            string[] ret = ((string[])(m_privateType.GetStaticField("NAMES")));
            return ret;
        }
        set {
            m_privateType.SetStaticField("NAMES", value);
        }
    }
    
    internal static string DATA {
        get {
            string ret = ((string)(m_privateType.GetStaticField("DATA")));
            return ret;
        }
        set {
            m_privateType.SetStaticField("DATA", value);
        }
    }
    
    internal static global::LunarCore.util.HolidayUtil CreatePrivate() {
        object[] args = new object[0];
        Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject priv_obj = new Microsoft.VisualStudio.TestTools.UnitTesting.PrivateObject(typeof(global::LunarCore.util.HolidayUtil), new System.Type[0], args);
        return ((global::LunarCore.util.HolidayUtil)(priv_obj.Target));
    }
    
    internal static string padding(int n) {
        object[] args = new object[] {
                n};
        string ret = ((string)(m_privateType.InvokeStatic("padding", new System.Type[] {
                    typeof(int)}, args)));
        return ret;
    }
    
    internal static global::LunarCore.Holiday buildHolidayForward(string s) {
        object[] args = new object[] {
                s};
        global::LunarCore.Holiday ret = ((global::LunarCore.Holiday)(m_privateType.InvokeStatic("buildHolidayForward", new System.Type[] {
                    typeof(string)}, args)));
        return ret;
    }
    
    internal static global::LunarCore.Holiday buildHolidayBackward(string s) {
        object[] args = new object[] {
                s};
        global::LunarCore.Holiday ret = ((global::LunarCore.Holiday)(m_privateType.InvokeStatic("buildHolidayBackward", new System.Type[] {
                    typeof(string)}, args)));
        return ret;
    }
    
    internal static string findForward(string key) {
        object[] args = new object[] {
                key};
        string ret = ((string)(m_privateType.InvokeStatic("findForward", new System.Type[] {
                    typeof(string)}, args)));
        return ret;
    }
    
    internal static string findBackward(string key) {
        object[] args = new object[] {
                key};
        string ret = ((string)(m_privateType.InvokeStatic("findBackward", new System.Type[] {
                    typeof(string)}, args)));
        return ret;
    }
    
    internal static System.Collections.Generic.List<Holiday> findHolidaysForward(string key) {
        object[] args = new object[] {
                key};
        System.Collections.Generic.List<Holiday> ret = ((System.Collections.Generic.List<LunarCore.Holiday>)(m_privateType.InvokeStatic("findHolidaysForward", new System.Type[] {
                    typeof(string)}, args)));
        return ret;
    }
    
    internal static System.Collections.Generic.List<Holiday> findHolidaysBackward(string key) {
        object[] args = new object[] {
                key};
        System.Collections.Generic.List<Holiday> ret = ((System.Collections.Generic.List<Holiday>)(m_privateType.InvokeStatic("findHolidaysBackward", new System.Type[] {
                    typeof(string)}, args)));
        return ret;
    }
}
}
