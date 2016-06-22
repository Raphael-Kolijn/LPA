using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LPAproject.Properties;

namespace LPAproject  // Test Textenc
{
    public partial class sloepkeForm : Form
    {
        List<string> s_BijbehorendeObjecten = new List<string>();
        List<string> s_BudgetBoten = new List<string>();

        public sloepkeForm()
        {
            InitializeComponent();
            motorboot motorboot = new motorboot(20, "testBoot");
            LPAproject.motorboot.alleMotorBoten.Add(motorboot);
            motorBootLaden();
            contractenRefresh();
        }

        // Admin Login
        public void button1_Click(object sender, EventArgs e)
        {
            if(AdminWachtwoordTextBox.Text == "qwerty")
            {
                adminLogoutBtn.Visible = true;
                adminLabel.Visible = true;
                adminRadioVerwijder.Visible = true;
                adminRadioVoegToe.Visible = true;
                adminRadioWijzig.Visible = true;
                adminLB.Visible = true;
            }
            else
            {
                MessageBox.Show("Verkeerd wachtwoord!");
            }
        }

        // Maak een nieuw contract, opent een form
        private void button3_Click(object sender, EventArgs e)
        {
            contractForm form = new contractForm();
            form.Show();
        }
        
        // Display de contracten in de listbox
        public void contractenRefresh()
        {
            foreach(contract contract in contractForm.alleContracten)
            {
                LBContracten.Items.Add(contract.huurder.naam.ToString());
                LBContracten.Refresh();
            }           
        }

        // Ververs de ListBox met daarin de contracten
        private void verversBtn(object sender, EventArgs e)
        {
            LBContracten.Items.Clear();
            motorBootLB.Items.Clear();
            motorBootLaden();
            contractenRefresh();
        }

        // Toon motorboten om radius te berekenen
        public void motorBootLaden()
        {
            foreach(motorboot motorboot in LPAproject.motorboot.alleMotorBoten)
            {
                motorBootLB.Items.Add(motorboot.naam);
                motorBootLB.Refresh();
            }           
        }

        // Selecteren van een contract
        private void LBContracten_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Uitloggen als admin
        private void adminLogoutBtn_Click(object sender, EventArgs e)
        {
            adminLogoutBtn.Visible = false;
            adminLabel.Visible = false;
            adminRadioVerwijder.Visible = false;
            adminRadioVoegToe.Visible = false;
            adminRadioWijzig.Visible = false;
            adminLB.Visible = false;
        }

        // Toevoegen van bijkomende artikelen bij budgetberekening
        private void budgetBijkomendeArtikelenCB_SelectedIndexChanged(object sender, EventArgs e)
        {           
            budgetBijkomendeArtikelenLB.Items.Add(budgetBijkomendeArtikelenCB.Text);
            budgetBijkomendeArtikelenCB.Refresh();
        }

        // Boten toevoegen voor budgetberekening
        private void budgetBootCB_SelectedIndexChanged(object sender, EventArgs e)
        {          
            budgetBotenLB.Items.Add(budgetBootCB.Text);
            budgetBotenLB.Refresh();
        }

        // 
        private void motorBootLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        
    }
}
