//Create a console application named “Demo” that displays current date a time for 10 times with the time interval of 2 seconds.

using System;
using System.Threading;

namespace DisplayCurrentTime {
	public class DisplayCurrentTime {

		static void Main (string[] args) {
			ThreadStart starter = new ThreadStart(ShowTime);
			Thread thread = new Thread(starter);
			thread.Start();
			thread.Join(); }

		static void ShowTime() {
			for (int i = 0; i < 10; i++) {
				Console.WriteLine(DateTime.Now);
				Thread.Sleep(2000); } }
	}
}