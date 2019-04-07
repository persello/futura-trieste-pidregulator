using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PIDRegulator {
	public partial class Form1 : Form {

		SerialPort port = new SerialPort();
		public Form1() {
			InitializeComponent();
		}

		private void UpdateButton_Click(object sender, EventArgs e) {
			UpdatePortList();
		}

		private void UpdatePortList() {
			PortListComboBox.Items.Clear();
			foreach (string name in SerialPort.GetPortNames()) {
				PortListComboBox.Items.Add(name);
			}
		}

		private void ConnectButton_Click(object sender, EventArgs e) {
			port.PortName = PortListComboBox.SelectedItem.ToString();
			port.BaudRate = 57600;
			port.Open();
		}

		private void ValueChanged(object sender, EventArgs e) {
			NumericUpDown nu = sender as NumericUpDown;
			char c = 'e';
			if(port.IsOpen) {
				switch(nu.Name) {
					case "KpNumeric":
						c = 'p';
						break;
					case "KiNumeric":
						c = 'i';
						break;
					case "KdNumeric":
						c = 'd';
						break;
					case "OffsetUpDown":
						c = 'o';
						break;
					case "LimitNumeric":
						c = 'l';
						break;
				}
			}
			port.Write(c.ToString());
			port.WriteLine(nu.Value.ToString());
		}
	}
}
