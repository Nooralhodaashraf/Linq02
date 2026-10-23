using Linq02.Models;
using System.Diagnostics.Metrics;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ProductList = DataSources.Source.ProductList;
            var CustomerList = DataSources.Source.CustomerList;

            #region 1. Get top 3 most expensive products 
            //var result = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);


            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 2. show page 2 of products, with page size = 5 
            //var results= ProductList.Skip(5).Take(5);

            // foreach (var item in results)
            // {
            //     Console.WriteLine(item);
            // }


            #endregion

            #region 3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 4. Check if ALL products in the "Seafood" category are in stock 
            //var result= ProductList.All(p => p.Category == "Seafood");
            //Console.WriteLine(result);

            #endregion

            #region 5. Check if the ID list contains 9 

            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Single(p=> p == 9);
            //Console.WriteLine(result);


            #endregion

            #region 6. Group all products by Category and print each group  with its product count.
            // var result = ProductList.GroupBy(P => P.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"    [{group.Key}]  ({group.Count()} products)");
            //}

            #endregion

            #region 7. Group products by Category and project only product names  per  group

            //var result = ProductList.GroupBy(P => P.Category);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"    [{group.Key}]  ");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item.ProductName);
            //    }
            //}

            #endregion

            #region 8. Find all categories that have MORE THAN 3 products 
            //var result = ProductList.GroupBy(P => P.Category)
            //                        .Where(G => G.Count() > 3)
            //                        .Select(G => new
            //                        {
            //                            CategoryName = G.Key,
            //                            CountOfProducts = G.Count()
            //                        });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.CategoryName}  count: {item.CountOfProducts} ");
            //}


            #endregion

            #region 9. Using QUERY SYNTAX, group customers by Country, and for  each  group select { Country, Count, TotalOrderValue }.
            //var QueryCustomers = from C in CustomerList
            //                     group C by C.Country
            //             into Countries
            //                     select new
            //                     {
            //                         CountryName = Countries.Key,
            //                         CountOfCustomers = Countries.Count(),
            //                         TotalOrderValue = Countries.Sum(C => C.Orders.Sum(O => O.Total))
            //                     };

            //foreach (var item in QueryCustomers)
            //{
            //    Console.WriteLine($"{item.CountryName}: {item.CountOfCustomers} customers, Total Order Value: {item.TotalOrderValue}");
            

            //}



            #endregion
            //Console.WriteLine("================================================");

            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("================================================");

        }
    }
}
