using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Trainer
    {
        private readonly ISpeaker speaker;

        public Trainer()
        {
            speaker = new QuietSpeaker();
        }

        public void BeginTraining()
        {
            speaker.Speak("Time to sweat");
        }


    }
}
