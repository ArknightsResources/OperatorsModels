using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员生日的结构
    /// </summary>
    public struct OperatorBirthday
    {
        /// <summary>
        /// 初始化<see cref="OperatorBirthday"/>结构的新实例
        /// </summary>
        /// <param name="month">月份</param>
        /// <param name="day">天</param>
        public OperatorBirthday(byte month, byte day)
        {
            Month = month;
            Day = day;
        }

        /// <summary>
        /// 生日日期中的月份
        /// </summary>
        [XmlAttribute]
        public byte Month;

        /// <summary>
        /// 生日日期中的天
        /// </summary>
        [XmlAttribute]
        public byte Day;
    }
}
