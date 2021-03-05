using System;

namespace App1
{
    public class Icommand
    {
        private Action<string> commandCliked;

        public Icommand(Action<string> commandCliked)
        {
            this.commandCliked = commandCliked;
        }
    }
}