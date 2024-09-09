#region Exploring unary operators
int a = 3;
int b = a++;
WriteLine($"a is {a}, b is {b}");
#endregion

#region Using prfix
int c = 3;
int d = ++c; // Prefix means increment c before assigning it.
WriteLine($"c is {c}, d is {d}");
#endregion

#region Exploring logical operators
bool p = true;
bool q = false;

WriteLine($"AND  | p    | q    ");
WriteLine($"p    | {p & p,-5} | {p & q,-5} ");
WriteLine($"q    | {q & p,-5} | {q & q,-5} ");
WriteLine();
WriteLine($"OR   | p    | q    ");
WriteLine($"p    | {p | p,-5} | {p | q,-5} ");
WriteLine($"q    | {q | p,-5} | {q | q,-5} ");
WriteLine();
WriteLine($"XOR   | p    | q    ");
WriteLine($"p    | {p ^ p,-5} | {p ^ q,-5} ");
WriteLine($"q    | {q ^ p,-5} | {q ^ q,-5} ");
#endregion

#region ConditionalOperator
WriteLine();
// Note that DoStuff() returns true;
WriteLine($"p & DoStuff() = {p & DoStuff()}");
WriteLine($"q & DoStuff() = {q & DoStuff()}");

WriteLine();
WriteLine($"p && DoStuff() = {p && DoStuff()}");
WriteLine($"q && DoStuff() = {q && DoStuff()}");
#endregion

WriteLine();
int x = 10;
int y = 6;

WriteLine("Expression   |   Decimal |   Binary");
WriteLine("-----------------------------------");
WriteLine($"x           |   {x,7} | {x:B8}");
WriteLine($"y           |   {y,7} | {y:B8}");
WriteLine($"x & y       |   {x & y,7} | {(x & y):B8}");
WriteLine($"x | y       |   {x | y,7} | {(x | y):B8}");
WriteLine($"x ^ y       |   {x ^ y,7} | {(x ^ y):B8}");
#region 
static bool DoStuff()
{
    WriteLine("I am doing some stuff.");
    return true;
}
#endregion