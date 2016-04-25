using System;
using System.Windows.Forms;

namespace InputValidator {
	static class InputValidator {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main () {
			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new InputValidatorForm ());
		}
	}
}
