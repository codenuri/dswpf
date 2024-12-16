//int[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

object[] x = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// int v = x.FirstOrDefault(n => n % 2 == 0); // error
                                        // n 은 object 타입이므로
                                        // % 연산 안됨!

var col = x.Cast<int>(); // x 의 모든 요소를 int로 바라볼수 있는
                         // 새로운 컬렉션 뷰(복사본 아님)

int v = col.FirstOrDefault(n => n % 2 == 0);
                        // 이제 여기서 n 은 int 입니다.
                        // 따라서 이코드 ok

// 아래는 그냥 조건이 2개 인것
int v2 = col.FirstOrDefault(n => n % 2 == 0 && n > 5);


Console.WriteLine(v);