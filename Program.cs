using System;
using System.IO;
using System.Linq;
using JakodevLibs.Collections;
using JakodevLibs.Extensions;
using UsingJakodevLibs.Mocks;

using Enum = System.Enum;

namespace UsingJakodevLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //WorkingWithEnumsTest();
                WorkingWithMatrixTest();



            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }

        private static void WorkingWithMatrixTest()
        {
            try
            {
                Console.WriteLine("Ciao, benvenuto nel test MATRIX:");
                Console.WriteLine("Adesso verrà creata una matrice e stampata a video");
                Console.WriteLine("Premere il tasto ANY per continuare...");
                var v = Console.ReadLine();

                var matrix = new DictionaryMatrix<DateTime, string, string>();
                matrix.Add(new DateTime(2020,1,10), "Carl", "dentist");
                matrix.Add(new DateTime(2020,1,11), "Carl", "exams");
                matrix.Add(new DateTime(2020,1,12), "Carl", "travel");
                matrix.Add(new DateTime(2020,1,13), "Carl", "travel");
                matrix.Add(new DateTime(2020,1,14), "Carl", "home working");
                matrix.Add(new DateTime(2020,1,15), "Carl", "home working");
                matrix.Add(new DateTime(2020,1,16), "Carl", "day off");
                matrix.Add(new DateTime(2020,1,17), "Carl", "customer meeting");
                matrix.Add(new DateTime(2020,1,18), "Carl", "travel");
                matrix.Add(new DateTime(2020,1,19), "Carl", "office");
                matrix.Add(new DateTime(2020,1,10), "Mark", "office");
                matrix.Add(new DateTime(2020,1,11), "Mark", "office");
                matrix.Add(new DateTime(2020,1,12), "Mark", "doctor");
                matrix.Add(new DateTime(2020,1,13), "Mark", "travel");
                matrix.Add(new DateTime(2020,1,14), "Mark", "customer meeting");
                matrix.Add(new DateTime(2020,1,15), "Mark", "presentation");
                matrix.Add(new DateTime(2020,1,16), "Mark", "travel");
                matrix.Add(new DateTime(2020,1,17), "Mark", "day off");
                matrix.Add(new DateTime(2020,1,18), "Mark", "day off");
                matrix.Add(new DateTime(2020,1,19), "Mark", "day off");
                matrix.Add(new DateTime(2020,1,10), "July", "home working");
                matrix.Add(new DateTime(2020,1,11), "July", "day off");
                matrix.Add(new DateTime(2020,1,12), "July", "customer meeting");
                matrix.Add(new DateTime(2020,1,13), "July", "dentist");
                matrix.Add(new DateTime(2020,1,14), "July", "exams");
                matrix.Add(new DateTime(2020,1,15), "July", "travel");
                matrix.Add(new DateTime(2020,1,16), "July", "travel");
                matrix.Add(new DateTime(2020,1,17), "July", "travel");
                matrix.Add(new DateTime(2020,1,18), "July", "home working");
                matrix.Add(new DateTime(2020,1,19), "July", "home working");
                matrix.Add(new DateTime(2020,1,10), "Anne", "travel");
                matrix.Add(new DateTime(2020,1,11), "Anne", "travel");
                matrix.Add(new DateTime(2020,1,12), "Anne", "home working");
                matrix.Add(new DateTime(2020,1,13), "Anne", "home working");
                matrix.Add(new DateTime(2020,1,14), "Anne", "day off");
                matrix.Add(new DateTime(2020,1,15), "Anne", "customer meeting");
                matrix.Add(new DateTime(2020,1,16), "Anne", "travel");
                matrix.Add(new DateTime(2020,1,17), "Anne", "office");
                matrix.Add(new DateTime(2020,1,18), "Anne", "office");
                matrix.Add(new DateTime(2020,1,19), "Anne", "office");

                string utenti = String.Empty;
                foreach (var col in matrix.ColsHeader)
                {
                    utenti += $"{col},";
                }
                Console.WriteLine($"Ora verranno stampati gli appuntamenti di {utenti} dal {matrix.RowsHeader.First().ToShortDateString()} al {matrix.RowsHeader.Last().ToShortDateString()}:" );
                Console.WriteLine("");

                Console.Write($"{FormatLenght(" ")}");
                foreach (var col in matrix.ColsHeader)
                {
                    Console.Write($"{FormatLenght(col)}");
                }

                Console.WriteLine("");
                foreach (var row in matrix.RowsHeader)
                {
                    Console.Write(FormatLenght(row.ToShortDateString()));
                    foreach (var col in matrix.ColsHeader)
                    {
                        Console.Write($"{FormatLenght(matrix.GetValue(row, col))}");
                    }
                    Console.WriteLine("");
                }




            }
            catch (Exception e)
            {
                Console.WriteLine("ERRORE: Lo vedi che sei un mona? ricontrolla quello che hai inserito");
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Premere il tasto ANY per chiudere...");
                Console.ReadKey();
            }
        }

        private static string FormatLenght(string s)
        {
            var spaces = new string(' ', 20);
            s = s+spaces;
            s = s.Substring(0, 20);
            return s;
        }
        private static void WorkingWithEnumsTest()
        {
            try
            {
                Console.WriteLine("Ciao, benvenuto nel test Enums Extension:");
                Console.WriteLine("inserisci un numero da 1 a 80");
                var v = Console.ReadLine();


                // WORKING WITH ENUM
                var test = new WorkingWithEnums()
                {
                    Animal = (Animals)int.Parse(v)
                };

                string nomeAnimale = test.Animal.Name();
                string versoAnimale = test.Animal.GetAttribute<AnimalSounds>().Sound;

                Console.WriteLine($"You choose the {nomeAnimale}, and it sounds {versoAnimale}");
                Console.WriteLine($"{nomeAnimale} >> is the enumerator");
                Console.WriteLine($"{versoAnimale} >> is the Custom Data Annotation called: AnimalSounds");

            }
            catch (Exception e)
            {
                Console.WriteLine("ERRORE: Lo vedi che sei un mona? ricontrolla quello che hai inserito");
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Premere il tasto ANY per chiudere...");
                Console.ReadKey();
            }
        }
    }




}
