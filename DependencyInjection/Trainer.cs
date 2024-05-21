using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Trainer
    {
        private readonly ISpeaker _speaker;

        public Trainer(ISpeaker speaker)
        {
            _speaker = speaker;
        }

        public void BeginTraining()
        {
            _speaker.Speak("Time to sweat");
        }
    }
}
