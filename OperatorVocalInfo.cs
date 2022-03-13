using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员配音信息的结构
    /// </summary>
    public struct OperatorVoiceInfo
    {
        /// <summary>
        /// 初始化<see cref="OperatorVoiceInfo"/>结构的新实例
        /// </summary>
        /// <param name="voice">配音人员</param>
        /// <param name="type">配音的语言种类</param>
        public OperatorVoiceInfo(string voice, OperatorVocalType type)
        {
            Voice = voice;
            Type = type;
        }

        /// <summary>
        /// 干员配音人员
        /// </summary>
        [XmlAttribute]
        public string Voice;

        /// <summary>
        /// 干员配音的语言种类
        /// </summary>
        [XmlAttribute]
        public OperatorVocalType Type;
    }
}
