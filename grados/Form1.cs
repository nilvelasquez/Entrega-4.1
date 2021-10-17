using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace grados
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }
        private void conectar_Click(object sender, EventArgs e)
        {
            //IPEndPoint con el ip y el puerto del servidor al que queremos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.102");
            IPEndPoint ipep = new IPEndPoint(direc, 9044);

            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                //Intentamos conectar el socket
                server.Connect(ipep);
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");
            }

            catch (SocketException)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            //Enviamos mensajje de desconexión
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            if (CelFah.Checked)
            {
                if (string.IsNullOrEmpty(gradosBox.Text))
                {
                    MessageBox.Show("Introduzca su nombre porfavor.");
                }
                else
                {
                    string mensaje = "1/" + gradosBox.Text;
                    // Enviamos al servidor los grados Celcius
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Los grados en Fahrenheit son : " + mensaje);
                }
            }
            else if (FahCel.Checked)
            {
                if (string.IsNullOrEmpty(gradosBox.Text))
                {
                    MessageBox.Show("Introduzca su nombre porfavor.");
                }
                else
                {
                    string mensaje = "2/" + gradosBox.Text;
                    // Enviamos al servidor los grados Fahrenheit
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                    server.Send(msg);

                    //Recibimos la respuesta del servidor
                    byte[] msg2 = new byte[80];
                    server.Receive(msg2);
                    mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                    MessageBox.Show("Los grados en Celcius son : " + mensaje);
                }
            }
        }
    }
}
