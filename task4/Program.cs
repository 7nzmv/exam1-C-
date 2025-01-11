int n = Convert.ToInt32(Console.ReadLine());
if (n%4==0 && n%100!=0 && n%400!=0)
{
    Console.WriteLine("Leap Year: YES");
}
else if (n%4!=0 && n%100==0 && n%400==0)
{
     Console.WriteLine("Leap Year: YES");
}
else 
{
     Console.WriteLine("Leap Year: NO");
}