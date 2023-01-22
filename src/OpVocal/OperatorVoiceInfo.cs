using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员配音信息的结构
    /// </summary>
    public readonly struct OperatorVoiceInfo : IEquatable<OperatorVoiceInfo>
    {
        /// <summary>
        /// 初始化<see cref="OperatorVoiceInfo"/>结构的新实例
        /// </summary>
        /// <param name="cv">配音人员</param>
        /// <param name="type">配音的语言种类</param>
        /// <param name="voices">语音条目</param>
        [JsonConstructor]
        public OperatorVoiceInfo(string cv, OperatorVoiceType type, OperatorVoiceItem[] voices)
        {
            CV = cv;
            Type = type;
            Voices = voices;
        }

        /// <summary>
        /// 干员配音人员
        /// </summary>
        public string CV { get; }

        /// <summary>
        /// 干员配音的语言种类
        /// </summary>
        public OperatorVoiceType Type { get; }

        /// <summary>
        /// 干员的语音条目
        /// </summary>
        public OperatorVoiceItem[] Voices { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is OperatorVoiceInfo info && Equals(info);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorVoiceInfo other)
        {
            return CV == other.CV &&
                   Type == other.Type &&
                   Voices.SequenceEqual(other.Voices);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 291305966;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CV);
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<OperatorVoiceItem[]>.Default.GetHashCode(Voices);
            return hashCode;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperatorVoiceInfo left, OperatorVoiceInfo right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperatorVoiceInfo left, OperatorVoiceInfo right)
        {
            return !(left == right);
        }
    }
}
