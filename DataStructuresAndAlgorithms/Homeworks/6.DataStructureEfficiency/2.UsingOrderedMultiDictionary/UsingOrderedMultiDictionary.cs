﻿// 2.A large trade company has millions of articles, each described by barcode, vendor, title and price. 
// Implement a data structure to store them that allows fast retrieval of all articles in given price range [x…y]. 
// Hint: use OrderedMultiDictionary<K,T> from Wintellect's Power Collections for .NET. 
namespace UsingOrderedMultiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class UsingOrderedMultiDictionary
    {
        private static readonly Random Rand = new Random();

        public static void Main()
        {
            OrderedMultiDictionary<decimal, Article> articlesByPrice = CreateArticles();

            decimal fromPrice = 0.99m;
            decimal toPrice = 9.99m;

            PrintArticlesInRange(articlesByPrice, fromPrice, toPrice);
        }

        private static OrderedMultiDictionary<decimal, Article> CreateArticles()
        {
            var articlesByPrice = new OrderedMultiDictionary<decimal, Article>(true);
            var numArticles = 100;
            var minPrice = 0.01;
            var maxPrice = 99.99;
            for (int i = 0; i < numArticles; i++)
            {
                var article = new Article(GetRandomPrice(minPrice, maxPrice), "Product" + i);
                articlesByPrice.Add(article.Price, article);
            }

            return articlesByPrice;
        }

        private static void PrintArticlesInRange(
            OrderedMultiDictionary<decimal, Article> articlesByPrice,
            decimal fromPrice,
            decimal toPrice)
        {
            Console.WriteLine("Articles in range [{0}; {1}]", fromPrice, toPrice);
            Console.WriteLine("==============================");
            var articlesInRange = articlesByPrice.Range(fromPrice, true, toPrice, true);
            foreach (var article in articlesInRange)
            {
                Console.WriteLine(article.Value);
            }
        }

        private static decimal GetRandomPrice(double minPrice, double maxPrice)
        {
            var randomDouble = (Rand.NextDouble() * (maxPrice - minPrice)) + minPrice;
            var randomPrice = (decimal)Math.Round(randomDouble, 2);
            return randomPrice;
        }
    }
}