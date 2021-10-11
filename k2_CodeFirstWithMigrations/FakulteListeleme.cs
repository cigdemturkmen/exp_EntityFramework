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
    public partial class FakulteListeleme : Form
    {
        public FakulteListeleme()
        {
            InitializeComponent();
        }
        OBSDbContext db = new OBSDbContext();

        private void FakulteListeleme_Load(object sender, EventArgs e)
        {
            foreach (var item in db.Faculties)
            {
                lvwFakulteler.Items.Add(item.FacultyName);
            }

            ////////////////


            var fakulteler = db.Faculties.ToList();

            foreach (var item in fakulteler)
            {
                //lvwFakulteler li = new lvwFakulteler
                //lvwFakulteler.Items.Add(item);
            }
        }

        private void btnFakulteleriListele_Click(object sender, EventArgs e)
        {

        }

     
    }
}
