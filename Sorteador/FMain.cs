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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
        }

        private void btSortear_Click(object sender, EventArgs e)
        {
            const string fileName = "LesVerbes.txt";
            try
            {
                if (File.Exists(fileName))
                {
                    var text = File.ReadAllText(fileName);
                    var verbs = text.Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                    lbCount.Text = verbs.Count.ToString();
                    var verb = Raffle(verbs);
                    lbResultado.Text = verb.ToUpper();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(@"Não foi possível abrir o arquivo que contém os verbos", @"Sorteador", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string Raffle(List<string> verbs)
        {
            var rd = new Random();
            var index = rd.Next(0, verbs.Count - 1);
            return verbs[index];
        }

        private void inserirNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fInsert = new FInsert();
            fInsert.ShowDialog();
        }

        
    }
}
