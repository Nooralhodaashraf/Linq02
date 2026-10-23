using Linq02.Models;

namespace Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ProductList = DataSources.Source.ProductList;

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


            //Console.WriteLine("================================================");

            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("================================================");

        }
    }
}
