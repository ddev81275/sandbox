var values = new int[] { 1, 2, 3, 4, 5 };

Parallel.ForEach(values, value => {
    if (value % 2 == 0) {
        Console.WriteLine(value);
    }
});
Console.WriteLine("---------------------");
Parallel.ForEach(values, value => {
    if (value % 2 == 1) {
        Console.WriteLine(value);
    }
});
