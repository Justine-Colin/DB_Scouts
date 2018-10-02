using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libraries ajoutées
using Projet_DB_SCOUT.Acces;
using Projet_DB_SCOUT.Classes;
using Projet_DB_SCOUT.Gestion;


namespace Projet_DB_Scout_JC
{
    public partial class Ecran_Section : Form
    {
        DataTable DT_Section;
        BindingSource BS_Section;
        string S_Ch_Conn;
        bool Ajout = false;

        public Ecran_Section(string _S_Ch_Conn)
        {
            InitializeComponent();
            S_Ch_Conn = _S_Ch_Conn;
            Remplir_DGV();
            Activer(true);
        }

        private void Remplir_DGV()
        {
            string A;
            DT_Section = new DataTable();
            DT_Section.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Section.Columns.Add("Nom");
            DT_Section.Columns.Add("Age minimum", System.Type.GetType("System.Int32"));
            DT_Section.Columns.Add("Age maximum", System.Type.GetType("System.Int32"));
            DT_Section.Columns.Add("Sexe");
            DT_Section.Columns.Add("Complet");

            List<C_T_Section> lTmp_S = new G_T_Section(S_Ch_Conn).Lire("ID");
            foreach (C_T_Section Tmp in lTmp_S)
            {
                if (Tmp.S_Complet == true)
                    A = "oui";
                else
                    A = "non";
                DT_Section.Rows.Add(Tmp.Id_Section, Tmp.S_Nom, Tmp.S_Age_Min, Tmp.S_Age_Max, Tmp.S_Sexe, A);
            }
            
            BS_Section = new BindingSource
            {
                DataSource = DT_Section
            };
            DGV_Section.DataSource = BS_Section;
        }

        private void Activer(bool Actif)
        {
            DGV_Section.Enabled = Btn_Ajout.Enabled = Btn_Edit.Enabled = Btn_Supp.Enabled = Actif;
            Btn_Conf.Enabled = Btn_Annu.Enabled = TB_Nom.Enabled = TB_Prenom.Enabled = Tb_Section.Enabled = CB_Complete_No.Enabled = CB_Complete_OK.Enabled = CB_Femme.Enabled = CB_Homme.Enabled = CB_Mixte.Enabled = !Actif;
            if (Actif)
                DGV_Section.Focus();
            else
                TB_Nom.Focus();
        }

        #region Events
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Activer(false);
            TB_Nom.Text = Tb_Section.Text = TB_Prenom.Text = "";
            CB_Complete_OK.Checked = CB_Complete_No.Checked = CB_Femme.Checked = CB_Homme.Checked = CB_Mixte.Checked = false;
            Ajout = true;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (DGV_Section.SelectedRows.Count > 0)
            {
                Activer(false);
                C_T_Section Tmp = new G_T_Section(S_Ch_Conn).Lire_ID(int.Parse(DGV_Section.SelectedRows[0].Cells["ID"].Value.ToString()));
                TB_Nom.Text = Tmp.S_Nom;
                TB_Prenom.Text = Tmp.S_Age_Min.ToString();
                Tb_Section.Text = Tmp.S_Age_Max.ToString();

                //Affichage du sexe
                if (Tmp.S_Sexe == "Homme")
                {
                    CB_Homme.Checked = true;
                    CB_Femme.Checked = false;
                    CB_Mixte.Checked = false;
                }
                else if (Tmp.S_Sexe == "Femme")
                {
                    CB_Homme.Checked = false;
                    CB_Homme.Checked = true;
                    CB_Mixte.Checked = false;
                }
                else if (Tmp.S_Sexe == "Mixte")
                {
                    CB_Homme.Checked = false;
                    CB_Homme.Checked = false;
                    CB_Mixte.Checked = true;
                }
                else
                {
                    CB_Homme.Checked = false;
                    CB_Femme.Checked = false;
                    CB_Mixte.Checked = false;
                }

                CB_Complete_OK.Checked = Tmp.S_Complet;
                CB_Complete_No.Checked = !Tmp.S_Complet;
                Ajout = false;
            }
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            if (DGV_Section.SelectedRows.Count > 0)
            {
                int N_ID = (int)DGV_Section.SelectedRows[0].Cells["ID"].Value;
                new G_T_Section(S_Ch_Conn).Supprimer(N_ID);
                BS_Section.RemoveCurrent();
            }
        }

        private void Btn_Conf_Click(object sender, EventArgs e)
        {
            if (TB_Nom.Text.Length == 0 || TB_Prenom.Text.Length == 0 || Tb_Section.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else if (CB_Complete_OK.Checked == false && CB_Complete_No.Checked == false)
                MessageBox.Show("Veuillez remplir tous les champs");
            else if (CB_Complete_OK.Checked == true && CB_Complete_No.Checked == true)
                MessageBox.Show("La section ne peut être complète et incomplète en même temps");
            else if (CB_Homme.Checked == false && CB_Femme.Checked == false && CB_Mixte.Checked == false)
                MessageBox.Show("Veuillez remplir tous les champs");
            else if ((CB_Homme.Checked == true && CB_Femme.Checked == true) || (CB_Homme.Checked == true && CB_Mixte.Checked == true) || (CB_Mixte.Checked == true && CB_Femme.Checked == true))
                MessageBox.Show("Veuillez cocher un seul sexe");
            else
            {
                string Sexe;
                if (CB_Homme.Checked == true)
                    Sexe = "Homme";
                else if (CB_Femme.Checked == true)
                    Sexe = "Femme";
                else
                    Sexe = "Mixte";

                string s;
                if (CB_Complete_OK.Checked)
                    s = "Oui";
                else
                    s = "Non";

                if (Ajout == true) //Mode ajout
                {
                    int N_ID = new G_T_Section(S_Ch_Conn).Ajouter(TB_Nom.Text, int.Parse(TB_Prenom.Text), int.Parse(Tb_Section.Text), Sexe, CB_Complete_OK.Checked);
                    DT_Section.Rows.Add(N_ID, TB_Nom.Text, TB_Prenom.Text, Tb_Section.Text, Sexe, s);
                }
                else //Mode édition
                {
                    int N_ID = int.Parse(DGV_Section.SelectedRows[0].Cells["ID"].Value.ToString());
                    new G_T_Section(S_Ch_Conn).Ajouter(TB_Nom.Text, int.Parse(TB_Prenom.Text), int.Parse(Sexe), Tb_Section.Text, CB_Complete_OK.Checked);
                    DGV_Section.SelectedRows[0].Cells["ID"].Value = N_ID;
                    DGV_Section.SelectedRows[0].Cells["Section"].Value = TB_Nom.Text;
                    DGV_Section.SelectedRows[0].Cells["Age minimum"].Value = TB_Prenom.Text;
                    DGV_Section.SelectedRows[0].Cells["Age maximum"].Value = Tb_Section.Text;
                    DGV_Section.SelectedRows[0].Cells["Sexe"].Value = Sexe;
                    DGV_Section.SelectedRows[0].Cells["Cotisation"].Value = s;
                    BS_Section.EndEdit();
                }
                Activer(true);
            }
        }

        private void Btn_Annu_Click(object sender, EventArgs e)
        {
            Activer(true);
        }
        #endregion
    }
}
