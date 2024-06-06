

namespace app
{
    internal class Lesson : SubjectData
    {

        IEnumerable<int> ProduceEvenNumbers() 
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 2;
            yield return 1;
            yield return 1;
        }
        public string Name { get; set; }
        public string Group { get; set; }
        public string Type { get; set; }
        //передавать день (уточнения на праздничный)  делаем функцию с точкизрения преподавателя
        public void DayLessons(int day, int Group)
        {
            switch (Group)
            {
                case 1:
                    switch (day)
                    {
                        case 1:
                            List<string> Monday_KI = new List<string>();
                            //Monday_KI.Add(englishLanguage.Name);
                            //Monday_KI.Add(higherMathematics.Name);
                            Console.WriteLine("Предметы на понедельник для группы КИ-21:");
                            foreach (var ex in Monday_KI) { Console.WriteLine(ex); }
                            break;
                        case 2:
                            List<string> Tuesday_KI = new List<string>();
                            Tuesday_KI.Add("Системное программирование");
                            Tuesday_KI.Add("-");
                            Tuesday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Tuesday_KI.Add("Численные методы и операции исчисления");
                            Tuesday_KI.Add("-");
                            Console.WriteLine("Предметы на вторник для группы КИ-21:");
                            foreach (var ex in Tuesday_KI) { Console.WriteLine(ex); }
                            break;
                        case 3:
                            List<string> Wednesday_KI = new List<string>();
                            Wednesday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Wednesday_KI.Add("Физическая культура");
                            Wednesday_KI.Add("Численные методы и операции исчисления");
                            Wednesday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Wednesday_KI.Add("-");
                            Console.WriteLine("Предметы на среду для группы КИ-21:");
                            foreach (var ex in Wednesday_KI) { Console.WriteLine(ex); }
                            break;
                        case 4:
                            List<string> Thursday_KI = new List<string>();
                            Thursday_KI.Add("Философия");
                            Thursday_KI.Add("Численные методы");
                            Thursday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Thursday_KI.Add("Численные методы и операции исчисления");
                            Thursday_KI.Add("Моделирование цифровых устройств");
                            Console.WriteLine("Предметы на четверг для группы КИ-21:");
                            foreach (var ex in Thursday_KI) { Console.WriteLine(ex); }
                            break;
                        case 5:
                            List<string> Friday_KI = new List<string>();
                            Friday_KI.Add("Русский язык");
                            Friday_KI.Add("-");
                            Friday_KI.Add("Моделирование цифровых узлов компьютерных систем");
                            Friday_KI.Add("Численные методы и операции исчисления");
                            Friday_KI.Add("Системное программирование");
                            Console.WriteLine("Предметы на пятницу для группы КИ-21:");
                            foreach (var ex in Friday_KI) { Console.WriteLine(ex); }
                            break;
                    }
                    break;
                case 2:
                    switch (day)
                    {
                        case 1:
                            List<string> Monday_PI = new List<string>();
                            Monday_PI.Add("Системное программирование");
                            Monday_PI.Add("Физическая культура");
                            Monday_PI.Add("Численные методы и операции исчисления");
                            Monday_PI.Add("-");
                            Monday_PI.Add("-");
                            Console.WriteLine("Предметы на понедельник для группы ПИ-21:");
                            foreach (var ex in Monday_PI) { Console.WriteLine(ex); }
                            break;
                        case 2:
                            List<string> Tuesday_PI = new List<string>();
                            Tuesday_PI.Add("Русский язык");
                            Tuesday_PI.Add("Моделирование цифровых узлов компьютерных систем");
                            Tuesday_PI.Add("Аналоговая семотехника");
                            Tuesday_PI.Add("Численные методы");
                            Tuesday_PI.Add("-");
                            Console.WriteLine("Предметы на вторник для группы ПИ-21:");
                            foreach (var ex in Tuesday_PI) { Console.WriteLine(ex); }
                            break;
                        case 3:
                            List<string> Wednesday_PI = new List<string>();
                            Wednesday_PI.Add("-");
                            Wednesday_PI.Add("-");
                            Wednesday_PI.Add("Цифровая схемотехника");
                            Wednesday_PI.Add("Русский язык");
                            Wednesday_PI.Add("Системное программирование");
                            Console.WriteLine("Предметы на среду для группы ПИ-21:");
                            foreach (var ex in Wednesday_PI) { Console.WriteLine(ex); }
                            break;
                        case 4:
                            List<string> Thursday_PI = new List<string>();
                            Thursday_PI.Add("Аналоговая схемотехника");
                            Thursday_PI.Add("Физическая культура");
                            Thursday_PI.Add("-");
                            Thursday_PI.Add("Системное программирование");
                            Thursday_PI.Add("-");
                            Console.WriteLine("Предметы на четверг для группы ПИ-21:");
                            foreach (var ex in Thursday_PI) { Console.WriteLine(ex); }
                            break;
                        case 5:
                            List<string> Friday_PI = new List<string>();
                            Friday_PI.Add("Философия");
                            Friday_PI.Add("Численные методы и операции исчисления");
                            Friday_PI.Add("Моделирование цифровых узлов компьютерных систем");
                            Friday_PI.Add("-");
                            Friday_PI.Add("-");
                            Console.WriteLine("Предметы на пятницу для группы ПИ-21:");
                            foreach (var ex in Friday_PI) { Console.WriteLine(ex); }
                            break;
                    }
                    break;
                default: Console.WriteLine("если кто-то видет это сообщение то знайте я забыл добавить группы и их расписание"); break;

            }
        }
    }
}
