using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示一条干员语音的结构
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public readonly struct OperatorVoiceItem : IEquatable<OperatorVoiceItem>
    {
        /// <summary>
        /// 初始化<see cref="OperatorVoiceItem"/>结构的新实例
        /// </summary>
        /// <param name="charactorCodename">该条语音所属干员的内部代号</param>
        /// <param name="voiceId">该条语音的包内ID(如"CN_007")</param>
        /// <param name="voiceTitle">该条语音的标题(如"信赖提升后交谈1")</param>
        /// <param name="voiceText">该条语音的文本</param>
        /// <param name="voiceType">该条语音的语言种类</param>
        [JsonConstructor]
        public OperatorVoiceItem(string charactorCodename, string voiceId, string voiceTitle, string voiceText, OperatorVoiceType voiceType)
        {
            CharactorCodename = charactorCodename;
            VoiceId = voiceId;
            VoiceTitle = voiceTitle;
            VoiceText = voiceText;
            VoiceType = voiceType;
        }

        /// <summary>
        /// 该条语音所属干员的内部代号
        /// </summary>
        public string CharactorCodename { get; }

        /// <summary>
        /// 该条语音的ID
        /// </summary>
        public string VoiceId { get; }

        /// <summary>
        /// 该条语音的标题
        /// </summary>
        public string VoiceTitle { get; }

        /// <summary>
        /// 该条语音的文本
        /// </summary>
        public string VoiceText { get; }

        /// <summary>
        /// 该条语音的语言
        /// </summary>
        public OperatorVoiceType VoiceType { get; }

        private string GetDebuggerDisplay()
        {
            return $"{CharactorCodename}, {VoiceId}, {VoiceTitle}, {VoiceType}:{VoiceText}";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is OperatorVoiceItem item && Equals(item);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorVoiceItem other)
        {
            return CharactorCodename == other.CharactorCodename &&
                   VoiceId == other.VoiceId &&
                   VoiceTitle == other.VoiceTitle &&
                   VoiceText == other.VoiceText &&
                   VoiceType == other.VoiceType;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -1345095473;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CharactorCodename);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VoiceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VoiceTitle);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VoiceText);
            hashCode = hashCode * -1521134295 + EqualityComparer<OperatorVoiceType>.Default.GetHashCode(VoiceType);
            return hashCode;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperatorVoiceItem left, OperatorVoiceItem right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperatorVoiceItem left, OperatorVoiceItem right)
        {
            return !(left == right);
        }
    }
}