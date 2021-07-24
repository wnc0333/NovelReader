using NovelReader.Common;
using NovelReader.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace NovelReader.ViewModel
{
    /// <summary>
    /// 打开Txt文件的类
    /// </summary>
    public class TxtFileOpener : NotificationObject,IOpenFile
    {
        // 用于存放文本内容的列表
        ObservableCollection<NovelParagraph> txtList = new ObservableCollection<NovelParagraph>();
        public ObservableCollection<NovelParagraph> TxtList
        {
            get { return txtList; }
            set 
            { txtList=value;
                this.RaisePropertyChanged("TxtList");
            }
        }

        // 用于存放实现了状态通知接口的类
        List<IStatusRecipient> listStatusRecipient = new List<IStatusRecipient>();

        // 状态属性
        Status status = new Status();

        /// <summary>
        /// 读取Txt文件
        /// </summary>
        /// <param name="filePath">文本文档的路径</param>
        public void ReadFile(string filePath, FrameworkElement frameworkElement)
        {
            // 打开文本文档
            OpenTxt(filePath, frameworkElement);
        }

        public void OpenTxt(string filePath, FrameworkElement frameworkElement)
        {
            // 先清空列表
            CleanTxtList();

            UpdateStatus("正在打开文件");

            ListBox listBox = frameworkElement as ListBox;
            
            Task.Run(() => {
                // 读取txt文件并填充列表
                using (StreamReader sr = new StreamReader(filePath, Encoding.Default))
                {
                    int lineCount = 0;
                    while (sr.Peek() > 0)
                    {
                        lineCount++;
                        string temp = sr.ReadLine();

                        listBox.Dispatcher.Invoke(new Action(() =>
                        {
                            //txtLineIndex.Add(lineCount);
                            //txtList.Add(temp);
                            txtList.Add(new NovelParagraph()
                            {
                                LineNumber = lineCount,
                                ParagraphContent = temp
                            });
                        }));
                    }

                    listBox.Dispatcher.Invoke(new Action(() =>
                    {
                        UpdateStatus("文件打开完毕");
                    }));
                   
                }
            });

        }

        /// <summary>
        /// 清空列表
        /// </summary>
        private void CleanTxtList()
        {
            //如果文本列表不为空，则先清空
            if (txtList.Count!=0)
            {
                txtList.Clear();
            }
        }

        #region 添加、删除实现了状态通知的列表项，通知方法，更新通知

        /// <summary>
        /// 添加通知
        /// </summary>
        /// <param name="statusRecipient">实现了 IStatusRecipient 的类</param>
        public void AddIStatusRecipient(IStatusRecipient statusRecipient)
        {
            listStatusRecipient.Add(statusRecipient);
        }

        /// <summary>
        /// 删除通知
        /// </summary>
        /// <param name="statusRecipient">实现了 IStatusRecipient 的类</param>
        public void DeleteIStatusRecipient(IStatusRecipient statusRecipient)
        {
            listStatusRecipient.Remove(statusRecipient);
        }

        /// <summary>
        /// 更新状态，并通知各个观察者
        /// </summary>
        private void UpdateStatus(string statusString)
        {
            status.StatusString = statusString;
            StatusNotify();
        }

        /// <summary>
        /// 通知各个观察者
        /// </summary>
        private void StatusNotify()
        {
            foreach (var iStatusRecipient in listStatusRecipient)
            {
                iStatusRecipient.StatusUpdate(status);
            }
        }

        #endregion


    }
}
