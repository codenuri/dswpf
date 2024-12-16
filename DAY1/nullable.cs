// C#
// reference type 은 null 이 될수 있지만
// value 타입은 nullable 을 사용할때면 null 가능 합니다.

int  n1 = null; // error
int? n2 = null; // ok. 널가능 value 타입

// 널인 객체를 사용하면 runtime 에 죽게 됩니다.
// 널은 꼭 필요 할때만 사용하는게 좋습니다.
int age = 0; // 나이는 반드시 값이 있어야 합니다.

string s1 = null; // 참조 타입은 null 가능
