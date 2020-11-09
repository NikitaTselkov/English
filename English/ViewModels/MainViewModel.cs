using English.Models.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.ViewModels
{
    public class MainViewModel : Navigation.NavigateViewModel
    {

       // public RelayCommand StartFindFractal { get; set; }

        public MainViewModel()
        {
           // StartFindFractal = new RelayCommand(StartFindFractalMethod);





            Pronoun pronoun = new Pronoun("hi", "[hi]", "hi", "hi", "привет", TypesOfPronouns.Personal);

            Noun noun = new Noun("hi", "[hi]", "hi", "hi", "привет");

            Adjective adjective = new Adjective("red", "[raed]", "красный");


            
            
            Console.WriteLine(pronoun.Word);
            Console.WriteLine(pronoun.Translation);


        }

        //public void StartFindFractalMethod(object param)
        //{ 
        
        //}


    }
}
