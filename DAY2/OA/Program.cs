﻿
// C/C++ 은 double 을 int 에 넣을때 에러 없이 "경고" 지만
// C# 을 비롯한 대부분의 언어는 "컴파일 에러" 입니다.

double d = 3.4;
//int n = d;  // 컴파일러가 d 가 Double 임을 명확히 알수 있기때문에
// 컴파일 시에 에러가 발생

object obj = d; // ok. C#의 모든 값은 object로 가리킬수 있다.

//int n1 = obj; // 컴파일 에러

int n2 = (int)obj; // 컴파일에러 일까요?
                   // 런타입에러일까요 ?
                   // 아무 문제 없을까요 ?
