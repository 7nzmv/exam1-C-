void str (string n);
{
    int cnt = 0;
    int snt = 0;
    if (n == "a" || n == "A" || n == "e" || n == "E" || n == "u" || n == "U" || n == "i" || n == "I" || n == "o" || n == "O") 
    {
       cnt++;
    }
    else 
    {
        snt++;
    }
    Console.Write("Vowels: ");
    Console.WriteLine(cnt);
    Console.Write("Consonants: ");
    Console.WriteLIne(snt);
}
string n = (Console.ReadLine());
str(n);
