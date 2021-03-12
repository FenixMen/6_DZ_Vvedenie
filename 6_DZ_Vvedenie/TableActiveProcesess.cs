using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _6_DZ_Vvedenie
{
    class TableActiveProcesess
    {

        public static void WriteTable(GetProcess allProcesses)
        {     
            int width = 0;
            StringBuilder line = new StringBuilder("");
            
            for (int i = 0; i < allProcesses.Lenght(); i++)
            {
                if (allProcesses.Name(i).Length > width) width = allProcesses.Name(i).Length;
            }
            Console.Write($" Id\t\tИмя");
            Console.SetCursorPosition(width + 20, 0);
            Console.Write($"Размер КБ\n");
            Console.Write(line.Append('=', 15) + " " + line.Append('=', 50) + " ==============\n");


            for (int i = 0; i < allProcesses.Lenght(); i++)
            {
                StringBuilder memory = new StringBuilder();
                Console.Write($" {allProcesses.Id(i)} \t\t{allProcesses.Name(i)}");
                Console.SetCursorPosition(width + 20, i+2);
                Console.Write($"{allProcesses.VirtualMemorySize(i)} KB\n");
            }

            
        }

    }
}

