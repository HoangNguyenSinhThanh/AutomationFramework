using System;
using System.Collections.Generic;

namespace Framework.Command
{
    public class TurnOffLight0 : ICommand
    {
        public string generateCmd()
        {
            return "UART:0,1";
        }
    }
}