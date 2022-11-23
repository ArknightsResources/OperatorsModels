using System;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员生日的结构
    /// </summary>
    public readonly struct OperatorBirthday : IEquatable<OperatorBirthday>
    {
        /// <summary>
        /// 初始化<see cref="OperatorBirthday"/>结构的新实例
        /// </summary>
        /// <param name="month">月份</param>
        /// <param name="day">天</param>
        [JsonConstructor]
        public OperatorBirthday(int month, int day)
        {
            Month = month;
            Day = day;
        }

        /// <summary>
        /// 生日日期中的月份
        /// </summary>
        public int Month { get; }

        /// <summary>
        /// 生日日期中的天
        /// </summary>
        public int Day { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is OperatorBirthday birthday && Equals(birthday);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorBirthday other)
        {
            return Month == other.Month && Day == other.Day;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 37050634;
            hashCode = hashCode * -1521134295 + Month.GetHashCode();
            hashCode = hashCode * -1521134295 + Day.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator ==(OperatorBirthday left, OperatorBirthday right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static bool operator !=(OperatorBirthday left, OperatorBirthday right)
        {
            return !(left == right);
        }
    }
}
