using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LPAproject
{
    public partial class contractForm : Form
    {
        // Te veel code in de Form, slechte gewoonte. Op terugkomen.
        string huurderNaam;
        string huurderEmail;
        public static List<contract> alleContracten = new List<contract>();
        List<string> c_boten = new List<string>();
        List<Boot> c_BootObjecten = new List<Boot>();
        List<string> c_BijbehorendeObjecten = new List<string>();
        List<bijkomendArtikel> c_bijbehorendeArtikelen = new List<bijkomendArtikel>();
        public static string contractFile;

        public contractForm(string huurderNaam, string huurderEmail)
        {
            InitializeComponent();
            c_VerhuurderEmail.Text = huurderEmail;
            c_VerhuurderNaam.Text = huurderNaam;
        }

        // Het opslaan van de bijbehorende objecten in een contract
        private void c_BijkomendeArtikelenCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            c_BijbehorendeObjecten.Add(c_BijkomendeArtikelenCB.Text);
            c_BijkomendeArtikelenLB.Items.Add(c_BijkomendeArtikelenCB.SelectedItem);
            c_BijkomendeArtikelenLB.Refresh();
        }

        // Bij het opslaan van een contract worden er nieuwe instanties van de relevante boten gemaakt. Dit zou ideaal
        // op een andere plek gebeuren
        private void c_SlaOpBtn_Click(object sender, EventArgs e)
        {
            if(c_BootTB1.Items != null)
            {
                c_boten.Add(c_BootTB1.Text);
            }

            if(c_BootTB2.Items != null)
            {
                c_boten.Add(c_BootTB2.Text);
            }

            if(c_BootTB3.Items != null)
            {
                c_boten.Add(c_BootTB3.Text);
            }
             foreach(string boot in c_boten)
             {
                 if(boot == "Kano")
                 {
                     kano kano = new kano();
                     c_BootObjecten.Add(kano);
                 }
                 if(boot == "Zeilboot")
                 {
                     zeilboot zeilboot = new zeilboot(c_zeilBootTypeCB.Text);
                     c_BootObjecten.Add(zeilboot);
                 }
                 if(boot == "Motorboot")
                 {
                     motorboot motorboot = new motorboot(20, "MotorBoot");
                     c_BootObjecten.Add(motorboot);
                     LPAproject.motorboot.alleMotorBoten.Add(motorboot);
                 }
             }

            // Het maken van de bijbehorende objecten om mee te geven aan het contract
            foreach(string bijbehorendObject in c_BijbehorendeObjecten)
            {
                bijkomendArtikel extraArtikel = new bijkomendArtikel(bijbehorendObject, 1.25);
                c_bijbehorendeArtikelen.Add(extraArtikel);
            }

            // Het aanmaken van een huurder voor in het contract - verschillende dingen geprobeerd, echter niet gelukt op moment van schrijven. 
            //string startDatum = c_DTPickerVan.Value.ToString("yyyy-MM-dd");
            //string eindDatum = c_DTPickerTot.Value.ToString("yyyy-MM-dd");
            huurderNaam = c_VerhuurderNaam.Text;
            huurderEmail = c_VerhuurderEmail.Text;
            huurder huurder = new huurder(huurderNaam, huurderEmail);
            database.insertHuurder(huurderNaam, huurderEmail);
            contract contract = new contract(huurder, c_BootObjecten, c_bijbehorendeArtikelen, c_DTPickerVan.Value, c_DTPickerTot.Value);
            database.insertContract(huurder.naam.ToString(), "DummyTekst", 1, c_DTPickerVan.Value, c_DTPickerTot.Value); 
            alleContracten.Add(contract);
            
            
            this.Close();
        }


        // Het exporteren van een contract. Dit kan vanuit de form van een contract. Hier zouden de contracten in geladen moeten worden wanneer ze geselecteerd worden
        // Echter vanwege het feit dat mijn insert query niet werkt op mijn contracten tabel is dit niet mogelijk. Nu is het enkel mogelijk om een contract te maken en meteen te exporteren.
        private void c_exportBtn_Click(object sender, EventArgs e)
        {         
            // Een string array met de gegevens van het contract
             string[] contractFile = { c_VerhuurderNaam.Text, c_VerhuurderEmail.Text, c_BootTB1.Text, c_BootTB2.Text, c_BootTB3.Text, c_BootTB3.Text, Convert.ToString(c_DTPickerVan.Value), Convert.ToString(c_DTPickerTot.Value) };

            // Een variabele die een pad zet naar MyDocuments. - MSDN
            string mydocpath =
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            // Schrijf de string array naar een bestand genaamd "WriteLines.txt".
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\WriteLines.txt"))
            {
                foreach (string line in contractFile)
                    outputFile.WriteLine(line);
                foreach (string line in c_BijbehorendeObjecten)
                    outputFile.WriteLine(line);
                
            }
            MessageBox.Show("Uw bestand is opgeslagen in MyDocuments/WriteLines.txt");
            
        }    
    }
}
