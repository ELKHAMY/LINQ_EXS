
namespace linq_exs;
internal class Program
{
    public static object ProductList { get; private set; }

    private static void Main(string[] args)
    {
        string filePath = @"C:\Users\jmalm\Downloads\dictionary_english.txt";


        List<string> FileContent = new List<string>();

        try
        {
            FileContent = File.ReadAllLines(filePath).ToList();
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred while reading the file: " + e.Message);
        }

        foreach (string file in FileContent) Console.WriteLine(file);

        //----------------------------------------------------------------------------------------
        //Console.WriteLine(FileContent.Count);
        //foreach (string line in FileContent)
        //{
        //    Console.WriteLine(line);
        //}
        //try
        //{
        //    string[] FileContent = File.ReadAllLines(filePath);
        //}
        //catch (IOException e)
        //{
        //    Console.WriteLine("An error occurred while reading the file: " + e.Message);
        //}

        //foreach (string line in FileContent)
        //{
        //    Console.WriteLine(line);
        //}

        //-------------------------------------------------------------------------------------------------------
        //var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
        //foreach (var product in outOfStockProducts) { Console.WriteLine(product); Console.WriteLine(); } 


        //-------------------------------------------------------------------------------------------------------
        //var ProductsInStock = ProductList.Where(p => p.UnitsInStock != 0 && p.UnitPrice > 3.00m);
        //foreach (var product in ProductsInStock) { Console.WriteLine(product); } 


        //-------------------------------------------------------------------------------------------------------
        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //var digits = Arr.Where((digit, index) => digit.Length < index);
        //foreach (var digit in digits) { Console.WriteLine($"The word {digit} is shorter than its value."); }

        //-------------------------------------------------------------------------------------------------------
        //var firstProduct = ProductList.Where(p=>p.UnitsInStock ==0).FirstOrDefault();
        //Console.WriteLine(firstProduct); 
        //-------------------------------------------------------------------------------------------------------
        //var product = ProductList.Where(p => p.UnitPrice > 1000).FirstOrDefault();
        //Console.WriteLine(product?.ToString()??"No Data"); 

        //-------------------------------------------------------------------------------------------------------
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var numbers = Arr.Where(x => x > 5).Skip(1).Take(1);
        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //} 
        //-------------------------------------------------------------------------------------------------------
        //var uniqueCategoryName = ProductList.Select(x => x.Category).Distinct();
        //foreach (var category in uniqueCategoryName) { Console.WriteLine(category); } 
        //-------------------------------------------------------------------------------------------------------
        //var sec = CustomerList;

        ////foreach (var item in sec) { Console.WriteLine(item); Console.WriteLine(); }

        ////var firstLetters = CustomerList.Select(c => c.Country.FirstOrDefault()).Distinct()
        ////.Union(ProductList.Select(p => p.ProductName.FirstOrDefault()).Distinct());

        ////foreach (var item in firstLetters) { Console.Write(item+" ,"); } 

        //-------------------------------------------------------------------------------------------------------
        //var letters = CustomerList.Select(c => c.Country.FirstOrDefault())
        //              .Intersect(ProductList.Select(p => p.ProductName.FirstOrDefault()));

        //foreach (var item in letters) { Console.Write(item + " ,"); } 
        //-------------------------------------------------------------------------------------------------------
        //var letters = CustomerList.Select(c => c.CompanyName.FirstOrDefault())
        //              .Except(ProductList.Select(p => p.ProductName.FirstOrDefault()));

        //foreach (var item in letters) { Console.Write(item + " ,"); } 
        //-------------------------------------------------------------------------------------------------------
        //var letters = CustomerList.Select(c => c.Country.Substring(Math.Max(0, c.Country.Length - 3)))
        //       .Union(ProductList.Select(p => p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3))));
        //foreach (var item in letters) { Console.Write(item + " ,"); }
        //-------------------------------------------------------------------------------------------------------
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var count = Arr.Where(x => x % 2 != 0).Count();
        //Console.WriteLine(count);
        //foreach (int i in newArr)
        //{
        //    Console.WriteLine(i);
        //} 
        //-------------------------------------------------------------------------------------------------------
        //var customersData = CustomerList.Select(x => new { x, NumberOfOrders = x.Orders.Length });
        //foreach (var customer in customersData)
        //{
        //    Console.WriteLine(customer);
        //    Console.WriteLine();
        //} 
        //var categories = ProductList
        //    .GroupBy(x => x.Category)
        //    .Select(x => new { category = x.Key, count = x.Count() });

        //foreach (var item in categories)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine();
        //-------------------------------------------------------------------------------------------------------
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var total = Arr.Sum();
        //Console.WriteLine(total);
        //-------------------------------------------------------------------------------------------------------

        // Get the total number of characters of all words in dictionary_english.txt
        // //(Read dictionary_english.txt into Array of String First)
        //var total = FileContent.SelectMany(x => x.Split(" ")).Sum(x => x.Length);
        //Console.WriteLine(total);
        //-------------------------------------------------------------------------------------------------------

        //var totalUnit = ProductList
        //    .Where(x=>x.UnitsInStock!=0)
        //    .GroupBy(x => x.Category)
        //    .Select(x => new { category = x.Key, count = x.Count() });

        //foreach (var item in totalUnit)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------

        //var shortest = FileContent.OrderBy(x => x.Length).FirstOrDefault();
        //var longest = FileContent.OrderByDescending(x => x.Length).FirstOrDefault();
        //Console.WriteLine(shortest);
        //Console.WriteLine(longest);

        //var lenght = FileContent.Min(x => x.Length);
        //Console.WriteLine(lenght);
        //-------------------------------------------------------------------------------------------------------

        //var price = ProductList.Min(x => x.UnitPrice);
        //var cheapestProduct = ProductList.Where(x => x.UnitPrice == price); // IEnumerable of products (collection)

        //var cheapestPriceProduct = ProductList.MinBy(x => x.UnitPrice); // single product
        //Console.WriteLine(cheapestPriceProduct);
        //-------------------------------------------------------------------------------------------------------

        //var cheapestPriceProduct = ProductList.GroupBy(x => x.Category).
        //    Select(g => new { Category = g.Key, product = g.MinBy(x => x.UnitPrice) });
        //foreach (var x in cheapestPriceProduct)
        //{
        //    Console.WriteLine($"{x.Category} => {x.product?.ProductName}");
        //}
        //-------------------------------------------------------------------------------------------------------

        //var length = FileContent.MaxBy(x => x.Length);
        //Console.WriteLine(length);

        //Console.WriteLine(length.Length);
        //-------------------------------------------------------------------------------------------------------

        // var ExpensivePriceProduct = ProductList.GroupBy(x => x.Category).
        //   Select(g => new { Category = g.Key, product = g.MaxBy(x => x.UnitPrice) });

        //foreach (var p in ExpensivePriceProduct)
        //{
        //    Console.WriteLine($"Category: {p.Category} => Price: {p.product?.ProductName}, {p.product?.UnitPrice}");
        //}
        //Console.WriteLine();

        //-------------------------------------------------------------------------------------------------------

        // var ExpensivePriceProducts = ProductList.GroupBy(x => x.Category).
        //    Select(g => new { Category = g.Key, product = g.MaxBy(x => x.UnitPrice) });

        //foreach (var p in ExpensivePriceProducts)
        //{
        //    Console.WriteLine($"Category: {p.Category} => Product: {p.product?.ProductName}, {p.product?.UnitPrice}");
        //}
        //-------------------------------------------------------------------------------------------------------

        //var avg = FileContent.Average(x => x.Length);
        //Console.WriteLine(avg);
        //-------------------------------------------------------------------------------------------------------
        //var averagePrice = ProductList.GroupBy(x => x.Category).
        //   Select(g => new { Category = g.Key, product = g.Average(x => x.UnitPrice) });


        //foreach (var p in ExpensivePriceProducts)
        //{
        //    Console.WriteLine($"Category: {p.Category} => Average Price: {p.product?.UnitPrice}");
        //}
        //-------------------------------------------------------------------------------------------------------

        //var products = ProductList.OrderBy(x => x.ProductName).Select(x => x.ProductName);
        //foreach (var pr in products)
        //{
        //    Console.WriteLine(pr);
        //}
        //-------------------------------------------------------------------------------------------------------

        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //Array.Sort(Arr, new CaseInsensitiveComparer());
        //foreach (var item in Arr)
        //{
        //    Console.WriteLine(item);
        //}

        //-------------------------------------------------------------------------------------------------------

        //var sortedProducts = ProductList.OrderByDescending(x => x.UnitPrice).Select(x => new { x.ProductName, x.UnitPrice });
        //foreach (var p in sortedProducts)
        //{
        //    Console.WriteLine(p);
        //}

        //-------------------------------------------------------------------------------------------------------

        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var sortedArray = Arr.OrderBy(x => x.Length).OrderBy(x => x);
        //foreach (var item in sortedArray)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------

        //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //var sortedArray = words.OrderBy(x => x.Length).Order(new CaseInsensitiveComparer());

        //foreach (var item in sortedArray)
        //{
        //    Console.WriteLine(item);
        //}

        //-------------------------------------------------------------------------------------------------------

        //var products = ProductList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
        //foreach (var item in products)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------

        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //var sortedArray = Arr.OrderBy(x => x.Length).OrderByDescending(x=>x,new CaseInsensitiveComparer());
        //foreach (var item in sortedArray)
        //{
        //    Console.WriteLine(item);
        //}

        //-------------------------------------------------------------------------------------------------------

        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //Array.Reverse(Arr);
        //var newArray = Arr.Where(x => x[1] == 'i');
        //foreach (var item in newArray)
        //{
        //    Console.WriteLine(item);

        //}
        //-------------------------------------------------------------------------------------------------------
        //var orders = CustomerList.Where(x => x.City == "Washington").Take(3);
        //foreach (var item in orders)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------

        //var orders = CustomerList.Where(x => x.City == "Washington").Take(2);
        //foreach (var item in orders)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var nums = numbers.TakeWhile((number, index) => number > index);
        //foreach (var n in nums)
        //{
        //    Console.WriteLine(n);
        //}

        //-------------------------------------------------------------------------------------------------------

        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var nums = numbers.Where(x => x % 3 == 0);
        //foreach (var item in nums)
        //{
        //    Console.WriteLine(item);
        //}

        //-------------------------------------------------------------------------------------------------------
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var nums = numbers.Where((number, index) => number < index);
        //foreach (var item in nums)
        //{
        //    Console.WriteLine(item);

        //}

        //-------------------------------------------------------------------------------------------------------
        //var products = ProductList.Select(x => x.ProductName);

        //foreach (var item in products)
        //{
        //    Console.WriteLine(item);

        //}
        //-------------------------------------------------------------------------------------------------------

        //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        //var newWords = words.Select(x => new { UpperCaseWords = x.ToUpper(), LowerCaseWords = x.ToLower() });

        //foreach (var item in newWords)
        //{
        //    Console.WriteLine(item);

        //}
        //-------------------------------------------------------------------------------------------------------

        //var products = ProductList.Select(x => new { x.ProductID, x.ProductName, Price = x.UnitPrice });
        //foreach (var item in products)
        //{
        //    Console.WriteLine(item);

        //}
        //-------------------------------------------------------------------------------------------------------
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = Arr.Select((n, i) => n ==i);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------
        //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        //int[] numbersB = { 1, 3, 5, 7, 8 };

        //var pairs = numbersA.SelectMany(n => numbersB.Where(x => n < x), (a, x) => new { NumberA = a, NumberB = x });
        //foreach (var item in pairs)
        //{
        //    Console.WriteLine($"The number {item.NumberA} is less than {item.NumberB}");
        //}
        //-------------------------------------------------------------------------------------------------------
        //var orders = CustomerList.SelectMany(x => x.Orders).Where(x => (decimal)x.Total < 500.00m);
        ////Console.WriteLine(orders);

        //foreach (var item in orders)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------
        //var orders = CustomerList.SelectMany(x => x.Orders).Where(x => x.OrderDate.Year>1998);
        //foreach (var item in orders)
        //{
        //    Console.WriteLine(item);
        //}
        //-------------------------------------------------------------------------------------------------------

        //var check = FileContent.Any(w => w.Contains("ei"));

        //Console.WriteLine(check);
        //-------------------------------------------------------------------------------------------------------

        //var products = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
        //foreach (var product in products)
        //{
        //    Console.WriteLine(product.Key);
        //    foreach (var p in product)
        //    {
        //        Console.WriteLine(p);
        //    }
        //    Console.WriteLine();

        //}

        //-------------------------------------------------------------------------------------------------------
        //var products = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock != 0));
        //foreach (var product in products)
        //{
        //    Console.WriteLine(product.Key);
        //    foreach (var p in product)
        //    {
        //        Console.WriteLine(p);
        //    }
        //    Console.WriteLine();

        //}
        //-------------------------------------------------------------------------------------------------------
        //List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        //var numbersGroub = numbers.GroupBy(n => n % 5);
        //foreach (var group in numbersGroub)
        //{
        //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5");
        //    foreach (var n in group)
        //    {
        //        Console.WriteLine($"{n}");
        //    }
        //    Console.WriteLine();
        //}

        //-------------------------------------------------------------------------------------------------------

        //var group = FileContent.GroupBy(w => w[0]);

        //foreach (var item in group)
        //{
        //    Console.WriteLine(item.Key);
        //    foreach (var w in item)
        //    {
        //        Console.WriteLine($"{w}");
        //    }
        //    Console.WriteLine();
        //}

        //-------------------------------------------------------------------------------------------------------

        string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };


        var groupedWords = Arr.GroupBy(w => w.TrimEnd(), new CheckEquality());

        foreach (var group in groupedWords)
        {
            Console.WriteLine(group.Key);
            foreach (var word in group)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine();
        }
    }
}