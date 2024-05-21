using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class LoudSpeaker : ISpeaker
    {
        public void Speak(string message)
        {
            Console.WriteLine(message.ToUpper() + "!");
        }
    }
}
