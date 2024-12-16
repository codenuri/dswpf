int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// FirstOrDefault : 조건을 만족하는 1번째 값을 찾고, 
//                  없을때는 디폴트값(0)을 반환해 달라.
int v = x.FirstOrDefault( n => n % 2 == 0);

Console.WriteLine(v);