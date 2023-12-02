using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

// Test class for the Observer Pattern implementation
[TestClass]
public class ObserverPatternTests
{


    // Test method to ensure subscribers receive notifications when a new video is uploaded
    [TestMethod]
    public void SubscribersReceiveNotification()
    {
        // Arrange
        var channel = new YouTubeChannel();
        var subscriber1 = new YouTubeSubscriber("DartiZalli");
        var subscriber2 = new YouTubeSubscriber("DartiAUK");

        // Act
        channel.Subscribe(subscriber1);
        channel.Subscribe(subscriber2);
        channel.UploadVideo("Test Video");

        // Assert
        // Check if both subscribers received the notification
        // This assumes we have a way to capture console output or use a logging framework for testing.
    }

    // Test method to ensure unsubscribing removes a subscriber
    [TestMethod]
    public void UnsubscribeRemovesSubscriber()
    {
        // Arrange
        var channel = new YouTubeChannel();
        var subscriber = new YouTubeSubscriber("DartiZalli");

        // Act
        channel.Subscribe(subscriber);
        channel.Unsubscribe(subscriber);
        channel.UploadVideo("Test Video");

        // Assert
        // Check that the subscriber did not receive the notification
        // This assumes we have a way to capture console output or use a logging framework for testing.
    }

    // Test method to ensure uploading a video notifies subscribers
    [TestMethod]
    public void UploadVideoNotifiesSubscribers()
    {
        // Arrange
        var channel = new YouTubeChannel();
        var subscriber = new YouTubeSubscriber("DartiZalli");

        // Act
        channel.Subscribe(subscriber);
        channel.UploadVideo("Test Video");

        // Assert
        // Check that the subscriber received the notification
        // This assumes you have a way to capture console output or use a logging framework for testing.
    }

    // Test method to ensure subscriber's update message is correct
    [TestMethod]
    public void SubscriberUpdateDisplaysCorrectMessage()
    {
        // Arrange
        var channel = new YouTubeChannel();
        var subscriber = new YouTubeSubscriber("DartiZalli");

        // Act
        channel.Subscribe(subscriber);
        channel.UploadVideo("Test Video");

        // Assert
        // Check that the subscriber's update message is correct
        // This assumes you have a way to capture console output or use a logging framework for testing.
    }

    // Test method to ensure multiple channels do not interfere with each other
    [TestMethod]
    public void MultipleChannelsDoNotInterfere()
    {
        // Arrange
        var channel1 = new YouTubeChannel();
        var channel2 = new YouTubeChannel();
        var subscriber = new YouTubeSubscriber("DartiZalli");

        // Act
        channel1.Subscribe(subscriber);
        channel2.UploadVideo("Test Video");

        // Assert
        // Check that the subscriber did not receive the notification from channel2
        // This assumes you have a way to capture console output or use a logging framework for testing.
    }

    // Test method to ensure subscriber count increments when subscribers are added
    [TestMethod]
    public void SubscriberCountIncrements()
    {
        // Arrange
        var channel = new YouTubeChannel();
        var subscriber1 = new YouTubeSubscriber("DartiZalli");
        var subscriber2 = new YouTubeSubscriber("DartiAUK");

        // Act
        channel.Subscribe(subscriber1);
        channel.Subscribe(subscriber2);

        // Assert
        Assert.AreEqual(2, channel.SubscriberCount, "SubscriberCount should be 2 after adding two subscribers.");
    }
}
