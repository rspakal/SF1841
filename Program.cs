// See https://aka.ms/new-console-template for more information
using SF1841;
using SF1841.Commands;

public class Program
{
    public static void Main()
    {
        UserAction userAction = new UserAction();
        YouTubeReceiver receiver = new YouTubeReceiver("https://www.youtube.com/watch?v=u8uYeHy10ZY");
        userAction.SetCommand(new RetrievDataCommand(receiver));
        userAction.SendCommand();
        userAction.SetCommand(new DownloadCommand(receiver));
        userAction.SendCommand();
        Console.ReadKey();
    }
}
