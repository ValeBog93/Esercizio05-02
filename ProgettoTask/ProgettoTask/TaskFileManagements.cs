using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgettoTask
{
    class TaskFileManagement
    {
        public static string path { get; } = "C:\\Users\\Utente\\Desktop\\ProgettoTask\\TaskEs.csv";

        public static Task[] GetAllProducts()
        {
            int totalLines = File.ReadLines(path).Count();
            Task[] taskList = new Task[totalLines - 1];
            string line;
            using (StreamReader reader = File.OpenText(path))
            {
                string header = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    for (int i = 0; i < totalLines - 1; i++)
                    {
                        line = reader.ReadLine();
                        string[] tasktData = line.Split(";");

                        Task task = new Task
                        {
                            Data = tasktData[0],
                            Descrizione = tasktData[1],
                            Importanza = tasktData[2],

                        };

                        taskList[i] = task;

                    }
                }
                return taskList;
            }
        }
    }
}