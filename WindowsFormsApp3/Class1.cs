﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Properties;
using WindowsFormsApp3;

namespace LabTexInf
{
    public class LabelTextInfo
    {
        public const string DesLabel4 = "Устройство фундамента  (монолитная, ж/б плита с пазами, ребрами) армированного.\r\nБетон В15, Сетки из арматурной стали А-III  диаметром 6, 14 мм. \r\nУтепление фундамента и полов 1 эт. (Высота фундамента 300-350мм)";
        public const string DesLabel5 = "Устройство фундамента  (монолитная, ж/б плита с пазами, ребрами) армированного.\r\nБетон В15, Сетки из арматурной стали А-III  диаметром 6, 14 мм. \r\nУтепление фундамента и полов 1 эт. (Высота фундамента 450-500мм)";
        public const string DesLabel6 = "Устройство фундамента  (буронабивные сваи, монолитная, ж/б плита с пазами, ребрами) армированного.\r\nБетон В15, Сетки из арматурной стали А-III  диаметром 6, 14 мм.\r\nУтепление фундамента и полов 1 эт. (Высота фундамента 450-500мм)";
        public const string DesLabel28 = "Дополнительное утепление 50 мм наружных стен по обрешетке";
        public const string DesLabel27 = "Обшивка стен, потолков ГКЛ 12,5 мм с устройством пароизоляции";
        public const string DesLabel26 = "Обшивка стен, потолков вагонкой с огнебиозащитой и покраской, с устройством пароизоляции";
        public const string DesLabel34 = "Окна, двери из ПВХ - профилей 'Exprof', металлические входные двери";
        public const string DesLabel45 = "Установка сантехники(раковина, унитаз, душ.поддон) включая установку сифонов и смесителей";
        public const string DesLabel42 = "Электроснабжение(Прокладка кабелей, установка розеток, выключателей)";
        public const string DesLabel38 = "Вентиляция (Установка воздуховодов, вентиляторов)";
        public const string DesLabel39 = "Отопление (Установка электрических конвекторов)";
        public const string DesLabel40 = "Отопление (Прокладка труб, установка радиаторов)";
        public const string DesLabel41 = "Водопровод и канализация (Прокладка труб, без установки сантех. Приборов)";
        public const string DesLabel14 = "Наружная отделка (виниловый сайдинг SAYGA)";
        public const string DesLabel32 = "Наружная отделка (цокольный сайдинг hand-cut-stone)";
        public const string DesLabel31 = "Наружная отделка (облицовка желтым и коричневым кирпичом)";
        public const string DesLabel30 = "Устройство цоколя (цокольный сайдинг)";
        public const string DesLabel12 = "Обшивка наружных стен ВНУТРИ (теплозвукоизоляционная плита «ISOPLAAT» 12мм)";
        public const string DesLabel13 = "Обшивка наружных стен СНАРУЖИ (Фасадная ветрозащита\r\nтеплозвукоизоляционная плита «ISOPLAAT» 25мм)";
        public const string DesLabel10 = "Конструкции каркаса стен (Наружные 150мм,  внутренние 100мм), Конструкции перекрытия,\r\nстропильная система. Без утепления и обшивки стен, перекрытий";
        public const string DesLabel8 = "Обшивка наружных стен СНАРУЖИ OSB 9мм";
        public const string DesLabel9 = "Утепление каркаса  (Наружные 150мм,  внутренние 100мм),Перекрытие 150мм, Кровля 200мм.\r\nТермо плита 037";
        public const string DesLabel25 = "Мягкая черепица Шинглас КАДРИЛЬ соната (корич.)";
        public const string DesLabel24 = "Металлочерепица Монтерей";
        public const string DesLabel23 = "Софит (сайдинг перфорированный)";
        public const string DesLabel22 = "Софит (деревянный, открытого типа)";
        public Int32 TextB1 = Convert.ToInt32(Settings.Default["TextB1"]);
        public Int32 TextB2 = Convert.ToInt32(Settings.Default["TextB2"]);
        public Int32 TextB3 = Convert.ToInt32(Settings.Default["TextB3"]);
        public Int32 TextB4 = Convert.ToInt32(Settings.Default["TextB4"]);
        public Int32 TextB5 = Convert.ToInt32(Settings.Default["TextB5"]);
        public Int32 TextB6 = Convert.ToInt32(Settings.Default["TextB6"]);
        public Int32 TextB7 = Convert.ToInt32(Settings.Default["TextB7"]);
        public Int32 TextB8 = Convert.ToInt32(Settings.Default["TextB8"]);
        public Int32 TextB9 = Convert.ToInt32(Settings.Default["TextB9"]);
        public Int32 TextB10 = Convert.ToInt32(Settings.Default["TextB10"]);
        public Int32 TextB11 = Convert.ToInt32(Settings.Default["TextB11"]);
        public Int32 TextB12 = Convert.ToInt32(Settings.Default["TextB12"]);
        public Int32 TextB13 = Convert.ToInt32(Settings.Default["TextB13"]);
        public Int32 TextB14 = Convert.ToInt32(Settings.Default["TextB14"]);
        public Int32 TextB15 = Convert.ToInt32(Settings.Default["TextB15"]);
        public Int32 TextB16 = Convert.ToInt32(Settings.Default["TextB16"]);
        public Int32 TextB17 = Convert.ToInt32(Settings.Default["TextB17"]);
        public Int32 TextB18 = Convert.ToInt32(Settings.Default["TextB18"]);
        public Int32 TextB19 = Convert.ToInt32(Settings.Default["TextB19"]);
        public Int32 TextB20 = Convert.ToInt32(Settings.Default["TextB20"]);
        public Int32 TextB21 = Convert.ToInt32(Settings.Default["TextB21"]);
        public Int32 TextB22 = Convert.ToInt32(Settings.Default["TextB22"]);
        public Int32 TextB23 = Convert.ToInt32(Settings.Default["TextB23"]);
        public Int32 TextB24 = Convert.ToInt32(Settings.Default["TextB24"]);
        public Int32 TextB25 = Convert.ToInt32(Settings.Default["TextB25"]);
        public Int32 TextB26 = Convert.ToInt32(Settings.Default["TextB26"]);
        public Int32 TextB27 = Convert.ToInt32(Settings.Default["TextB27"]);
        public Int32 TextB28 = Convert.ToInt32(Settings.Default["TextB28"]);
        public Int32 TextB29 = Convert.ToInt32(Settings.Default["TextB29"]);
        public Int32 TextB30 = Convert.ToInt32(Settings.Default["TextB30"]);
        public Int32 TextB31 = Convert.ToInt32(Settings.Default["TextB31"]);
        public Int32 TextB32 = Convert.ToInt32(Settings.Default["TextB32"]);
        public Int32 TextB33 = Convert.ToInt32(Settings.Default["TextB33"]);
        public Int32 TextB34 = Convert.ToInt32(Settings.Default["TextB34"]);
        public Int32 TextB35 = Convert.ToInt32(Settings.Default["TextB35"]);
        public Int32 TextB36 = Convert.ToInt32(Settings.Default["TextB36"]);
        public Int32 TextB37 = Convert.ToInt32(Settings.Default["TextB37"]);
        public Int32 TextB38 = Convert.ToInt32(Settings.Default["TextB38"]);
        public Int32 TextB39 = Convert.ToInt32(Settings.Default["TextB39"]);
        public Int32 TextB40 = Convert.ToInt32(Settings.Default["TextB40"]);
        public Int32 TextB41 = Convert.ToInt32(Settings.Default["TextB41"]);
        public Int32 TextB42 = Convert.ToInt32(Settings.Default["TextB42"]);
        public Int32 TextB43 = Convert.ToInt32(Settings.Default["TextB43"]);

