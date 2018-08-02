using AsianOptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace intro_async_parallel_dotnet4_m1
{
    public partial class Form1 : Form
    {
        public int taskCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            var txtInitialPrice = 30;
            var txtExercisePrice = 30;
            var txtUpGrowth = 1.4;
            var txtDownGrowth = 0.8;
            var txtInterestRate = 1.08;
            var txtPeriods = 30;
            var txtSimulations = 5000000;

            double initial = Convert.ToDouble(txtInitialPrice);
            double exercise = Convert.ToDouble(txtExercisePrice);
            double up = Convert.ToDouble(txtUpGrowth);
            double down = Convert.ToDouble(txtDownGrowth);
            double interest = Convert.ToDouble(txtInterestRate);
            long periods = Convert.ToInt64(txtPeriods);
            long sims = Convert.ToInt64(txtSimulations);

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
    }
}
