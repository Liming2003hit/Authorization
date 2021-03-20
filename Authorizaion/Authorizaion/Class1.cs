using System;

namespace Authorizaion
{
    public class CompareData
    {
        /// <summary>
        /// 比较日期的类
        /// </summary>
        /// <param name="datelimitstr">传入一个字符串，代表日期限值，格式如"2021-4-01 00:00:00"，超过该日期，软件不能使用</param>
        /// <returns>返回true代表现实比现在时间晚,没到限时.false代表限时比现在时间早,过了试用期了.</returns>
        public bool DataCompare(string datelimitstr)
        {
            DateTime datelimit = DateTime.Parse(datelimitstr);
            DateTime datenow = DateTime.Now;
            if (DateTime.Compare(datelimit, datenow) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
