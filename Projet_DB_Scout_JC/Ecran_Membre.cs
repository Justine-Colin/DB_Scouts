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
    public partial class Ecran_Membre : Form
    {
        DataTable DT_Membre;
        BindingSource BS_Membre;
        string S_Ch_Conn;
        bool Ajout = false;

        public Ecran_Membre(string _S_Ch_Conn)
        {
            InitializeComponent();
            S_Ch_Conn = _S_Ch_Conn;
            Remplir_DGV();
            Activer(true);
        }

        private void Remplir_DGV() //Affichage membre
        {
            DT_Membre = new DataTable();
            DT_Membre.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Membre.Columns.Add("Nom");
            DT_Membre.Columns.Add("Prénom");
            DT_Membre.Columns.Add("Section");
            DT_Membre.Columns.Add("Age");
            DT_Membre.Columns.Add("Sexe");
            DT_Membre.Columns.Add("Statut");
            DT_Membre.Columns.Add("Cotisation");
            DT_Membre.Columns.Add("Mail");

            List<C_T_Membre> lTmp_M = new G_T_Membre(S_Ch_Conn).Lire("Nom");
            foreach (C_T_Membre Tmp in lTmp_M)
                DT_Membre.Rows.Add(Tmp.Id_Membre, Tmp.M_Nom, Tmp.M_Prenom, Tmp.M_Section, Tmp.M_Age, Tmp.M_Sexe, Tmp.M_Statut, Tmp.M_Cotisation, Tmp.M_Mail);
            BS_Membre = new BindingSource
            {
                DataSource = DT_Membre
            };
            DGV_Membres.DataSource = BS_Membre;
        }

        private void Activer(bool Actif)
        {
            DGV_Membres.Enabled = Btn_Ajout.Enabled = Btn_Edit.Enabled = Btn_Supp.Enabled = Actif;
            Btn_Conf.Enabled = Btn_Annu.Enabled = TB_Nom.Enabled = TB_Prenom.Enabled = Tb_Section.Enabled = Tb_Statut.Enabled = TB_Age.Enabled = CB_Cotisation_No.Enabled = CB_Cotisation_OK.Enabled = CB_Femme.Enabled = CB_Homme.Enabled = !Actif;
            if (Actif)
                DGV_Membres.Focus();
            else
                TB_Nom.Focus();
        }

        #region Events
        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            Activer(false);
            TB_Nom.Text = Tb_Section.Text = TB_Prenom.Text = Tb_Statut.Text = TB_Age.Text = "";
            CB_Cotisation_No.Checked = CB_Cotisation_OK.Checked = CB_Femme.Checked = CB_Homme.Checked = false;
            Ajout = true;
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if (DGV_Membres.SelectedRows.Count > 0)
            {
                Activer(false);                
                C_T_Membre Tmp = new G_T_Membre(S_Ch_Conn).Lire_ID(int.Parse(DGV_Membres.SelectedRows[0].Cells["ID"].Value.ToString()));
                TB_Nom.Text = Tmp.M_Nom;
                Tb_Section.Text = Tmp.M_Section;
                TB_Prenom.Text = Tmp.M_Prenom;
                Tb_Statut.Text = Tmp.M_Statut;
                TB_Age.Text = Tmp.M_Age.ToString();
                TB_Mail.Text = Tmp.M_Mail;

                //Affichage du sexe
                if (Tmp.M_Sexe == "Homme")
                {
                    CB_Homme.Checked = true;
                    CB_Femme.Checked = false;
                }
                else if (Tmp.M_Sexe == "Femme")
                {
                    CB_Homme.Checked = false;
                    CB_Homme.Checked = true;
                }
                else
                {
                    CB_Homme.Checked = false;
                    CB_Femme.Checked = false;
                }

                if(Tmp.M_Cotisation == "Oui")
                {
                    CB_Cotisation_OK.Checked = true;
                    CB_Cotisation_No.Checked = false;
                }
                else
                {
                    CB_Cotisation_OK.Checked = false;
                    CB_Cotisation_No.Checked = true;
                }
                Ajout = false;
            }
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            if (DGV_Membres.SelectedRows.Count > 0)
            {
                int N_ID = (int)DGV_Membres.SelectedRows[0].Cells["ID"].Value;
                new G_T_Membre(S_Ch_Conn).Supprimer(N_ID);
                BS_Membre.RemoveCurrent();
            }
        }

        private void Btn_Conf_Click(object sender, EventArgs e)
        {
            if (TB_Age.Text.Length == 0 || TB_Nom.Text.Length == 0 || TB_Prenom.Text.Length == 0 || Tb_Section.Text.Length == 0 || Tb_Statut.Text.Length == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
            else if (CB_Cotisation_OK.Checked == false && CB_Cotisation_No.Checked == false)
                MessageBox.Show("Veuillez remplir tous les champs");
            else if (CB_Cotisation_OK.Checked == true && CB_Cotisation_No.Checked == true)
                MessageBox.Show("Veuillez cocher une seule option de cotisation");
            else if (CB_Homme.Checked == false && CB_Femme.Checked == false)
                MessageBox.Show("Veuillez remplir tous les champs");
            else if (CB_Homme.Checked == true && CB_Femme.Checked == true)
                MessageBox.Show("Veuillez cocher un seul sexe");
            else
            {
                string Sexe;
                if (CB_Homme.Checked == true)
                    Sexe = "Homme";
                else
                    Sexe = "Femme";

                string s;
                if (CB_Cotisation_OK.Checked)
                    s = "Oui";
                else
                    s = "Non";

                if (Ajout == true) //Mode ajout
                {
                    int N_ID = new G_T_Membre(S_Ch_Conn).Ajouter(TB_Nom.Text, TB_Prenom.Text, int.Parse(TB_Age.Text), Sexe, Tb_Statut.Text, Tb_Section.Text, s, TB_Mail.Text);
                    DT_Membre.Rows.Add(N_ID, TB_Nom.Text, TB_Prenom.Text, Tb_Section.Text, TB_Age.Text, Sexe, Tb_Statut.Text, s, TB_Mail.Text);
                }
                else //Mode édition
                {
                    int N_ID = int.Parse(DGV_Membres.SelectedRows[0].Cells["ID"].Value.ToString());
                    new G_T_Membre(S_Ch_Conn).Modifier(N_ID, TB_Nom.Text, TB_Prenom.Text, int.Parse(TB_Age.Text), Sexe, Tb_Statut.Text, Tb_Section.Text, CB_Cotisation_OK.Text, TB_Mail.Text);
                    DGV_Membres.SelectedRows[0].Cells["ID"].Value = N_ID;
                    DGV_Membres.SelectedRows[0].Cells["Nom"].Value = TB_Nom.Text;
                    DGV_Membres.SelectedRows[0].Cells["Prénom"].Value = TB_Prenom.Text;
                    DGV_Membres.SelectedRows[0].Cells["Section"].Value = Tb_Section.Text;
                    DGV_Membres.SelectedRows[0].Cells["Age"].Value = TB_Age.Text;
                    DGV_Membres.SelectedRows[0].Cells["Sexe"].Value = Sexe;
                    DGV_Membres.SelectedRows[0].Cells["Statut"].Value = Tb_Statut.Text;
                    DGV_Membres.SelectedRows[0].Cells["Cotisation"].Value = s;
                    DGV_Membres.SelectedRows[0].Cells["Mail"].Value = TB_Mail.Text;
                    BS_Membre.EndEdit();
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
