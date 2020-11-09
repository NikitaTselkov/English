using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Models.Subject
{
    /// <summary>
    /// Прилагательное.
    /// </summary>
    public class Adjective : NounGroup
    {
        /// <summary>
        /// Установка значений для Существительного.
        /// </summary>
        /// <param name="word"> Слово. </param>
        /// <param name="transcription"> Транскрипция. </param>
        /// <param name="translation"> Перевод. </param>
        public Adjective(string word, string transcription, string translation)
        {
            base.AddNewWord(word, transcription, "", "", translation);
        }

    }
}