        public void SafeNewValueTextBox()
        {
            Settings.Default["TextB1"] = TextB1;
            Settings.Default["TextB2"] = TextB2;
            Settings.Default["TextB3"] = TextB3;            
            Settings.Default["TextB4"] = TextB4;
            Settings.Default["TextB5"] = TextB5;
            Settings.Default["TextB6"] = TextB6;
            Settings.Default["TextB7"] = TextB7;
            Settings.Default["TextB8"] = TextB8;
            Settings.Default["TextB9"] = TextB9;
            Settings.Default["TextB10"] = TextB10;
            Settings.Default["TextB11"] = TextB11;
            Settings.Default["TextB12"] = TextB12;
            Settings.Default["TextB13"] = TextB13;
            Settings.Default["TextB14"] = TextB14;
            Settings.Default["TextB15"] = TextB15;
            Settings.Default["TextB16"] = TextB16;
            Settings.Default["TextB17"] = TextB17;
            Settings.Default["TextB18"] = TextB18;
            Settings.Default["TextB19"] = TextB19;
            Settings.Default["TextB20"] = TextB20;
            Settings.Default["TextB21"] = TextB21;
            Settings.Default["TextB22"] = TextB22;
            Settings.Default["TextB23"] = TextB23;
            Settings.Default["TextB24"] = TextB24;
            Settings.Default["TextB25"] = TextB25;
            Settings.Default["TextB26"] = TextB26;
            Settings.Default["TextB27"] = TextB27;
            Settings.Default["TextB28"] = TextB28;
            Settings.Default["TextB29"] = TextB29;
            Settings.Default["TextB30"] = TextB30;
            Settings.Default["TextB31"] = TextB31;
            Settings.Default["TextB32"] = TextB32;
            Settings.Default["TextB33"] = TextB33;
            Settings.Default["TextB34"] = TextB34;
            Settings.Default["TextB35"] = TextB35;
            Settings.Default["TextB36"] = TextB36;
            Settings.Default["TextB37"] = TextB37;
            Settings.Default["TextB38"] = TextB38;
            Settings.Default["TextB39"] = TextB39;
            Settings.Default["TextB40"] = TextB40;
            Settings.Default["TextB41"] = TextB41;
            Settings.Default["TextB42"] = TextB42;
            Settings.Default["TextB43"] = TextB43;
            Settings.Default.Save();
        }
    }
}
    
  