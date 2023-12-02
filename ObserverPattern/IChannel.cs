// Subject interface
// 'IChannel' represents the YT channel interface with methods for 
// subscribing, unsubscribing, and notifying subscribers
using System.Collections;
using System.Collections.Generic;

public interface IChannel
{
    // Method for subscribing a new subscriber
    void Subscribe(ISubscriber subscriber);

    // Method for unsubscribing a subscriber
    void Unsubscribe(ISubscriber subscriber);

    // Method for notifying subscribers with a given notification
    void NotifySubscribers(string notification);
}