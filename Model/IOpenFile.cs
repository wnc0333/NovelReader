using System.Windows;

namespace NovelReader.Model
{
    /// <summary>
    /// 这个接口用于打开文件
    /// </summary>
    public interface IOpenFile : IStatusSender
    {
        /// <summary>
        /// 读取文件方法
        /// </summary>
        /// <param name="filePath">文本文档的路径</param>
        /// <param name="frameworkElement">要填充的容器</param>
       void ReadFile(string filePath,FrameworkElement frameworkElement);
    }
}
