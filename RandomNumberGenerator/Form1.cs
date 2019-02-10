using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberGenerator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {

            int minValue = 0;
            int maxValue = 0;

            // Get user input
            string input_minValue = txt_minValue.Text;
            string input_maxValue = txt_maxValue.Text;

            try
            {
                // Cast input into an int
                minValue = Int32.Parse(input_minValue);
                maxValue = Int32.Parse(input_maxValue);
            }
            catch (FormatException)
            {
                MessageBox.Show("There is no number!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException)
            {
                MessageBox.Show("The selected number is too big!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Create random object
            Random random = new Random();

            // Init random number
            int randomNum = 0;

            try
            {
                randomNum = random.Next(minValue, maxValue);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("The first number cannot be greater than the second one!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            // Display the result and cast to string
            txt_result.Text = randomNum.ToString();

        }

        // This event is used to clear all text Boxes
        private void btn_clear_Click(object sender, EventArgs e)
        {

            txt_minValue.Clear();
            txt_maxValue.Clear();
            txt_result.Clear();

        }

        // Boolean used to determine when a character other than a number is entered
        private bool nonNumberEntered = false;

        private void txt_minValue_KeyDown(object sender, KeyEventArgs e)
        {

            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed
                        nonNumberEntered = true;
                    }
                }
            }

            //If shift key was pressed, it's not a number
            if (e.KeyCode == Keys.Shift)
                nonNumberEntered = true;

        }

        private void txt_minValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (nonNumberEntered == true)
                e.Handled = true;

        }

        private void txt_maxValue_KeyDown(object sender, KeyEventArgs e)
        {

            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed
                        nonNumberEntered = true;
                    }
                }
            }

            //If shift key was pressed, it's not a number
            if (e.KeyCode == Keys.Shift)
                nonNumberEntered = true;

        }

        private void txt_maxValue_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (nonNumberEntered == true)
                e.Handled = true;

        }

    }
}
