﻿using System;
using System.Diagnostics;

namespace _6_DZ_Vvedenie
{
    class Program
    {//Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и позволяет
     //завершить указанный процесс. Предусмотреть возможность завершения процессов с помощью указания его ID
     //или имени процесса. В качестве примера можно использовать консольные утилиты Windows tasklist и taskkill.
        static void Main(string[] args)
        {
            // GetProcess getProcess = new GetProcess();
            // TableActiveProcesess.WriteTable();
            //  GetProcess.Some();
            TableActiveProcesess.WriteTable();
        }
    }
}
