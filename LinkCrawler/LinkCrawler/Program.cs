﻿using System;
using System.Diagnostics;
using System.IO;
using System.Security.Policy;

namespace LinkCrawler
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            var crawler = new LinkCrawler();
            crawler.CrawlLinks();

            sw.Stop();
            var elapsedTime = sw.Elapsed;
            var outputMessage = string.Format("____Finsihed____ {0}d {1}H {2}m {3}s", elapsedTime.Days, elapsedTime.Hours, elapsedTime.Minutes,
                elapsedTime.Seconds);
            Console.WriteLine(outputMessage);
            Console.ReadLine();
        }
    }
}
