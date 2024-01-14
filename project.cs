using System;
using System.Collections.Generic;
using System.Text;

class Authentication
{
    private const string ValidUsername = "meryemd";
    private const string ValidPassword = "1234";

    public static bool AuthenticateUser(string username, string password)
    {
        return username == ValidUsername && password == ValidPassword;
    }
}

class Task
{
    public string TaskName { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Priority { get; set; }

    public Task() { }

    public Task(string taskName, string description, DateTime startDate, DateTime endDate, int priority)
    {
        TaskName = taskName;
        Description = description;
        StartDate = startDate;
        EndDate = endDate;
        Priority = priority;
    }
}


class Program
{

    static List<Task> tasks = new List<Task>();

    static Dictionary<string, List<Task>> folders = new Dictionary<string, List<Task>>();

    static string GetMaskedPassword()
    {
        StringBuilder password = new StringBuilder();
        ConsoleKeyInfo key;

        do
        {
            key = Console.ReadKey(true);

            // Sadece basılan tuş bir karakter ise ve Enter tuşu değilse
            if (!char.IsControl(key.KeyChar))
            {
                password.Append(key.KeyChar);
                Console.Write("*");
            }
            // Eğer basılan tuş bir kontrol tuşu (Enter, Backspace, vb.) ise
            else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
            {
                password.Remove(password.Length - 1, 1);
                Console.Write("\b \b");
            }
        } while (key.Key != ConsoleKey.Enter);

        Console.WriteLine(); // Enter tuşuna basılınca yeni satıra geçmek için

        return password.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine("ToDoList'e Hoşgeldin!" + "                                                                                                                        ");

        Console.Write("Kullanıcı Adı: ");
        string username = Console.ReadLine();

        Console.Write("Şifre: ");
        string password = GetMaskedPassword();

        if (Authentication.AuthenticateUser(username, password))
        {
            Console.WriteLine($"\nMerhaba {username}!");

            ListTasks();

            bool exit = false;
            while (!exit)

            {
                Console.WriteLine("1- Görev Ekle");
                Console.WriteLine("2- Görev Çıkar");
                Console.WriteLine("3- Görevleri Listele");
                Console.WriteLine("4- Tamamlanmış işaretle");
                Console.WriteLine("5- Klasör oluştur");
                Console.WriteLine("6- Klasörler");
                Console.WriteLine("7- Çıkış");
                Console.Write("\nHangi işlemi yapmak istediğini seç (1-7): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        DeleteTask();
                        break;
                    case "3":
                        ListTasks();
                        break;
                    case "4":
                        CompleteTask();
                        break;
                    case "5":
                        CreateFolder();
                        break;
                    case "6":
                        ListFoldersAndAddTask();
                        break;
                    case "7":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Geçersiz seçenek. Lütfen tekrar deneyin.");
                        break;
                }

                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Geçersiz kullanıcı adı veya şifre. Program kapatılıyor..");
        }
    }

    static void AddTask()
    {
        Console.Write("Yeni görevin adını girin: ");
        string taskName = Console.ReadLine();

        Console.Write("Görevin açıklamasını girin: ");
        string taskDescription = Console.ReadLine();

        Console.Write("Başlangıç Tarihi (gg.aa.yyyy): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
        {
            Console.Write("Bitiş Tarihi (gg.aa.yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                Console.Write("Öncelik Derecesi (1-3): ");
                if (int.TryParse(Console.ReadLine(), out int priority) && (priority >= 1 && priority <= 3))
                {
                    Task task = new Task(taskName, taskDescription, startDate, endDate, priority);

                    tasks.Add(task);
                    Console.WriteLine("\nGörev başarıyla eklendi!");
                }

                else
                {
                    Console.WriteLine("Geçersiz öncelik derecesi. 1, 2 veya 3 girin.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bitiş tarihi. Lütfen doğru bir tarih girin.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz başlangıç tarihi. Lütfen doğru bir tarih girin.");
        }
    }

    static void DeleteTask()
    {
        ListTasks();
        if (tasks.Count == 0)
        {
            Console.WriteLine("Silinecek görev bulunmuyor.");
            return;
        }

        Console.WriteLine("Silmek istediğiniz görevin adını girin: ");
        string name = Console.ReadLine();
        if (tasks.Count > 0)
        {
            foreach (var t in tasks)
            {
                if (name == t.TaskName)
                {
                    tasks.Remove(t);
                    Console.WriteLine("Görev listeden silindi.");
                    return;
                }
            }

            Console.WriteLine("\nBu isimde bir görev bulunamadı.");
        }
        else
        {
            Console.WriteLine("Listede daha önce eklemiş bir görev yok.");
        }

    }
    static void ListTasks()
    {
        Console.WriteLine("\n------------------------");
        if (tasks.Count == 0)
        {
            Console.WriteLine("Listede görev bulunmuyor.");
        }
        else
        {
            int i = 1;
            foreach (var task in tasks)
            {
                Console.WriteLine($"{i}. {task.TaskName}");
                Console.WriteLine($"Açıklama: {task.Description}");
                Console.WriteLine($"Başlangıç tarihi: {task.StartDate.ToString().Substring(0, 10)}");
                Console.WriteLine($"Bitiş tarihi: {task.EndDate.ToString().Substring(0, 10)}\n");
                i++;
            }
        }
        Console.WriteLine("------------------------\n");
    }

    static void CompleteTask()
    {
        ListTasks();
        if (tasks.Count == 0)
        {
            Console.WriteLine("Tamamlanacak görev bulunmuyor.");
            return;
        }

        Console.Write("Tamamlanan görevin adını girin: ");
        string name = Console.ReadLine();
        if (tasks.Count > 0)
        {
            foreach (var t in tasks)
            {
                if (t.TaskName == name)
                {
                    tasks.Remove(t);
                    Console.WriteLine("\nTamamlanmış görev listeden kaldırıldı.");
                    return;
                }
            }
            Console.WriteLine("\nBu isimde bir görev bulunamadı.");
        }
        else
        {
            Console.WriteLine("Geçersiz görev numarası.");
        }
    }
    static void CreateFolder()
    {
        Console.Write("Yeni klasör adını girin: ");
        string folderName = Console.ReadLine();

        if (!folders.ContainsKey(folderName))
        {
            folders.Add(folderName, new List<Task>());
            Console.WriteLine($"'{folderName}' adında klasör oluşturuldu.");
        }
        else
        {
            Console.WriteLine("Bu isimde zaten bir klasör bulunmaktadır.");
        }
    }

    static void ListFoldersAndAddTask()
    {
        Console.WriteLine("--- Klasörler ---");
        if (folders.Count == 0)
        {
            Console.WriteLine("Klasör bulunmuyor.");
        }
        else
        {
            foreach (var folder in folders)
            {
                Console.WriteLine($"- {folder.Key}"); // folder ismi

                foreach (var task in folder.Value)
                {
                    Console.WriteLine($" - {task.TaskName}"); // folder içindeki tasklar
                }
            }


            Console.Write("Klasöre bir görev eklemek istiyor musunuz? (E/H): ");
            string answer = Console.ReadLine();

            if (answer.ToUpper() == "E")
            {
                Console.Write("Görev eklemek istediğiniz klasör adını girin: ");
                string selectedFolder = Console.ReadLine();

                if (selectedFolder == "Bu Hafta İçindekiler" || selectedFolder == "Bu Ay İçindekiler")
                {
                    //AddTaskToSpecialFolder(selectedFolder);
                }

                else if (folders.ContainsKey(selectedFolder))
                {
                    AddTaskToFolder(selectedFolder);
                }
                else
                {
                    Console.WriteLine("Belirtilen klasör bulunamadı.");
                }
            }

        }

        Console.WriteLine("*******************************");
    }
    static void AddTaskToFolder(string folderName)
    {
        Console.WriteLine("Yeni görevi girin: ");
        string name = Console.ReadLine();

        Console.WriteLine("Görevin açıklamasını girin: ");
        string description = Console.ReadLine();

        Console.WriteLine("Başlangıç tarihini girin (örn. 2024-01-13): ");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime startDate))
        {
            Console.WriteLine("Bitiş tarihini girin (örn. 2024-01-20): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime endDate))
            {
                Console.WriteLine("Öncelik derecesini belirtin (1-3): ");
                if (int.TryParse(Console.ReadLine(), out int priority) && priority >= 1 && priority <= 3)
                {
                    Task task = new Task(name, description, startDate, endDate, priority);
                    tasks.Add(task);
                    folders[folderName].Add(task);
                    Console.WriteLine("Görev başarıyla klasöre eklendi!");
                }
                else
                {
                    Console.WriteLine("Geçersiz öncelik derecesi.");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz bitiş tarihi.");
            }
        }
        else
        {
            Console.WriteLine("Geçersiz başlangıç tarihi.");
        }
    }
}
