using System;
using System.Collections.Generic;
using System.Text;

namespace EF_ComicsDB
{
    class UserInteraction
    {
        public static int TableSelect()
        {
            Console.WriteLine("1) Autor");
            Console.WriteLine("2) Categoria");
            Console.WriteLine("3) Comic");
            Console.WriteLine("4) Exit");
            return int.Parse(Console.ReadLine())-1;
        }
        public static int ActionSelect()
        {
            Console.WriteLine("1) Create");
            Console.WriteLine("2) Read");
            Console.WriteLine("3) Update");
            Console.WriteLine("4) Delete");
            return int.Parse(Console.ReadLine()) - 1;
        }
        public static int IdData()
        {
            Console.WriteLine("Specify Id:");
            return int.Parse(Console.ReadLine());
        }

        //Autor
        public static string[] CreateAutorData()
        {
            string[] data = new string[3];
            Console.WriteLine("Name:");
            data[0] = Console.ReadLine();
            Console.WriteLine("Nationality:");
            data[1] = Console.ReadLine();
            Console.WriteLine("BirthDate:");
            data[2] = Console.ReadLine();
            return data;
        }
        public static string[] UpdateAutorData()
        {
            string[] data = new string[3];
            Console.WriteLine("Modify name(enter to not edit):");
            data[0] = Console.ReadLine();
            Console.WriteLine("Nationality(enter to not edit):");
            data[1] = Console.ReadLine();
            Console.WriteLine("BirthDate(enter to not edit):");
            data[2] = Console.ReadLine();
            return data;
        }

        //Categoria
        public static string[] CreateCategoriaData()
        {
            string[] data = new string[2];
            Console.WriteLine("Name:");
            data[0] = Console.ReadLine();
            Console.WriteLine("Description:");
            data[1] = Console.ReadLine();
            return data;
        }
        public static string[] UpdateCategoriaData()
        {
            string[] data = new string[2];
            Console.WriteLine("Modify name(enter to not edit):");
            data[0] = Console.ReadLine();
            Console.WriteLine("Description(enter to not edit):");
            data[1] = Console.ReadLine();
            return data;
        }

        //Comic
        public static string[] CreateComicData()
        {
            string[] data = new string[4];
            Console.WriteLine("Title:");
            data[0] = Console.ReadLine();
            Console.WriteLine("Description:");
            data[1] = Console.ReadLine();
            Console.WriteLine("Date:");
            data[2] = Console.ReadLine();
            Console.WriteLine("NumberPages:");
            data[3] = Console.ReadLine();
            return data;
        }
        public static string[] UpdateComicData()
        {
            string[] data = new string[4];
            Console.WriteLine("Modify title(enter to not edit):");
            data[0] = Console.ReadLine();
            Console.WriteLine("Description(enter to not edit):");
            data[1] = Console.ReadLine();
            Console.WriteLine("Date(enter to not edit):");
            data[2] = Console.ReadLine();
            Console.WriteLine("NumberPages(enter to not edit):");
            data[3] = Console.ReadLine();
            return data;
        }
    }
}
