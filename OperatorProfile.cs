using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员档案的结构
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    public struct OperatorProfile
    {
        /// <summary>
        /// 该档案的内容
        /// </summary>
        [XmlText]
        public string Profile;

        /// <summary>
        /// 该档案的类型
        /// </summary>
        [XmlAttribute]
        public OperatorProfileType Type;
    }
}
