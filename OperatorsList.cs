using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 干员列表
    /// </summary>
    [XmlRoot("OperatorsList",Namespace = "http://schema.livestudio.com/Operators.xsd"), XmlType("OperatorsList", Namespace = "http://schema.livestudio.com/Operators.xsd")]
    public sealed class OperatorsList
    {
        /// <summary>
        /// 包含<see cref="Operator"/>对象的数组
        /// </summary>
        [XmlElement(ElementName = "Operator")]
        [JsonIgnore]
        public Operator[] OperatorList { get; set; }

        /// <summary>
        /// 包含<see cref="Operator"/>对象的字典
        /// </summary>
        
        public Dictionary<string, Operator> Operators { get; set; }
    }
}
