using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTexInf;
using WindowsFormsApp3.Properties;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private LabelTextInfo LTI = new LabelTextInfo();
        public void LabelText() {
            toolTip1.SetToolTip(label4, LabelTextInfo.DesLabel4);
            toolTip1.SetToolTip(label5, LabelTextInfo.DesLabel5);
            toolTip1.SetToolTip(label6, LabelTextInfo.DesLabel6);
            toolTip1.SetToolTip(label28, LabelTextInfo.DesLabel28);
            toolTip1.SetToolTip(label27, LabelTextInfo.DesLabel27);
            toolTip1.SetToolTip(label26, LabelTextInfo.DesLabel26);
            toolTip1.SetToolTip(label34, LabelTextInfo.DesLabel34);
            toolTip1.SetToolTip(label45, LabelTextInfo.DesLabel45);
            toolTip1.SetToolTip(label42, LabelTextInfo.DesLabel42);
            toolTip1.SetToolTip(label38, LabelTextInfo.DesLabel38);
            toolTip1.SetToolTip(label39, LabelTextInfo.DesLabel39);
            toolTip1.SetToolTip(label40, LabelTextInfo.DesLabel40);
            toolTip1.SetToolTip(label41, LabelTextInfo.DesLabel41);
            toolTip1.SetToolTip(label14, LabelTextInfo.DesLabel14);
            toolTip1.SetToolTip(label32, LabelTextInfo.DesLabel32);
            toolTip1.SetToolTip(label31, LabelTextInfo.DesLabel31);
            toolTip1.SetToolTip(label30, LabelTextInfo.DesLabel30);
            toolTip1.SetToolTip(label12, LabelTextInfo.DesLabel12);
            toolTip1.SetToolTip(label13, LabelTextInfo.DesLabel13);
            toolTip1.SetToolTip(label10, LabelTextInfo.DesLabel10);
            toolTip1.SetToolTip(label8, LabelTextInfo.DesLabel8);
            toolTip1.SetToolTip(label9, LabelTextInfo.DesLabel9);
            toolTip1.SetToolTip(label25, LabelTextInfo.DesLabel25);
            toolTip1.SetToolTip(label24, LabelTextInfo.DesLabel24);
            toolTip1.SetToolTip(label23, LabelTextInfo.DesLabel23);
            toolTip1.SetToolTip(label22, LabelTextInfo.DesLabel22);
        }
        private void ValidationCheck() {
            SumAll(radioButton1.Checked ? LTI.TextB1 : radioButton2.Checked ? LTI.TextB2 : radioButton3.Checked ? LTI.TextB3 : 0);
            //SumAll(1000);
            //if (radioButton1.Checked) { sum = LTI.TextB1; } else { if (radioButton2.Checked) { sum = LTI.TextB2; } else { sum = LTI.TextB3; } }
            
        }
        
            private void Form1_Load(object sender, EventArgs e)
        {
            radioButton3_CheckedChanged(sender, e);
            LabelText();
            //radioButton1.Checked ? () : ();
            //[первый операнд - условие] ? [второй операнд] : [третий операнд]
            // ⍰ \r\n  t.SetToolTip(label28, "");
        }
        private int sum;
        private void SumAll(int i) {
            sum += i;
            label7.Text = sum.ToString();
            
        }
        private void просмотрИзменитьToolStripMenuItem_Click(object sender, EventArgs e)    
        {
            Form2 Сoeffic = new Form2();
            Сoeffic.ShowDialog(this);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sum = 0;
            ValidationCheck();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged_1(object sender, EventArgs e)
        {
            //тут перечисляем чекбокс= значению чекбокса и в начале делаем сум=0; сум+= значение чекбокса
        }
    }
}
