class step1
{
    public static int Sum(int first, int last)
    {
        int s = 0;
        for (int i = first; i <= last; i++)
        {
            s += i;
            Thread.Sleep(10);
            Console.WriteLine($"Sum {i}");
        }
        return s;
    }

    public static Task<int> SumAsync(int first, int last)
    {
        Task<int> t = Task.Run( () =>
        {

            int s = 0;
            for (int i = first; i <= last; i++)
            {
                s += i;
                Thread.Sleep(10);
                Console.WriteLine($"Sum {i}");
            }
            return s;
        });
        return t;
    }

    public static void Main()
    {
        // #1. 아래 코드는 사용자가 스레드를 생성해서 Sum 을 호출한것
        
        //Task t = Task.Run(() => { Sum(1, 500); });


        // #2. 아래 코드는 사용자가 그냥 함수를 호출하면
        // => 함수가 내부적으로 스레드를 만들어 실행하고..
        // => 즉시 반환됨.
        Task<int> t2 = SumAsync(1, 500);

        Console.WriteLine("main 은 계속 실행될수 있음");

        // 결과가 필요하면 t2의 result 를 꺼내면 됨.
        int ret = t2.Result; // 결과가 있을때 (스레드 종료) 까지 대기

        Console.WriteLine($"결과 {ret}");
    }
}

