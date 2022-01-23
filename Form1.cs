using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using CreazioneIniMateriali;

namespace CreazioneIniMateriali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CancellaLabel(RichTextBox label)
        {
            label.Text = "";
        }

        private void CopiaLabel(RichTextBox label)
        {
            Clipboard.SetText(label.Text);
        }

        private void IncollaLabel(RichTextBox label)
        {
            label.Text = Clipboard.GetText();
        }

        private void SeparaStringa(string insert, out string exit) 
        {
            exit = "";
            Elementi el = new Elementi();
            List<string> lineString = insert.ToLower().Split('\n').ToList();
            foreach(string line in lineString) 
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    char[] c = line.Replace(" ", "").ToCharArray();
                    char oldChar = ' ';
                    string newLine = "";
                   
                    for(int i = 0; i < c.Length; i++) // Prima pulizia rimozione di simboli, del limite massimo e rilevamento stringhe troncate
                    {
                        if(char.IsLetterOrDigit(c[i]) || c[i].Equals('/') || c[i].Equals('.'))
                        {
                            if (c[i].Equals('/')) break;
                            else if (c[i].Equals('.') && oldChar.Equals('.')) // Se trova il doppio punto presume che la stringa sia troncata quindi isnserisce "="
                            {
                                newLine = newLine.Remove(newLine.Length - 1);
                                newLine += "=";
                            }
                            else
                            {
                                newLine += c[i];
                            }
                            oldChar = c[i];
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(newLine))
                    {
                        string component = "";
                        int value = 0;
                        if (newLine.Contains("=")) // Seconda pulizia tramite "=" e confronto con tutte le stringhe presenti nella tabella
                        {
                            component = GestioneMateriali(newLine.Remove(newLine.IndexOf("=") - 1));
                            
                            foreach (string e in el.dictElement)
                            {
                                if (e.Contains(component))
                                {
                                    value = CalcoloValore(newLine.Substring(newLine.IndexOf("=") + 1));
                                    exit += e + "=" + value.ToString() + "\n";
                                    break;
                                }
                                    
                            }
                        }
                        else
                        {
                            foreach (string e in el.dictElement) // Seconda pulizia tramite il matching con l'array
                            {
                                component = GestioneMateriali(newLine);
                                if (component.Contains(e))
                                {
                                    value = CalcoloValore(component.Replace(e, ""));
                                    exit += e + "=" + value.ToString() + "\n";
                                    break;
                                }

                            }
                        }     
                    }
                }
            }

        }
        private int CalcoloValore(string strValore) // Prima pulizia del valore per estrazione del numero
        {
            strValore = strValore.Replace(",", ".");
            int somma = 1;
            double dbValore = 0;
            if (strValore.Contains("k"))
            {
                strValore = strValore.Replace("k", "");
                somma = 1000;

            }
            else if (strValore.Contains("m"))
            {
                strValore = strValore.Replace("m", "");
                somma = 1000000;
            }

            if (Double.TryParse(strValore, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out dbValore))
                return (int)Math.Truncate(dbValore * somma);
            else
                return (int)Math.Truncate(PuliziaValore(strValore) * somma);

        }

        private double PuliziaValore(string strValore) // Seconda pulizia del valore da eventuali residui
        {
            if (!string.IsNullOrWhiteSpace(strValore))
            {
                char[] c = strValore.Replace(" ", "").ToCharArray();
                string newLine = "";
                double dbValore = 0;

                for (int i = 0; i < c.Length; i++) // Pulizia valore da simboli non concessi
                {
                    if (char.IsDigit(c[i]) || c[i].Equals('.'))
                    {
                        newLine += c[i];
                    }
                }
                if (Double.TryParse(newLine, NumberStyles.Any, NumberFormatInfo.InvariantInfo, out dbValore))
                    return dbValore;
                else
                    return 0;
            }
            else
                return 0;
        }

        private string GestioneMateriali(string strMateriale) // In base alla selezione tramite combobox inserisce il tipo di materiale 
        {
            switch (this.cmb_SelezioneMateriali.SelectedIndex)
            {
                case 0: return strMateriale;
                case 1: return "ingot/" + strMateriale;
                case 2: return "ore/" + strMateriale;
                default: return strMateriale;
            }
        }

        private void btn_Cancella_Click(object sender, EventArgs e)
        {
            CancellaLabel(this.lbl_Insert);
        }

        private void btn_Cancella2_Click(object sender, EventArgs e)
        {
            CancellaLabel(this.lbl_Out);
        }

        private void btn_Copia_Click(object sender, EventArgs e)
        {
            CopiaLabel(this.lbl_Insert);
        }

        private void btn_Copia2_Click(object sender, EventArgs e)
        {
            CopiaLabel(this.lbl_Out);
        }

        private void btn_Incolla_Click(object sender, EventArgs e)
        {
            IncollaLabel(this.lbl_Insert);
        }

        private void btn_Incolla2_Click(object sender, EventArgs e)
        {
            IncollaLabel(this.lbl_Out);
        }

        private void btn_Converti_Click(object sender, EventArgs e)
        {
            string insert = this.lbl_Insert.Text;
            string exit;
            SeparaStringa(insert, out exit);
            this.lbl_Out.Text = exit;
        }
    }
}
