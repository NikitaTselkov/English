using English.Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Subject
{
    /// <summary>
    /// Существительное.
    /// </summary>
    public class Noun : NounGroup
    {
        /// <summary>
        /// Установка значений для Существительного.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="plural"> Множественное число. </param>
        /// <param name="pluralTranscription"> Транскрипция Множественного числа. </param>
        /// <param name="translation"> Перевод. </param>
        public Noun(string word, string transcription, string plural, string pluralTranscription, string translation)
        {
            base.AddNewWord(word, transcription, plural, pluralTranscription, translation);
        }

    }
}
