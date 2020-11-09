using English.Models.Predicate;
using English.Models.Subject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace English.ViewModels
{
    public class MainViewModel : Navigation.NavigateViewModel
    {

        #region Списки

        /// <summary>
        /// Список глаголов.
        /// </summary>
        public List<Verb> LibraryVerbs { get; set; }

        /// <summary>
        /// Список существительных.
        /// </summary>
        public List<Noun> LibraryNouns { get; set; }

        /// <summary>
        /// Список местоимений.
        /// </summary>
        public List<Pronoun> LibraryPronouns { get; set; }

        /// <summary>
        /// Список прилагательных.
        /// </summary>
        public List<Adjective> LibraryAdjectives { get; set; }

        #endregion

        #region Пути

        /// <summary>
        /// Путь к списку глаголов.
        /// </summary>
        private const string LIBRARY_VERBS_PATH = "LibraryVerbs.json";

        /// <summary>
        /// Путь к списку существительных.
        /// </summary>
        private const string LIBRARY_NOUNS_PATH = "LibraryNouns.json";

        /// <summary>
        /// Путь к списку местоимений.
        /// </summary>
        private const string LIBRARY_PRONOUNS_PATH = "LibraryPronouns.json";

        /// <summary>
        /// Путь к списку прилагательных.
        /// </summary>
        private const string LIBRARY_ADJECTIVE_PATH = "LibraryAdjectives.json";

        #endregion

        public MainViewModel()
        {
            // Получение данных.
            GetData();

            #region

            //Pronoun pronoun = new Pronoun("I", "[ai]", "we", "[we]", "я", "мы", TypesOfPronouns.Personal);

            //Noun noun = new Noun("cat", "[caet]", "cats", "[caets]", "кот", "коты");

            //Adjective adjective = new Adjective("red", "[raed]", "красный");

            //Verb verb = new Verb("read", "[read]", "читать");

            //LibraryVerbs.Add(verb);

            //LibraryPronouns.Add(pronoun);
            //LibraryNouns.Add(noun);
            //LibraryAdjectives.Add(adjective);

            #endregion

            // Сохранение данных.
            SaveData();
        }

        /// <summary>
        /// Метод сохраняющий данные.
        /// </summary>
        private void SaveData()
        {
            // Сохранение списка существительных.
            Save(LIBRARY_NOUNS_PATH, LibraryNouns);

            // Сохранение списка местоимений.
            Save(LIBRARY_PRONOUNS_PATH, LibraryPronouns);

            // Сохранение списка подлежащих.
            Save(LIBRARY_ADJECTIVE_PATH, LibraryAdjectives);

            // Сохранение списка прилагательных.
            Save(LIBRARY_VERBS_PATH, LibraryVerbs);
        }

        /// <summary>
        /// Метод помещающий данные в списки.
        /// </summary>
        private void GetData()
        {
            // Загружает данные в список глаголов.
            LibraryVerbs = Load<List<Verb>>(LIBRARY_VERBS_PATH);

            // Загружает данные в список существительных.
            LibraryNouns = Load<List<Noun>>(LIBRARY_NOUNS_PATH);

            // Загружает данные в список местоимений.
            LibraryPronouns = Load<List<Pronoun>>(LIBRARY_PRONOUNS_PATH);

            // Загружает данные в список прилагательных.
            LibraryAdjectives = Load<List<Adjective>>(LIBRARY_ADJECTIVE_PATH);

            // Провека на null.
            if (LibraryVerbs == null)
            {
                LibraryVerbs = new List<Verb>();
            }
            if (LibraryNouns == null)
            {
                LibraryNouns = new List<Noun>();
            }
            if (LibraryPronouns == null)
            {
                LibraryPronouns = new List<Pronoun>();
            }
            if (LibraryAdjectives == null)
            {
                LibraryAdjectives = new List<Adjective>();
            }
        }

        /// <summary>
        /// Метод сохранения.
        /// </summary>
        /// <typeparam name="T"> Тип сохраняемого обьекта. </typeparam>
        /// <param name="path"> Путь сохранения. </param>
        /// <param name="file"> Сохраняемый обьект. </param>
        private void Save<T>(string path, T file)
        {
            var formatter = new DataContractJsonSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.Create))
            {
                formatter.WriteObject(fs, file);
            }
        }

        /// <summary>
        /// Метод загрузки данных.
        /// </summary>
        /// <typeparam name="T"> Тип сохраняемого обьекта. </typeparam>
        /// <param name="path"> Путь сохранения. </param>
        /// <returns> Загружаемый обьект. </returns>
        private T Load<T>(string path)
        {
            var formatter = new DataContractJsonSerializer(typeof(T));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0)
                {
                    if (formatter.ReadObject(fs) is T file)
                    {
                        return file;
                    }
                    else
                    {
                        return default;
                    }
                }
                return default;
            }
        }


    }
}
