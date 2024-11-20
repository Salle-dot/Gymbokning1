using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private Bokningshantering bokningshantering;

        public Form1()
        {
            InitializeComponent();
            bokningshantering = new Bokningshantering(); // Initiera bokningshantering
            LaddaPass(); // Ladda passen
        }

        private void LaddaPass()
        {
            listViewPass.Items.Clear(); // Rensa befintliga poster
            var tillgängligaPass = bokningshantering.HämtaTillgängligaPass(); // Hämta tillgängliga pass

            foreach (var pass in tillgängligaPass)
            {
                var listViewItem = new ListViewItem(pass.Kategori);
                listViewItem.SubItems.Add(pass.Tid.ToString("g")); // Formatera tid
                listViewItem.SubItems.Add(pass.AntalPlatser.ToString());
                listViewPass.Items.Add(listViewItem); // Lägg till i ListView
            }
        }

        private void btnBoka_Click(object sender, EventArgs e)
        {
            // Kontrollera att något pass är valt
            if (listViewPass.SelectedItems.Count > 0)
            {
                var selectedItem = listViewPass.SelectedItems[0];
                string kategori = selectedItem.Text;
                DateTime tid = DateTime.Parse(selectedItem.SubItems[1].Text);

                // Boka passet via bokningshanteringen
                bool success = bokningshantering.BokaPass(kategori, tid);

                if (success)
                {
                    MessageBox.Show("Bokningen lyckades!");
                    LaddaPass(); // Uppdatera listan
                }
                else
                {
                    MessageBox.Show("Bokningen misslyckades.");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett pass att boka.");
            }
        }

        private void btnAvboka_Click(object sender, EventArgs e)
        {
            // Kontrollera att något pass är valt
            if (listViewPass.SelectedItems.Count > 0)
            {
                var selectedItem = listViewPass.SelectedItems[0];
                string kategori = selectedItem.Text;
                DateTime tid = DateTime.Parse(selectedItem.SubItems[1].Text);

                // Avboka passet via bokningshanteringen
                bool success = bokningshantering.AvbokaPass(kategori, tid);

                if (success)
                {
                    MessageBox.Show("Avbokningen lyckades!");
                    LaddaPass(); // Uppdatera listan
                }
                else
                {
                    MessageBox.Show("Avbokningen misslyckades.");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett pass att avboka.");
            }
        }
    }
}
