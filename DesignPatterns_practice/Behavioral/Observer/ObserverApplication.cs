namespace DesignPatterns_practice.Behavioral.Observer;

public class ObserverApplication
{
    public void RunObserverScenario()
    {
        var editor = new Editor();
        var logger1 = new LoggingListener("log1.txt", "Someone has open log1.txt");
        var logger2 = new LoggingListener("log2.txt", "Someone has open log2.txt");
        var logger3 = new LoggingListener("log3.txt", "Someone has open log3.txt");
        
        editor.EventManager.Subscribe("open", logger1);
        editor.EventManager.Subscribe("open", logger2);
        editor.EventManager.Subscribe("open", logger3);

        var emailAlerts1 = new EmailAlertsListener("vlad1@gmail.com", "Change the file test.txt");
        var emailAlerts2= new EmailAlertsListener("vlad2@gmail.com", "Change the file test.txt");
        var emailAlerts3 = new EmailAlertsListener("vlad3@gmail.com", "Change the file test.txt");
        var emailAlerts4 = new EmailAlertsListener("vlad4@gmail.com", "Change the file test.txt");
        
        editor.EventManager.Subscribe("save", emailAlerts1);
        editor.EventManager.Subscribe("save", emailAlerts2);
        editor.EventManager.Subscribe("save", emailAlerts3);
        editor.EventManager.Subscribe("save", emailAlerts4);
        
        editor.OpenFile("log1.txt");
        editor.SaveFile();
    }
}