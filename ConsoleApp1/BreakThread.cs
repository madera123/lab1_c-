namespace threaddemo;

public class BreakThread
{
    private bool canBreak = false;
    private int time;

    public int getTime() {
        return time;
    }
    public  void setTime(int value){
        time=value;
    }
    public void Run() {
            Thread.Sleep(time);
        canBreak = true;
    }

    public bool isCanBreak() {
        return canBreak;
    }
}