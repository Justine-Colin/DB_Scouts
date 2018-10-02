namespace Projet_DB_Scout_JC
{
    partial class Ecran_Principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGV_Membres = new System.Windows.Forms.DataGridView();
            this.DGV_Section = new System.Windows.Forms.DataGridView();
            this.DGV_ActiviteMembre = new System.Windows.Forms.DataGridView();
            this.DGV_ActiviteSection = new System.Windows.Forms.DataGridView();
            this.Btn_Membre = new System.Windows.Forms.Button();
            this.Btn_Section = new System.Windows.Forms.Button();
            this.Btn_Listing = new System.Windows.Forms.Button();
            this.CB_Cotisation = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GB_Membres = new System.Windows.Forms.GroupBox();
            this.GB_Section = new System.Windows.Forms.GroupBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.DTP_Activite = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Nom_Act = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Lbl_Chef = new System.Windows.Forms.Label();
            this.CB_Chef = new System.Windows.Forms.ComboBox();
            this.CB_Anim = new System.Windows.Forms.CheckBox();
            this.DGV_NbActivite = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Section)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ActiviteMembre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ActiviteSection)).BeginInit();
            this.GB_Membres.SuspendLayout();
            this.GB_Section.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NbActivite)).BeginInit();
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
            this.DGV_Membres.Location = new System.Drawing.Point(6, 29);
            this.DGV_Membres.Name = "DGV_Membres";
            this.DGV_Membres.ReadOnly = true;
            this.DGV_Membres.RowHeadersVisible = false;
            this.DGV_Membres.RowTemplate.Height = 24;
            this.DGV_Membres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Membres.Size = new System.Drawing.Size(438, 184);
            this.DGV_Membres.TabIndex = 0;
            this.DGV_Membres.SelectionChanged += new System.EventHandler(this.DGV_Membres_SelectionChanged);
            // 
            // DGV_Section
            // 
            this.DGV_Section.AllowUserToAddRows = false;
            this.DGV_Section.AllowUserToDeleteRows = false;
            this.DGV_Section.AllowUserToOrderColumns = true;
            this.DGV_Section.BackgroundColor = System.Drawing.Color.Linen;
            this.DGV_Section.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_Section.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_Section.GridColor = System.Drawing.Color.Bisque;
            this.DGV_Section.Location = new System.Drawing.Point(6, 29);
            this.DGV_Section.MultiSelect = false;
            this.DGV_Section.Name = "DGV_Section";
            this.DGV_Section.ReadOnly = true;
            this.DGV_Section.RowHeadersVisible = false;
            this.DGV_Section.RowTemplate.Height = 24;
            this.DGV_Section.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Section.Size = new System.Drawing.Size(438, 184);
            this.DGV_Section.TabIndex = 6;
            this.DGV_Section.SelectionChanged += new System.EventHandler(this.DGV_Section_SelectionChanged);
            // 
            // DGV_ActiviteMembre
            // 
            this.DGV_ActiviteMembre.BackgroundColor = System.Drawing.Color.Linen;
            this.DGV_ActiviteMembre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ActiviteMembre.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGV_ActiviteMembre.GridColor = System.Drawing.Color.Bisque;
            this.DGV_ActiviteMembre.Location = new System.Drawing.Point(6, 244);
            this.DGV_ActiviteMembre.Name = "DGV_ActiviteMembre";
            this.DGV_ActiviteMembre.ReadOnly = true;
            this.DGV_ActiviteMembre.RowHeadersVisible = false;
            this.DGV_ActiviteMembre.RowTemplate.Height = 24;
            this.DGV_ActiviteMembre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ActiviteMembre.Size = new System.Drawing.Size(438, 192);
            this.DGV_ActiviteMembre.TabIndex = 2;
            // 
            // DGV_ActiviteSection
            // 
            this.DGV_ActiviteSection.BackgroundColor = System.Drawing.Color.Linen;
            this.DGV_ActiviteSection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_ActiviteSection.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGV_ActiviteSection.GridColor = System.Drawing.Color.Bisque;
            this.DGV_ActiviteSection.Location = new System.Drawing.Point(6, 243);
            this.DGV_ActiviteSection.Name = "DGV_ActiviteSection";
            this.DGV_ActiviteSection.ReadOnly = true;
            this.DGV_ActiviteSection.RowHeadersVisible = false;
            this.DGV_ActiviteSection.RowTemplate.Height = 24;
            this.DGV_ActiviteSection.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ActiviteSection.Size = new System.Drawing.Size(438, 192);
            this.DGV_ActiviteSection.TabIndex = 3;
            // 
            // Btn_Membre
            // 
            this.Btn_Membre.BackColor = System.Drawing.Color.Linen;
            this.Btn_Membre.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Membre.Location = new System.Drawing.Point(474, 268);
            this.Btn_Membre.Name = "Btn_Membre";
            this.Btn_Membre.Size = new System.Drawing.Size(232, 43);
            this.Btn_Membre.TabIndex = 4;
            this.Btn_Membre.Text = "Gestion membres";
            this.Btn_Membre.UseVisualStyleBackColor = false;
            this.Btn_Membre.Click += new System.EventHandler(this.Btn_Membre_Click);
            // 
            // Btn_Section
            // 
            this.Btn_Section.BackColor = System.Drawing.Color.Linen;
            this.Btn_Section.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Section.Location = new System.Drawing.Point(474, 317);
            this.Btn_Section.Name = "Btn_Section";
            this.Btn_Section.Size = new System.Drawing.Size(232, 43);
            this.Btn_Section.TabIndex = 6;
            this.Btn_Section.Text = "Gestion section";
            this.Btn_Section.UseVisualStyleBackColor = false;
            this.Btn_Section.Click += new System.EventHandler(this.Btn_Section_Click);
            // 
            // Btn_Listing
            // 
            this.Btn_Listing.BackColor = System.Drawing.Color.Linen;
            this.Btn_Listing.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Listing.Location = new System.Drawing.Point(474, 366);
            this.Btn_Listing.Name = "Btn_Listing";
            this.Btn_Listing.Size = new System.Drawing.Size(232, 43);
            this.Btn_Listing.TabIndex = 7;
            this.Btn_Listing.Text = "Listing de la section";
            this.Btn_Listing.UseVisualStyleBackColor = false;
            this.Btn_Listing.Click += new System.EventHandler(this.Btn_Listing_Click);
            // 
            // CB_Cotisation
            // 
            this.CB_Cotisation.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Cotisation.Location = new System.Drawing.Point(474, 52);
            this.CB_Cotisation.Name = "CB_Cotisation";
            this.CB_Cotisation.Size = new System.Drawing.Size(226, 28);
            this.CB_Cotisation.TabIndex = 8;
            this.CB_Cotisation.Tag = "6";
            this.CB_Cotisation.Text = "En retard de cotisation";
            this.CB_Cotisation.UseVisualStyleBackColor = true;
            this.CB_Cotisation.CheckedChanged += new System.EventHandler(this.CB_Cotisation_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(6, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 17;
            this.label2.Text = "Activités de l\'animateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Activités de la section";
            // 
            // GB_Membres
            // 
            this.GB_Membres.Controls.Add(this.DGV_Membres);
            this.GB_Membres.Controls.Add(this.DGV_ActiviteMembre);
            this.GB_Membres.Controls.Add(this.label2);
            this.GB_Membres.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Membres.Location = new System.Drawing.Point(12, 12);
            this.GB_Membres.Name = "GB_Membres";
            this.GB_Membres.Size = new System.Drawing.Size(450, 442);
            this.GB_Membres.TabIndex = 20;
            this.GB_Membres.TabStop = false;
            this.GB_Membres.Text = "Membres";
            // 
            // GB_Section
            // 
            this.GB_Section.Controls.Add(this.label4);
            this.GB_Section.Controls.Add(this.DGV_ActiviteSection);
            this.GB_Section.Controls.Add(this.DGV_Section);
            this.GB_Section.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Section.Location = new System.Drawing.Point(712, 12);
            this.GB_Section.Name = "GB_Section";
            this.GB_Section.Size = new System.Drawing.Size(450, 442);
            this.GB_Section.TabIndex = 21;
            this.GB_Section.TabStop = false;
            this.GB_Section.Text = "Sections";
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(135, 462);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(241, 22);
            this.TB_Nom.TabIndex = 22;
            // 
            // DTP_Activite
            // 
            this.DTP_Activite.Location = new System.Drawing.Point(396, 460);
            this.DTP_Activite.Name = "DTP_Activite";
            this.DTP_Activite.Size = new System.Drawing.Size(207, 22);
            this.DTP_Activite.TabIndex = 23;
            // 
            // Lbl_Nom_Act
            // 
            this.Lbl_Nom_Act.AutoSize = true;
            this.Lbl_Nom_Act.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nom_Act.Location = new System.Drawing.Point(76, 460);
            this.Lbl_Nom_Act.Name = "Lbl_Nom_Act";
            this.Lbl_Nom_Act.Size = new System.Drawing.Size(53, 24);
            this.Lbl_Nom_Act.TabIndex = 24;
            this.Lbl_Nom_Act.Text = "Nom :";
            // 
            // Btn_Add
            // 
            this.Btn_Add.BackColor = System.Drawing.Color.Linen;
            this.Btn_Add.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Add.Location = new System.Drawing.Point(901, 456);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(169, 33);
            this.Btn_Add.TabIndex = 26;
            this.Btn_Add.Text = "Ajouter l\'activité";
            this.Btn_Add.UseVisualStyleBackColor = false;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Lbl_Chef
            // 
            this.Lbl_Chef.AutoSize = true;
            this.Lbl_Chef.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Chef.Location = new System.Drawing.Point(609, 460);
            this.Lbl_Chef.Name = "Lbl_Chef";
            this.Lbl_Chef.Size = new System.Drawing.Size(127, 24);
            this.Lbl_Chef.TabIndex = 28;
            this.Lbl_Chef.Text = "Chef secondaire :";
            // 
            // CB_Chef
            // 
            this.CB_Chef.FormattingEnabled = true;
            this.CB_Chef.Location = new System.Drawing.Point(746, 460);
            this.CB_Chef.Name = "CB_Chef";
            this.CB_Chef.Size = new System.Drawing.Size(132, 24);
            this.CB_Chef.TabIndex = 29;
            // 
            // CB_Anim
            // 
            this.CB_Anim.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Anim.Location = new System.Drawing.Point(474, 86);
            this.CB_Anim.Name = "CB_Anim";
            this.CB_Anim.Size = new System.Drawing.Size(226, 28);
            this.CB_Anim.TabIndex = 30;
            this.CB_Anim.Tag = "6";
            this.CB_Anim.Text = "Animateur";
            this.CB_Anim.UseVisualStyleBackColor = true;
            this.CB_Anim.CheckedChanged += new System.EventHandler(this.CB_Anim_CheckedChanged);
            // 
            // DGV_NbActivite
            // 
            this.DGV_NbActivite.AllowUserToAddRows = false;
            this.DGV_NbActivite.AllowUserToDeleteRows = false;
            this.DGV_NbActivite.AllowUserToOrderColumns = true;
            this.DGV_NbActivite.BackgroundColor = System.Drawing.Color.Linen;
            this.DGV_NbActivite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV_NbActivite.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGV_NbActivite.GridColor = System.Drawing.Color.Bisque;
            this.DGV_NbActivite.Location = new System.Drawing.Point(474, 129);
            this.DGV_NbActivite.MultiSelect = false;
            this.DGV_NbActivite.Name = "DGV_NbActivite";
            this.DGV_NbActivite.ReadOnly = true;
            this.DGV_NbActivite.RowHeadersVisible = false;
            this.DGV_NbActivite.RowTemplate.Height = 24;
            this.DGV_NbActivite.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_NbActivite.Size = new System.Drawing.Size(226, 123);
            this.DGV_NbActivite.TabIndex = 20;
            // 
            // Ecran_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1171, 508);
            this.Controls.Add(this.DGV_NbActivite);
            this.Controls.Add(this.CB_Anim);
            this.Controls.Add(this.CB_Chef);
            this.Controls.Add(this.CB_Cotisation);
            this.Controls.Add(this.Btn_Listing);
            this.Controls.Add(this.Lbl_Chef);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.Lbl_Nom_Act);
            this.Controls.Add(this.DTP_Activite);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.GB_Section);
            this.Controls.Add(this.Btn_Section);
            this.Controls.Add(this.GB_Membres);
            this.Controls.Add(this.Btn_Membre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ecran_Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Activated += new System.EventHandler(this.Ecran_Principal_Activated);
            this.Load += new System.EventHandler(this.Ecran_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Membres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Section)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ActiviteMembre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ActiviteSection)).EndInit();
            this.GB_Membres.ResumeLayout(false);
            this.GB_Membres.PerformLayout();
            this.GB_Section.ResumeLayout(false);
            this.GB_Section.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_NbActivite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Membres;
        private System.Windows.Forms.DataGridView DGV_Section;
        private System.Windows.Forms.DataGridView DGV_ActiviteMembre;
        private System.Windows.Forms.DataGridView DGV_ActiviteSection;
        private System.Windows.Forms.Button Btn_Membre;
        private System.Windows.Forms.Button Btn_Section;
        private System.Windows.Forms.Button Btn_Listing;
        private System.Windows.Forms.CheckBox CB_Cotisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox GB_Membres;
        private System.Windows.Forms.GroupBox GB_Section;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.DateTimePicker DTP_Activite;
        private System.Windows.Forms.Label Lbl_Nom_Act;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label Lbl_Chef;
        private System.Windows.Forms.ComboBox CB_Chef;
        private System.Windows.Forms.CheckBox CB_Anim;
        private System.Windows.Forms.DataGridView DGV_NbActivite;
    }
}

