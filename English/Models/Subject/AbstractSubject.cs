using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Subject
{
    /// <summary>
    /// Подлежащее.
    /// </summary>
    [DataContract]
    public abstract class AbstractSubject
    {
        /// <summary>
        /// Слово.
        /// </summary>
        [DataMember]
        public string Word { get; private set; }

        /// <summary>
        /// Транскрипция.
        /// </summary>
        [DataMember]
        public string Transcription { get; private set; }

        /// <summary>
        /// Перевод.
        /// </summary>
        [DataMember]
        public string Translation { get; private set; }

        /// <summary>
        /// Множественное число.
        /// </summary>
        [DataMember]
        public string Plural { get; private set; }

        /// <summary>
        /// Транскрипция Множественного числа.
        /// </summary>
        [DataMember]
        public string PluralTranscription { get; private set; }

        /// <summary>
        /// Перевод множественного числа.
        /// </summary>
        [DataMember]
        public string PluralTranslation { get; private set; }

        /// <summary>
        /// Установка значений.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="plural"> Множественное число. </param>
        /// <param name="pluralTranscription"> Транскрипция Множественного числа. </param>
        /// <param name="translation"> Перевод. </param>
        /// <param name="pluralTranslation"> Перевод множественного числа. </param>
        protected void AddNewWord(string word, string transcription, string plural, string pluralTranscription, string translation, string pluralTranslation)
        {
            Word = word;
            Transcription = transcription;
            Plural = plural;
            PluralTranscription = pluralTranscription;
            Translation = translation;
            PluralTranslation = pluralTranslation;
        }

        public AbstractSubject() { }
    }
}
