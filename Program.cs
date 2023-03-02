int age = 55;
int _value;


//InModifierTest(in age);
//RefModifierTest(ref age);
//OutModifierTest(out _value);
Test test = new Test();
test.SetValue(10);
int value = test.GetValue();

Console.WriteLine(test.Age);
Console.WriteLine(value);
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

public class Test {
    private readonly int _age;
    private static int _value;

    public Test() {
        _age = 10;
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