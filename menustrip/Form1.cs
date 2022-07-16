using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menustrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void esaretinBedeliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Esaretin bedeli bir dram ve aksiyon filmidir. ";
            listBox1.Items.Add("Esaretin Bedeli");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void amelieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Amelie fransız bir kızın aşk mecerasını anlatıyor.";
            listBox1.Items.Add("Amelie");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void theNoteBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " The Nootebook iki gencin yeni yüzyılda değişen aşk anlayışı üzeine bir bakış açısı sunuyor";
            listBox1.Items.Add("The NoteBook");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void gladyatörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Bolca kan ve kılıç sesinin olduğu bu film sizi orta çağa götürecek";
            listBox1.Items.Add("Gladyatör");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void yüzüklerinEfendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Eğer cadılara ve büyüye minik insanlara ve cücelere inanıyorsanız bu film tam size göre.";
            listBox1.Items.Add("Yüzüklerin Efendisi");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
