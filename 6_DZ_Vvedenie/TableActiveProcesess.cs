using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace _6_DZ_Vvedenie
{
    class TableActiveProcesess
    {


        public static void WriteTable()
        {
            
            GetProcess getProcess = new GetProcess();
            int width = 0;
            for (int i = 0; i < getProcess.Lenght(); i++)
            {
                if (getProcess.Name(i).Length > width) width = getProcess.Name(i).Length;
            }
            Console.Write($"№ \t\tИмя");
            Console.SetCursorPosition(width + 20, 0);
            Console.Write($"Размер КБ\n");

            for (int i = 0; i < getProcess.Lenght(); i++)
            {
                
                Console.Write($"{i} \t\t{getProcess.Name(i)} ");
                Console.SetCursorPosition(width + 20, i+1);
                Console.Write($"{getProcess.VirtualMemorySize(i)} KB\n");
            }

        }
    }
}

