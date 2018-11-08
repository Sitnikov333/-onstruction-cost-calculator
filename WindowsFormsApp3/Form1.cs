using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private ToolTip t = new ToolTip();

        public void LabelText() {
            t.SetToolTip(label4, "Устройство фундамента  (монолитная, ж/б плита с пазами, ребрами) армированного.\r\nБетон В15, Сетки из арматурной стали А-III  диаметром 6, 14 мм. \r\nУтепление фундамента и полов 1 эт. (Высота фундамента 300-350мм)");
            t.SetToolTip(label5, "Устройство фундамента  (монолитная, ж/б плита с пазами, ребрами) армированного.\r\nБетон В15, Сетки из арматурной стали А-III  диаметром 6, 14 мм. \r\nУтепление фундамента и полов 1 эт. (Высота фундамента 450-500мм)");
            t.SetToolTip(label6, "Устройство фундамента  (буронабивные сваи, монолитная, ж/б плита с пазами, ребрами) армированного.\r\nБетон В15, Сетки из арматурной стали А-III  диаметром 6, 14 мм.\r\nУтепление фундамента и полов 1 эт. (Высота фундамента 450-500мм)");
            t.SetToolTip(label28, "Дополнительное утепление 50 мм наружных стен по обрешетке");
            t.SetToolTip(label27, "Обшивка стен, потолков ГКЛ 12,5 мм с устройством пароизоляции");
            t.SetToolTip(label26, "Обшивка стен, потолков вагонкой с огнебиозащитой и покраской, с устройством пароизоляции");
            t.SetToolTip(label34, "Окна, двери из ПВХ - профилей 'Exprof', металлические входные двери");
            t.SetToolTip(label45, "Установка сантехники(раковина, унитаз, душ.поддон) включая установку сифонов и смесителей");
            t.SetToolTip(label42, "Электроснабжение(Прокладка кабелей, установка розеток, выключателей)");
            t.SetToolTip(label38, "Вентиляция (Установка воздуховодов, вентиляторов)");
            t.SetToolTip(label39, "Отопление (Установка электрических конвекторов)");
            t.SetToolTip(label40, "Отопление (Прокладка труб, установка радиаторов)");
            t.SetToolTip(label41, "Водопровод и канализация (Прокладка труб, без установки сантех. Приборов)");
            t.SetToolTip(label14, "Наружная отделка (виниловый сайдинг SAYGA)");
            t.SetToolTip(label32, "Наружная отделка (цокольный сайдинг hand-cut-stone)");
            t.SetToolTip(label31, "Наружная отделка (облицовка желтым и коричневым кирпичом)");
            t.SetToolTip(label30, "Устройство цоколя (цокольный сайдинг)");
            t.SetToolTip(label12, "Обшивка наружных стен ВНУТРИ (теплозвукоизоляционная плита «ISOPLAAT» 12мм)");
            t.SetToolTip(label13, "Обшивка наружных стен СНАРУЖИ (Фасадная ветрозащита\r\nтеплозвукоизоляционная плита «ISOPLAAT» 25мм)");
            t.SetToolTip(label10, "Конструкции каркаса стен (Наружные 150мм,  внутренние 100мм), Конструкции перекрытия,\r\nстропильная система. Без утепления и обшивки стен, перекрытий");
            t.SetToolTip(label8, "Обшивка наружных стен СНАРУЖИ OSB 9мм");
            t.SetToolTip(label9, "Утепление каркаса  (Наружные 150мм,  внутренние 100мм),Перекрытие 150мм, Кровля 200мм.\r\nТермо плита 037");
            t.SetToolTip(label25, "Мягкая черепица Шинглас КАДРИЛЬ соната (корич.)");
            t.SetToolTip(label24, "Металлочерепица Монтерей");
            t.SetToolTip(label23, "Софит (сайдинг перфорированный)");
            t.SetToolTip(label22, "Софит (деревянный, открытого типа)");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LabelText();


            //radioButton1.Checked ? () : ();
            //[первый операнд - условие] ? [второй операнд] : [третий операнд]
            // ⍰ \r\n  t.SetToolTip(label28, "");
        }
        private int sum;
        private void SumAll(int i) {
            //sum += i;
            //checkBox19.Checked ? 
        }
        /*private void коэффициентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeComponent();

        }
        */
        private void просмотрИзменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form2 dlg = new Form2();
            dlg.ShowDialog(this);
            //Form2 formK = new Form2();
            //formK.Show();
            //new 
        }
    }

}
