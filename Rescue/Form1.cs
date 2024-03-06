using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpDX.XInput;

namespace Rescue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void url1Enter_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtUrl1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser2.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser2.Navigate(txtUrl2.Text);
        }

        private void txtUrl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            output.SelectionStart = output.Text.Length;
            // scroll it automatically
            output.ScrollToCaret();
            outputLineCount.Text = output.Lines.Length.ToString();
        }

        public async void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Replace "arduino_server_ip" and "port_number" with the actual IP address and port number of your Arduino server
                string serverIP = ipAddress.Text;
                int port = 80;

                // Connect to the server
                TcpClient client = new TcpClient(serverIP, port);
                Console.WriteLine("Connected to Arduino server.");

                // Send data to the server
                string message = "Hello Arduino!";
                byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                output.Text += "Sent:" + message + "\n";
                System.Threading.Thread.Sleep(1000);
                // Receive data from the server
                /*data = new byte[256];
                int bytes = stream.Read(data, 0, data.Length);
                string responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                if (responseData != null)
                {
                    Console.WriteLine("Received: {0}", responseData);
                }*/
                // Close the connection

                Controller controller = new Controller(UserIndex.One);

                // Check if the controller is connected
                if (controller.IsConnected)
                {
                    output.Text += "Controller connected.\n";
                    System.Threading.Thread.Sleep(500);

                    while (true)
                    {
                        // Get the current state of the controller
                        State state = controller.GetState();

                        // Check if the controller is still connected
                        if (!state.PacketNumber.Equals(0))
                        {
                            // Print out the values of the thumbsticks
                            if ((state.Gamepad.LeftThumbX) != 0)
                            {
                                message = "Left Thumbstick X: " + state.Gamepad.LeftThumbX + "\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }
                            if ((state.Gamepad.LeftThumbY) != 0)
                            {
                                message = "Left Thumbstick Y: " + state.Gamepad.LeftThumbY + "\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }
                            if ((state.Gamepad.RightThumbX) != 0)
                            {
                                message = "Right Thumbstick X: " + state.Gamepad.RightThumbX + "\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }
                            if ((state.Gamepad.RightThumbY) != 0)
                            {
                                message = "Right Thumbstick Y: " + state.Gamepad.RightThumbY + "\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }
                            if ((state.Gamepad.LeftTrigger) != 0)
                            {
                                message = "Left Trigger: " + state.Gamepad.LeftTrigger + "\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }
                            if ((state.Gamepad.RightTrigger) != 0)
                            {
                                message = "Right Trigger: " + state.Gamepad.RightTrigger + "\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }


                            // Check if the A button is pressed
                            if ((state.Gamepad.Buttons & GamepadButtonFlags.A) != 0)
                            {
                                message = "A button pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            // Check if the B button is pressed
                            if ((state.Gamepad.Buttons & GamepadButtonFlags.B) != 0)
                            {
                                message = "B button pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            // Check if the Y button is pressed
                            if ((state.Gamepad.Buttons & GamepadButtonFlags.Y) != 0)
                            {
                                message = "Y button pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            // Check if the X button is pressed
                            if ((state.Gamepad.Buttons & GamepadButtonFlags.X) != 0)
                            {
                                message = "X button pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadLeft) != 0)
                            {
                                message = "Dpad: Left.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadRight) != 0)
                            {
                                message = "Dpad: Right.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadUp) != 0)
                            {
                                message = "Dpad: Up.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadDown) != 0)
                            {
                                message = "Dpad: Down.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.LeftThumb) != 0)
                            {
                                message = "Left Thumbstick Button Pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.RightThumb) != 0)
                            {
                                message = "Right Thumbstick Button Pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.LeftShoulder) != 0)
                            {
                                message = "Left Shoulder Button Pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.RightShoulder) != 0)
                            {
                                message = "Right Shoulder Button Pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.Start) != 0)
                            {
                                message = "Start Button Pressed.\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                            }

                            if ((state.Gamepad.Buttons & GamepadButtonFlags.Back) != 0)
                            {
                                message = "Back Button Pressed Exitting...\n";
                                data = System.Text.Encoding.ASCII.GetBytes(message);
                                stream = client.GetStream();
                                stream.Write(data, 0, data.Length);
                                break;
                            }

                            // Add more button checks as needed

                            // Wait for a short amount of time to reduce CPU usage
                            System.Threading.Thread.Sleep(100);
                        }
                        else
                        {
                            output.Text += "Controller disconnected.\n";
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Controller not connected.");
                }
                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Controller controller = new Controller(UserIndex.One);

            // Check if the controller is connected
            if (controller.IsConnected)
            {
                output.Text += "Controller connected.\n";
                System.Threading.Thread.Sleep(500);

                while (true)
                {
                    // Get the current state of the controller
                    State state = controller.GetState();

                    // Check if the controller is still connected
                    if (!state.PacketNumber.Equals(0))
                    {
                        // Print out the values of the thumbsticks
                        if ((state.Gamepad.LeftThumbX) != 0)
                        {
                            output.Text += "Left Thumbstick X: " + state.Gamepad.LeftThumbX + "\n";
                        }
                        if ((state.Gamepad.LeftThumbY) != 0)
                        {
                            output.Text += "Left Thumbstick Y: " + state.Gamepad.LeftThumbY + "\n";
                        }
                        if ((state.Gamepad.RightThumbX) != 0)
                        {
                            output.Text += "Right Thumbstick X: " + state.Gamepad.RightThumbX + "\n";
                        }
                        if ((state.Gamepad.RightThumbY) != 0)
                        {
                            output.Text += "Right Thumbstick Y: " + state.Gamepad.RightThumbY + "\n";
                        }
                        if ((state.Gamepad.LeftTrigger) != 0)
                        {
                            output.Text += "Left Trigger: " + state.Gamepad.LeftTrigger + "\n";
                        }
                        if ((state.Gamepad.RightTrigger) != 0)
                        {
                            output.Text += "Right Trigger: " + state.Gamepad.RightTrigger + "\n";
                        }


                        // Check if the A button is pressed
                        if ((state.Gamepad.Buttons & GamepadButtonFlags.A) != 0)
                        {
                            output.Text += "A button pressed.\n";
                        }

                        // Check if the B button is pressed
                        if ((state.Gamepad.Buttons & GamepadButtonFlags.B) != 0)
                        {
                            output.Text += "B button pressed.\n";
                        }

                        // Check if the Y button is pressed
                        if ((state.Gamepad.Buttons & GamepadButtonFlags.Y) != 0)
                        {
                            output.Text += "Y button pressed.\n";
                        }

                        // Check if the X button is pressed
                        if ((state.Gamepad.Buttons & GamepadButtonFlags.X) != 0)
                        {
                            output.Text += "X button pressed.\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadLeft) != 0)
                        {
                            output.Text += "DL\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadRight) != 0)
                        {
                            output.Text += "DR\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadUp) != 0)
                        {
                            output.Text += "DU\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.DPadDown) != 0)
                        {
                            output.Text += "DD\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.LeftThumb) != 0)
                        {
                            output.Text += "Left Thumbstick Button Pressed.\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.RightThumb) != 0)
                        {
                            output.Text += "Right Thumbstick Button Pressed.\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.LeftShoulder) != 0)
                        {
                            output.Text += "Left Shoulder Button Pressed.\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.RightShoulder) != 0)
                        {
                            output.Text += "Right Shoulder Button Pressed.\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.Start) != 0)
                        {
                            output.Text += "Start Button Pressed.\n";
                        }

                        if ((state.Gamepad.Buttons & GamepadButtonFlags.Back) != 0)
                        {
                            output.Text += "Back Button Pressed Exitting...\n";
                            break;
                        }

                        // Add more button checks as needed

                        // Wait for a short amount of time to reduce CPU usage
                        System.Threading.Thread.Sleep(50);
                        outputLineCount.Text = output.Lines.Length.ToString();
                    }
                    else
                    {
                        output.Text += "Controller disconnected.\n";
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Controller not connected.");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            output.Text = "";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int linecount = output.Lines.Length;
        }

        private void ipAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}