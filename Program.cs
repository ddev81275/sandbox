////using LINQ;

////LINQ_query _linq = new LINQ_query();
////var values = _linq.Collection4LINQ;

////var cars = from item in values
////           where item.ToLower() != "nissan" && item.ToLower() != "bmw" //exclude nissan, bmw. 
////           orderby item.Length ascending  //kia, toyota
////           select item;

//////foreach (var item in cars) {
//////    Console.Write(item + " ");
//////}

////var _ = from item in values
////        group item by item.Length;

//////foreach (var item in _) {
//////    Console.WriteLine(item.Key);
//////}

////var test = values.Where(item => item.ToLower() != "nissan" && item.ToLower() != "bmw").OrderByDescending(item => item.Length).Select(item => item);

////foreach (var item in test) {
////    Console.Write(item + " ");
////}

//string[] words = { "apples", "blueberries", "oranges", "bananas", "apricots" };

//var values = from item in words
//             group item by item.Length into _group
//             //where _group.Count() >= 2
//             select new { name = _group.Key };

//foreach (var item in values) {
//    Console.Write($"{item.name} ");
//}

using LINQ;

var categories =
    new List<Category>() {
        new Category { Name="Beverages",  ID=1 },
        new Category { Name="Condiments", ID=2 },
        new Category { Name="Vegetables", ID=3 },
        new Category { Name="Grains",     ID=4 },
        new Category { Name="Fruit",      ID=5 }
    };

var products =
    new List<Product>() {
        new Product {Name="Cola",     CategoryID=1},
        new Product {Name="Tea",      CategoryID=1},
        new Product {Name="Mustard",  CategoryID=2},
        new Product {Name="Pickles",  CategoryID=2},
        new Product {Name="Carrots",  CategoryID=3},
        new Product {Name="Bok Choy", CategoryID=3},
        new Product {Name="Peaches",  CategoryID=5},
        new Product {Name="Melons",   CategoryID=5},
};

var innerJoin = from c in categories
                join p in products on c.ID equals p.CategoryID
                select new { CategoryID = c.ID, ProductName = p.Name };

var groupJoin = from c in categories
                join p in products on c.ID equals p.CategoryID into _group
                select _group;


//foreach (var item in innerJoin) {
//    Console.WriteLine(item);
//}

foreach (var item in groupJoin) {
    Console.WriteLine(item);
}