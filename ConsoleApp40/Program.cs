namespace ConsoleApp40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };
            Product[] products = { new Product { Price = 1000, Discount = 50 } };
            var r1 = numbers.Min();
            var r2 = products.Sum(p => p.Price - p.Price/100*p.Discount);
            var r3 = numbers.Average();
            var r4 = numbers.All(p=>p %2==0);
            var r5 = numbers.Count(p=>p%2==0);
            var r6 = numbers.Max();
            var r7 = products.MinBy(p => p.Price);

            var r8 = products
                .Select(p => new { p.Name, Price = p.Price - p.Price / 100 * p.Discount });
               

            foreach(var item in r8)
            {
                Console.WriteLine(item.Name);
            }

            var a = r8.Count();


        }
    }
}