using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelReader.Model
{
    /// <summary>
    /// 用来发送状态更改通知的接口
    /// </summary>
    public interface IStatusSender
    {
        void AddIStatusRecipient(IStatusRecipient statusNotify);

        void DeleteIStatusRecipient(IStatusRecipient statusNotify);
    }
}
