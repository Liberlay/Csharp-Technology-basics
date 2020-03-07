### 20. Какое пространство имен использует системная библиотека C#? 

    Системная библиотека C# использует пространство имен System.

### 15. Приведите синтаксис оператора выбора в общем виде. Проиллюстрируйте его фрагментом программы на языке C#. 

    // Синтаксис
    switch (выражение){
    case константа1:
    оператор1;
    …
    break;
    case константа2:
    операторX1;
    …
    break;
    …
    default:
    операторZ1;
    …
    break;
    } 

    // Пример кода
    int TaskNumber = Convert.ToInt32(Console.ReadLine());
    switch (TaskNumber)
    {
        case 20:
            task20();
            break;
        case 15:
            task15();
            break;
        case 10:
            task10();
            break;
        case 5:
            task5();
            break;
        case 24:
            task24();
            break;
        default:
            Console.WriteLine("Enter task number from list!");
            ChooseTask();
            break;
    }

### 10. Перечислите пять простых типов языка C#. 

    int, char, bool, double, long.

### 5. Является ли среда CLR многоязычной? 

    Среда CLR является независимой от языка.

### 24.Приведите синтаксис описания пространства имен в общем виде. Проиллюстрируйте его фрагментом программы на языке C#. 

    Общий вид:

    Создание пространства имен:

        namespace имя {члены_пространства_имен} 

    Подключение пространства имен:

        using имя_пространства_имен;

    // Пример:
    using System;

    namespace Lab1
    {
        class Program
        {
            static void Main(string[] args)
            {
                // 19. Реализовать функцию возведения в куб суммы двух целых чисел 
                int a, b, c;
                Console.WriteLine("Write two integer numbers:");
