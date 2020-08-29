using System; 

namespace CSharp_DebugTools
{
	public class UITools
	{
		///<summary>
		/// Creates a string containing multiple occurances of the provided char, hence replicating it. 
		///</summary>
		///<param name = "chr"> Character to be replicated. </param>
		///<param name = "times"> Number of occurances/replicants of the char </param>
		public static string ReplicateChar(char chr, int times)
		{
			string MultipleChars = null;
					
			for (int x = 0; x < times; x++)
				MultipleChars += chr;

			return MultipleChars;
		}
	}
	
	public class Debugger
	{
		public string Title; 	//	Title of the current instance
	
		public int LogCount;	// Stores the number of times a message is logged using current instance 

		///<summary>
		/// Outputs a debug message to the console.
		///</summary>
		///<param name = "Message"> Message tot be printed </param>
	
		public void Log(string Message) 
		{
			Console.WriteLine($"\nDebug {this.LogCount++}: {Message}");
		}
	
		///<summary>
		///	Sets up the console UI. 
		///</summary>
		public void StartConsole()	// Sets up the console UI
		{
			Console.WriteLine($"{this.Title}\n{UITools.ReplicateChar('-', this.Title.Length)}");		
		}

		public Debugger()
		{
			this.LogCount = 0;	//	Initializes the LogCount
			this.Title = "New Debugging Console";
		}

		public Debugger(string title)			
		{
			this.LogCount = 0; //  Initializes the LogCount
			this.Title = title;
		}
	}
}
