Console.WriteLine("Введите число: ");
string number1 = Console.ReadLine();
thrichislo (number1);
void  thrichislo (string number1 )
{
    if (number1.Length > 2)
    {
        Console.WriteLine ($" Третья цифра введенного Вами числа равна: {number1 [2]}");

    }
    else Console.WriteLine ($"В введенном Вами числе {number1} нет третьей цифры");


   


}