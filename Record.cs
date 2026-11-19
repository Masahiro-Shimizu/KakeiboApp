using System;
using System.Collections.Generic;
using System.Text;

namespace KakeiboApp
{
    internal class Record
    {
        public DateTime Date { get; set; }
        public string Category { get; set; } = "";
        public int Amount { get; set; }
        public bool IsIncome { get; set; }
        //　お店
        public string Shop { get; set; } = "";
        public string Memo { get; set; } = "";

        //　収入か支出かを文字列で返す
        // IsIncome ? は「IsIncome が true なら"収入"、そうでなければ"支出"」(if を1行に縮めた書き方で、三項演算子と言います)
        public string Kind => IsIncome ? "収入" : "支出"; // 値を覚えておくのではなく、「聞かれるたびにこの式で答える」プロパティ

        
    }
}
