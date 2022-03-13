using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员职业的结构
    /// </summary>
    public struct OperatorClass
    {
        /// <summary>
        /// 初始化<see cref="OperatorClass"/>结构的新实例
        /// </summary>
        /// <param name="mainClass">干员的主要职业</param>
        /// <param name="branchClass">干员的分支职业</param>
        public OperatorClass(OperatorMainClass mainClass, OperatorBranchClass branchClass)
        {
            MainClass = mainClass;
            BranchClass = branchClass;
        }

        /// <summary>
        /// 干员的主要职业
        /// </summary>
        [XmlAttribute]
        public OperatorMainClass MainClass;

        /// <summary>
        /// 干员的分支职业
        /// </summary>
        [XmlAttribute]
        public OperatorBranchClass BranchClass;
    }
}
