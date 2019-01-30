using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ProjetArduinoCommPC1
{
    public partial class Form1 : Form
    {
        string ipaddressESP = "192.168.201.2"; //IP addr ESP
        int portESP = 4210; //le port utilisé par l'ESP
        bool udpcreer = false; //si déjà créer
        IPEndPoint ep; //endpoint
        Socket clienttoESP; //le socket
        byte[] packetData; //Les data

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                CheckCreerSocketUDP();
                packetData = System.Text.ASCIIEncoding.ASCII.GetBytes(tbDataUDPToSend.Text.ToString()); //Les data
                clienttoESP.SendTo(packetData, ep);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                stStatus.Text = "Aucune connexion établie";
            }
        }

        private void timerGetSerial_Tick(object sender, EventArgs e)
        {

        }

        private void CheckCreerSocketUDP() //vérif si socket déjà créer ou non
        {
            if (udpcreer != true)
            {
                ep = new IPEndPoint(IPAddress.Parse(ipaddressESP), portESP);
                clienttoESP = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                udpcreer = true;
            }
        }
        private void btnLED_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("LEDO"); 
            clienttoESP.SendTo(packetData, ep);
        }

        private void btnLEDClignote_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("LEDC");
            clienttoESP.SendTo(packetData, ep);
        }

        private void btnServo0_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("SER0");
            clienttoESP.SendTo(packetData, ep);
        }

        private void btnServo60_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("SER1");
            clienttoESP.SendTo(packetData, ep);
        }

        private void btnServo120_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("SER2");
            clienttoESP.SendTo(packetData, ep);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("SER3");
            clienttoESP.SendTo(packetData, ep);
        }

        private void btnTourServo_Click(object sender, EventArgs e)
        {
            CheckCreerSocketUDP();
            packetData = System.Text.ASCIIEncoding.ASCII.GetBytes("SERT");
            clienttoESP.SendTo(packetData, ep);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbIP.Text != "" && tbPort.Text != "")
            {
                ipaddressESP = tbIP.Text.ToString();
                portESP = Int32.Parse(tbPort.Text);
                btnEnvoi.Enabled = btnLED.Enabled = btnServo0.Enabled = btnServo60.Enabled = btnServo120.Enabled = btnServo180.Enabled = btnLEDClignote.Enabled = btnTourServo.Enabled = true;
                tbIP.Enabled = tbPort.Enabled = btnValider.Enabled = false;
            }
        }


    }
}
