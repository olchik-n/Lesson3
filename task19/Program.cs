//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число");
String a = Console.ReadLine();
//String a = "13321";
char[] ch = new char[a.Length]; 
    for (int i = 0; i < a.Length; i++) 
{ 
    ch[i] = a[i]; 
} 
if (ch[0] == ch[4] )
{
  if (ch[1]==ch[3]){
    Console.WriteLine("число палиндром");
  }
else
    Console.WriteLine("число не палиндром");
}
else
    Console.WriteLine("число не палиндром");
