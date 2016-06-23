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
        public static int inhoud;
        public string YorN;
        public static int bootPrijs;
        public static int aantalBijkomendeArtikelen;
        public bool noordZee;
        public bool ijsselMeer;
        public int aantalMeren;

        // Alle zaken die moeten plaatsvinden bij het laden van de form
        public sloepkeForm()
        {
            InitializeComponent();
            motorboot motorboot = new motorboot(20, "De Clipper");
            LPAproject.motorboot.alleMotorBoten.Add(motorboot);
            motorBootLaden();
            contractenRefresh();
        }

        // Admin Login
        public void button1_Click(object sender, EventArgs e)
        {
            if (AdminWachtwoordTextBox.Text == "qwerty")
            {
                adminLogoutBtn.Visible = true;
                adminLabel.Visible = true;
                adminRadioVerwijder.Visible = true;
                adminRadioVoegToe.Visible = true;
                adminRadioWijzig.Visible = true;
                adminLB.Visible = true;
                adminVoegToeBtn.Visible = true;
                adminGB.Visible = true;
            }
            else
            {
                // Na drie keer zou deze optie kunnen locken. qwerty is hier aangegeven omdat dit een prototype betreft
                MessageBox.Show("Verkeerd wachtwoord! Probeer qwerty");
            }
        }

        // Maak een nieuw contract, opent een form
        private void button3_Click(object sender, EventArgs e)
        {
            contractForm form = new contractForm("Typ uw naam", "Typ uw e-mailadres");
            form.Show();
        }

        // Display de contracten in de listbox. Email omdat deze uniek moet zijn, en zodoende is het mogelijk om de contracten opnieuw op te roepen
        public void contractenRefresh()
        {
            foreach (contract contract in contractForm.alleContracten)
            {
                LBContracten.Items.Add(contract.huurder.email.ToString());
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
            foreach (motorboot motorboot in LPAproject.motorboot.alleMotorBoten)
            {
                inhoud = motorboot.tankinhoud;
                motorBootLB.Items.Add(motorboot.naam + " " + motorboot.tankinhoud);
                motorBootLB.Refresh();
            }
        }

        // Selecteren van een contract
        private void LBContracten_SelectedIndexChanged(object sender, EventArgs e)
        {
            contractForm form = new contractForm("TestTekst", LBContracten.SelectedItem.ToString());
            form.Show();
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
            adminVoegToeBtn.Visible = false;
            adminGB.Visible = false;
        }

        // Toevoegen van bijkomende artikelen bij budgetberekening
        private void budgetBijkomendeArtikelenCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            budgetBijkomendeArtikelenLB.Items.Add(budgetBijkomendeArtikelenCB.Text);
            s_BijbehorendeObjecten.Add(budgetBijkomendeArtikelenCB.Text);
            budgetBijkomendeArtikelenCB.Refresh();
        }

        // Boten toevoegen voor budgetberekening
        private void budgetBootCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            budgetBotenLB.Items.Add(budgetBootCB.Text);
            s_BudgetBoten.Add(budgetBootCB.Text);
            budgetBotenLB.Refresh();
        }

        // Een motorboot kiezen om de radius te berekenen
        private void motorBootLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string radius = (inhoud * 15).ToString();
            MessageBox.Show("De radius van" + " " + motorBootLB.SelectedItem.ToString() + " " + "is" + "" + radius);
        }

        // Voeg een vaarwater toe aan de database
        private void adminVoegToeBtn_Click(object sender, EventArgs e)
        {
            if(adminMeerCB.SelectedItem.ToString() == "Meer")
            {
                YorN = "Y";
            }
            else
            {
                YorN = "N";
            }
            database.insertVaarwater(adminWaterNaam.Text, YorN);
            MessageBox.Show("Vaarwater is toegevoegd");
        }

        // Het aantal meren berekenen aan de hand van het budget
        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach(string motor in s_BudgetBoten)
            {
                if (motor == "Motor")
                {
                    bootPrijs += 15;
                }
                else
                {
                    bootPrijs += 10;
                }
            }

            foreach(string artikel in s_BijbehorendeObjecten)
            {
                aantalBijkomendeArtikelen += 1;
            }
            
            if(budgetNoordzeeChck.Checked == true)
            {
                noordZee = true;
            }
            if(budgetIjsselmeerChck.Checked == true)
            {
                ijsselMeer = true;
            }
            aantalMeren = budgetBerekening.berekenMeren(Convert.ToDouble(budgetNUD.Value), bootPrijs, aantalBijkomendeArtikelen, noordZee, ijsselMeer);
            MessageBox.Show("Het aantal meren dat u met dit budget kunt bevaren is" + " " + Convert.ToString(aantalMeren));
        }

   
    }
}
