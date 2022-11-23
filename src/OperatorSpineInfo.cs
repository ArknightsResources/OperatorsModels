namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员Spine相关信息的结构
    /// </summary>
    public readonly struct OperatorSpineInfo
    {
        /// <summary>
        /// Spine动画类别
        /// </summary>
        public OperatorSpineAnimationType Type { get; }

        /// <summary>
        /// Spine动画模型组类型
        /// </summary>
        public OperatorSpineModelSet ModelSet { get; }

        /// <summary>
        /// 干员图片代号
        /// </summary>
        public string ImageCodename { get; }

        /// <summary>
        /// 构造<see cref="OperatorSpineInfo"/>的新实例
        /// </summary>
        /// <param name="type">Spine动画类别</param>
        /// <param name="modelSet">Spine动画模型组类型</param>
        /// <param name="imageCodename">干员图片代号</param>
        public OperatorSpineInfo(OperatorSpineAnimationType type, OperatorSpineModelSet modelSet, string imageCodename)
        {
            Type = type;
            ModelSet = modelSet;
            ImageCodename = imageCodename;
        }
    }
}
