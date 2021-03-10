using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _6_DZ_Vvedenie
{
    class TableActiveProcesess
    {

        private static GetProcess getProcess = new GetProcess();
        public static void WriteTable()
        {
             


            int width = 0;
            StringBuilder line = new StringBuilder("");
            
            for (int i = 0; i < getProcess.Lenght(); i++)
            {
                if (getProcess.Name(i).Length > width) width = getProcess.Name(i).Length;
            }
            Console.Write($" Id\t\tИмя");
            Console.SetCursorPosition(width + 20, 0);
            Console.Write($"Размер КБ\n");
            Console.Write(line.Append('=', 15) + " " + line.Append('=', 50) + " ==============\n");


            for (int i = 0; i < getProcess.Lenght(); i++)
            {
                StringBuilder memory = new StringBuilder();
                Console.Write($" {getProcess.Id(i)} \t\t{getProcess.Name(i)}");
                Console.SetCursorPosition(width + 20, i+2);
                Console.Write($"{getProcess.VirtualMemorySize(i)} KB\n");
            }

            
        }
        public static void KillById(int id) => getProcess.Kill(id);
        public static void KillByName(string name) => getProcess.Kill(name);
    }
}

