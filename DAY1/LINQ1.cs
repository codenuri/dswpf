// LINQ1.cs

int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var y = x.Where( x => x % 2 == 0 );
// var y = x.Where(람다표현식);

foreach(var e in y)
    Console.WriteLine( e );



