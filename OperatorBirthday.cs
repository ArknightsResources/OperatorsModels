using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员生日的结构
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public struct OperatorBirthday
    {
        /// <summary>
        /// 生日日期中的月份月份
        /// </summary>
        [XmlAttribute]
        public int Month;

        /// <summary>
        /// 生日日期中的天
        /// </summary>
        [XmlAttribute]
        public int Day;
    }
}
