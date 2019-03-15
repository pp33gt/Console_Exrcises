using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Grades
{
    class SpeechSynthesis
    {

        public void Speek()
        {
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            var voices = speechSynthesizer.GetInstalledVoices();
            foreach (var voice in voices)
            {
                if (voice.Enabled)
                {
                    speechSynthesizer.SelectVoice(voice.VoiceInfo.Name);
                    speechSynthesizer.Speak("Hi, I'm " + voice.VoiceInfo.Name + ", I welcomes you to the grade book!");
                }
            }

        }
    }
}
