using System.Diagnostics;
using System.Xml;
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
        /// 使用指定的参数构造<see cref="Operator"/>的新实例
        /// </summary>
        /// <param name="name">干员名称</param>
        /// <param name="star">干员星级</param>
        /// <param name="imageCodename">干员图像代号</param>
        /// <param name="gender">干员性别</param>
        /// <param name="birthday">干员生日</param>
        /// <param name="class">干员职业</param>
        /// <param name="illustrations">干员立绘信息</param>
        /// <param name="voices">干员配音信息</param>
        /// <param name="profiles">干员档案信息</param>
        public Operator(string name, byte star, string imageCodename, OperatorGender gender, OperatorBirthday? birthday, OperatorClass @class, OperatorIllustrationInfo[] illustrations, OperatorVoiceInfo[] voices, OperatorProfile[] profiles)
        {
            Name = name;
            Star = star;
            ImageCodename = imageCodename;
            Gender = gender;
            Birthday = birthday;
            Class = @class;
            Illustrations = illustrations;
            Voices = voices;
            Profiles = profiles;
        }

        /// <summary>
        /// 
        /// </summary>
        public Operator()
        {
            //For serialize
        }


        /// <summary>
        /// 干员名称
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// 干员星级
        /// </summary>
        [XmlAttribute]
        public byte Star { get; set; }

        /// <summary>
        /// 干员立绘图代号
        /// </summary>
        [XmlAttribute]
        public string ImageCodename { get; set; }

        /// <summary>
        /// 干员性别
        /// </summary>
        [XmlAttribute]
        public OperatorGender Gender { get; set; }

        /// <summary>
        /// 干员生日
        /// </summary>
        public OperatorBirthday? Birthday { get; set; }

        /// <summary>
        /// 干员职业
        /// </summary>
        [XmlElement]
        public OperatorClass Class { get; set; }

        /// <summary>
        /// 干员的立绘信息
        /// </summary>
        [XmlArrayItem(elementName: "Illustration")]
        public OperatorIllustrationInfo[] Illustrations { get; set; }

        /// <summary>
        /// 干员的配音信息
        /// </summary>
        [XmlArrayItem(elementName: "Voice")]
        public OperatorVoiceInfo[] Voices { get; set; }

        /// <summary>
        /// 干员档案
        /// </summary>
        [XmlArrayItem(elementName: "Profile")]
        public OperatorProfile[] Profiles { get; set; }

        private string GetDebuggerDisplay() => Name;
    }
}
