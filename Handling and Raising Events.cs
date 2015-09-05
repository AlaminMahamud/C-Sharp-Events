// Events

class Counter
{
	public event EventHandler ThresoldReached;
	protected virtual void OnThresolReached(EventArgs e)
	{
		EventHandler handler = ThresoldReached;
		if(handler != null)
			handler(this,e);
	}

	// provide remaining implementaion
}

// Delegates
public delegate void ThresholdReachedEventHandler(ThresholdReachedEventArgs e);

// Event Args
public class ThresholdReachedEventArgs : EventArgs
{
	public int Threshold{get; set;}
	public DateTime TimeReached{get; set;}
}

/// Event Handlers

class Program
{
	static void Main(string[] args)
	{
		Counter c = new Counter();
		c.ThresholdReached += c_ThresholdReached;

		// Provide remaining implementation for the class
	}

	static void c_ThresholdReached(object sender, EventArgs e)
	{
		Console.WriteLine("The Threshold was reached");
	}
}