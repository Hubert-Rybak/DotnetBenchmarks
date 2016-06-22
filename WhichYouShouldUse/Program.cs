using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;
using WhichYouShouldUse.Configs;
using WhichYouShouldUse.Models;

namespace WhichYouShouldUse
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListVsCollection>();
            Console.ReadKey();
        }
    }
}
