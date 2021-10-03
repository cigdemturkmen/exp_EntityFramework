using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace k2_CodeFirstWithMigrations
{
    public partial class Form1 : Form
    {

        /*
         Üniversite için öğrenci bilgi sistemi uygulaması yaptığınızı düşünün. İNGİLİZCE YAP

        -Ogrenci Student
        -Egitmen Instructor
        -Ders Lecture
        -Fakulte Faculty
        -Bolum Department

        -Öğrenci Eğitmen ilişkisi(danışman eğitmen) 1-n
        -Öğrenci Ders arasında n-n
        -Fakülte ile Bölüm 1-n
        -Bölüm ile Öğrenci 1-n
        -Bölüm ile ders n-n
        -Eğitmen ile ders 1-n
        
        */
        public Form1()
        {
            InitializeComponent();
        }
    }
}
