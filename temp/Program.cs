// 

// int[] a =  {1,6,6,4,5};
// for (int i = 0; i < a.Length; i++)
// {
//     Console.WriteLine(a[i]);
// }
// int imax = 0;
// for (int k = 0; k < a.Length; k++)
// {
//   int max = a[k];

// for (int i = k; i < a.Length; i++)
// {
//     if (max<=a[i])
//     {
//         max = a[i];
//         imax = i;
//     }
// }
// max = a[k];
// a[k] = a[imax];
// a[imax] = max;


// for (int i = 0; i < a.Length; i++)
// {
//     Console.Write(a[i]);
// }
// Console.WriteLine("");
// }

// Random rnd = new Random();
// int[] a = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     a[i] = rnd.Next(1, 9 + 1);
//     Console.WriteLine(a[i]);
// }

// for (int i = 0; i < 8; i++)
// {
//     Console.WriteLine(a[i]);
// }

Random rnd = new Random();
int[] a = new int[10];
a[0] = rnd.Next(10, 100);

for (int i = 1; i < 10; i++)
{
    a[i] = rnd.Next(10, 100);
link:
int k = 0;
    for (int j = 0; j < i; j++)
    {
        if (a[j] == a[i]) 
        {
            a[j] = rnd.Next(10, 100);
        k=1;
        }
        else k = 0;
    }
    if (k==1) goto link;
    


    Console.WriteLine(a[i]);
}
