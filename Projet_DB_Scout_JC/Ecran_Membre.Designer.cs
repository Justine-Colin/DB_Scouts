namespace Projet_DB_Scout_JC
{
    partial class Ecran_Membre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Membres = new System.Windows.Forms.DataGridView();
            this.Btn_Supp = new System.Windows.Forms.Button();
            this.Btn_Edit = new System.Windows.Forms.Button();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Lbl_Nom = new System.Windows.Forms.Label();
            this.Lbl_Prenom = new System.Windows.Forms.Label();
            this.TB_Prenom = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.Lbl_Naissance = new System.Windows.Forms.Label();
            this.Btn_Annu = new System.Windows.Forms.Button();
            this.Btn_Conf = new System.Windows.Forms.Button();
            this.Lbl_Sexe = new System.Windows.Forms.Label();
            this.CB_Femme = new System.Windows.Forms.CheckBox();
            this.CB_Homme = new System.Windows.Forms.CheckBox();
            this.Lbl_Statut = new System.Windows.Forms.Label();
            this.Tb_Statut = new System.Windows.Forms.TextBox();
            this.Lbl_Section = new System.Windows.Forms.Label();
            this.Tb_Section = new System.Windows.Forms.TextBox();
            this.CB_Cotisation_OK = new System.Windows.Forms.CheckBox();
            this.CB_Cotisation_No = new System.Windows.Forms.CheckBox();
            this.Lbl_Cotisation = new System.Windows.Forms.Label();
            this.TB_Age = new System.Windows.Forms.TextBox();
            this.TB_Mail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membres)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Membres
            // 
            this.DGV_Membres.BackgroundColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Membres.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_Membres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Membres.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_Membres.GridColor = System.Drawing.Color.Bisque;
            this.DGV_Membres.Location = new System.Drawing.Point(12, 12);
            this.DGV_Membres.Name = "DGV_Membres";
            this.DGV_Membres.RowHeadersVisible = false;
            this.DGV_Membres.RowTemplate.Height = 24;
            this.DGV_Membres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Membres.Size = new System.Drawing.Size(776, 258);
            this.DGV_Membres.TabIndex = 1;
            // 
            // Btn_Supp
            // 
            this.Btn_Supp.BackColor = System.Drawing.Color.Linen;
            this.Btn_Supp.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Supp.Location = new System.Drawing.Point(688, 370);
            this.Btn_Supp.Name = "Btn_Supp";
            this.Btn_Supp.Size = new System.Drawing.Size(100, 36);
            this.Btn_Supp.TabIndex = 5;
            this.Btn_Supp.Text = "Supprimer";
            this.Btn_Supp.UseVisualStyleBackColor = false;
            this.Btn_Supp.Click += new System.EventHandler(this.Btn_Supp_Click);
            // 
            // Btn_Edit
            // 
            this.Btn_Edit.BackColor = System.Drawing.Color.Linen;
            this.Btn_Edit.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Edit.Location = new System.Drawing.Point(688, 328);
            this.Btn_Edit.Name = "Btn_Edit";
            this.Btn_Edit.Size = new System.Drawing.Size(100, 36);
            this.Btn_Edit.TabIndex = 4;
            this.Btn_Edit.Text = "Editer";
            this.Btn_Edit.UseVisualStyleBackColor = false;
            this.Btn_Edit.Click += new System.EventHandler(this.Btn_Edit_Click);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.BackColor = System.Drawing.Color.Linen;
            this.Btn_Ajout.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout.Location = new System.Drawing.Point(688, 286);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(100, 36);
            this.Btn_Ajout.TabIndex = 3;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = false;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Lbl_Nom
            // 
            this.Lbl_Nom.AutoSize = true;
            this.Lbl_Nom.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nom.Location = new System.Drawing.Point(12, 273);
            this.Lbl_Nom.Name = "Lbl_Nom";
            this.Lbl_Nom.Size = new System.Drawing.Size(44, 24);
            this.Lbl_Nom.TabIndex = 18;
            this.Lbl_Nom.Text = "Nom";
            // 
            // Lbl_Prenom
            // 
            this.Lbl_Prenom.AutoSize = true;
            this.Lbl_Prenom.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Prenom.Location = new System.Drawing.Point(12, 325);
            this.Lbl_Prenom.Name = "Lbl_Prenom";
            this.Lbl_Prenom.Size = new System.Drawing.Size(63, 24);
            this.Lbl_Prenom.TabIndex = 17;
            this.Lbl_Prenom.Text = "Prenom";
            // 
            // TB_Prenom
            // 
            this.TB_Prenom.BackColor = System.Drawing.Color.Linen;
            this.TB_Prenom.Location = new System.Drawing.Point(12, 352);
            this.TB_Prenom.Name = "TB_Prenom";
            this.TB_Prenom.Size = new System.Drawing.Size(196, 22);
            this.TB_Prenom.TabIndex = 16;
            // 
            // TB_Nom
            // 
            this.TB_Nom.BackColor = System.Drawing.Color.Linen;
            this.TB_Nom.Location = new System.Drawing.Point(12, 300);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(196, 22);
            this.TB_Nom.TabIndex = 15;
            // 
            // Lbl_Naissance
            // 
            this.Lbl_Naissance.AutoSize = true;
            this.Lbl_Naissance.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Naissance.Location = new System.Drawing.Point(230, 273);
            this.Lbl_Naissance.Name = "Lbl_Naissance";
            this.Lbl_Naissance.Size = new System.Drawing.Size(37, 24);
            this.Lbl_Naissance.TabIndex = 14;
            this.Lbl_Naissance.Text = "Age";
            // 
            // Btn_Annu
            // 
            this.Btn_Annu.BackColor = System.Drawing.Color.Linen;
            this.Btn_Annu.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Annu.Location = new System.Drawing.Point(481, 390);
            this.Btn_Annu.Name = "Btn_Annu";
            this.Btn_Annu.Size = new System.Drawing.Size(100, 36);
            this.Btn_Annu.TabIndex = 12;
            this.Btn_Annu.Text = "Annuler";
            this.Btn_Annu.UseVisualStyleBackColor = false;
            this.Btn_Annu.Click += new System.EventHandler(this.Btn_Annu_Click);
            // 
            // Btn_Conf
            // 
            this.Btn_Conf.BackColor = System.Drawing.Color.Linen;
            this.Btn_Conf.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Conf.Location = new System.Drawing.Point(481, 352);
            this.Btn_Conf.Name = "Btn_Conf";
            this.Btn_Conf.Size = new System.Drawing.Size(100, 36);
            this.Btn_Conf.TabIndex = 11;
            this.Btn_Conf.Text = "Confirmer";
            this.Btn_Conf.UseVisualStyleBackColor = false;
            this.Btn_Conf.Click += new System.EventHandler(this.Btn_Conf_Click);
            // 
            // Lbl_Sexe
            // 
            this.Lbl_Sexe.AutoSize = true;
            this.Lbl_Sexe.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Sexe.Location = new System.Drawing.Point(230, 325);
            this.Lbl_Sexe.Name = "Lbl_Sexe";
            this.Lbl_Sexe.Size = new System.Drawing.Size(42, 24);
            this.Lbl_Sexe.TabIndex = 19;
            this.Lbl_Sexe.Text = "Sexe";
            // 
            // CB_Femme
            // 
            this.CB_Femme.AutoSize = true;
            this.CB_Femme.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Femme.Location = new System.Drawing.Point(339, 349);
            this.CB_Femme.Name = "CB_Femme";
            this.CB_Femme.Size = new System.Drawing.Size(82, 28);
            this.CB_Femme.TabIndex = 21;
            this.CB_Femme.Text = "Femme";
            this.CB_Femme.UseVisualStyleBackColor = true;
            // 
            // CB_Homme
            // 
            this.CB_Homme.AutoSize = true;
            this.CB_Homme.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Homme.Location = new System.Drawing.Point(234, 349);
            this.CB_Homme.Name = "CB_Homme";
            this.CB_Homme.Size = new System.Drawing.Size(85, 28);
            this.CB_Homme.TabIndex = 22;
            this.CB_Homme.Text = "Homme";
            this.CB_Homme.UseVisualStyleBackColor = true;
            // 
            // Lbl_Statut
            // 
            this.Lbl_Statut.AutoSize = true;
            this.Lbl_Statut.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Statut.Location = new System.Drawing.Point(230, 377);
            this.Lbl_Statut.Name = "Lbl_Statut";
            this.Lbl_Statut.Size = new System.Drawing.Size(54, 24);
            this.Lbl_Statut.TabIndex = 24;
            this.Lbl_Statut.Text = "Statut";
            // 
            // Tb_Statut
            // 
            this.Tb_Statut.BackColor = System.Drawing.Color.Linen;
            this.Tb_Statut.Location = new System.Drawing.Point(234, 404);
            this.Tb_Statut.Name = "Tb_Statut";
            this.Tb_Statut.Size = new System.Drawing.Size(196, 22);
            this.Tb_Statut.TabIndex = 23;
            // 
            // Lbl_Section
            // 
            this.Lbl_Section.AutoSize = true;
            this.Lbl_Section.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Section.Location = new System.Drawing.Point(12, 377);
            this.Lbl_Section.Name = "Lbl_Section";
            this.Lbl_Section.Size = new System.Drawing.Size(61, 24);
            this.Lbl_Section.TabIndex = 26;
            this.Lbl_Section.Text = "Section";
            // 
            // Tb_Section
            // 
            this.Tb_Section.BackColor = System.Drawing.Color.Linen;
            this.Tb_Section.Location = new System.Drawing.Point(12, 404);
            this.Tb_Section.Name = "Tb_Section";
            this.Tb_Section.Size = new System.Drawing.Size(196, 22);
            this.Tb_Section.TabIndex = 25;
            // 
            // CB_Cotisation_OK
            // 
            this.CB_Cotisation_OK.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cotisation_OK.Location = new System.Drawing.Point(481, 298);
            this.CB_Cotisation_OK.Name = "CB_Cotisation_OK";
            this.CB_Cotisation_OK.Size = new System.Drawing.Size(100, 27);
            this.CB_Cotisation_OK.TabIndex = 27;
            this.CB_Cotisation_OK.Text = "Oui";
            this.CB_Cotisation_OK.UseVisualStyleBackColor = true;
            // 
            // CB_Cotisation_No
            // 
            this.CB_Cotisation_No.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cotisation_No.Location = new System.Drawing.Point(481, 322);
            this.CB_Cotisation_No.Name = "CB_Cotisation_No";
            this.CB_Cotisation_No.Size = new System.Drawing.Size(100, 27);
            this.CB_Cotisation_No.TabIndex = 28;
            this.CB_Cotisation_No.Text = "Non";
            this.CB_Cotisation_No.UseVisualStyleBackColor = true;
            // 
            // Lbl_Cotisation
            // 
            this.Lbl_Cotisation.AutoSize = true;
            this.Lbl_Cotisation.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Cotisation.Location = new System.Drawing.Point(477, 273);
            this.Lbl_Cotisation.Name = "Lbl_Cotisation";
            this.Lbl_Cotisation.Size = new System.Drawing.Size(163, 24);
            this.Lbl_Cotisation.TabIndex = 29;
            this.Lbl_Cotisation.Text = "En ordre de cotisation";
            // 
            // TB_Age
            // 
            this.TB_Age.BackColor = System.Drawing.Color.Linen;
            this.TB_Age.Location = new System.Drawing.Point(234, 300);
            this.TB_Age.Name = "TB_Age";
            this.TB_Age.Size = new System.Drawing.Size(196, 22);
            this.TB_Age.TabIndex = 30;
            // 
            // TB_Mail
            // 
            this.TB_Mail.BackColor = System.Drawing.Color.Linen;
            this.TB_Mail.Location = new System.Drawing.Point(12, 477);
            this.TB_Mail.Name = "TB_Mail";
            this.TB_Mail.Size = new System.Drawing.Size(196, 22);
            this.TB_Mail.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mail";
            // 
            // Ecran_Membre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(802, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Mail);
            this.Controls.Add(this.TB_Age);
            this.Controls.Add(this.Lbl_Cotisation);
            this.Controls.Add(this.CB_Cotisation_No);
            this.Controls.Add(this.CB_Cotisation_OK);
            this.Controls.Add(this.Lbl_Section);
            this.Controls.Add(this.Tb_Section);
            this.Controls.Add(this.Lbl_Statut);
            this.Controls.Add(this.Tb_Statut);
            this.Controls.Add(this.CB_Homme);
            this.Controls.Add(this.CB_Femme);
            this.Controls.Add(this.Lbl_Sexe);
            this.Controls.Add(this.Lbl_Nom);
            this.Controls.Add(this.Lbl_Prenom);
            this.Controls.Add(this.TB_Prenom);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.Lbl_Naissance);
            this.Controls.Add(this.Btn_Annu);
            this.Controls.Add(this.Btn_Conf);
            this.Controls.Add(this.Btn_Supp);
            this.Controls.Add(this.Btn_Edit);
            this.Controls.Add(this.Btn_Ajout);
            this.Controls.Add(this.DGV_Membres);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Membre";
            this.Text = "Ecran_Membre";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Membres;
        private System.Windows.Forms.Button Btn_Supp;
        private System.Windows.Forms.Button Btn_Edit;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Label Lbl_Nom;
        private System.Windows.Forms.Label Lbl_Prenom;
        private System.Windows.Forms.TextBox TB_Prenom;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.Label Lbl_Naissance;
        private System.Windows.Forms.Button Btn_Annu;
        private System.Windows.Forms.Button Btn_Conf;
        private System.Windows.Forms.Label Lbl_Sexe;
        private System.Windows.Forms.CheckBox CB_Femme;
        private System.Windows.Forms.CheckBox CB_Homme;
        private System.Windows.Forms.Label Lbl_Statut;
        private System.Windows.Forms.TextBox Tb_Statut;
        private System.Windows.Forms.Label Lbl_Section;
        private System.Windows.Forms.TextBox Tb_Section;
        private System.Windows.Forms.CheckBox CB_Cotisation_OK;
        private System.Windows.Forms.CheckBox CB_Cotisation_No;
        private System.Windows.Forms.Label Lbl_Cotisation;
        private System.Windows.Forms.TextBox TB_Age;
        private System.Windows.Forms.TextBox TB_Mail;
        private System.Windows.Forms.Label label1;
    }
}