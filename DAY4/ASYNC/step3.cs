class step1
{
    public static Task<int> SumAsync(int first, int last)
    {
        Task<int> t = Task.Run(() =>
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

    public static void ButtonClick()
    {
        Task<int> t2 = SumAsync(1, 500);

        Console.WriteLine("main 은 계속 실행될수 있음");

//        int ret = t2.Result;  // 이렇게 하면 주스레드가 Block 됩니다.
                                // UI Update 안됨

        var awaiter= t2.GetAwaiter();

        awaiter.OnCompleted(() => 
            { 
                Console.WriteLine($"결과 {awaiter.GetResult()}"); 
            });
    }

    public static void Main()
    {
        ButtonClick();
    }
}

