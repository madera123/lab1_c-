namespace threaddemo;

public class MainThread
{
    private int id;
    private BreakThread breakThread;
    private int step;

    public MainThread(int id, BreakThread breakThread, int step)
    {
        this.id = id;
        this.breakThread = breakThread;
        this.step = step;
    }
    public void Run()
    {
        long col = 0;
        long sum = 0;
        bool isStop = false;
        do
        {
            col++;
            sum += step;
            isStop = breakThread.isCanBreak();
        } while (!isStop);
        Console.WriteLine(id + " sum - " + sum + " col - " + col);
    }
}