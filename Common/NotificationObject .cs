using System.ComponentModel;

namespace NovelReader.Common
{
    public abstract class NotificationObject : INotifyPropertyChanged
    {
        // 属性更改事件
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 发起通知
        /// </summary>
        /// <param name="propertyName">属性名</param>
        public void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
