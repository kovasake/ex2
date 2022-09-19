// int Max (int arg1 , int arg2, int arg3)
// {
//     int result = arg1;
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;
// }
// int [] array = {1,2,3,4,5,6,7,8,9};
// array [0] = 12;
// Console.WriteLine (array[4]);

// // int max = Max (
// //     Max (a1,b1,c1),
// //     Max (a2,b2,c2),
// //     Max (a3,b3,c3));

// Console.WriteLine (max);

// int [] array = {3,5,7,8,34,545,45};

// int n = array.Lenght;
// int find = 4;
// int index = 0;
// while (index < n)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine (index);
//     }
//     index ++;
// }

// void FillArray (int [] collection)
// {
//     int Lenght = collection.Length;
//     int index =0;
//     while (index < Lenght)
//     {
//     collection[index] = new Random ().Next (1,100);
//     index ++;
//     }
// }

// void PrintArray (int [] cool)
// {
//     int count = cool.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine (cool[position]);
//         position++;
//     }
// }

int IndexOf (int [] collection , int find)
{
    count= collection.Lenght;
    int index = 0;
    int position = 0;
    
    while (index < count )
    {
        if (collection [index] == find)
        {
             position = index;
        }

        index++;
    }
return position;
}

int [] array = new int [10];

FillArray (array);
PrintArray (array);
Console.WriteLine ();

int pos = IndexOf (array, 4);
Console.WriteLine (pos);