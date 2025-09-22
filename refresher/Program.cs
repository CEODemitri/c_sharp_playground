// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"short :{short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");

// integral types
// 8 integral types for 8-bit, 16-bit, 32-bit, 64-bit values unsigned and signed
// sbyte, byte, short, ushort, int, uint, long, ulong

// sybte -128 to 127 used for small numbers such as a counter or a small array index
sbyte appleCount = 10;
sbyte orangeCount = 20;
sbyte fruitCount = (sbyte)(appleCount + orangeCount);
Console.WriteLine($" sbyte >> fruitCount : {fruitCount}");

// short -32,768 to 32,767 used for signed values that that don't require large range
short elevation = 32000;
Console.WriteLine($" short >> elevation : {elevation}");

// int -2,147,483,648 to 2,147,483,647 used for most common integer values
int populationUSA = 330000000;
Console.WriteLine($" int >> populationUSA : {populationUSA}");

// long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807 used for large integer values
long distanceToAlphaCentauri = 9461000000000;
Console.WriteLine($" long >> distanceToAlphaCentauri : {distanceToAlphaCentauri}");

// byte 0 to 255 used for small numbers such as ASCII values
byte smiley = 0x2A;
Console.WriteLine($" byte >> smiley : {smiley}");

// ushort 0 to 65,535 used for positive numbers that don't require large range
ushort usElevation = 32000;
Console.WriteLine($" ushort >> usElevation : {usElevation}");

// uint 0 to 4,294,967,295 used for positive numbers that don't require negative values
uint kenyaPopulation = 43000000;
Console.WriteLine($" uint >> kenyaPopulation : {kenyaPopulation}");

// ulong 0 to 18,446,744,073,709,551,615 used for large positive numbers
ulong starsInMilkyWay = 250000000000;
Console.WriteLine($" ulong >> starsInMilkyWay : {starsInMilkyWay}");

// implicit conversion from smaller to larger integral types accepted
int count = appleCount;
long distance = distanceToAlphaCentauri;

// explicit conversion from larger to smaller integral types requires casting
short smallDistance = (short)distanceToAlphaCentauri; // data loss
Console.WriteLine($" short >> smallDistance : {smallDistance}");

// literal suffixes
long bigNumber = 3000000000L;
uint averageElevation = 32000U;
ulong starsInUniverse = 10000000000000000UL;

// OVERFLOW 
// unchecked: if overflow, wrap around without exception. may silently corrupt data (Default behavior for integral types)
int alpha = int.MaxValue;
int beta = alpha + 3;
Console.WriteLine($" unchecked >> beta : {beta}"); // -2147483646

// checked: if overflow, will throw OverflowException
try
{
    checked
    {
        int a = int.MaxValue;
        int b = a + 3;
    }
}
catch (OverflowException ex)
{
    Console.WriteLine($" checked >> OverflowException caught: {ex.Message}");
}

// integral division
int test1 = 7 / 4; // 1
Console.WriteLine($" integral division >> test1 : {test1}");

// to get a floating-point result, at least one operand must be a floating-point type
double test2 = 7 / 4.0; // 1.75
Console.WriteLine($" floating-point division >> test2 : {test2}");