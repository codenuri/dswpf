// C#
// reference type 은 null 이 될수 있지만
// value 타입은 nullable 을 사용할때면 null 가능 합니다.

int  n1 = null; // error
int? n2 = null; // ok. 널가능 value 타입

// 널인 객체를 사용하면 runtime 에 죽게 됩니다.
// 널은 꼭 필요 할때만 사용하는게 좋습니다.
int age = 0; // 나이는 반드시 값이 있어야 합니다.
            // 따라서, 이때는 int? 보다는 이 타입이 
            // 훨씬 좋습니다.

// 결론 : int 같은  value 타입은 int 사용할지, int? 사용할지
//        선택가능합니다.

// 그런데, string, Image, Button, Window 같은 
// reference 타입은 항상 null 이 가능했습니다.

string s1 = null; // 참조 타입은 null 가능
string? s2 = null;

Console.WriteLine(s1);