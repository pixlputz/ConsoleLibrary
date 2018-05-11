using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleLibrary.Utils
{
    public class MenuOption
    {
        public Action Action { get; set; }
        public string Description { get; set; }

        public MenuOption(Action action, string description)
        {
            Action = action;
            Description = description;
        }
    }
}
