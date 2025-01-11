int n = Convert.ToInt32(Console.ReadLine());
int [] arr = new int [n];
for (int i=0;i<n;i++)
{
    arr[i]=Convert.ToInt32(Console.ReadLine());
}
int min = 99999 ;
for (int i=0;i<n;i++)
{
    if (arr[i]<min)
    {
        min = arr [i];
    }
}
int max = 0;
for (int i=0;i<n;i++)
{
    if (arr[i]>max)
    {
        max = arr [i];
    }
}
Console.Write("min: ");
Console.WriteLine(min);
Console.Write("max: ");
Console.WriteLine(max);
 Console.Write("sum: ");
Console.WriteLine(max+min);
