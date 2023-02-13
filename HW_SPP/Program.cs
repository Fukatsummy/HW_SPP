using System.Diagnostics;
using System.Runtime.InteropServices;
using System;
using System.Threading; //Для создания пауз в мелодии


//1//  Разработайте приложение, которое использует унаследованный код. Вам необходимо использовать функцию
//MessageBox из Windows API. Отобразите с помощью
//MessageBox информацию о вас. Данные должны быть показаны в нескольких MessageBox.

namespace CSharpSP
{
    /*internal class Program
    {
        [DllImport("user32.dll")]//использование унаследованного кода
        public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);

        const uint MB_ICONWARNING = 0x030;
        const uint MB_CANCELTRYCONTINUR = 0x06;
        const uint MB_DEFBUTTON2 = 0x0100;
        const uint MB_YESNOCANCEL = 0x03;
        const uint MB_OK = 0x000;
        const uint MB_INFORMATION = 64;

        static int MyMessageBox(int number)
        {
            return MessageBox(IntPtr.Zero, "Yes - число угадано верно," + " NO - число меньше," + "Cancel - число больше\nМожет быть Вы загадали " + number.ToString(), "Угадай число", MB_YESNOCANCEL | MB_DEFBUTTON2);
        }

        static void Main(string[] args)
        {

            MessageBox(IntPtr.Zero, "Лукьянчикова Анастасия", " ", MB_INFORMATION | MB_OK);   // task_1
            MessageBox(IntPtr.Zero, "Студент компьютерной академии \"гр.ПВ-111\"", "", MB_INFORMATION | MB_OK);

        }
    }*/


//  2//  Разработайте приложение, которое использует унаследованный код.Вам необходимо использовать функции
//Beep и MessageBeep из Windows API.С помощью импортированных функций сгенерируйте набор звуковых
//сигналов через определенные промежутки времени.

    internal class Program
    {
        [DllImport("Kernel32.dll")]
        public static extern int Beep(uint dwFreq, uint dwDuration);
        [DllImport("user32.dll")]//использование унаследованного кода
        public static extern bool MessageBeep(uint type);

        const uint MB_ICONERROR = 0x00000010;
        const uint MB_ICONQUESTION = 0x00000020;

        static void Main(string[] args)
        {
            /*Console.WriteLine("Включите звук, пожалуйста!");
            DllImportExample.Beep(750, 2000);*/

            Grasshoper();
        }
        private static void Grasshoper()
        {
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(330, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(415, 300);
            Thread.Sleep(600);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(330, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 300);
            Console.Beep(440, 300);
            Thread.Sleep(600);
            Console.Beep(440, 300);
            Console.Beep(494, 300);
            Console.Beep(494, 100);
            Console.Beep(494, 100);
            Console.Beep(494, 300);
            Console.Beep(494, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 100);
            Console.Beep(523, 100);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(523, 300);
            Console.Beep(494, 300);
            Console.Beep(440, 300);
            Console.Beep(415, 300);
            Console.Beep(440, 800);
        }
    }
}