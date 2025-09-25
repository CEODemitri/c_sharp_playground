// float   | 6-9   | 4 bytes
// double  | 15-17 | 8 bytes
// decimal | 28-29 | 16 bytes

// floating point numeric types represent real number  
// all are value types, simple and can be initialized with literals


Console.WriteLine($"float: {float.MinValue} to {float.MaxValue}");
Console.WriteLine($"double: {double.MinValue} to {double.MaxValue}");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue}");

decimal aba = 0.1M;
double ba = 0.1;
float baba = 0.1f;

Console.WriteLine($"0.1: \ndecimal >> {aba}\ndouble >> {ba}\nfloat >> {baba}");

// type of real literal determined by suffix
/*
 *  literal without suffix {decimal a = 0.1} or with d|D is type [double]
 *  literal with f|F suffix is type float
 *  literal with m|M is type decimal
 */
 
double batteryLevel = 9.8;
batteryLevel = 22.99d;
batteryLevel = 44.23D;

float g = 4_500.3f;
g = 33.9F;

decimal exchangeEU = 1.198m;
decimal exchangeUS = 0.786M;

Console.WriteLine($"Print affair >> {batteryLevel}, {exchangeEU}, {exchangeUS}, {g}");

// may also use scientific notation in expressions
double vv = 0.42e2;
float vf = 4200032E-4f;
decimal ef = 1.45e5m;
Console.WriteLine($"scientific notation >> {vv}, {vf}, {ef}");

