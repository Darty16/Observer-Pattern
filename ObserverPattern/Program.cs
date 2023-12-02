using System;

// Create an instance of the YouTubeChannel
YouTubeChannel youtubeChannel = new YouTubeChannel("Juventus");

// Infinite loop for the console application
while (true)
{
    // Display the current channel name
    Console.WriteLine($"Channel Name: {youtubeChannel.ChannelName}");

    // Display menu options
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1. Add Subscriber");
    Console.WriteLine("2. Remove Subscriber");
    Console.WriteLine("3. Upload Video");
    Console.WriteLine("4. Exit");

    // Read user input for menu choice
    string choice = Console.ReadLine();

    // Process user choice using a switch statement
    // Add validation to handle unexpected choices gracefully.
    switch (choice)
    {
        // Option 1: Add Subscriber
        case "1":
            Console.Write("Enter subscriber name: ");
            string subscriberName = Console.ReadLine();
            ISubscriber subscriber = new YouTubeSubscriber(subscriberName);
            youtubeChannel.Subscribe(subscriber);
            break;

        // Option 2: Remove Subscriber
        case "2":
            Console.Write("Enter subscriber name to remove: ");
            string subscriberToRemove = Console.ReadLine();
            ISubscriber subscriberInstanceToRemove = youtubeChannel.GetSubscriberByName(subscriberToRemove);
            if (subscriberInstanceToRemove != null)
            {
                youtubeChannel.Unsubscribe(subscriberInstanceToRemove);
                Console.WriteLine($"{subscriberToRemove} unsubscribed.");
            }
            else
            {
                Console.WriteLine($"Subscriber '{subscriberToRemove}' not found.");
            }
            break;

        // Option 3: Upload Video
        case "3":
            Console.Write("Enter video title: ");
            string videoTitle = Console.ReadLine();
            youtubeChannel.UploadVideo(videoTitle);
            break;

        // Option 4: Exit the program
        case "4":
            Environment.Exit(0);
            break;

        // Default case: Handle invalid options
        default:
            Console.WriteLine("Invalid option. Please try again.");
            break;
    }

    // Display the current number of subscribers after each action
    Console.WriteLine($"Current Subscribers: {youtubeChannel.SubscriberCount}");
    Console.WriteLine();
}
