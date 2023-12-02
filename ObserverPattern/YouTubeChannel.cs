// Concrete Subject
// 'YouTubeChannel' is a concrete implementation of a YouTube Channel
// Maintains a list of subscribers
// Notifies subscribers when a new vid is uploaded
using System;
using System.Collections.Generic;
public class YouTubeChannel : IChannel
{
    // List to store subscribers
    private List<ISubscriber> subscribers = new List<ISubscriber>();

    // The title of the latest uploaded video
    private string latestVideoTitle;

    // Property to get or set the channel name
    public string ChannelName { get; set; }

    // Default constructor with an empty channel name
    public YouTubeChannel()
    {
        ChannelName = string.Empty;
    }

    // Constructor that allows setting the channel name
    public YouTubeChannel(string name)
    {
        ChannelName = name;
    }

    // Property to get the count of subscribers
    public int SubscriberCount { get { return subscribers.Count; } }

    // Method to subscribe a new subscriber
    public void Subscribe(ISubscriber subscriber)
    {
        // Increment SubscriberCount when a subscriber is added
        subscribers.Add(subscriber);

        // GetHashCode to differentiate instances of subscribers
        Console.WriteLine($"{subscriber.GetType().Name} {subscriber.GetHashCode()} subscribed.");
    }

    // Method to unsubscribe a subscriber
    public void Unsubscribe(ISubscriber subscriber)
    {
        // Decrement SubscriberCount when a subscriber is removed
        subscribers.Remove(subscriber);
    }

    // Method to notify all subscribers about a new video
    public void NotifySubscribers(string videoTitle)
    {
        foreach (var subscriber in subscribers)
        {
            // Notify each subscriber about the latest video
            subscriber.Update(latestVideoTitle);
        }
    }

    // Method to upload a new video to the channel
    public void UploadVideo(string videoTitle)
    {
        Console.WriteLine($"New video uploaded: {videoTitle}");

        // Update the latestVideoTitle
        latestVideoTitle = videoTitle;

        // Notify subscribers about the new video
        NotifySubscribers(videoTitle);
    }

    // Method to get a subscriber by name
    public ISubscriber GetSubscriberByName(string name)
    {
        // Find and return a subscriber with a matching name
        return subscribers.Find(subscriber => (subscriber as YouTubeSubscriber)?.SubscriberName == name);
    }
}
