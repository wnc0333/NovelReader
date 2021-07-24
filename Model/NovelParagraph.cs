using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovelReader.Model
{
    /// <summary>
    /// 这个类用来保存具体的txt段落
    /// </summary>
    public class NovelParagraph
    {
        // 行号
        public int LineNumber { get; set; }

        // 段落内容
        public string ParagraphContent { get; set; }
    }
}
