using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarCachier
{
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbStrat.Text = "0";
            tbTele.Text = "0";
            tbLP.Text = "0";
            tbThin.Text = "0";
            tbSemiH.Text = "0";
            tbHollow.Text = "0";
            tbPick.Text = "0";
            tbPickSet.Text = "0";
            tbString.Text = "0";
            tbHandle.Text = "0";
            tbStrap.Text = "0";
            tbCase.Text = "0";
            lblGCost.Text = "0";
            lblACost.Text = "0";

            cbStrat.Checked = false;
            cbTele.Checked = false;
            cbLP.Checked = false;
            cbThin.Checked = false;
            cbSemiH.Checked = false;
            cbHollow.Checked = false;
            cbPick.Checked = false;
            cbPickSet.Checked = false;
            cbString.Checked = false;
            cbHandle.Checked = false;
            cbStrap.Checked = false;
            cbCase.Checked = false;

            rtbReceipt.Clear();

            lblTax.Text = "0";
            lblSubtot.Text = "0";
            lblTotal.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTanggal.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            tbStrat.Text = "0";
            tbTele.Text = "0";
            tbLP.Text = "0";
            tbThin.Text = "0";
            tbSemiH.Text = "0";
            tbHollow.Text = "0";
            tbPick.Text = "0";
            tbPickSet.Text = "0";
            tbString.Text = "0";
            tbHandle.Text = "0";
            tbStrap.Text = "0";
            tbCase.Text = "0";
            lblGCost.Text = "0";
            lblACost.Text = "0";

            tbStrat.Enabled = false;
            tbTele.Enabled = false;
            tbLP.Enabled = false;
            tbThin.Enabled = false;
            tbSemiH.Enabled = false;
            tbHollow.Enabled = false;
            tbPick.Enabled = false;
            tbPickSet.Enabled = false;
            tbString.Enabled = false;
            tbHandle.Enabled = false;
            tbStrap.Enabled = false;
            tbCase.Enabled = false;

            cbStrat.Checked = false;
            cbTele.Checked = false;
            cbLP.Checked = false;
            cbThin.Checked = false;
            cbSemiH.Checked = false;
            cbHollow.Checked = false;
            cbPick.Checked = false;
            cbPickSet.Checked = false;
            cbString.Checked = false;
            cbHandle.Checked = false;
            cbStrap.Checked = false;
            cbCase.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbStrat_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStrat.Checked == true)
            {
                tbStrat.Enabled = true;
            }
            if (cbStrat.Checked == false)
            {
                tbStrat.Enabled = false;
                tbStrat.Text = "0";
            }
        }

        private void tbStrat_Click(object sender, EventArgs e)
        {
            tbStrat.Text = "";
            tbStrat.Focus();
        }

        private void cbTele_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTele.Checked == true)
            {
                tbTele.Enabled = true;
            }
            if (cbTele.Checked == false)
            {
                tbTele.Enabled = false;
                tbTele.Text = "0";
            }
        }

        private void tbTele_Click(object sender, EventArgs e)
        {
            tbTele.Text = "";
            tbTele.Focus();
        }

        private void cbLP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLP.Checked == true)
            {
                tbLP.Enabled = true;
            }
            if (cbLP.Checked == false)
            {
                tbLP.Enabled = false;
                tbLP.Text = "0";
            }
        }

        private void tbLP_Click(object sender, EventArgs e)
        {
            tbLP.Text = "";
            tbLP.Focus();
        }

        private void cbThin_CheckedChanged(object sender, EventArgs e)
        {
            if (cbThin.Checked == true)
            {
                tbThin.Enabled = true;
            }
            if (cbThin.Checked == false)
            {
                tbThin.Enabled = false;
                tbThin.Text = "0";
            }
        }

        private void tbThin_Click(object sender, EventArgs e)
        {
            tbThin.Text = "";
            tbThin.Focus();
        }

        private void cbSemiH_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSemiH.Checked == true)
            {
                tbSemiH.Enabled = true;
            }
            if (cbSemiH.Checked == false)
            {
                tbSemiH.Enabled = false;
                tbSemiH.Text = "0";
            }
        }

        private void tbSemiH_Click(object sender, EventArgs e)
        {
            tbSemiH.Text = "";
            tbSemiH.Focus();
        }

        private void cbHollow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHollow.Checked == true)
            {
                tbHollow.Enabled = true;
            }
            if (cbHollow.Checked == false)
            {
                tbHollow.Enabled = false;
                tbHollow.Text = "0";
            }
        }

        private void tbHollow_Click(object sender, EventArgs e)
        {
            {
                tbHollow.Text = "";
                tbHollow.Focus();
            }
        }

        private void cbPick_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPick.Checked == true)
            {
                tbPick.Enabled = true;
            }
            if (cbPick.Checked == false)
            {
                tbPick.Enabled = false;
                tbPick.Text = "0";
            }
        }

        private void cbPickSet_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPickSet.Checked == true)
            {
                tbPickSet.Enabled = true;
            }
            if (cbPickSet.Checked == false)
            {
                tbPickSet.Enabled = false;
                tbPickSet.Text = "0";
            }
        }

        private void cbString_CheckedChanged(object sender, EventArgs e)
        {
            if (cbString.Checked == true)
            {
                tbString.Enabled = true;
            }
            if (cbString.Checked == false)
            {
                tbString.Enabled = false;
                tbString.Text = "0";
            }
        }

        private void cbHandle_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHandle.Checked == true)
            {
                tbHandle.Enabled = true;
            }
            if (cbHandle.Checked == false)
            {
                tbHandle.Enabled = false;
                tbHandle.Text = "0";
            }
        }

        private void cbStrap_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStrap.Checked == true)
            {
                tbStrap.Enabled = true;
            }
            if (cbStrap.Checked == false)
            {
                tbStrap.Enabled = false;
                tbStrap.Text = "0";
            }
        }

        private void cbCase_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCase.Checked == true)
            {
                tbCase.Enabled = true;
            }
            if (cbCase.Checked == false)
            {
                tbCase.Enabled = false;
                tbCase.Text = "0";
            }
        }

        private void tbPick_Click(object sender, EventArgs e)
        {
            tbPick.Text = "";
            tbPick.Focus();
        }

        private void tbPickSet_Click(object sender, EventArgs e)
        {
            tbPickSet.Text = "";
            tbPickSet.Focus();
        }

        private void tbString_Click(object sender, EventArgs e)
        {
            tbString.Text = "";
            tbString.Focus();
        }

        private void tbHandle_Click(object sender, EventArgs e)
        {
            tbHandle.Text = "";
            tbHandle.Focus();
        }

        private void tbStrap_Click(object sender, EventArgs e)
        {
            tbStrap.Text = "";
            tbStrap.Focus();
        }

        private void tbCase_Click(object sender, EventArgs e)
        {
            tbCase.Text = "";
            tbCase.Focus();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtbReceipt.Clear();

            rtbReceipt.AppendText(Environment.NewLine);
            rtbReceipt.AppendText(" " + "______________________________________________" + Environment.NewLine);
            rtbReceipt.AppendText(" " + "\t" + "  Rici XYZ Guitar Store" + Environment.NewLine);
            rtbReceipt.AppendText(" " + "**********************************************" + Environment.NewLine);

            rtbReceipt.AppendText("  " + tbStrat.Text + "\t" + "Stratocaster \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbTele.Text + "\t" + "Telecaster \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbLP.Text + "\t" + "Les Paul \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbThin.Text + "\t" + "Thinline \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbSemiH.Text + "\t" + "Semi-Hollow \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbHollow.Text + "\t" + "Hollow \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbPick.Text + "\t" + "Pick (pcs) \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbPickSet.Text + "\t" + "Pick (Set) \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbString.Text + "\t" + "String \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbHandle.Text + "\t" + "Handle \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbStrap.Text + "\t" + "Strap \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + tbCase.Text + "\t" + "Case \t" + Environment.NewLine);
            rtbReceipt.AppendText("  " + "----------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("  " + "Tax \t\t\t" + lblTax.Text + Environment.NewLine);
            rtbReceipt.AppendText("  " + "Subtotal \t\t" + lblSubtot.Text + Environment.NewLine);
            rtbReceipt.AppendText("  " + "Total \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtbReceipt.AppendText("  " + "----------------------------------------------" + Environment.NewLine);
            rtbReceipt.AppendText("  " + lblWaktu.Text + "\t\t" + lblTanggal.Text);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblWaktu.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtbReceipt.Text, new Font("Calisto MT", 13, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Clear();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtbReceipt.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtbReceipt.Paste();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(rtbReceipt.Text);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double tax;
            tax = 0.8;
            double strat, tele, lp, thinline, semihollow, hollow;
            double pick, pickset, gstring, handle, strap, gcase;

            //Set Harga Gitar dan Aksesoris dalam USD
            strat = 5500000.0;
            tele = 5600000.0;
            lp = 7000000.0;
            thinline = 6100000.0;
            semihollow = 5800000.0;
            hollow = 6440000.0;

            pick = 4500.0;
            pickset = 90500.0;
            gstring = 200000.0;
            handle = 100000.0;
            strap = 150000.0;
            gcase = 375500.0;

            double stratG = Convert.ToDouble(tbStrat.Text);
            double teleG = Convert.ToDouble(tbTele.Text);
            double lpG = Convert.ToDouble(tbLP.Text);
            double thinlineG = Convert.ToDouble(tbThin.Text);
            double semihollowG = Convert.ToDouble(tbSemiH.Text);
            double hollowG = Convert.ToDouble(tbHollow.Text);

            double pickA = Convert.ToDouble(tbPick.Text);
            double picksetA = Convert.ToDouble(tbPickSet.Text);
            double gstringA = Convert.ToDouble(tbString.Text);
            double handleA = Convert.ToDouble(tbHandle.Text);
            double strapA = Convert.ToDouble(tbStrap.Text);
            double gcaseA = Convert.ToDouble(tbCase.Text);

            XYZStore buy = new XYZStore(stratG, teleG, lpG, thinlineG, semihollowG, hollowG,
                pickA, picksetA, gstringA, handleA, strapA, gcaseA);

            //Display Cost
            double guitarcost = (stratG * strat) + (teleG * tele) + (lpG * lp) + (thinlineG * thinline) + (semihollowG * semihollow) + (hollowG * hollow);
            lblGCost.Text = Convert.ToString(guitarcost);

            double accesoriescost = (pickA * pick) + (picksetA * pickset) + (gstringA * gstring) + (handleA * handle) + (strapA * strap) + (gcaseA * gcase);
            lblACost.Text = Convert.ToString(accesoriescost);

            lblSubtot.Text = Convert.ToString(guitarcost + accesoriescost);
            lblTax.Text = Convert.ToString(((guitarcost + accesoriescost) * tax) / 100);
            double Taxfix = Convert.ToDouble(lblTax.Text);
            lblTotal.Text = Convert.ToString(guitarcost + accesoriescost + Taxfix);

            lblGCost.Text = String.Format("{0:C}", guitarcost);
            lblACost.Text = String.Format("{0:C}", accesoriescost);
            lblSubtot.Text = String.Format("{0:C}", (guitarcost + accesoriescost));
            lblTax.Text = String.Format("{0:C}", (((guitarcost + accesoriescost) * tax) / 100));
            lblTotal.Text = String.Format("{0:C}", (guitarcost + accesoriescost + Taxfix));


        }

        private void rtbReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
