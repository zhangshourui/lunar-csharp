using System;
using System.Collections.Generic;
using System.Text;
using LunarCore.util;
using LunarCore.eightchar;
using LunarCore;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ���� =====");
            // ����
            // Solar solar = new Solar(2020, 5, 26, 23, 42, 0);
            Console.Write("������");
            Solar solar = new Solar(DateTime.Now);
            Console.WriteLine(solar);
            Console.WriteLine(solar.toFullString());

            // ����
            Console.Write("������");
            Lunar lunar = solar.getLunar();
            Console.WriteLine(lunar);
            Console.WriteLine(lunar.toFullString());

            // ����
            Console.Write("���֣�");
            EightChar baZi = lunar.getEightChar();
            Console.WriteLine(baZi.getYear() + " " + baZi.getMonth() + " " + baZi.getDay() + " " + baZi.getTime());

            // ��������
            Console.Write("����������");
            Console.WriteLine(baZi.getYearNaYin() + " " + baZi.getMonthNaYin() + " " + baZi.getDayNaYin() + " " + baZi.getTimeNaYin());

            // ��������
            Console.Write("�������У�");
            Console.WriteLine(baZi.getYearWuXing() + " " + baZi.getMonthWuXing() + " " + baZi.getDayWuXing() + " " + baZi.getTimeWuXing());

            // �������ʮ��
            Console.Write("�������ʮ��");
            Console.WriteLine(baZi.getYearShiShenGan() + " " + baZi.getMonthShiShenGan() + " " + baZi.getDayShiShenGan() + " " + baZi.getTimeShiShenGan());

            // ���ֵ�֧ʮ��
            Console.Write("���ֵ�֧ʮ��");
            Console.WriteLine(baZi.getYearShiShenZhi()[0] + " " + baZi.getMonthShiShenZhi()[0] + " " + baZi.getDayShiShenZhi()[0] + " " + baZi.getTimeShiShenZhi()[0]);

            // ������֧ʮ��
            Console.Write("������֧ʮ��");
            foreach (string s in baZi.getYearShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            Console.Write("������֧ʮ��");
            foreach (string s in baZi.getMonthShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ������֧ʮ��
            Console.Write("������֧ʮ��");
            foreach (string s in baZi.getDayShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ����ʱ֧ʮ��
            Console.Write("����ʱ֧ʮ��");
            foreach (string s in baZi.getTimeShiShenZhi())
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();

            // ����̥Ԫ
            Console.Write("����̥Ԫ��");
            Console.WriteLine(baZi.getTaiYuan());

            // ��������
            Console.Write("����������");
            Console.WriteLine(baZi.getMingGong());

            // ������
            Console.Write("��������");
            Console.WriteLine(baZi.getShenGong());

            Console.WriteLine();


            //////////////////

            Console.WriteLine("===== ���� =====");


            solar = new Solar(1988, 3, 20, 18, 0, 0);
            lunar = solar.getLunar();
            EightChar bazi = lunar.getEightChar();

            // ����
            Console.Write("���ƣ��У���");
            Yun yun = bazi.getYun(1);
            Console.WriteLine("����" + solar.toYmdHms() + "����");
            Console.WriteLine("����" + yun.getStartYear() + "��" + yun.getStartMonth() + "����" + yun.getStartDay() + "�������");
            Console.WriteLine("����" + yun.getStartSolar().toYmd() + "������");
            Console.WriteLine();

            // �ڼ���
            //List<Holiday> holidays = HolidayUtil.getHolidays(2012);
            //foreach (Holiday holiday in holidays)
            //{
            //    Console.WriteLine(holiday);
            //}
            //Console.WriteLine();

            // ����ת����
            List<Solar> solars = Solar.fromBaZi("����", "����", "��î", "����");
            Console.Write("����ת������\"����\", \"����\", \"��î\", \"����\"����");
            foreach (Solar d in solars)
            {
                Console.WriteLine(d.toFullString());
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
