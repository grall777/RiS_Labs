﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;


using ClassLibrary1;




namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создать канал между клиентом и сервером, создать объект типа HttpChannel
            HttpChannel ch = new HttpChannel(5000); // номер порта = 5000 - выбран наугад
                                                    // 2. Зарегистрировать канал ch, в методе RegisterChannel() указывается уровень безопасности false
            ChannelServices.RegisterChannel(ch, false);
            // 3. Зарегистрировать сервис как WKO
            RemotingConfiguration.RegisterWellKnownServiceType(
            typeof(ClassLibrary1.Class1),
            "MathFunctions.soap",
            WellKnownObjectMode.Singleton);
            // 4. Вывести сообщения, что сервис в состоянии выполнения
            Console.WriteLine("MathFunctions service is ready...");
            // 5. Остановить, оставить сервис в состоянии выполнения, пока не будет нажата клавиша Enter
            Console.ReadLine();

        }
    }
}