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





            //Console.WriteLine("================================================");

            //foreach (var item in ProductList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("================================================");

        }
    }
}
