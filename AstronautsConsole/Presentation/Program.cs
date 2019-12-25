using System;
using AstronautsConsole.Presentation;
using AstronautsConsole.Services;

namespace AstronautsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ViewModel viewModel = new ViewModel(new Api());
            viewModel.ShowListOfAstronauts();
        }
    }
}
