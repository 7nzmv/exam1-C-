void arr (int n , int b)
{
    int [] ar = new int [n];
    // int b = Convert.ToInt32(Console.ReadLine());
   
    for (int i=0;i<n;i++)
    {
        ar[i]=Convert.ToInt32(Console.ReadLine());
    } 
    for (int i=0;i<n;i++)
    {
        for (int j=0;j<n;j++)
        {
            if (ar[i]+ar[j]==b)
            {
               Console.Write(ar[i] + " ");
            }
        }
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
arr(n,b);
