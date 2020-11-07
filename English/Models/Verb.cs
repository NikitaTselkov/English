using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.Models
{
    /// <summary>
    /// Глагол.
    /// </summary>
    public class Verb
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
        /// Первая форма.
        /// </summary>
        public string FirstForm { get; private set; }

        /// <summary>
        /// Вторая форма.
        /// </summary>
        public string SecondForm { get; private set; }

        /// <summary>
        /// Третья форма.
        /// </summary>
        public string ThirdForm { get; private set; }
    }
}
