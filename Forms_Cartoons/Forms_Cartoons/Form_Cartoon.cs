using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cartoons_DATA;
using Cartoons_DATA.DSCartoonsTableAdapters;

namespace Forms_Cartoons
{
    public partial class Form_Cartoon : Form
    {
        public Form_Cartoon()
        {
            InitializeComponent();
            cartoonsTableAdapter1.Fill(dsCartoons.CARTOONS);
            diC_COMPANYTableAdapter1.Fill(dsCartoons.DIC_COMPANY);
            diC_COUNRTYTableAdapter1.Fill(dsCartoons.DIC_COUNRTY);
            diC_DIRACTORSTableAdapter1.Fill(dsCartoons.DIC_DIRACTORS);
            diC_GENRETableAdapter1.Fill(dsCartoons.DIC_GENRE);
            diC_CARTOON_STATUSESTableAdapter1.Fill(dsCartoons.DIC_CARTOON_STATUSES);

        }


        private void Form_Cartoon_Load(object sender, EventArgs e)
        {

        }


        private void buttn_save_Cartoons_Click(object sender, EventArgs e)
        {
            cartoonsTableAdapter1.Update(dsCartoons.CARTOONS);
        }

        private void button_delete_Cartoons_Click(object sender, EventArgs e)
        {
            cARTOONSBindingSource.RemoveCurrent();
        }

        private void button_save_company_Click(object sender, EventArgs e)
        {
            diC_COMPANYTableAdapter1.Update(dsCartoons.DIC_COMPANY);
        }

