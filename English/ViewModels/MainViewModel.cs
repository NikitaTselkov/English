using English.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English.ViewModels
{
    public class MainViewModel : Navigation.NavigateViewModel
    {

        public RelayCommand StartFindFractal { get; set; }

        public MainViewModel()
        {
            StartFindFractal = new RelayCommand(StartFindFractalMethod);



        }

        public void StartFindFractalMethod(object param)
        { 
        
        }


    }
}
