﻿int a = 1;
int b = 2;
int c = 6;
int d = 8;
int f = 4;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (f > max) max = f;

Console.Write ("max = ");
Console.WriteLine (max);