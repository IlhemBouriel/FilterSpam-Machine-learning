using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NaiveBayes;


namespace FilterSpamML
{
    class Program
    {
        static void Main(string[] args)
        {
            NaiveBayes.NaiveBayes naiveBayes = new NaiveBayes.NaiveBayes();
            // spam mail
            var result = naiveBayes.CheckEmail("Buy Cheap cialis Online");
            Assert.AreEqual(true, result);
            Console.WriteLine(result.ToString());
            // not spam mail
            result = naiveBayes.CheckEmail("Thanks in advance for your support");
            Assert.AreEqual(false, result);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
