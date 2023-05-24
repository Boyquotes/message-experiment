using System;

public class Message
{
	public string Text { get; private set; }
	public string TimeSent { get; private set; }
	public User Sender { get; private set; }
}
