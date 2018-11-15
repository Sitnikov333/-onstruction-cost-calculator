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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private LabelTextInfo LTI = new LabelTextInfo();
        private Form1 form1 = new Form1();
        bool changes;
        private void Form2_Load(object sender, EventArgs e)
        {
            LabelText();
            ValueTextBox();
            checkBox1_CheckedChanged(sender,e);
            

        }
        
        private void ChekedCheckBox() {
            changes = checkBox1.Checked ? true : false;
            TextForTextBox(changes);
        }

        private void ValueTextBox() {
            textBox1.Text = LTI.TextB1.ToString();
            textBox2.Text = LTI.TextB2.ToString();
            textBox3.Text = LTI.TextB3.ToString();
            textBox4.Text = LTI.TextB4.ToString();
            textBox5.Text = LTI.TextB5.ToString();
            textBox6.Text = LTI.TextB6.ToString();
            textBox7.Text = LTI.TextB7.ToString();
            textBox8.Text = LTI.TextB8.ToString();
            textBox9.Text = LTI.TextB9.ToString();
            textBox10.Text = LTI.TextB10.ToString();
            textBox11.Text = LTI.TextB11.ToString();
            textBox12.Text = LTI.TextB12.ToString();
            textBox13.Text = LTI.TextB13.ToString();
            textBox14.Text = LTI.TextB14.ToString();
            textBox15.Text = LTI.TextB15.ToString();
            textBox16.Text = LTI.TextB16.ToString();
            textBox17.Text = LTI.TextB17.ToString();
            textBox18.Text = LTI.TextB18.ToString();
            textBox19.Text = LTI.TextB19.ToString();
            textBox20.Text = LTI.TextB20.ToString();
            textBox21.Text = LTI.TextB21.ToString();
            textBox22.Text = LTI.TextB22.ToString();
            textBox23.Text = LTI.TextB23.ToString();
            textBox24.Text = LTI.TextB24.ToString();
            textBox25.Text = LTI.TextB25.ToString();
            textBox26.Text = LTI.TextB26.ToString();
            textBox27.Text = LTI.TextB27.ToString();
            textBox28.Text = LTI.TextB28.ToString();
            textBox29.Text = LTI.TextB29.ToString();
            textBox30.Text = LTI.TextB30.ToString();
            textBox31.Text = LTI.TextB31.ToString();
            textBox32.Text = LTI.TextB32.ToString();
            textBox33.Text = LTI.TextB33.ToString();
            textBox34.Text = LTI.TextB34.ToString();
            textBox35.Text = LTI.TextB35.ToString();
            textBox36.Text = LTI.TextB36.ToString();
            textBox37.Text = LTI.TextB37.ToString();
            textBox38.Text = LTI.TextB38.ToString();
            textBox39.Text = LTI.TextB39.ToString();
            textBox40.Text = LTI.TextB40.ToString();
            textBox41.Text = LTI.TextB41.ToString();
            textBox42.Text = LTI.TextB42.ToString();
            textBox43.Text = LTI.TextB43.ToString();
        }
        
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
        
        private void SaveValue() {
            LTI.TextB1 = Convert.ToInt32(textBox1.Text);
            LTI.TextB2 = Convert.ToInt32(textBox2.Text);
            LTI.TextB3 = Convert.ToInt32(textBox3.Text);
            LTI.TextB4 = Convert.ToInt32(textBox4.Text);
            LTI.TextB5 = Convert.ToInt32(textBox5.Text);
            LTI.TextB6 = Convert.ToInt32(textBox6.Text);
            LTI.TextB7 = Convert.ToInt32(textBox7.Text);
            LTI.TextB8 = Convert.ToInt32(textBox8.Text);
            LTI.TextB9 = Convert.ToInt32(textBox9.Text);
            LTI.TextB10 = Convert.ToInt32(textBox10.Text);
            LTI.TextB11 = Convert.ToInt32(textBox11.Text);
            LTI.TextB12 = Convert.ToInt32(textBox12.Text);
            LTI.TextB13 = Convert.ToInt32(textBox13.Text);
            LTI.TextB14 = Convert.ToInt32(textBox14.Text);
            LTI.TextB15 = Convert.ToInt32(textBox15.Text);
            LTI.TextB16 = Convert.ToInt32(textBox16.Text);
            LTI.TextB17 = Convert.ToInt32(textBox17.Text);
            LTI.TextB18 = Convert.ToInt32(textBox18.Text);
            LTI.TextB19 = Convert.ToInt32(textBox19.Text);
            LTI.TextB20 = Convert.ToInt32(textBox20.Text);
            LTI.TextB21 = Convert.ToInt32(textBox21.Text);
            LTI.TextB22 = Convert.ToInt32(textBox22.Text);
            LTI.TextB23 = Convert.ToInt32(textBox23.Text);
            LTI.TextB24 = Convert.ToInt32(textBox24.Text);
            LTI.TextB25 = Convert.ToInt32(textBox25.Text);
            LTI.TextB26 = Convert.ToInt32(textBox26.Text);
            LTI.TextB27 = Convert.ToInt32(textBox27.Text);
            LTI.TextB28 = Convert.ToInt32(textBox28.Text);
            LTI.TextB29 = Convert.ToInt32(textBox29.Text);
            LTI.TextB30 = Convert.ToInt32(textBox30.Text);
            LTI.TextB31 = Convert.ToInt32(textBox31.Text);
            LTI.TextB32 = Convert.ToInt32(textBox32.Text);
            LTI.TextB33 = Convert.ToInt32(textBox33.Text);
            LTI.TextB34 = Convert.ToInt32(textBox34.Text);
            LTI.TextB35 = Convert.ToInt32(textBox35.Text);
            LTI.TextB36 = Convert.ToInt32(textBox36.Text);
            LTI.TextB37 = Convert.ToInt32(textBox37.Text);
            LTI.TextB38 = Convert.ToInt32(textBox38.Text);
            LTI.TextB39 = Convert.ToInt32(textBox39.Text);
            LTI.TextB40 = Convert.ToInt32(textBox40.Text);
            LTI.TextB41 = Convert.ToInt32(textBox41.Text);
            LTI.TextB42 = Convert.ToInt32(textBox42.Text);
            LTI.TextB43 = Convert.ToInt32(textBox43.Text);
            LTI.SafeNewValueTextBox();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             if (changes) { SaveValue(); } else { this.Close(); }
        }
    }
}
