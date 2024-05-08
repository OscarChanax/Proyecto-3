using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using mamth
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Proyecto_3
{
    public partial class Principal : Form
    {
   
        System.IO.Ports.SerialPort Arduino; // Declarar la variable serialPort
        int brilloLed;
        public Principal()
        {
            InitializeComponent();
            //Form
            this.Text = string.Empty;
           // this.ControlBox = false;
            this.DoubleBuffered = true;

            //Inicializa puerto
            //Los Puertos se muestran en el ComboBox
            string[] ports = SerialPort.GetPortNames();
            comboBoxPuerto.Items.AddRange(ports);

            estadoPanel.BackColor = Color.Red;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Cuando se presiona el botón desconectar
            //Habilitacion del boton conectar
            buttonConectar.Enabled = true;
            estadoPanel.BackColor = Color.Red;

            if (Arduino.IsOpen)      //Si el puerto esta habierto
            {
                Arduino.Close();      //Desconecta el Puerto
            } 
        }

        private void comboBoxPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            if (comboBoxPuerto.SelectedItem != null)
            {
                string selectedPort = comboBoxPuerto.SelectedItem.ToString();

                try
                {
                    Arduino = new SerialPort(selectedPort, 9600); // Crear la instancia de SerialPort
                    Arduino.Open();
                    buttonConectar.Enabled = false;
                   // Estado de la conexion panel
                   estadoPanel.BackColor = Color.Green;
                    //Comunicación con Arduino a través de Arduino
                    // Por ejemplo, enviar datos a Arduino: Arduino.WriteLine("Hola, Arduino!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el puerto COM: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un puerto COM antes de conectar.");
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Arduino.Write("E");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Arduino.Write("F");
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen) 
            {
                Arduino.Close();
            }
        }

        private void buttonConectar_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void trackBarHorizontal_Scroll(object sender, EventArgs e)
        {
            labelValorhorizontal.Text = "Valor: " + trackBarHorizontal.Value.ToString();

            int brilloLed = trackBarHorizontal.Value;
            Arduino.WriteLine(brilloLed.ToString());
        }

        private void labelValorhorizontal_Click(object sender, EventArgs e)
        {

        }

        private void trackBarVertical_Scroll(object sender, EventArgs e)
        {
            labelValorvertical.Text = "Valor: " + trackBarVertical.Value.ToString();

            int brilloLed = trackBarVertical.Value;
            Arduino.WriteLine(brilloLed.ToString());
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int q2 = Math.Cosh *
        }
    }
}
