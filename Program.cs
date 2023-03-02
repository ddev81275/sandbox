int age = 55;
int _value;


InModifierTest(in age);
RefModifierTest(ref age);
OutModifierTest(out _value);

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