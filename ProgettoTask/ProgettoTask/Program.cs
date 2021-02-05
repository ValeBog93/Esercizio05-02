using System;

namespace ProgettoTask
{
    class Program
    {
        tatic void Main(string[] args)
        {
            Task[] productList = TaskFileManagement.GetAllProducts();

            foreach (Task task in productList)
            {
                Console.WriteLine(task.Data + " - " + task.Descrizione + " - " + task.Importanza);

            }
        }
    }
}