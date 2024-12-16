// step01.cs
using System;
using System.Windows;   // MessageBox 클래스가 이 안에 있습니다

// Console Project => WPF 사용하도록 변경하는 방법
// .csproj 파일(프로젝트 이름 클릭)에서 아래 변경

// 아래 1개 변경

//    < TargetFramework > net8.0-windows </ TargetFramework >

// 아래 1개 추가
// < UseWPF > true </ UseWPF >


// 아래 설정은 "console" 유무
//    < OutputType > WinExe </ OutputType >
// Exe : Console 생성
// WinExe : Console 없음.

// 외울 필요 없이 WPF 프로젝트 만들어서 .csproj 파일 참고하면 됩니다.


class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, C#");

        MessageBox.Show("Hello, WPF");
    }
}
// github.com/codenuri/dswpf 에서 받을수 있습니다.