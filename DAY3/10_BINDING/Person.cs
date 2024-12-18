// Person.cs

// 아래 처럼만 만들면 
// => Person 객체의 Name, Address 를
// => UI 의 컨트롤(TextBox)과 연결가능합니다
// => 단, 객체의 상태가 변경될때 연결된 컨트롤에 통보가 안됩니다.(관찰자 패턴이아님)
/*
class Person
{
    public string Name { get; set; }
    public string Address { get; set; }
}
*/

/*
class Person
{

    public string Name { get; set; }
    public string Address { get; set; }

//  public List<Person 과연결된 UI 객체의 약속된함수이름> observer;
//  => 결국 delegate(event) 문법

//  Name 또는 Address 가 변경되면 자신과 연결된 모든 UI 객체(observer)에
//  통보

//  위내용을 "약속된 방식" 으로 구현하면 됩니다.
}
*/

// 약속된 방식 : INotifyPropertyChanged 라는 인터페이스를 구현 하면 됩니다.

using System.ComponentModel;

class Person : INotifyPropertyChanged
{
    // 아래 코드에서 "PropertyChanged" 는 delegate 입니다.
    // => C 언어의 함수 포인터 의 배열 정도로 생각하세요
    // => UI(TextBox)가 Person 객체 pe에 연결될때
    //    이미 아래 필드에 함수를 등록해 놓게 됩니다.
    //    이제 속성이 변경되면 아래 등록된 함수를 호출하며 됩니다.
    public event PropertyChangedEventHandler? PropertyChanged;

    // set 에서 통보해야 하므로 아래처럼 auto property로는 안됩니다.
    //  public string Name { get; set; }
    //  public string Address { get; set; }

    // #1. 필드를 먼저 만들고
    private string name;
    private string address;

    // #2. Property를 만들어야 합니다.
    public string Name
    {
        get { return name; }
        set { name = value;

            if (PropertyChanged != null)
            {
                // 아래 코드는 그냥 등록된 함수를 호출하는 것입니다.
                // => 인자는 객체(pe) 주소와 어떤 Property 가 변경되었는지
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }

        }
    }
    public string Address
    {
        get { return address; }
        set
        {
            address = value;

            if (PropertyChanged != null)
            {
                // 아래 코드는 그냥 등록된 함수를 호출하는 것입니다.
                // => 인자는 객체(pe) 주소와 어떤 Property 가 변경되었는지
                PropertyChanged(this, new PropertyChangedEventArgs("Address"));
            }

        }
    }

    public override string ToString()
    {
        return $"{Name}, {Address}";
    }

}