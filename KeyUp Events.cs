// KeyUp Events

// This example Demonstrates how to use the KeyUp event with the Help class to Display the pop-style to the user of the application.

// When the usaer presses F1, the help class Display a popup window, similar to a ToolTip, near the cotrol.

// this textbox has been added to the form and its KeyUp 
// event has been contected to this event handler method. 

private void textBox1_KeyUp(Obejct sender, Systems.Windows.Forms.KeyEventArgs e)
{
	// Determine whether the key is entered F1 Key. Display help if it is

	if(e.KeyCode == Keys.F1)
		Help.ShowPopup(tetBoox1, "Enter your first name", new Point(textBox1.Right, this.textBook1.Bottom));
}