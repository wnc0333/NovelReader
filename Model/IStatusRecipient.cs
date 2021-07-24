namespace NovelReader.Model
{
    /// <summary>
    /// 用来接收状态更改通知的接口
    /// </summary>
    public interface IStatusRecipient
    {
        /// <summary>
        /// 通知方法
        /// </summary>
        void StatusUpdate(Status status);

    }
}
