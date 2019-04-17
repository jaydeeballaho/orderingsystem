using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderingSystem
{
    class Validation
    {
        public string LetterWSpecial = " 1234567890ÑñabcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ-,./";
        public string NumberOnly = "1234567890";

        public bool isTextBoxEmpty(params TextBox[] obj)
        {
            for (int i = 0; i < obj.Length; i++)
            {
                if (obj[i].Text.Length == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public void AllowedOnly(string s, TextBox tb)
        {
            try
            {
                string theText = tb.Text;
                string Letter;
                int SelectionIndex = tb.SelectionStart;
                int Change = 0;
                for (int x = 0; x < tb.Text.Length; x++)
                {
                    Letter = tb.Text.Substring(x, 1);
                    if (s.Contains(Letter) == false)
                    {
                        theText = theText.Replace(Letter, string.Empty);
                        Change = 1;
                    }
                }
                tb.Text = theText;
                tb.Select(SelectionIndex - Change, 0);
            }
            catch
            {
                //
            }
        }
        
    }
}
