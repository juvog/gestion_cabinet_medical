
namespace examen_final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblNomPatient = new System.Windows.Forms.Label();
            this.lblPrenomPatient = new System.Windows.Forms.Label();
            this.lblNomMedecin = new System.Windows.Forms.Label();
            this.lblMatriculeMedecin = new System.Windows.Forms.Label();
            this.gbTypeConsultation = new System.Windows.Forms.GroupBox();
            this.rdSpecialiste = new System.Windows.Forms.RadioButton();
            this.rdGeneraliste = new System.Windows.Forms.RadioButton();
            this.gbUrgence = new System.Windows.Forms.GroupBox();
            this.rdNon = new System.Windows.Forms.RadioButton();
            this.rdOui = new System.Windows.Forms.RadioButton();
            this.txtNomPatient = new System.Windows.Forms.TextBox();
            this.txtPrenomPatient = new System.Windows.Forms.TextBox();
            this.txtNomMedecin = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.lblConsultation = new System.Windows.Forms.Label();
            this.dgvConsultations = new System.Windows.Forms.DataGridView();
            this.nom_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nom_medecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matricule_medecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_consultation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urgence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMatricule = new System.Windows.Forms.ComboBox();
            this.gbTypeConsultation.SuspendLayout();
            this.gbUrgence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(83, 494);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 0;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblNomPatient
            // 
            this.lblNomPatient.AutoSize = true;
            this.lblNomPatient.Location = new System.Drawing.Point(41, 85);
            this.lblNomPatient.Name = "lblNomPatient";
            this.lblNomPatient.Size = new System.Drawing.Size(80, 15);
            this.lblNomPatient.TabIndex = 1;
            this.lblNomPatient.Text = "Nom patient :";
            // 
            // lblPrenomPatient
            // 
            this.lblPrenomPatient.AutoSize = true;
            this.lblPrenomPatient.Location = new System.Drawing.Point(281, 84);
            this.lblPrenomPatient.Name = "lblPrenomPatient";
            this.lblPrenomPatient.Size = new System.Drawing.Size(95, 15);
            this.lblPrenomPatient.TabIndex = 2;
            this.lblPrenomPatient.Text = "Prénom patient :";
            // 
            // lblNomMedecin
            // 
            this.lblNomMedecin.AutoSize = true;
            this.lblNomMedecin.Location = new System.Drawing.Point(42, 149);
            this.lblNomMedecin.Name = "lblNomMedecin";
            this.lblNomMedecin.Size = new System.Drawing.Size(89, 15);
            this.lblNomMedecin.TabIndex = 3;
            this.lblNomMedecin.Text = "Nom médecin :";
            // 
            // lblMatriculeMedecin
            // 
            this.lblMatriculeMedecin.AutoSize = true;
            this.lblMatriculeMedecin.Location = new System.Drawing.Point(281, 153);
            this.lblMatriculeMedecin.Name = "lblMatriculeMedecin";
            this.lblMatriculeMedecin.Size = new System.Drawing.Size(106, 15);
            this.lblMatriculeMedecin.TabIndex = 4;
            this.lblMatriculeMedecin.Text = "Matricule Médecin";
            // 
            // gbTypeConsultation
            // 
            this.gbTypeConsultation.Controls.Add(this.rdSpecialiste);
            this.gbTypeConsultation.Controls.Add(this.rdGeneraliste);
            this.gbTypeConsultation.Location = new System.Drawing.Point(570, 58);
            this.gbTypeConsultation.Name = "gbTypeConsultation";
            this.gbTypeConsultation.Size = new System.Drawing.Size(384, 61);
            this.gbTypeConsultation.TabIndex = 5;
            this.gbTypeConsultation.TabStop = false;
            this.gbTypeConsultation.Text = "Type consultation";
            // 
            // rdSpecialiste
            // 
            this.rdSpecialiste.AutoSize = true;
            this.rdSpecialiste.Location = new System.Drawing.Point(258, 22);
            this.rdSpecialiste.Name = "rdSpecialiste";
            this.rdSpecialiste.Size = new System.Drawing.Size(80, 19);
            this.rdSpecialiste.TabIndex = 1;
            this.rdSpecialiste.TabStop = true;
            this.rdSpecialiste.Text = "Spécialiste";
            this.rdSpecialiste.UseVisualStyleBackColor = true;
            // 
            // rdGeneraliste
            // 
            this.rdGeneraliste.AutoSize = true;
            this.rdGeneraliste.Location = new System.Drawing.Point(107, 22);
            this.rdGeneraliste.Name = "rdGeneraliste";
            this.rdGeneraliste.Size = new System.Drawing.Size(83, 19);
            this.rdGeneraliste.TabIndex = 0;
            this.rdGeneraliste.TabStop = true;
            this.rdGeneraliste.Text = "Généraliste";
            this.rdGeneraliste.UseVisualStyleBackColor = true;
            // 
            // gbUrgence
            // 
            this.gbUrgence.Controls.Add(this.rdNon);
            this.gbUrgence.Controls.Add(this.rdOui);
            this.gbUrgence.Location = new System.Drawing.Point(570, 125);
            this.gbUrgence.Name = "gbUrgence";
            this.gbUrgence.Size = new System.Drawing.Size(383, 60);
            this.gbUrgence.TabIndex = 6;
            this.gbUrgence.TabStop = false;
            this.gbUrgence.Text = "Urgence";
            // 
            // rdNon
            // 
            this.rdNon.AutoSize = true;
            this.rdNon.Location = new System.Drawing.Point(257, 23);
            this.rdNon.Name = "rdNon";
            this.rdNon.Size = new System.Drawing.Size(48, 19);
            this.rdNon.TabIndex = 1;
            this.rdNon.TabStop = true;
            this.rdNon.Text = "Non";
            this.rdNon.UseVisualStyleBackColor = true;
            // 
            // rdOui
            // 
            this.rdOui.AutoSize = true;
            this.rdOui.Location = new System.Drawing.Point(115, 23);
            this.rdOui.Name = "rdOui";
            this.rdOui.Size = new System.Drawing.Size(44, 19);
            this.rdOui.TabIndex = 0;
            this.rdOui.TabStop = true;
            this.rdOui.Text = "Oui";
            this.rdOui.UseVisualStyleBackColor = true;
            // 
            // txtNomPatient
            // 
            this.txtNomPatient.Location = new System.Drawing.Point(137, 81);
            this.txtNomPatient.Name = "txtNomPatient";
            this.txtNomPatient.Size = new System.Drawing.Size(111, 23);
            this.txtNomPatient.TabIndex = 7;
            // 
            // txtPrenomPatient
            // 
            this.txtPrenomPatient.Location = new System.Drawing.Point(395, 77);
            this.txtPrenomPatient.Name = "txtPrenomPatient";
            this.txtPrenomPatient.Size = new System.Drawing.Size(135, 23);
            this.txtPrenomPatient.TabIndex = 8;
            // 
            // txtNomMedecin
            // 
            this.txtNomMedecin.Location = new System.Drawing.Point(137, 145);
            this.txtNomMedecin.Name = "txtNomMedecin";
            this.txtNomMedecin.ReadOnly = true;
            this.txtNomMedecin.Size = new System.Drawing.Size(111, 23);
            this.txtNomMedecin.TabIndex = 9;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(291, 214);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(433, 214);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(75, 23);
            this.btnInitialiser.TabIndex = 12;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(586, 214);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 13;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // lblConsultation
            // 
            this.lblConsultation.AutoSize = true;
            this.lblConsultation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConsultation.Location = new System.Drawing.Point(342, 9);
            this.lblConsultation.Name = "lblConsultation";
            this.lblConsultation.Size = new System.Drawing.Size(231, 21);
            this.lblConsultation.TabIndex = 14;
            this.lblConsultation.Text = "CONSULTATIONS MÉDICALES";
            // 
            // dgvConsultations
            // 
            this.dgvConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom_patient,
            this.prenom_patient,
            this.nom_medecin,
            this.matricule_medecin,
            this.type_consultation,
            this.urgence});
            this.dgvConsultations.Location = new System.Drawing.Point(83, 282);
            this.dgvConsultations.Name = "dgvConsultations";
            this.dgvConsultations.RowTemplate.Height = 25;
            this.dgvConsultations.Size = new System.Drawing.Size(825, 193);
            this.dgvConsultations.TabIndex = 15;
            // 
            // nom_patient
            // 
            this.nom_patient.HeaderText = "nom_patient";
            this.nom_patient.Name = "nom_patient";
            this.nom_patient.Width = 125;
            // 
            // prenom_patient
            // 
            this.prenom_patient.HeaderText = "prenom_patient";
            this.prenom_patient.Name = "prenom_patient";
            this.prenom_patient.Width = 125;
            // 
            // nom_medecin
            // 
            this.nom_medecin.HeaderText = "nom_medecin";
            this.nom_medecin.Name = "nom_medecin";
            this.nom_medecin.Width = 125;
            // 
            // matricule_medecin
            // 
            this.matricule_medecin.HeaderText = "matricule_medecin";
            this.matricule_medecin.Name = "matricule_medecin";
            this.matricule_medecin.Width = 125;
            // 
            // type_consultation
            // 
            this.type_consultation.HeaderText = "type_consultation";
            this.type_consultation.Name = "type_consultation";
            this.type_consultation.Width = 125;
            // 
            // urgence
            // 
            this.urgence.HeaderText = "urgence";
            this.urgence.Name = "urgence";
            this.urgence.Width = 125;
            // 
            // cmbMatricule
            // 
            this.cmbMatricule.FormattingEnabled = true;
            this.cmbMatricule.Location = new System.Drawing.Point(395, 153);
            this.cmbMatricule.Name = "cmbMatricule";
            this.cmbMatricule.Size = new System.Drawing.Size(135, 23);
            this.cmbMatricule.TabIndex = 16;
            this.cmbMatricule.TextChanged += new System.EventHandler(this.cmbMatricule_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1031, 579);
            this.Controls.Add(this.cmbMatricule);
            this.Controls.Add(this.dgvConsultations);
            this.Controls.Add(this.lblConsultation);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtNomMedecin);
            this.Controls.Add(this.txtPrenomPatient);
            this.Controls.Add(this.txtNomPatient);
            this.Controls.Add(this.gbUrgence);
            this.Controls.Add(this.gbTypeConsultation);
            this.Controls.Add(this.lblMatriculeMedecin);
            this.Controls.Add(this.lblNomMedecin);
            this.Controls.Add(this.lblPrenomPatient);
            this.Controls.Add(this.lblNomPatient);
            this.Controls.Add(this.btnEnregistrer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultations médicales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbTypeConsultation.ResumeLayout(false);
            this.gbTypeConsultation.PerformLayout();
            this.gbUrgence.ResumeLayout(false);
            this.gbUrgence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblNomPatient;
        private System.Windows.Forms.Label lblPrenomPatient;
        private System.Windows.Forms.Label lblNomMedecin;
        private System.Windows.Forms.Label lblMatriculeMedecin;
        private System.Windows.Forms.GroupBox gbTypeConsultation;
        private System.Windows.Forms.RadioButton rdSpecialiste;
        private System.Windows.Forms.RadioButton rdGeneraliste;
        private System.Windows.Forms.GroupBox gbUrgence;
        private System.Windows.Forms.RadioButton rdNon;
        private System.Windows.Forms.RadioButton rdOui;
        private System.Windows.Forms.TextBox txtNomPatient;
        private System.Windows.Forms.TextBox txtPrenomPatient;
        private System.Windows.Forms.TextBox txtNomMedecin;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Label lblConsultation;
        private System.Windows.Forms.DataGridView dgvConsultations;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom_medecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn matricule_medecin;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_consultation;
        private System.Windows.Forms.DataGridViewTextBoxColumn urgence;
        private System.Windows.Forms.ComboBox cmbMatricule;
    }
}

