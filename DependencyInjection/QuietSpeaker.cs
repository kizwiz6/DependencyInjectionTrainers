using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class QuietSpeaker : ISpeaker
    {
        public void Speak(string message)
        {
            Console.WriteLine("..." + message.ToLower() + "...");
        }
    }
}
