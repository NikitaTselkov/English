using English.Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Subject
{
    /// <summary>
    /// Местоимение.
    /// </summary>
    public class Pronoun : NounGroup
    {
        /// <summary>
        /// Тип местоимения.
        /// </summary>
        public TypesOfPronouns TypeOfPronoun { get; private set; }

        /// <summary>
        /// Установка значений для местоимения.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="plural"> Множественное число. </param>
        /// <param name="pluralTranscription"> Транскрипция Множественного числа. </param>
        /// <param name="translation"> Перевод. </param>
        /// <param name="typeOfPronoun"> Тип местоимения. </param>
        public Pronoun(string word, string transcription, string plural, string pluralTranscription, string translation, TypesOfPronouns typeOfPronoun)
        {
            base.AddNewWord(word, transcription, plural, pluralTranscription, translation);

            TypeOfPronoun = typeOfPronoun;
        }

    }
}
