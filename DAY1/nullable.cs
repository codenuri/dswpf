// C#
// reference type 은 null 이 될수 있지만
// value 타입은 nullable 을 사용할때면 null 가능 합니다.
int  n1 = null; // error
int? n2 = null; // ok. 널가능 value 타입

string s1 = null; // 참조 타입은 null 가능
