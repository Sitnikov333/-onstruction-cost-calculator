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
            
            //SumAll(1000);
            //if (radioButton1.Checked) { sum = LTI.TextB1; } else { if (radioButton2.Checked) { sum = LTI.TextB2; } else { sum = LTI.TextB3; } }
            
        }
        
            private void Form1_Load(object sender, EventArgs e)
        {
            radioButton3_CheckedChanged(sender, e);
            checkBox21_CheckedChanged_1(sender, e);
            label20.Text = sum.ToString();

            LabelText();
            //radioButton1.Checked ? () : ();
            //[первый операнд - условие] ? [второй операнд] : [третий операнд]
            // ⍰ \r\n  t.SetToolTip(label28, "");
        }
        private int sum;
        private int summ;
        private int value;


        private void SumAll(int i) {
            sum += i;
           
            
        }
        private void просмотрИзменитьToolStripMenuItem_Click(object sender, EventArgs e)    
        {
            Form2 Сoeffic = new Form2();
            Сoeffic.ShowDialog(this);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //sum = 0;
            sum = radioButton1.Checked ? LTI.TextB1 : radioButton2.Checked ? LTI.TextB2 : radioButton3.Checked ? LTI.TextB3 : 0;
            
        }





        private void checkBox21_CheckedChanged_1(object sender, EventArgs e)
        {

            summ = 0;
            //Связал чекбоксы и значения
            //Summ(checkBox19.Checked = LTI.TextB6  );
            //Summ(checkBox20.Checked = LTI.TextB5  );
            //Summ(checkBox21.Checked = LTI.TextB4  );
            //Summ(checkBox27.Checked = LTI.TextB12 );
            //Summ(checkBox18.Checked = LTI.TextB9  );
            //Summ(checkBox17.Checked = LTI.TextB8  );
            //Summ(checkBox16.Checked = LTI.TextB7  );
            //Summ(checkBox15.Checked = LTI.TextB11 );
            //Summ(checkBox14.Checked = LTI.TextB10 );
            //Summ(checkBox12.Checked = LTI.TextB17 );    
            //Summ(checkBox11.Checked = LTI.TextB16 );
            //Summ(checkBox10.Checked = LTI.TextB14 );
            //Summ(checkBox9.Checked = LTI.TextB15  );
            //Summ(checkBox8.Checked = LTI.TextB13  );
            //Summ(checkBox7.Checked = LTI.TextB22  );
            //Summ(checkBox25.Checked = LTI.TextB21 );
            //Summ(checkBox24.Checked = LTI.TextB19 );
            //Summ(checkBox23.Checked = LTI.TextB20 );
            //Summ(checkBox22.Checked = LTI.TextB18 );
            //Summ(checkBox35.Checked = LTI.TextB27 );
            //Summ(checkBox34.Checked = LTI.TextB26 );
            //Summ(checkBox33.Checked = LTI.TextB24 );
            //Summ(checkBox32.Checked = LTI.TextB25 );
            //Summ(checkBox31.Checked = LTI.TextB23 );
            //Summ(checkBox45.Checked = LTI.TextB37 );
            //Summ(checkBox44.Checked = LTI.TextB36 );
            //Summ(checkBox43.Checked = LTI.TextB34 );
            //Summ(checkBox42.Checked = LTI.TextB35 );
            //Summ(checkBox41.Checked = LTI.TextB33 );
            //Summ(checkBox40.Checked = LTI.TextB32 );
            //Summ(checkBox39.Checked = LTI.TextB31 );
            //Summ(checkBox38.Checked = LTI.TextB29 );
            //Summ(checkBox37.Checked = LTI.TextB30 );
            //Summ(checkBox36.Checked = LTI.TextB28 );
            //Summ(checkBox1.Checked = LTI.TextB43  );
            //Summ(checkBox2.Checked = LTI.TextB42  );
            //Summ(checkBox3.Checked = LTI.TextB40  );
            //Summ(checkBox4.Checked = LTI.TextB41  );
            //Summ(checkBox5.Checked = LTI.TextB39  );
            //Summ(checkBox6.Checked = LTI.TextB38  );





            //тут перечисляем чекбокс= значению чекбокса и в начале делаем сум=0; сум+= значение чекбокса
        }

    }
}
