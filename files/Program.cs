string inputData = "";

while (true)
{
    Console.WriteLine("1 - Ввести данные\n2 - Сохранить\n3 - Выбрать файл и дописать\n4 - Выйти");
    string choice = Console.ReadLine();
    
    if (choice == "1")
    {
        inputData = to_input();
    }

    if (choice == "2")
    {
        to_save(inputData);
    }

    if (choice == "3")
    {
        to_append();
    }

    if (choice == "4")
    {
        break;
    }
}


string to_input()
{
    Console.WriteLine("Введите данные...");
    return Console.ReadLine();
}


void to_save(string input)
{
    Console.WriteLine("Сохранить?\n1 - Да       2 - Нет");
    string choice = Console.ReadLine();

    if (choice == "1")
    {
        Console.WriteLine("Введите наименование файла:");
        string filename = Console.ReadLine();

        string filePath = filename + ".txt";
        File.WriteAllText(filePath, input);

        string currentDir = Environment.CurrentDirectory;
        Console.WriteLine("Текст успешно записан в " + currentDir);
    }
}


void to_append()
{
    Console.WriteLine("Введите наименование файла, в который хотите дописать данные:");
    string filename = Console.ReadLine();

    string filePath = filename + ".txt";

    if (File.Exists(filePath))
    {
        Console.WriteLine("Продолжайте вводить данные");
        string addData = Console.ReadLine();

        File.AppendAllText(filePath, addData);
    }
    else
    {
        Console.WriteLine("Файл не существует");
    }
}