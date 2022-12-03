System.Console.WriteLine("Введите любое число");
int a = int.Parse(Console.ReadLine());
int b = 0;
if (a>1000){
    while(a>1000){
        a=a/10;
        b=a%10;
       
    }
     System.Console.WriteLine(b);
    
}else if (a>100 & a<1000){
    b=a%10;
    System.Console.WriteLine(b);
}else if (a<100){
    System.Console.WriteLine("Третьей цифры нет");
}
