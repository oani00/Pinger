// See https://aka.ms/new-console-template for more information
using System.Net.NetworkInformation;
using System;

Console.WriteLine("Hello, World!");

Pingador.Pinger p = new();

int iterations = 60 * 5; // 2 minutes = 120 seconds
int interval = 2000; // ping every 1 second

StreamWriter file = new StreamWriter("C:\\Users\\oani_\\OneDrive\\Área de Trabalho\\logNET.txt", true);

file.WriteLine($"\n\n\n--------------NOVOLOG--------------------");

file.Close();

for (int i = 0; i < iterations; i++)
{
    p.Ping_andLog();
    Thread.Sleep(interval);
}

Console.WriteLine("Pingei");