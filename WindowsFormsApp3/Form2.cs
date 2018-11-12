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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private Form1 form1 = new Form1();
        bool changes;
        private void Form2_Load(object sender, EventArgs e)
        {
            LabelText();
            checkBox1_CheckedChanged(sender,e);


        }
        
        private void ChekedCheckBox() {
            changes = checkBox1.Checked ? true : false;
            TextForTextBox(changes);
        }

        /*private void ValueTextBox() {
            textBox1.Text = TextB1;
            textBox2.Text = TextB2;
            textBox3.Text = TextB3;
            textBox4.Text = TextB4;
            textBox5.Text = TextB5;
            textBox6.Text = TextB6;
            textBox7.Text = TextB7;
            textBox8.Text = TextB8;
            textBox9.Text = TextB9;
            textBox10.Text = TextB10;
            textBox11.Text = TextB11;
            textBox12.Text = TextB12;
            textBox13.Text = TextB13;
            textBox14.Text = TextB14;
            textBox15.Text = TextB15;
            textBox16.Text = TextB16;
            textBox17.Text = TextB17;
            textBox18.Text = TextB18;
            textBox19.Text = TextB19;
            textBox20.Text = TextB20;
            textBox21.Text = TextB21;
            textBox22.Text = TextB22;
            textBox23.Text = TextB23;
            textBox24.Text = TextB24;
            textBox25.Text = TextB25;
            textBox26.Text = TextB26;
            textBox27.Text = TextB27;
            textBox28.Text = TextB28;
            textBox29.Text = TextB29;
            textBox30.Text = TextB30;
            textBox31.Text = TextB31;
            textBox32.Text = TextB32;
            textBox33.Text = TextB33;
            textBox34.Text = TextB34;
            textBox35.Text = TextB35;
            textBox36.Text = TextB36;
            textBox37.Text = TextB37;
            textBox38.Text = TextB38;
            textBox39.Text = TextB39;
            textBox40.Text = TextB40;
            textBox41.Text = TextB41;
            textBox42.Text = TextB42;
            textBox43.Text = TextB43;
        }
        */
        private void TextForTextBox(bool changes) {
            //[первый операнд - условие] ? [второй операнд] : [третий операнд]
            textBox1.Enabled = changes;
            textBox2.Enabled = changes;
            textBox3.Enabled = changes;
            textBox4.Enabled = changes;
            textBox5.Enabled = changes;
            textBox6.Enabled = changes;
            textBox7.Enabled = changes;
            textBox8.Enabled = changes;
            textBox9.Enabled = changes;
            textBox10.Enabled = changes;
            textBox11.Enabled = changes;
            textBox12.Enabled = changes;
            textBox13.Enabled = changes;
            textBox14.Enabled = changes;
            textBox15.Enabled = changes;
            textBox16.Enabled = changes;
            textBox17.Enabled = changes;
            textBox18.Enabled = changes;
            textBox19.Enabled = changes;
            textBox20.Enabled = changes;
            textBox21.Enabled = changes;
            textBox22.Enabled = changes;
            textBox23.Enabled = changes;
            textBox24.Enabled = changes;
            textBox25.Enabled = changes;
            textBox26.Enabled = changes;
            textBox27.Enabled = changes;
            textBox28.Enabled = changes;
            textBox29.Enabled = changes;
            textBox30.Enabled = changes;
            textBox31.Enabled = changes;
            textBox32.Enabled = changes;
            textBox33.Enabled = changes;
            textBox34.Enabled = changes;
            textBox35.Enabled = changes;
            textBox36.Enabled = changes;
            textBox37.Enabled = changes;
            textBox38.Enabled = changes;
            textBox39.Enabled = changes;
            textBox40.Enabled = changes;
            textBox41.Enabled = changes;
            textBox42.Enabled = changes;
            textBox43.Enabled = changes;

        }
        private void LabelText()
        {
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Text = checkBox1.Checked ? "Сохранить" : "Закрыть";
            ChekedCheckBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (changes) { } else { this.Close(); }
        }
    }
}
