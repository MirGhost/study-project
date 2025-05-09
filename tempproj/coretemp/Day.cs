using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.IO; //для сохранения данных в txt
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

/* backend Дулин Никита
 Full Stack Developer Витвицкий Даниил
UI/UX Вавилов Данил
CodeReview Ким Крмаджян
QA Владимир Балабанов*/
namespace app
{

    class Day
    {


        public int hoursofwork { get; set; }// реализвать функцией ( файлы чтения->поиск нужной строки -> поиск цифр ->применение из переменной)

        public void GetAllInformationOnFile(string Filename)
        {
            using (FileStream stream1 = File.OpenRead(Filename))
            {
                byte[] array = new byte[stream1.Length];
                stream1.Read(array, 0, array.Length);
                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine(textFromFile);
                stream1.Close();
            }
        }
        public string SearchContextInFile(string NameDiscipline,string Filename)
        {
            int counter = 0;
            try
            {
                string line;
                StreamReader file = new StreamReader(Filename);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains(NameDiscipline))
                    {
                        break;
                    }
                    counter++;
                }
                /*Console.WriteLine("Line number: {0}", counter);*/ //показывает на какой строчке премет
                file.Close();
            }
            catch (Exception e) { Console.WriteLine("ошибка чтения: " + e.Message); }
            finally { /*Console.WriteLine("чтение выполнено успешно");*/ } //успешное чтение документа

            string secondLine = File.ReadLines(Filename).ElementAtOrDefault(counter);
            //Console.WriteLine("Найден предмет: " + secondLine);

            string[] readText = File.ReadAllLines(Filename);
            using (StreamWriter secfile = new StreamWriter(Filename, true)) //если поставить false то файлик будет стираться
            {

                if (counter == readText.Length)
                {
                    Console.WriteLine("Такой предмет не найден");
                }
                secfile.Close();
            }
            return secondLine;

        }
        public void SetHoursLessons(string NameDiscipline,string Filename)
        {

            string str = SearchContextInFile(NameDiscipline, Filename);
            int value;
            int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out value);
            value = value - 2;
            while (value <= 0) { Console.WriteLine("План выполнен"); return; }
            
            string valuestr = Convert.ToString(value);
            string newstr = NameDiscipline + " " + valuestr;

            ReplaceInFile("HoursOfWork.txt", str, newstr);
            Console.WriteLine($"Новое значение {SearchContextInFile(NameDiscipline, Filename)}");

        }
        private void ReplaceInFile(string filePath, string searchText, string replaceText)
        {
            StreamReader reader = new StreamReader(filePath);
            string content = reader.ReadToEnd();
            reader.Close();

            content = Regex.Replace(content, searchText, replaceText);

            StreamWriter writer = new StreamWriter(filePath);
            writer.Write(content);
            writer.Close();

        }

    }
}
