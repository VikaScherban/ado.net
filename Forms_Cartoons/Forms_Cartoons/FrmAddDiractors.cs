using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms_Cartoons
{
    public partial class FrmAddDiractors : Form
    {
         public int id_cart;
        string name_cart;
        public FrmAddDiractors()
        {
            InitializeComponent();
           
        }

        public FrmAddDiractors(int cart_id, string cart_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", cart_name);
           dtadD_DIRACTORS1TableAdapter1.Fill(dsCartoons.DTADD_DIRACTORS1, cart_id);
            id_cart = cart_id;
            name_cart = cart_name;
        }

        private void button_add_diractors_Click(object sender, EventArgs e)
        {
            try
            {
                int dir_id = (int)(dTADDDIRACTORS1BindingSource.Current as DataRowView)["CR_ID"];
              dtadD_DIRACTORS1TableAdapter1.InsertQuery(id_cart, dir_id);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації про режисера мультфільму", "Додавання інформації про режисера мультфільму");
            }
        }

    }
}
