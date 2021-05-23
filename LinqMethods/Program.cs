using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Paging Methods
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(list.First());
            Console.WriteLine(list.FirstOrDefault());

            Console.WriteLine(list.Last());
            Console.WriteLine(list.LastOrDefault());

            Console.WriteLine(list.Single(s => s == 4));
            Console.WriteLine(list.SingleOrDefault(s => s == 4));

            Console.WriteLine(string.Join(',', list.Skip(5).Take(10)));

            Console.WriteLine(string.Join(',', list.SkipLast(2)));
            Console.WriteLine(string.Join(',', list.TakeLast(4)));

            Console.WriteLine(string.Join(',', list.TakeWhile(s => s < 3)));
            Console.WriteLine(string.Join(',', list.SkipWhile(s => s < 3)));

            Console.WriteLine(list.ElementAt(3));
            Console.WriteLine(list.ElementAtOrDefault(3));


            //Aggregate Methods

            Console.WriteLine("Maximum : " + list.Aggregate((s, r) => (s > r) ? s : r));
            Console.WriteLine("Minimum : " + list.Aggregate((s, r) => (s < r) ? s : r));
            Console.WriteLine("Total : " + list.Aggregate((s, r) => s + r));
            Console.WriteLine("10! : " + list.Aggregate((s, r) => r > 1 ? s * r-- : s));

            Console.WriteLine("Sum : " + list.Sum());
            Console.WriteLine("Max : " + list.Max());
            Console.WriteLine("Min : " + list.Min());
            Console.WriteLine("Count : " + list.Count());
            Console.WriteLine("Average : " + list.Average());

            //Ordering methods

            Console.WriteLine("OrderBy : " + string.Join(',', list.OrderBy(s => s)));
            Console.WriteLine("OrderByDescending : " + string.Join(',', list.OrderByDescending(s => s)));
            Console.WriteLine("Actual : " + string.Join(',', list));
            list.Reverse(1, 5);
            Console.WriteLine("Reverse : " + string.Join(',', list));
            list.Reverse(1, 5);
            Console.WriteLine("Actual : " + string.Join(',', list));

            var anotherList = new List<int>() { 1, 11, 3, 232, 34, 6, 75, 3, 8, 9, 54, 4, 54, 5 };

            var updatedList = list.Concat(anotherList);
            Console.WriteLine("Actual List : " + string.Join(',', list));
            Console.WriteLine("Another List : " + string.Join(',', anotherList));
            Console.WriteLine("Updated List : " + string.Join(',', updatedList));

            Console.WriteLine("Updated List with unique elements : " + string.Join(',', updatedList.Distinct()));
            Console.WriteLine(string.Join(',', updatedList.Except(list)));

            Console.WriteLine(string.Join(',', anotherList.Intersect(list)));
            Console.WriteLine(string.Join(',', list.Intersect(anotherList)));

            Console.WriteLine(string.Join(',', list.Union(anotherList)));
            Console.WriteLine(string.Join(',', updatedList.Distinct()));

            var customers = new ShopingData().GetCustomerDetails();
            var cartItems = new ShopingData().GetCartDetails();
            var customerAddress = new ShopingData().GetAddressDetails();

            var customerCompleteInfo = customers.Join(cartItems,
                s => s.CustomerId,
                r => r.CustomerId,
                (s, r) => new
                {
                    s.CustomerId,
                    s.Name,
                    r.ProductName,
                    r.Quantity
                }
                );

            foreach (var customer in customerCompleteInfo)
            {
                Console.WriteLine(customer.CustomerId + " " + customer.Name + " " + customer.ProductName);
            }

            var EvenNumbers = Enumerable.Range(1, 10);
            Console.WriteLine(string.Join(',', EvenNumbers));

            Console.WriteLine("10.5 is Integer ? {0}", (10.5m % 1 == 0));
            Console.WriteLine("10 is Integer ? {0}", (10.0m % 1 == 0));
        }
    }
}
