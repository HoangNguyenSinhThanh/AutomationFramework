using System;
using System.Collections.Generic;

namespace Framework.Command
{
    public static final ICommand createCommand(CommandType commandType)
    {
        switch (commandType) {
            case On0:
                return new TurnOnLight0();
                break;
            case On1:
                return new TurnOnLight1();
                break;
            case Off0:
                return new TurnOffLight0();
                break;
            case Off1:
                return new TurnOffLight1();
                break;
            default:
                throw new IllegalArgumentException("This command type is unsupported");
        }
    }
}