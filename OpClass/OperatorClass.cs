using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员职业的结构
    /// </summary>
    public readonly struct OperatorClass
    {
        /// <summary>
        /// 初始化<see cref="OperatorClass"/>结构的新实例
        /// </summary>
        /// <param name="mainClass">干员的主要职业</param>
        /// <param name="branchClass">干员的分支职业</param>
        [JsonConstructor]
        public OperatorClass(OperatorMainClass mainClass, OperatorBranchClass branchClass)
        {
            MainClass = mainClass;
            BranchClass = branchClass;
        }

        /// <summary>
        /// 干员的主要职业
        /// </summary>
        public OperatorMainClass MainClass { get; }

        /// <summary>
        /// 干员的分支职业
        /// </summary>
        public OperatorBranchClass BranchClass { get; }
    }
}
