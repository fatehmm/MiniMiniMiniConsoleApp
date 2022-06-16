using CitizenApp;

static void Main(string[] args)
{
    Baku baku = new Baku();
    string? answer;
    do
    {
        Console.WriteLine("1. Employee elave et");
        Console.WriteLine("2. Student elave et");
        Console.WriteLine("3. Employeelerin sayini goster");
        Console.WriteLine("4. Studentlerin sayini goster");
        Console.WriteLine("5. Employeelere bax");
        Console.WriteLine("6. Studentlere bax");
        Console.WriteLine("7. Insanlar uzre axtaris et");
        Console.WriteLine("8. Menudan cix");
        do
        {
            answer = Console.ReadLine();
        } while (string.IsNullOrWhiteSpace(answer) || (answer != "1" && answer != "2" && answer != "3" && answer != "4" && answer != "5" && answer != "6" && answer != "7" && answer != "8"));

        switch (answer)
        {
            case "1":
                Console.Write("Employeenin adini daxil edin...");
                string? name = Console.ReadLine();
                Console.Write("Employeenin soyadini daxil edin...");
                string? surname = Console.ReadLine();
                Human employee1;
                employee1 = new Employee(name, surname);
                baku.AddHuman(employee1);
                Console.WriteLine("Employee elave olundu....");
                break;
            case "2":
                Console.Write("Employeenin adini daxil edin...");
                string? nameStd = Console.ReadLine();
                Console.Write("Employeenin soyadini daxil edin...");
                string? surnameStd = Console.ReadLine();
                Human student1 = new Student(nameStd, surnameStd);
                baku.AddHuman(student1);
                Console.WriteLine("Student elave olundu....");
                break;
            case "3":
               Human[] employees =  baku.GetEmployees();
               Console.WriteLine(employees.Length);
               break;
            case "4":
                Human[] students =  baku.GetStudents();
                Console.WriteLine(students.Length);
                break;
            case "5":
                Human[] employeesToShow =  baku.GetEmployees();
                foreach (var item in employeesToShow)
                {
                    item.ShowInfo();
                }
                break;
            case "6":
                Human[] studentsToShow =  baku.GetStudents();
                foreach (var item in studentsToShow)
                {
                    item.ShowInfo();
                }
                break;
            case "7":
                Console.Write("Axtaris deyerini daxil edin ...");
                string? answerSearch = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(answerSearch))
                {
                    Human[] searchedHumans = baku.SearchHumans(answerSearch);
                    foreach (var variable in searchedHumans)
                    {
                        variable.ShowInfo();
                    }
                }

                break;
            
                
        }
    } while (answer !="8");
    

}

