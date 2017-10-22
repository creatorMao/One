using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One.Model
{
    public class PromptManager
    {
        MainPage mainPage = new MainPage();

        public void SetPrompt(string prompt)
        {
            mainPage.SetPrompt(prompt);
        }
    }
}
