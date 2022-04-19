using System;
using System.Collections.Generic;

namespace Framework.Command
{
    public class TurnOffLight1 : ICommand
    {
        string generateCmd()
        {
            return "UART:1,1"
        }
    }
}