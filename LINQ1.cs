// LINQ1.cs

int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


// 아래 코드에서 y 는 collection 입니다.(배열 같은 것)
// => x의 요소중 짝수면 열거 가능한것
var y = x.Where( n => n % 2 == 0 );

// var y = x.Where(람다표현식);


foreach(var e in y)
    Console.WriteLine( e );



