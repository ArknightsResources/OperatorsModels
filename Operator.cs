using System.Diagnostics;
using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员的类
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public sealed class Operator
    {
        /// <summary>
        /// 干员名称
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// 干员生日
        /// </summary>
        public OperatorBirthday Birthday { get; set; }

        /// <summary>
        /// 干员星级
        /// </summary>
        [XmlAttribute]
        public short Star { get; set; }

        /// <summary>
        /// 干员性别
        /// </summary>
        [XmlAttribute]
        public OperatorGender Gender { get; set; }

        /// <summary>
        /// 干员立绘图代号
        /// </summary>
        [XmlAttribute]
        public string ImageCodename { get; set; }

        /// <summary>
        /// 干员信息
        /// </summary>
        [XmlArrayItem(elementName: "Info")]
        public OperatorInfo[] Information { get; set; }

        /// <summary>
        /// 干员档案
        /// </summary>
        [XmlArrayItem(elementName: "Profile")]
        public OperatorProfile[] Profiles { get; set; }

        private string GetDebuggerDisplay() => Name;
    }
}
