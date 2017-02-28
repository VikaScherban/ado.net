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
    public partial class FrmAddGenre : Form
    {
        public int id_cart;
       string name_cart;
        public FrmAddGenre()
        {
            InitializeComponent();
        }

        public FrmAddGenre(int cart_id, string cart_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", cart_name);

            dT_ADD_GENRETableAdapter1.Fill(dsCartoons.DT_ADD_GENRE, cart_id);

            id_cart = cart_id;
            name_cart = cart_name;
        }

        private void button_AddGenre_Click(object sender, EventArgs e)
        {
            try
            {
                int gr_id = (int) (dICGENREBindingSource.Current as DataRowView)["GR_ID"];
                dT_ADD_GENRETableAdapter1.InsertQuery(id_cart, gr_id);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Помилка додавання інформації про жанр мультфільму",  "Додавання інформації про жанр мультфільму");
            }
        }



    }
}
