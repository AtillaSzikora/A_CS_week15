/* Write a Windows Forms application that accepts a name, address and phone number from a user.
Add a Submit button that uses regular expressions to validate the input. */

using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InputValidator {
	public partial class InputValidatorForm : Form {
		public InputValidatorForm () {
			InitializeComponent (); }

		private void btnSubmit_Click (object sender, System.EventArgs e) {
			if (!Regex.IsMatch(txtName.Text, @"^([A-Za-z]*\s*)*$")) 
				MessageBox.Show(@"The name is invalid (only alphabetical characters are allowed)"); 
			if (!Regex.IsMatch(txtPhone.Text, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$")) 
				MessageBox.Show(@"The phone number is not a valid US phone number"); }
	}
}