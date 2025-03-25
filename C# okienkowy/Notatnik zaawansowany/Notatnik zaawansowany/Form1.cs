using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Notatnik_zaawansowany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMenu();
        }
        private void InitializeMenu()
        {
            MenuStrip menuStrip1 = new MenuStrip(); // tworzymy obiekt
            this.Controls.Add(menuStrip1); // dodajemy zeby mógl byc uzywany dalej

            // Menu pliku
            ToolStripMenuItem plikMenu = new ToolStripMenuItem("Plik");
            menuStrip1.Items.Add(plikMenu);

            plikMenu.DropDownItems.Add("Nowa karta", null, (s, e) => NowaKarta());
            plikMenu.DropDownItems.Add("Zapisz", null, (s, e) => ZapiszPlik());
            plikMenu.DropDownItems.Add("Zapisz jako", null, (s, e) => ZapiszJako());
            plikMenu.DropDownItems.Add("Otworz plik", null, (s, e) => Otworz());
            plikMenu.DropDownItems.Add("Nowy notatnik", null, (s, e) => NowyNotatnik());
            plikMenu.DropDownItems.Add("Zamknij", null, (s, e) => Zamknij());


            // Edycja 
            ToolStripMenuItem edycjaMenu = new ToolStripMenuItem("Edycja");
            menuStrip1.Items.Add(edycjaMenu);

            edycjaMenu.DropDownItems.Add("Kopiuj", null, (s, e) => Kopiuj());
            edycjaMenu.DropDownItems.Add("Wklej", null, (s, e) => Wklej());


            // Format
            ToolStripMenuItem formatMenu = new ToolStripMenuItem("Edycja");
            menuStrip1.Items.Add(formatMenu);

            formatMenu.DropDownItems.Add("Pogrubienie", null, (s, e) => Pogrubienie());
            formatMenu.DropDownItems.Add("Kursywa", null, (s, e) => Kursywa());

            TabControl tabControl = new TabControl()
            {
                Dock = DockStyle.Fill,
                Name = "tabControl1"
            };
            this.Controls.Add(tabControl);

            NowaKarta();
        }
        private void NowaKarta()
        {
            TabControl tabControl1 = this.Controls["tabControl1"] as TabControl;
            TabPage nowaKarta = new TabPage("Nowa karta");
            RichTextBox richTextBox = new RichTextBox()
            {
                Dock = DockStyle.Fill
            };
            nowaKarta.Controls.Add(richTextBox);

            nowaKarta.Tag = null;
            tabControl1.TabPages.Add(nowaKarta);
            tabControl1.SelectedTab = nowaKarta;
        }
        private void ZapiszPlik()
        {
            TabControl tabControl1 = this.Controls["tabControl1"] as TabControl;
            TabPage currentTab = tabControl1.SelectedTab;
            RichTextBox currentTextBox = GetCurrentRichTextBox();

            if(currentTab.Tag == null)
                ZapiszJako();
            else
                File.WriteAllText(currentTab.Tag.ToString(), currentTextBox.Text);
        }
        private void ZapiszJako()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Pliki tekstowe (*.txt)|*.txt|Wszytskie pliki (*.*)|*.*"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox currentTextBox = GetCurrentRichTextBox();
                if (currentTextBox != null)
                {
                    File.WriteAllText(saveFileDialog.FileName, currentTextBox.Text); //zapis do pliku
                    TabControl tabControl1 = this.Controls["tabControl1"] as TabControl;
                    TabPage currentTab = tabControl1.SelectedTab;
                    currentTab.Tag = saveFileDialog.FileName;
                    currentTab.Text = Path.GetFileName(saveFileDialog.FileName);
                }
            }
        }
        private RichTextBox GetCurrentRichTextBox()
        {
            TabControl tabControl1 = this.Controls["tabControl1"] as TabControl;
            if(tabControl1 != null && tabControl1.SelectedTab != null)
            {
                return tabControl1.SelectedTab.Controls[0] as RichTextBox;
            }
            return null;
        }
        private void Zamknij()
        {
            Application.Exit();
        }
        private void NowyNotatnik()
        {
            TabControl tabControl1 = this.Controls["tabControl1"] as TabControl;
            tabControl1.Controls.Clear();
            NowaKarta();
        }
        private void Otworz()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "Pliki tekstowe (*.txt)|*.txt|Wszytskie pliki (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox currentTextBox = GetCurrentRichTextBox();
                if (currentTextBox != null)
                {
                    currentTextBox.Text = File.ReadAllText(openFileDialog.FileName); //wczytaj plik

                    //zaaktualizuj informacje o pliku w karcie
                    TabControl tabControl = this.Controls["tabControl1"] as TabControl;
                    tabControl.SelectedTab.Tag = openFileDialog.FileName;
                    tabControl.SelectedTab.Text = Path.GetFileName(openFileDialog.FileName); //nazwa pliku

                }
            }
        }
        private void Kopiuj()
        {
            RichTextBox currentTextBox = GetCurrentRichTextBox();
            currentTextBox?.Copy();
        }
        private void Wklej()
        {
            RichTextBox currentTextBox = GetCurrentRichTextBox();
            currentTextBox?.Paste();
        }
        private void Pogrubienie()
        {
            RichTextBox currentTextBox = GetCurrentRichTextBox();
            if(currentTextBox.Font.Style== FontStyle.Regular)
                currentTextBox.SelectionFont = new Font("Arial", 8, FontStyle.Bold);
            else
                currentTextBox.SelectionFont = new Font("Arial", 8, FontStyle.Regular);
        }
        private void Kursywa()
        {
            RichTextBox currentTextBox = GetCurrentRichTextBox();
            if(currentTextBox.Font.Style == FontStyle.Regular)
                currentTextBox.SelectionFont = new Font("Arial", 8, FontStyle.Italic);
            else
                currentTextBox.SelectionFont = new Font("Arial", 8, FontStyle.Regular);
        }
    }
}
