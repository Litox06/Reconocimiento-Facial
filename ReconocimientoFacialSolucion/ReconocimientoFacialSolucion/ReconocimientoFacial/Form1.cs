using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace ReconocimientoFacial
{
    public partial class Form1 : Form
    {
        FaceRec faceRec = new FaceRec();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            faceRec.openCamera(pictureBox1, pictureBox2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            faceRec.Save_IMAGE(textBox2.Text);
            MessageBox.Show("GUARDADO EXITOSO!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            faceRec.isTrained = true;
        }
    }
}
