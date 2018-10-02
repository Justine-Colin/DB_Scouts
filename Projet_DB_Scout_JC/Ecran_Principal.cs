using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
//Libraries ajoutées
using Projet_DB_SCOUT.Classes;
using Projet_DB_SCOUT.Gestion;
using System.Text.RegularExpressions;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Projet_DB_Scout_JC
{
    public partial class Ecran_Principal : Form
    {
        DataTable DT_Membre, DT_Section, DT_ActiviteMembre, DT_ActiviteSection;
        BindingSource BS_Membre, BS_Section, BS_ActiviteMembre, BS_ActiviteSection;
        string S_Ch_Conn = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\juju_\source\repos\DB_Scout.mdf;Integrated Security = True";
        //clientBindingSource.PositionChanged += new EventHandler(Bouger_Client); Exemple de création d'un event

        public Ecran_Principal()
        {
            InitializeComponent();
            Remplir_DGV();
        }

        public void Remplir_DGV() //Affichage membre et section
        {
            DT_Membre = new DataTable();
            DT_Section = new DataTable();
            DT_ActiviteMembre = new DataTable();
            DT_ActiviteSection = new DataTable();

            List<C_T_Membre> lTmp_M = new G_T_Membre(S_Ch_Conn).Lire("Nom");
            List<C_T_Section> lTmp_S = new G_T_Section(S_Ch_Conn).Lire("ID");

            DT_Membre.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Membre.Columns.Add("Nom");
            DT_Membre.Columns.Add("Prénom");
            DT_Membre.Columns.Add("Section");
            DT_Membre.Columns.Add("Cotisation");

            foreach (C_T_Membre Tmp in lTmp_M)
                DT_Membre.Rows.Add(Tmp.Id_Membre, Tmp.M_Nom, Tmp.M_Prenom, Tmp.M_Section, Tmp.M_Cotisation);

            DT_Section.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_Section.Columns.Add("Nom");
            DT_Section.Columns.Add("Complet");

            foreach (C_T_Section Tmp in lTmp_S)
                DT_Section.Rows.Add(Tmp.Id_Section, Tmp.S_Nom, Tmp.S_Complet);

            BS_Membre = new BindingSource();
            BS_Section = new BindingSource();
            BS_ActiviteMembre = new BindingSource();
            BS_ActiviteSection = new BindingSource();

            BS_Membre.DataSource = DT_Membre;
            BS_Section.DataSource = DT_Section;
            DGV_Membres.DataSource = BS_Membre;
            DGV_Section.DataSource = BS_Section;

            //Préparation des DGV activité
            

            DT_ActiviteMembre.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_ActiviteMembre.Columns.Add("Nom");
            DT_ActiviteMembre.Columns.Add("Date");
            DT_ActiviteMembre.Columns.Add("Section");
            BS_ActiviteMembre.DataSource = DT_ActiviteMembre;

            DT_ActiviteSection.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            DT_ActiviteSection.Columns.Add("Nom");
            DT_ActiviteSection.Columns.Add("Date");
            DT_ActiviteSection.Columns.Add("Chef");
            DT_ActiviteSection.Columns.Add("Autre chef");
            BS_ActiviteSection.DataSource = DT_ActiviteSection;

            //Remplir ComboBox
            List<C_T_Membre> lTmp = new G_T_Membre(S_Ch_Conn).Lire("ID");
            DataTable DT_CB = new DataTable();
            BindingSource BS_CB = new BindingSource();
            DT_CB.Columns.Add("Prenom");
            foreach (var Tmp in lTmp)
            {
                if (Tmp.M_Statut.Trim() == "Chef")
                    DT_CB.Rows.Add(Tmp.M_Prenom.ToString() + " " + Tmp.M_Nom.ToString());
            }
            BS_CB.DataSource = DT_CB;
            CB_Chef.DataSource = BS_CB;
            CB_Chef.DisplayMember = "Prenom";

            // SQL :
            //            go
            //WITH bb(cpt, chf)
            //as
            //(SELECT COUNT(Id_Activite)AS cc, A_Chef2 FROM T_Activite GROUP BY A_Chef2 UNION
            //SELECT COUNT(Id_Activite) as cc, A_Chef as A_Chef2 FROM T_Activite GROUP BY A_Chef)
            //select sum(cpt),chf from bb group by chf

        }

        #region Events
        private void DGV_Membres_SelectionChanged(object sender, EventArgs e) //Affichage de l'activité par chef
        {
            DT_ActiviteMembre.Rows.Clear();
            List<C_T_Activite> lTmp_A = new G_T_Activite(S_Ch_Conn).Lire("ID"); //Liste de toutes les activités
            List<C_T_Activite> lTmp = new List<C_T_Activite>(); //Liste des activités correspondantes
            List<C_T_Section> lTmp_S = new List<C_T_Section>();
            string Nom = "";

            if(DGV_Membres.SelectedRows.Count>0)
            {
                if (lTmp_A.Count > 0)
                {
                    foreach (C_T_Activite Tmp in lTmp_A)
                    {

                        if (Tmp.A_Chef == int.Parse(DGV_Membres.SelectedRows[0].Cells["ID"].Value.ToString()) || Tmp.A_Chef2 == int.Parse(DGV_Membres.SelectedRows[0].Cells["ID"].Value.ToString())) //On va rechercher les liaisons correspondantes
                        {
                            lTmp.Add(Tmp);
                        }
                    }

                    //Remplissage de la DGV

                    foreach (C_T_Activite Tmp in lTmp)
                    {
                        foreach (C_T_Section Tmp2 in lTmp_S)
                        {
                            if (Tmp2.Id_Section == Tmp.A_Section)
                            {
                                Nom = Tmp2.S_Nom;
                                break;
                            }
                        }
                        DT_ActiviteMembre.Rows.Add(Tmp.Id_Activite, Tmp.A_Nom, Tmp.A_Date, Nom);
                    }
                }
                DGV_ActiviteMembre.DataSource = BS_ActiviteMembre;
            }
        }

        private void Btn_Membre_Click(object sender, EventArgs e) //Gestion membre
        {
            Ecran_Membre f = new Ecran_Membre(S_Ch_Conn);
            f.Show();
        }

        private void CB_Cotisation_CheckedChanged(object sender, EventArgs e)
        {
            DT_Membre.Clear();
            if (CB_Cotisation.Checked)
            {
                List<C_T_Membre> lTmp = new G_T_Membre(S_Ch_Conn).Lire("ID");
                foreach (var Tmp in lTmp)
                {
                    if(Tmp.M_Cotisation == "Non")
                        DT_Membre.Rows.Add(Tmp.Id_Membre, Tmp.M_Nom, Tmp.M_Prenom, Tmp.M_Section, Tmp.M_Cotisation);
                }
            }
            else
            {
                Remplir_DGV();
            }
        }

        private void CB_Anim_CheckedChanged(object sender, EventArgs e)
        {
            DT_Membre.Clear();
            if (CB_Anim.Checked)
            {
                List<C_T_Membre> lTmp = new G_T_Membre(S_Ch_Conn).Lire("ID");
                foreach (var Tmp in lTmp)
                {
                    if (Tmp.M_Statut.Trim() == "Chef")
                        DT_Membre.Rows.Add(Tmp.Id_Membre, Tmp.M_Nom, Tmp.M_Prenom, Tmp.M_Section, Tmp.M_Cotisation);
                }
            }
            else
            {
                Remplir_DGV();
            }
        }

        private void Ecran_Principal_Activated(object sender, EventArgs e)
        {
            //Remplir_DGV();
        }

        private void DGV_Section_SelectionChanged(object sender, EventArgs e)//Affichage de l'activité par section
        {
            DT_ActiviteSection.Rows.Clear();
            List<C_T_Activite> lTmp_A = new G_T_Activite(S_Ch_Conn).Lire("ID"); //Liste de toutes les activités
            List<C_T_Activite> lTmp = new List<C_T_Activite>(); //Liste des activités correspondantes
            List<C_T_Membre> lTmp_S = new List<C_T_Membre>();
            string Nom1 = "", Nom2 = "";

            if (DGV_Section.SelectedRows.Count > 0)
            {
                if (lTmp_A.Count > 0)
                {
                    foreach (C_T_Activite Tmp in lTmp_A)
                    {

                        if (Tmp.A_Section == int.Parse(DGV_Section.SelectedRows[0].Cells["ID"].Value.ToString())) //On va rechercher les liaisons correspondantes
                        {
                            lTmp.Add(Tmp);
                        }
                    }

                    //Remplissage de la DGV

                    foreach (C_T_Activite Tmp in lTmp)
                    {
                        foreach (C_T_Membre Tmp2 in lTmp_S)
                        {
                            if (Tmp2.Id_Membre == Tmp.A_Chef)
                            {
                                Nom1 = Tmp2.M_Nom + " " + Tmp2.M_Prenom;
                            }
                            else if (Tmp2.Id_Membre == Tmp.A_Chef2)
                            {
                                Nom2 = Tmp2.M_Nom + " " + Tmp2.M_Prenom;
                            }
                        }
                        DT_ActiviteSection.Rows.Add(Tmp.Id_Activite, Tmp.A_Nom, Tmp.A_Date, Nom1, Nom2);
                    }
                }
                DGV_ActiviteSection.DataSource = BS_ActiviteSection;
            }

        }

        private void Ecran_Principal_Load(object sender, EventArgs e)
        {
            DGV_Membres.Rows[0].Selected = true;
            DGV_Section.Rows[0].Selected = true;
        }

        private void Btn_Section_Click(object sender, EventArgs e) //Gestion activité
        {
            Ecran_Section f = new Ecran_Section(S_Ch_Conn);
            f.Show();
        }

        private void Btn_Add_Click(object sender, EventArgs e)//Ajout d'une activité
        {
            if (TB_Nom.Text.Length == 0 )
                MessageBox.Show("Veuillez renseigner toutes les informations");
            else
            {
                List<C_T_Membre> lTmp_M = new G_T_Membre(S_Ch_Conn).Lire("Nom");

                foreach (C_T_Membre Tmp in lTmp_M)
                {
                    Regex exp = new Regex(" ", RegexOptions.IgnoreCase);
                    string[] Tab = exp.Split(CB_Chef.Text);
                    if (Tmp.M_Prenom == Tab[0] && Tmp.M_Nom == Tab[1])
                    {
                        int N_ID = new G_T_Activite(S_Ch_Conn).Ajouter(TB_Nom.Text, DTP_Activite.Value, int.Parse(DGV_Section.SelectedRows[0].Cells["ID"].Value.ToString()), int.Parse(DGV_Membres.SelectedRows[0].Cells["ID"].Value.ToString()), Tmp.Id_Membre);
                    }
                }                
            }
        }

        private void Btn_Listing_Click(object sender, EventArgs e)//Liste de la section en PDF
        {
            if(DGV_ActiviteSection.Rows.Count > 1)
            {
                //Liste des membres
                List<C_T_Membre> lTmp_M = new G_T_Membre(S_Ch_Conn).Lire("ID");
                List<C_T_Activite> lTmp_A = new G_T_Activite(S_Ch_Conn).Lire("ID");
                List<C_T_Section> lTmp_S = new G_T_Section(S_Ch_Conn).Lire("ID");
                DateTime datetime = Convert.ToDateTime(DGV_ActiviteSection.SelectedRows[0].Cells["Date"].Value.ToString());
                string Section = "", Nom = DGV_ActiviteSection.SelectedRows[0].Cells["Nom"].Value.ToString().Trim();
                string Date = datetime.ToShortDateString();                
                int? i = 0;

                foreach (var Tmp in lTmp_A)
                {
                    if (int.Parse(DGV_Section.SelectedRows[0].Cells["ID"].Value.ToString()) == Tmp.Id_Activite)
                        i = Tmp.A_Section;
                }
                foreach (var Tmp in lTmp_S)
                {
                    if (i == Tmp.Id_Section)
                        Section = Tmp.S_Nom.Trim();
                }

                //Création du PDF
                var PDF = new Document();
                string Path = @"C:\Users\juju_\source\repos\Projet_DB_Scout_JC";
                string Chemin = Path + "\\Liste_" + Section.Trim() + "_" + Nom + "_" + Date + ".pdf";
                PdfWriter.GetInstance(PDF, new FileStream(Chemin, FileMode.Create));
                PDF.Open();

                //Ecriture du titre + ajout logo
                iTextSharp.text.Image Pic1 = iTextSharp.text.Image.GetInstance(@"C:\Users\juju_\source\repos\Projet_DB_Scout_JC\packages\Scouts.png");
                Pic1.Alignment = iTextSharp.text.Image.TEXTWRAP | iTextSharp.text.Image.ALIGN_RIGHT;
                Pic1.ScaleAbsolute(50f, 50f);
                PDF.Add(Pic1);
                string s1 = "Liste des présences à l'activité " + DGV_ActiviteSection.SelectedRows[0].Cells["Nom"].Value.ToString().Trim();
                Paragraph Texte1 = new Paragraph(s1)
                {
                    Alignment = Element.ALIGN_CENTER
                };
                PDF.Add(Texte1);

                //Récupération des noms des membres de la section + ajout au PDF
                iTextSharp.text.List Liste = new iTextSharp.text.List(iTextSharp.text.List.UNORDERED);
                string s = "";
                foreach (var Tmp in lTmp_M)
                {
                    if (Tmp.M_Section == Section)
                    {
                        string Membre = "0" + "      " + Tmp.M_Nom.Trim() + " " + Tmp.M_Prenom.Trim();
                        Liste.Add(Membre);
                    }
                }
                PDF.Add(Liste);
                PDF.Close();
                MessageBox.Show("Le fichier PDF a été généré dans le dossier " + Path);
            }            
        }


        #endregion
    }
}
