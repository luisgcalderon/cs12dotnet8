string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;

WriteLine();
WriteLine(format: "{0,-10} {1,6}",
    arg0: "Name", arg1: "Count");
WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: applesText, arg1: applesCount);
WriteLine(format: "{0,-10} {1,6:N0}",
    arg0: bananasText, arg1: bananasCount);

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");
string age = ReadLine()!;
WriteLine($"Hello {firstName}, you look good for {age}.");

