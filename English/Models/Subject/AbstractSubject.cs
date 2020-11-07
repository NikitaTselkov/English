using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Subject
{
    /// <summary>
    /// Подлежащее.
    /// </summary>
    public abstract class AbstractSubject
    {
        /// <summary>
        /// Слово.
        /// </summary>
        public string Word { get; private set; }

        /// <summary>
        /// Транскрипция.
        /// </summary>
        public string Transcription { get; private set; }

        /// <summary>
        /// Множественное число.
        /// </summary>
        public string Plural { get; private set; }

        /// <summary>
        /// Транскрипция Множественного числа.
        /// </summary>
        public string PluralTranscription { get; private set; }

        /// <summary>
        /// Установка значений.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="plural"> Множественное число. </param>
        /// <param name="pluralTranscription"> Транскрипция Множественного числа. </param>
        public AbstractSubject(string word, string transcription, string plural, string pluralTranscription)
        {
            Word = word;
            Transcription = transcription;
            Plural = plural;
            PluralTranscription = pluralTranscription;
        }

        public AbstractSubject() { }
    }
}
