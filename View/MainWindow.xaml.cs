using NovelReader.Model;
using System.Windows;
using NovelReader.ViewModel;
using System.IO;

namespace NovelReader.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// 实现接收状态更改通知接口
    /// </summary>
    public partial class MainWindow : Window ,IStatusRecipient
    {
        // ViewModel对象
        TxtFileOpener openFile = new TxtFileOpener();

        public MainWindow()
        {
            InitializeComponent();

            

            // 绑定数据上下文
            this.DataContext = openFile;

            // 添加状态接收者
            openFile.AddIStatusRecipient(this);
        }

        //状态通知
        public void StatusUpdate(Status status)
        {
            statusControl.Text = status.StatusString;
        }

        /// <summary>
        /// 打开文件
        /// </summary>
        /// <param name="sender">事件源</param>
        /// <param name="e">事件参数</param>
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            string filePath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName
                + @"\小说\放开那个女巫.txt";
            //string filePath = @"G:\书\造化之王.txt";

            
            // 读取文件
            openFile.ReadFile(filePath,DisplayPanel);
        }

    }
}
