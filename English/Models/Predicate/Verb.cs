using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Predicate
{
    /// <summary>
    /// Глагол.
    /// </summary>
    [DataContract]
    public class Verb
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
        /// Первая форма.
        /// </summary>
        [DataMember]
        public string FirstForm { get; private set; }

        /// <summary>
        /// Вторая форма.
        /// </summary>
        [DataMember]
        public string SecondForm { get; private set; }

        /// <summary>
        /// Третья форма.
        /// </summary>
        [DataMember]
        public string ThirdForm { get; private set; }

        /// <summary>
        /// Установка значений.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="translation"> Перевод. </param>
        /// <param name="firstForm"> Первая форма. </param>
        /// <param name="secondForm"> Вторая форма. </param>
        /// <param name="thirdForm"> Третья форма. </param>
        public Verb(string word, string transcription, string translation, string firstForm, string secondForm, string thirdForm)
        {
            Word = word;
            Transcription = transcription;
            Translation = translation;
            FirstForm = firstForm;
            SecondForm = secondForm;
            ThirdForm = thirdForm;
        }

        /// <summary>
        /// Установка значений если все 3 формы глагола одинаковы.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="translation"> Перевод. </param>
        public Verb(string word, string transcription, string translation)
        {
            Word = word;
            Transcription = transcription;
            Translation = translation;
            FirstForm = word;
            SecondForm = word;
            ThirdForm = word;
        }
    }
}
