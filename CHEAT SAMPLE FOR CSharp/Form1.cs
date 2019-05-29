//Hi, My Name is Izumi.
//This Program is Cheat Code Sender Assist Source
//Framework = 4.6.1.
//Contact Discord : Izumi_2147483647#9849
//I play Minecraft, MarioKart 8, Splatoon.
//Enjoy Cheat!!

//Copyright 🄫 2019 IzumiPlaza

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHEAT_SAMPLE_FOR_CSharp
{
    public partial class Form1 : Form
    {
        public TCPGecko GckApi;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Sample / Example Code Normal Code(Not Pointer);
            //GckApi.byteary_poke(0x10000000, new byte[] { 0x10, 0x20, 0x30, 0x40 } );
            //This Command is 0x10000000 Write 0x10203040;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sample / Example Code Pointer Code;
            //Test ptr = GckApi.peek(0x10000000);
            //ptr += 0x10;
            //GckApi.byteary_poke(ptr, new byte[] { 0x10, 0x20, 0x30, 0x40 } );

            //and Pointer in Pointer;

            //Sample / Example Code Pointer Code;
            //Test ptr2 = GckApi.peek(GckApi.peek(0x10000000) + 0x10);
            //ptr2 += 0x10;
            //GckApi.byteary_poke(ptr2, new byte[] { 0x10, 0x20, 0x30, 0x40 } );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(button1.Text == "Connect to Wii U")
            //{
                //bool GckConnect = true;
                //GckApi = new TCPGecko(textBox1.Text, 7331);
                //GckConnect = GckApi.Connect();
                //if(GckConnect)
                //{
                    //button1.Text = "Disconnect Wii U";
                    //button2.Enabled = true;
                    //checkBox1.Enabled = true;
                //}
            //}
            //else
            //{
                //GckApi.Disconnect();
                //button1.Text = "Connect to Wii U";
                //button2.Enabled = false;
                //checkBox1.Enabled = false;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button2.Enabled = false;
            //checkBox1.Enabled = false;
        }
    }
}

//Cheat Sample for C# by _Izumi_