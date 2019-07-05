namespace Interfaces
{
    interface ISwitchable
    {
        /// <summary>
        /// 获取一个值，指示是否处于打开状态。
        /// </summary>
        bool IsOn { get; }

        /// <summary>
        /// 打开。
        /// </summary>
        void Open();

        /// <summary>
        /// 关闭。
        /// </summary>
        void Close();
    }
}
