using LINQ;

LINQ_query _linq = new LINQ_query();
var values = _linq.Collection4LINQ;

var cars = from item in values
           where item.ToLower() != "nissan" && item.ToLower() != "bmw" //exclude nissan, bmw. 
           //orderby item.Length descending   //toyota, kia
           orderby item.Length ascending  //kia, toyota
           select item;

foreach (var item in cars) {
    Console.Write(item + " ");
}