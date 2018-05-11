using DataLibrary.Models;
using DataLibrary;
using System;
using ConsoleLibrary.Services;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryService ls = new LibraryService();
            while (ls.Running)
            {
                ls.LibrarySelection();

            }





        }
    }
}