        private void button_delete_company_Click(object sender, EventArgs e)
        {
            try
            {
                var qTAdapterDtCartoons = new Cartoons_DATA.DSCartoonsTableAdapters.QTAdapterDTCartoons();
                int id = (int) dGVCompany.CurrentRow.Cells["cPIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> cp_count = qTAdapterDtCartoons.SQCountCPInCompany_Cartoons(id);
                if (cp_count == 0)
                {
                    dICCOMPANYBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видаляти не можна! До компанії прив'язані мультфільми!", "Помилка видалення компанії");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про компанію", "Видалення інформації про компанію");
            }
        }

        private void button_save_country_Click(object sender, EventArgs e)
        {
            diC_COUNRTYTableAdapter1.Update(dsCartoons.DIC_COUNRTY);
        }

        private void button_delete_country_Click(object sender, EventArgs e)
        {
           
            dICCOUNRTYBindingSource.RemoveCurrent();
        }

        private void button_save_directors_Click(object sender, EventArgs e)
        {
            diC_DIRACTORSTableAdapter1.Update(dsCartoons.DIC_DIRACTORS);
        }

        private void button_delete_directors_Click(object sender, EventArgs e)
        {
            try
            {
                var qTAdapterDtCartoons = new Cartoons_DATA.DSCartoonsTableAdapters.QTAdapterDTCartoons();
                int id = (int) dGVDiractors.CurrentRow.Cells["dRIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> dr_count = qTAdapterDtCartoons.SQCountDR_IDInDiractors_Cartoons(id);
                if (dr_count == 0)
                {
                    dICDIRACTORSBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видаляти не можна! До режисера прив'язані мультфільми!", "Помилка видалення режисера");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про режисера", "Видалення інформації про режисера");
            }
        }

        private void button_save_genre_Click(object sender, EventArgs e)
        {
            diC_GENRETableAdapter1.Update(dsCartoons.DIC_GENRE);
        }

        private void button_delete_genre_Click(object sender, EventArgs e)
        {
            try
            {
                var qTAdapterDtCartoons = new Cartoons_DATA.DSCartoonsTableAdapters.QTAdapterDTCartoons();
                int id = (int) dGVGenre.CurrentRow.Cells["gRIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> gr_count = qTAdapterDtCartoons.SQCountGR_IDInGenre_Cartoons(id);
                if (gr_count == 0)
                {
                    dICGENREBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видаляти не можна! До жанру прив'язані мультфільми!", "Помилка видалення жанру");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про жанр", "Видалення інформації про жанр");
            }
        }

        private void button_save_statuses_Click(object sender, EventArgs e)
        {
            diC_CARTOON_STATUSESTableAdapter1.Update(dsCartoons.DIC_CARTOON_STATUSES);
        }

        private void button_delete_statuses_Click(object sender, EventArgs e)
        {
            try
            {
                var qTAdapterDtCartoons = new Cartoons_DATA.DSCartoonsTableAdapters.QTAdapterDTCartoons();
                int id = (int) dGVStatuses.CurrentRow.Cells["cSIDDataGridViewTextBoxColumn"].Value;
                global::System.Nullable<int> cs_count = qTAdapterDtCartoons.SQCountCS_IDInCartoons(id);
                if (cs_count == 0)
                {
                    dICCARTOONSTATUSESBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("Видаляти не можна! До статуса прив'язані мультфільми!", "Помилка видалення статуса");
                }
            }
            catch
            {
                MessageBox.Show("Помилка видалення інформації про статус", "Видалення інформації про статус");
            }

        }

        private void dGVCartoons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (changed)
            {
                MessageBox.Show("Необхідно зберегти зміни!", "Перегляд жанрів та режисерів мультфільма");
            }
            else*/
            {
                try
                {
                    int id = (int) dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
                    dtdiC_GENRETableAdapter1.FillByCR_IDInGenreCartoons(dsCartoons.DTDIC_GENRE, id);
                    dtdiC_DIRACORSTableAdapter1.FillByCR_IDInDiractorsCartoons(dsCartoons.DTDIC_DIRACORS, id);
                }
                catch
                {
                    MessageBox.Show("Помилка відображення списку жанрів та режисерів з таким іd мультфільму",  "Відображення жанрів та режисерів мультфільму");
                }
            }
        }

        private void button_del_genre_Click(object sender, EventArgs e)
        {
            try
            {
                int id_genre = (int)dGVAddGenre.CurrentRow.Cells["gRIDDataGridViewTextBoxColumn1"].Value;
                int id_cartoon = (int) dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;

                dtdiC_GENRETableAdapter1.DeleteQuery(id_cartoon, id_genre);
                dtdiC_GENRETableAdapter1.FillByCR_IDInGenreCartoons(dsCartoons.DTDIC_GENRE, id_cartoon);
            }
            catch
            {
                MessageBox.Show("Помилка видалення жанру мультфільму!", "Видалення  жанру мультфільму");
            }
        }

        private void button_delete_diractor_Click(object sender, EventArgs e)
        {
            try
            {
                int id_diractor = (int)dGVAddDiractor.CurrentRow.Cells["dRIDDataGridViewTextBoxColumn1"].Value;
                int id_cartoon = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
               dtdiC_DIRACORSTableAdapter1.DeleteQuery(id_cartoon, id_diractor);
               dtdiC_DIRACORSTableAdapter1.FillByCR_IDInDiractorsCartoons(dsCartoons.DTDIC_DIRACORS, id_cartoon);
            }
            catch
            {
                MessageBox.Show("Помилка видалення режисера мультфільму!", "Видалення режисера мультфільму");
            }
        }

        private void button_add_genre_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
            string name = (string)dGVCartoons.CurrentRow.Cells["cRNAMEDataGridViewTextBoxColumn"].Value;
            FrmAddGenre genDialog = new  FrmAddGenre(id, name);

            genDialog.ShowDialog(this);
            genDialog.Dispose();
            dtdiC_GENRETableAdapter1.FillByCR_IDInGenreCartoons(dsCartoons.DTDIC_GENRE, id);
        }
        
        private void button_add_diractor_Click(object sender, EventArgs e)
        {
            int id = (int)dGVCartoons.CurrentRow.Cells["cRIDDataGridViewTextBoxColumn"].Value;
            string name = (string)dGVCartoons.CurrentRow.Cells["cRNAMEDataGridViewTextBoxColumn"].Value;
            FrmAddDiractors dirDialog = new FrmAddDiractors(id, name);

            dirDialog.ShowDialog(this);
            dirDialog.Dispose();

            dtdiC_DIRACORSTableAdapter1.FillByCR_IDInDiractorsCartoons(dsCartoons.DTDIC_DIRACORS, id);
        }

 

}
}
