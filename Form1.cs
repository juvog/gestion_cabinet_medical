using System;
using System.IO;
using System.Windows.Forms;

namespace examen_final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Question 1. Écrire le code du bouton « Initialiser » qui permet d’initialiser tous les champs.
        private void btnInitialiser_Click(object sender, EventArgs e)
        {
            txtNomMedecin.Text = "";
            txtPrenomPatient.Text = "";
            txtNomPatient.Text = "";
            cmbMatricule.Text = "";
            rdGeneraliste.Checked = false;
            rdSpecialiste.Checked = false;
            rdOui.Checked = false;
            rdNon.Checked = false;

        }


        // Question 2 
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomMedecin.Text))
            {
                MessageBox.Show("Vous devez saisir le champ vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomMedecin.Focus();
            }
            else if (string.IsNullOrEmpty(cmbMatricule.Text))
            {
                MessageBox.Show("Vous devez saisir le champ vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMatricule.Focus();
            }
            else if (string.IsNullOrEmpty(txtNomPatient.Text))
            {
                MessageBox.Show("Vous devez saisir le champ vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomPatient.Focus();
            }
            else if (string.IsNullOrEmpty(txtPrenomPatient.Text))
            {
                MessageBox.Show("Vous devez saisir le champ vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrenomPatient.Focus();
            }
            else
            {
                string type = "généraliste";
                string urgence = "non";
                if (rdOui.Checked == true) urgence = "oui";
                if (rdSpecialiste.Checked == true) type = "spécialiste";

                dgvConsultations.Rows.Add(txtNomPatient.Text, txtPrenomPatient.Text, txtNomMedecin.Text, cmbMatricule.Text, type, urgence);
            }
        }

        //Question 3 a)
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbMatricule.Items.Add("JAD123");
            cmbMatricule.Items.Add("NAH234");
            cmbMatricule.Items.Add("QA567");
            cmbMatricule.Items.Add("SO9876");

            StreamReader readList = new StreamReader("Consultations.txt");
            string ligne = string.Empty;
            while ((ligne = readList.ReadLine()) != null)
            {
                string[] tabLigne = ligne.Split(';');
                dgvConsultations.Rows.Add(tabLigne);

            }
            readList.Close();
        }

        //Question 4
        private void cmbMatricule_TextChanged(object sender, EventArgs e)
        {
            if (cmbMatricule.Text == "JAD123")
            {
                txtNomMedecin.Text = "Jacques Dubois";
            }
            else if (cmbMatricule.Text == "NAH234")
            {
                txtNomMedecin.Text = "Nassim Hilali";
            }
            else if (cmbMatricule.Text == "QA567")
            {
                txtNomMedecin.Text = "Quan";
            }
            else if (cmbMatricule.Text == "SO9876")
            {
                txtNomMedecin.Text = "Soulière";
            }
            else
            {
                MessageBox.Show("Le matricule saisi n'existe pas, veuillez utiliser la liste déroulante", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmbMatricule.Focus();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                // Il y a un message d'erreur étrange comne quoi la liste est vide donc qu'une exception est lancée alors qu'elle ne l'est visiblement pas...
                if (dgvConsultations.Rows.Count == 0) throw new Exception();
                
                if (!string.IsNullOrEmpty(txtNomPatient.Text) || !string.IsNullOrEmpty(txtPrenomPatient.Text))
                {
                    // Question 4b
                    Boolean existe = false;
                    DialogResult reponse = MessageBox.Show("Désirez-vous vraiment effacer ce patient ? ", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (reponse == DialogResult.Yes)
                    {
                        for (int i = 0; i < dgvConsultations.Rows.Count; i++)
                        {
                            if ((dgvConsultations.Rows[i].Cells[0].Value.ToString() != "") && (dgvConsultations.Rows[i].Cells[0].Value.ToString().Equals(txtNomPatient.Text)) &&
                                ((dgvConsultations.Rows[i].Cells[1].Value.ToString() != "")&& dgvConsultations.Rows[i].Cells[1].Value.ToString().Equals(txtPrenomPatient.Text)))
                            {
                                dgvConsultations.Rows.RemoveAt(i);
                                existe = true;
                            }
                        }
                        if (existe == false)
                         {
                             MessageBox.Show("Le patient n'est pas dans la liste", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
                             txtNomPatient.SelectAll();
                             txtPrenomPatient.SelectAll();
                             txtNomPatient.Focus();

                         }
                    }

                }
                else
                {
                    MessageBox.Show("Pour effacer un patient de liste, veuillez saisir les champs : Nom patient, Prénom Patient", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("La liste est vide", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Question 6
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            TextWriter saveList = new StreamWriter("Consultations.txt");

            for (int i = 0; i < dgvConsultations.Rows.Count-1; i++)
            {
                for (int j = 0; j < dgvConsultations.Columns.Count; j++)
                {
                    saveList.Write(dgvConsultations.Rows[i].Cells[j].Value.ToString() + ";");
                   
                }
                saveList.WriteLine("");
            }
            saveList.Close();
        }






      


    }
}


