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
			port.ErrorReceived += Port_ErrorReceived;
			port.DataReceived += Port_DataReceived;

			UpdatePortList();
			if (PortListComboBox.Items.Count > 0)
				PortListComboBox.SelectedIndex = 0;
		}

		string lastData = "";
		private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e) {
			// Aggiorniamo il grafico con gli ultimi dati soltanto quando il thread principale è pronto
			if (chart1.InvokeRequired) {
				chart1.Invoke((Action)(() => UpdateChart()));
			} else {
				UpdateChart();
			}
		}

		void UpdateChart() {
			// Formato dei dati ricevuti: Motori + \t + Angolo + \r\n
			try {
				lastData = port.ReadLine();
				chart1.Series.FindByName("OutputSeries").Points.Add(Convert.ToDouble(lastData.Split('\t')[0]));
				chart1.Series.FindByName("AngleSeries").Points.Add(Convert.ToDouble(lastData.Split('\t')[1]));
				chart1.ChartAreas[0].RecalculateAxesScale();
				if (chart1.Series.FindByName("OutputSeries").Points.Count > 500) {
					chart1.Series.FindByName("OutputSeries").Points.RemoveAt(0);
				}
				if (chart1.Series.FindByName("AngleSeries").Points.Count > 500) {
					chart1.Series.FindByName("AngleSeries").Points.RemoveAt(0);
				}
			} catch (Exception ex) {

			}
		}

		private void Port_ErrorReceived(object sender, SerialErrorReceivedEventArgs e) {
			// In caso di errore cambio il testo sul pulsante 
			port.Close();
			if (ConnectButton.InvokeRequired) {
				ConnectButton.Invoke((Action)(() => UpdateText(ConnectButton, "Connect")));
				return;
			} else {
				UpdateText(ConnectButton, "Connect");
			}
		}

		void UpdateText(Button b, string s) {
			b.Text = s;
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
			Button b = sender as Button;
			if (!port.IsOpen) {
				port.PortName = PortListComboBox.SelectedItem.ToString();
				port.BaudRate = 115200;
				port.Open();
				b.Text = "Disconnect";
			} else {
				port.Close();
				b.Text = "Connect";
			}
		}

		private void ValueChanged(object sender, EventArgs e) {
			NumericUpDown nu = sender as NumericUpDown;
			char c = 'e';
			if (port.IsOpen) {
				switch (nu.Name) {
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
			SendData(c, (double)nu.Value);
		}

		void SendData(char type, double value) {
			if (port.IsOpen) {
				port.Write(type.ToString());
				port.Write(value.ToString().PadRight(9));
			}
		}

		private void chart1_Click(object sender, EventArgs e) {

		}

		private void Form1_KeyUp(object sender, KeyEventArgs e) {

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e) {

		}

		private void ButtonUp_MouseDown(object sender, MouseEventArgs e) {
			Button b = sender as Button;
			switch (b.Text) {
				case "Down":
					SendData('o', (double)OffsetUpDown.Value + (double)ControlAngleNumericUpDown.Value);
					break;
				case "Up":
					SendData('o', (double)OffsetUpDown.Value - (double)ControlAngleNumericUpDown.Value);
					break;
				case "Left":
					SendData('s', 10000);
					break;
				case "Right":
					SendData('s', -10000);
					break;
			}
		}

		private void ButtonUp_MouseUp(object sender, MouseEventArgs e) {
			Button b = sender as Button;
			switch (b.Text) {
				case "Down":
					SendData('o', (double)OffsetUpDown.Value);
					break;
				case "Up":
					SendData('o', (double)OffsetUpDown.Value);
					break;
				case "Left":
					SendData('s', 0);
					break;
				case "Right":
					SendData('s', 0);
					break;
			}
		}

		private void DefaultButton_Click(object sender, EventArgs e) {
			LimitNumeric.Value = 52700;
			KpNumeric.Value = 5000;
			KiNumeric.Value = 500000;
			KdNumeric.Value = 2;
			OffsetUpDown.Value = 2;
		}
	}
}
