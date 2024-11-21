namespace AbstractionPrinciple.MessagingPlatforms;


/*
 * Imagine a system that has to communicate with multiple messaging platforms: Email, SMS, and Push Notification.
 * Without abstraction, you might end up with methods like SendEmail(), SendSms(), SendPushNotification(), etc.
 * scattered throughout your application. If a new messaging method is added, you must add another method and call it differently.
 */


//Abstraction Layer
//Define a common interface for all messaging platforms
public interface IMessagingService
{
    void SendMessage(string recipient, string message);
}