using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pi_approximation_wf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.Maximum = Convert.ToDecimal(Decimal.MaxValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> piapp = new List<string>();

            richTextBox1.Text = "";

            double n = Convert.ToDouble(numericUpDown1.Value);
            double w = 0;

            for (double i = 1; i <= n; i += 1)
            {
                for (double j = i * 3 + 1; j < i * 4; j++)
                {
                    w = j / i;

                    if (w.ToString().Contains(piToPoint(Convert.ToInt32(numericUpDown2.Value))))
                    {
                        int k = 0;

                        for (k = 0; k < piapp.Count; k++)
                        {
                            if (piapp[k] == w.ToString())
                                break;
                        }
                        
                        if (k == piapp.Count)
                        {
                            piapp.Add(w.ToString());

                            richTextBox1.Text += j.ToString() + " / " + i.ToString() + " = " + w.ToString() + "\n";
                        }
                    }
                }
            }
        }

        string piToPoint(int point)
        {
            string pi = "3,1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679821480865132823066470938446095505822317253594081284811174502841027019385211055596446229489549303819644288109756659334461284756482337867831652712019091456485669234603486104543266482133936072602491412737245870066063155881748815209209628292540917153643678925903600113305305488204665213841469519415116094330572703657595919530921861173819326117931051185480744623799627495673518857527248912279381830119491298336733624406566430860213949463952247371907021798609437027705392171762931767523846748184676694051320005681271452635608277857713427577896091736371787214684409012249534301465495853710507922796892589235420199561121290219608640344181598136297747713099605187072113499999983729780499510597317328160963185950244594553469083026425223082533446850352619311881710100031378387528865875332083814206171776691473035982534904287554687311595628638823537875937519577818577805321712268066130019278766111959092164201989380952572010654858632788659361533818279682303019520353";

            return pi.Substring(0, point + 2);
        }
    }
}
