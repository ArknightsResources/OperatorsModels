using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员信息的结构
    /// </summary>
    [StructLayout(LayoutKind.Auto)]
    [Obsolete("已经弃用该结构")]
    public struct OperatorInfo
    {
        /// <summary>
        /// 此"干员信息"的种类
        /// </summary>
        [XmlAttribute]
        public OperatorType Type;

        /// <summary>
        /// 干员画师
        /// </summary>
        [XmlAttribute]
        [Obsolete("请使用新的OperatorVocalInfo结构")]
        public string Illustrator;

        /// <summary>
        /// 干员外语配音
        /// </summary>
        [XmlAttribute]
        [Obsolete("请使用新的OperatorVocalInfo结构")]
        public string ForeignCV;

        /// <summary>
        /// 干员中文配音
        /// </summary>
        [XmlAttribute]
        [Obsolete("请使用新的OperatorVocalInfo结构")]
        public string ChineseCV;

        /// <summary>
        /// 干员职业
        /// </summary>
        [XmlAttribute("OperatorClass")]
        public OperatorMainClass Class;

        /// <summary>
        /// 干员皮肤信息
        /// </summary>
        [Obsolete("请使用新的OperatorIllustrationInfo结构")]
        public OperatorSkinInfo? SkinInfo;
    }
}
