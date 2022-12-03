Console.WriteLine("Введите день недели цифрой от 1 до 7");
int s = int.Parse(Console.ReadLine());
switch (s){
    case 1:
    Console.WriteLine("Понедельник");
    break;
     case 2:
    Console.WriteLine("Вторник");
    break;
     case 3:
    Console.WriteLine("Среда");
    break;
     case 4:
    Console.WriteLine("Четверг");
    break;
     case 5:
    Console.WriteLine("Пятница");
    break;
     case 6:
    Console.WriteLine("Суббота");
    break;
     case 7:
    Console.WriteLine("Воскресенье");
    break;}
if (s==6 || s==7)
    System.Console.WriteLine("Это выходной");
else System.Console.WriteLine("Это не выходной");
