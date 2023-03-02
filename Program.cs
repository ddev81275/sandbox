int age = 55;
int _value;


//InModifierTest(in age);
//RefModifierTest(ref age);
//OutModifierTest(out _value);
Test test = new Test();
test.SetValue(10);
int value = test.GetValue();
int year = Test.year;

Console.WriteLine(test.Age);
Console.WriteLine(value);
Console.WriteLine(year);

void InModifierTest(in int age) {
    //age += 1;
    Console.WriteLine($"{age}");
}

void RefModifierTest(ref int age) {
    Console.WriteLine("ref");
}

void OutModifierTest(out int _value) {
    _value = 0;
    _value += 10;
    Console.WriteLine($"{_value}");
}

class Test {
    private readonly int _age;
    // Static variable that must be initialized at run time.
    private static int _value;
    public static int year;
    static Test() {
        year = DateTime.Now.Year;
    }

    public int Age {
        get => _age;
    }

    public void SetValue(int value) {
        _value = value;
    }
    public int GetValue() {
        return _value;
    }
}