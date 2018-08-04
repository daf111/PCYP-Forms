using AsianOptions;
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

namespace intro_async_parallel_dotnet4_m1
{
    public partial class Form1 : Form
    {
        List<Client> clients = new List<Client>();
        public int taskCounter = 0;

        public Form1()
        {
            InitializeComponent();

            Client c;

            string[] lineOfContents = File.ReadAllLines(@"..\..\Data\clients.txt");
            foreach (var line in lineOfContents)
            {
                string[] fields = line.Split(';');
                c = new Client();
                c.name = fields[0];
                c.initialPrice = Double.Parse(fields[1]);
                c.excercisePrice = Double.Parse(fields[2]);
                c.upGrowth = Double.Parse(fields[3]);
                c.downGrowth = Double.Parse(fields[4]);
                c.interestRate = Double.Parse(fields[5]);
                c.periods = long.Parse(fields[6]);
                c.simulations = long.Parse(fields[7]);
                clients.Add(c);
                comboBox1.Items.Add(fields[0]);
            }

            comboBox1.SelectedIndex = 0;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            double initial = Convert.ToDouble(txtInitialPrice.Text);
            double exercise = Convert.ToDouble(txtExcercisePrice.Text);
            double up = Convert.ToDouble(txtUpGrowth.Text);
            double down = Convert.ToDouble(txtDownGrowth.Text);
            double interest = Convert.ToDouble(txtInterestRate.Text);
            long periods = Convert.ToInt64(txtPeriods.Text);
            long sims = Convert.ToInt64(txtSimulations.Text);

            /* First approach
            //
            // Run simulation to price option:
            //

            Task T = new Task(() =>
               {

                   btnOption.Enabled = false;
                   Cursor.Current = Cursors.WaitCursor;

                   Random rand = new Random();
                   int start = System.Environment.TickCount;

                   double price = AsianOptionsPricing.Simulation(rand, initial, exercise, up, down, interest, periods, sims);

                   int stop = System.Environment.TickCount;

                   double elapsedTimeInSecs = (stop - start) / 1000.0;

                   string result = string.Format("{0:C}  [{1:#,##0.00} secs]",
                       price, elapsedTimeInSecs);

                    //
                    // Display the results:
                    //
                    lstPrices.Items.Add(result);

                   Cursor.Current = Cursors.Default;
                   btnOption.Enabled = true;

               }
           );

            // Standar Execution
            //T.Start(); //Go Task!

            // Execution passing context
            T.Start( TaskScheduler.FromCurrentSynchronizationContext() ); //Go Task!

            */

            /* Second approach */
            //
            // Run simulation to price option:
            //
            string result = "";

            taskCounter++;
            lblCounter.Text = "Tasks running: " + taskCounter.ToString();

            //btnOption.Enabled = false;
            Cursor.Current = Cursors.WaitCursor;
            picSpinner.Visible = true;

            Task T = new Task(() =>
               {

                   Random rand = new Random();
                   int start = System.Environment.TickCount;

                   double price = AsianOptionsPricing.Simulation(rand, initial, exercise, up, down, interest, periods, sims);

                   int stop = System.Environment.TickCount;

                   double elapsedTimeInSecs = (stop - start) / 1000.0;

                   result = string.Format("{0:C}  [{1:#,##0.00} secs]",
                       price, elapsedTimeInSecs);
                }
               );

            Task T2 = T.ContinueWith( (antecedent) =>
            {
                    //
                    // Display the results:
                    //
                    lstPrices.Items.Add(result);

                    taskCounter--;
                    lblCounter.Text = "Tasks running: " + taskCounter.ToString();

                    if (taskCounter == 0)
                    {
                        picSpinner.Visible = false;
                        Cursor.Current = Cursors.Default;
                        //btnOption.Enabled = true;
                    }

            },
               TaskScheduler.FromCurrentSynchronizationContext()
           );

            // Standar Execution
            T.Start(); //Go Task!

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client c = clients[comboBox1.SelectedIndex];
            txtInitialPrice.Text = c.initialPrice.ToString();
            txtExcercisePrice.Text = c.excercisePrice.ToString();
            txtUpGrowth.Text = c.upGrowth.ToString();
            txtDownGrowth.Text = c.downGrowth.ToString();
            txtInterestRate.Text = c.interestRate.ToString();
            txtPeriods.Text = c.periods.ToString();
            txtSimulations.Text = c.simulations.ToString();
        }
    }
}
