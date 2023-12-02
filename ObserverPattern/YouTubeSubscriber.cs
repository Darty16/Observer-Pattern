using System;

// Concrete Observer
// 'YouTubeSubscriber' is a concrete implementation of a YouTube subscriber
// Receives notifications when a new video is uploaded and prints a message
public class YouTubeSubscriber : ISubscriber
{
    // Private field to store the subscriber's name
    private string subscriberName;

    // Public property to get the subscriber's name
    public string SubscriberName { get { return subscriberName; } }

    // Constructor to initialize the subscriber with a name
    public YouTubeSubscriber(string name)
    {
        subscriberName = name;
    }

    // Method to receive notifications about a new video
    public void Update(string videoTitle)
    {
        // Print a message indicating that the subscriber received a notification
        // and provide details about the new video
        Console.WriteLine($"{subscriberName} received a notification: New video: {videoTitle}");
    }
}
