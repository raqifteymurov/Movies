using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsUI.HELP
{
    public class helper
    {
        public bool IsNullOrEmpty(string text)
        {
            if (text == null | text == "") return true;
            return false;
        }
        public void Check(Func<string, bool> condition, string text, Action ifTrue, Action ifFalse)
        {
            if (!condition.Invoke(text))
            {
                ifTrue.Invoke();
            }
            else
            {
                ifFalse.Invoke();
            }
        }
        public void Check1(Func<string, bool> condition1, string text, Action iftrue)
        {
            if (!condition1.Invoke(text))
            {
                iftrue.Invoke();
            }
        }
    }
}
