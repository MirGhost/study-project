namespace app
{
    //ЭТО ДЕЛАЛ ВИТВИЦКИЙ Я БЫ ЗА ТАКОЙ ПОЗОР ЗАКОНЧИЛ КАРЬЕРУ ПРОГРАММИСТА
    class Load 
    {
        bool Lectures = false;
        bool PracticalExercises = false;
        bool LaboratoryWork = false;
        bool Seminars = false;
        bool CourseConsultations = false;
        bool ManagementOfDiplomaDesign = false;
        bool CourseProjectWork = false;
        bool Credits = false;
        bool Exams = false;
        bool ManagementOfGraduateStudents = false;
        bool ManagementOfProductionPractice = false;
        bool ManagementOfEducationalPractice = false;
        bool CheckingTheWorOfPartTimeStudents = false;
        bool GEK = false;
        bool MRK = false;

        public void Processing(string TypeLessonsGroup)  //обработка
        {
            Day da = new Day();

            string str = da.SearchContextInFile(TypeLessonsGroup, "KI21.txt");
            int value;
            int.TryParse(string.Join("", str.Where(c => char.IsDigit(c))), out value);
            Console.WriteLine($"{TypeLessonsGroup} {value.ToString()}");
            
        }
        public void setBolean( string[] TypeLessonsGroup) //передаём массивом
        {
            MainClass mainClass = new MainClass();
            List<bool> bools = new List<bool>();
            bools.Add(Lectures);
            bools.Add(PracticalExercises);
            bools.Add(LaboratoryWork);
            bools.Add(Seminars);
            bools.Add(CourseConsultations);
            bools.Add(ManagementOfDiplomaDesign);
            bools.Add(CourseProjectWork);
            bools.Add(Credits);
            bools.Add(Exams);
            bools.Add(ManagementOfGraduateStudents);
            bools.Add(ManagementOfProductionPractice);
            bools.Add(ManagementOfEducationalPractice);
            bools.Add(CheckingTheWorOfPartTimeStudents);
            bools.Add(GEK);
            bools.Add(MRK);

            int counter = 0;//ОШИБКА
            try
            {
                int i = 0;
                int k = 0;
                string line;

                while ( i< TypeLessonsGroup.Length)
                {
                    StreamReader file = new StreamReader("KI21.txt");
                    while ((line = file.ReadLine()) != null)
                    {
                        while (line.Contains(TypeLessonsGroup[i]))
                        {
                            i++;
                            bools[counter] = true;
                            counter = -1;
                        }
                        counter++;
                    }
                    file.Close();
                }
            }
            catch (Exception e) { Console.WriteLine("ошибка чтения: " + e.Message); }


        } 

    }
}

