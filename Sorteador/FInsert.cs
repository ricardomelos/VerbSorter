using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorteador
{
    public partial class FInsert : Form
    {
        const string fileName = "LesVerbes.txt";
        public FInsert()
        {
            InitializeComponent();
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    var verbs = File.ReadAllText(fileName)
                        .Split(new []{'\n'}, StringSplitOptions.RemoveEmptyEntries)
                        .ToList();
                    if (!verbs.Any(v => v.Trim().Equals(txNewVerb.Text.Trim())))
                    {
                        File.AppendAllLines(fileName, new List<string>{txNewVerb.Text.Trim()});
                        MessageBox.Show(@"O verbo " + txNewVerb.Text + @" foi adicionado a lista com sucesso", @"Sorteador",
                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txNewVerb.Text = "";
                        txNewVerb.Focus();
                    }
                    else
                    {
                        MessageBox.Show(@"O verbo " + txNewVerb.Text + @" já consta na lista", @"Sorteador", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Não foi possível abrir o arquivo que contém os verbos", @"Sorteador", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txNewVerb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btInsert_Click(sender,e);
            }
        }
    }
}
