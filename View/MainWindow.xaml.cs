using NovelReader.Model;
using System.Windows;
using NovelReader.ViewModel;
using System.IO;
using System.Windows.Input;
using System;
using System.Windows.Controls;
using System.Collections.Generic;

namespace NovelReader.View
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// 实现接收状态更改通知接口
    /// </summary>
    public partial class MainWindow : Window, IStatusRecipient
    {
        // ViewModel对象
        TxtFileOpener openFile = new TxtFileOpener();

        // 表示是否要进行自动隐蔽操作
        bool autoHidden = false;

        // 用来存储之前的显示面板状态
        List<double> previousDisplayPanelState = new List<double>();

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
            openFile.ReadFile(filePath, DisplayPanel);
        }

        /// <summary>
        /// 鼠标按下后拖动窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayPanel_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
            e.Handled = true;
        }

        //当鼠标双击时，自动显示
        private void DisplayPanel_PreviewMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // 如果处于隐蔽状态，则取消隐蔽，正常显示
            if (autoHidden)
            {
                // 设置自动隐蔽模式下的显示状态的显示面板状态
                SetVisibleDisplayPanelStateOfAutoHidden();
            }
        }

        // 当鼠标从显示板上移开时，进入隐蔽状态
        private void DisplayPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            if (autoHidden)
            {
                // 设置自动隐蔽模式下的隐蔽状态的显示面板状态
                SetHiddenDisplayPanelStateOfAutoHidden();
            }
        }

        // 设置自动隐蔽模式下的隐蔽状态的显示面板状态
        private void SetHiddenDisplayPanelStateOfAutoHidden()
        {
            DisplayPanel.Background.Opacity = 1;
            DisplayPanel.Opacity = 0.01;
        }

        // 设置自动隐蔽模式下的显示状态的显示面板状态
        private void SetVisibleDisplayPanelStateOfAutoHidden()
        {
            DisplayPanel.Background.Opacity = 0.01;
            DisplayPanel.Opacity = 1;
        }

        // 当是否屏蔽的勾选框值改变时
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // 保存非隐蔽状态也就是正常状态下的显示面板状态
            SaveNormalDisplayPanelState();

            autoHidden = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            autoHidden = false;

            RecoverNormalDisplayPanelState();
        }

        // 保存非隐蔽状态也就是正常状态下的显示面板状态
        private void SaveNormalDisplayPanelState()
        {
            previousDisplayPanelState.Clear();
            previousDisplayPanelState.Add(DisplayPanel.Opacity);
            previousDisplayPanelState.Add(DisplayPanel.Background.Opacity);
        } 
        
        // 恢复之前保存的非隐蔽状态也就是正常状态下的显示面板状态
        private void RecoverNormalDisplayPanelState()
        {
            DisplayPanel.Opacity=previousDisplayPanelState[0];
            DisplayPanel.Background.Opacity=previousDisplayPanelState[1];
        }
    }
}
