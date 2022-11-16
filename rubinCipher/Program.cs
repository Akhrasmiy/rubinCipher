
Console.WriteLine("Hello, World!");
int p = 0;
int q=0;
do
{
    Console.WriteLine("pni kiriting");
    p = Convert.ToInt32(Console.ReadLine());
}
while (p % 4 != 3);
do
{
    Console.WriteLine("qni kiriting");
    q = Convert.ToInt32(Console.ReadLine());
}
while (q % 4 != 3);
int n = p * q;
int a = (int)Math.Pow(p, q - 2) % q;
int b = (int)Math.Pow(q, p - 2) % p;
Console.WriteLine("deshifrlamoqchi bolganlar soni");
int soni=Convert.ToInt32(Console.ReadLine());
for(int i = 0; i < soni; i++)
{
    Console.WriteLine(1 + i + "- sonni kiritng");
    int c= Convert.ToInt32(Console.ReadLine());
    int m1 =(int)Math.Pow(c, (p + 1) / 4) % p;
    
    int m2 = p - m1;
    
    int m3 = (int)Math.Pow(c, (q + 1) / 4) % q;
    
    int m4 = q - m3;

    int M1 = (a * m3 + b * m1) % n;
    int M2=(a*m3 + b * m2) % n;
    int M3=(a*m4+b*m1) % n;
    int M4=(a*m4+b*m2) % n;
    if (M1 >= 0 && M1 <= 255)
    {
        Console.Write(M1+" ");

    }
    else if (M1 > -256 && M1 < 0)
    {
        Console.Write(M1+256 + " ");

    }

    if (M2 >= 0 && M2 <= 255)
    {
        Console.Write(M2 + " ");

    }
    else if (M2 > -256&& M2 < 0)
    {
        Console.Write(M2 + 256 + " ");

    }

    if (M3 >= 0 && M3 <= 255)
    {
        Console.Write(M3 + " ");

    }
    else if (M3 > -256 && M3 < 0)
    {
        Console.Write(M3 + 256 + " ");

    }
    if (M4 >= 0 && M4 <= 255)
    {
        Console.WriteLine(M4 + " ");

    }
    else if (M4 > -256 && M4 < 0)
    {
        Console.WriteLine(M4 + 256 + " ");

    }

}

