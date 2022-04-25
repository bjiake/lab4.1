using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Directory.EnumerateFiles(catalog, fileName, SearchOption);
 * catalog (строковый тип string) — путь к каталогу в котором будет производиться поиск. Регистр символов не учитывается.
 * fileName (строковый тип string) — имя файла для поиска. Оно может содержать подстановочные поисковые символы: * и ?. 
Звездочка обозначает произвольное количество символов на её месте, а знак вопроса — один символ на месте подстановки.
 * SearchOption — это перечисление задающее опции поиска. Имеет два значения: SearchOption.TopDirectoryOnly (поиск будет выполнен только в текущем каталоге) и SearchOption.
AllDirectories (поиск будет произведён в указанном каталоге и во всех его подкаталогах).
 */
namespace lab4._1
{
    class FindFile
    {
        string NameFile;
        string catalog = @"C:\Users\Блэйк\source\repos\4\FilesForTask";
        public void Find()
        {
            Console.WriteLine("Введите название текстового файла, которого хотите найти:");
            NameFile = Console.ReadLine();
            NameFile = NameFile + ".txt";
            //Directory.EnumerateFiles(catalog, NameFile, SearchOption.AllDirectories);
            foreach (string findedFile in Directory.EnumerateFiles(catalog, NameFile, SearchOption.AllDirectories))
            {
                FileInfo FI;
                try
                {
                    //по полному пути к файлу создаём объект класса FileInfo
                    FI = new FileInfo(findedFile);
                    //найденный результат выводим в консоль (имя, путь, размер, дата создания файла)
                    Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" + " Создан: " + FI.CreationTime);

                }
                catch //слишком длинное имя файла
                {
                    continue;
                }

            }
        }
    }
}
