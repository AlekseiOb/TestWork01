string[] LessThan(string[] input, int n) {
    string[] output = new string[CountArray(input, n)];
    for(int i = 0, j = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            output[j] = input[i];
            j++;
        }
    }
    return output;
}

int CountArray(string[] input, int n) {
    int count = 0;
    for(int i = 0; i < input.Length; i++) {
        if(input[i].Length <= n) {
            count++;
        }
    }
    return count;
}

string[] MyArray() {
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

string[] arrayIn = MyArray();
string[] arrayOut = LessThan(arrayIn, 3);
Console.WriteLine($"[{string.Join(", ", arrayIn)}] -> [{string.Join(", ", arrayOut)}]");