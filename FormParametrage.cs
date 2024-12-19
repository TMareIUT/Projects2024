using System;
using System.Windows.Forms;
using BiblioClass;

namespace Puissance4
{
    public partial class FormParametrage : Form
    {
        internal Partie PartieEnCours = new Partie();
        public FormParametrage()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
        }

        private void rdoPerso_CheckedChanged(object sender, EventArgs e)
        {
            lblX.Visible = true;
            nudHauteur.Visible = true;
            nudLargeur.Visible = true;
        }

        private void rdoClassique_CheckedChanged(object sender, EventArgs e)
        {
            lblX.Visible = false;
            nudHauteur.Visible = false;
            nudLargeur.Visible = false;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if(rdoPerso.Checked)
                PartieEnCours.ModifierPlateau((int)nudHauteur.Value, (int)nudLargeur.Value);
            if (rdoJvJ.Checked)
                PartieEnCours.ModifierMode(rdoJvJ.Checked);
            FormJeu frmJeu = new FormJeu();
            frmJeu.Show(this);
            this.Hide();
        }
    }
}
