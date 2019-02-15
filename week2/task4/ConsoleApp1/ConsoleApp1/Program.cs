using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter New = new StreamWriter(@"D:\txt\5.txt"); // создаем новый текстовой документ
            New.Write(3333); // вводим любой стринг
            New.Close(); // закрываем документ

            File.Copy(@"D:\txt\5.txt", @"D:\txt\4.txt"); // копируем информацию из того документа в новый
            File.Delete(@"D:\txt\5.txt"); // удаляем старый документ
        }
    }
}