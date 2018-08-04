namespace intro_async_parallel_dotnet4_m1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lstPrices = new System.Windows.Forms.ListBox();
            this.btnOption = new System.Windows.Forms.Button();
            this.picSpinner = new System.Windows.Forms.PictureBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSimulations = new System.Windows.Forms.TextBox();
            this.txtPeriods = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtDownGrowth = new System.Windows.Forms.TextBox();
            this.txtUpGrowth = new System.Windows.Forms.TextBox();
            this.txtExcercisePrice = new System.Windows.Forms.TextBox();
            this.txtInitialPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPrices
            // 
            this.lstPrices.FormattingEnabled = true;
            this.lstPrices.Location = new System.Drawing.Point(12, 79);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.Size = new System.Drawing.Size(232, 186);
            this.lstPrices.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(28, 12);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(119, 37);
            this.btnOption.TabIndex = 1;
            this.btnOption.Text = "Price Option...";
            this.btnOption.UseVisualStyleBackColor = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // picSpinner
            // 
            this.picSpinner.Image = ((System.Drawing.Image)(resources.GetObject("picSpinner.Image")));
            this.picSpinner.Location = new System.Drawing.Point(157, 6);
            this.picSpinner.Name = "picSpinner";
            this.picSpinner.Size = new System.Drawing.Size(57, 50);
            this.picSpinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpinner.TabIndex = 2;
            this.picSpinner.TabStop = false;
            this.picSpinner.Visible = false;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Location = new System.Drawing.Point(68, 58);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(81, 13);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "Task running: 0";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(302, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(263, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Client";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSimulations);
            this.groupBox1.Controls.Add(this.txtPeriods);
            this.groupBox1.Controls.Add(this.txtInterestRate);
            this.groupBox1.Controls.Add(this.txtDownGrowth);
            this.groupBox1.Controls.Add(this.txtUpGrowth);
            this.groupBox1.Controls.Add(this.txtExcercisePrice);
            this.groupBox1.Controls.Add(this.txtInitialPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(260, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulator parameters";
            // 
            // txtSimulations
            // 
            this.txtSimulations.Location = new System.Drawing.Point(91, 186);
            this.txtSimulations.Name = "txtSimulations";
            this.txtSimulations.Size = new System.Drawing.Size(115, 20);
            this.txtSimulations.TabIndex = 13;
            // 
            // txtPeriods
            // 
            this.txtPeriods.Location = new System.Drawing.Point(91, 158);
            this.txtPeriods.Name = "txtPeriods";
            this.txtPeriods.Size = new System.Drawing.Size(115, 20);
            this.txtPeriods.TabIndex = 12;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(91, 132);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(115, 20);
            this.txtInterestRate.TabIndex = 11;
            // 
            // txtDownGrowth
            // 
            this.txtDownGrowth.Location = new System.Drawing.Point(91, 106);
            this.txtDownGrowth.Name = "txtDownGrowth";
            this.txtDownGrowth.Size = new System.Drawing.Size(115, 20);
            this.txtDownGrowth.TabIndex = 10;
            // 
            // txtUpGrowth
            // 
            this.txtUpGrowth.Location = new System.Drawing.Point(91, 80);
            this.txtUpGrowth.Name = "txtUpGrowth";
            this.txtUpGrowth.Size = new System.Drawing.Size(115, 20);
            this.txtUpGrowth.TabIndex = 9;
            // 
            // txtExcercisePrice
            // 
            this.txtExcercisePrice.Location = new System.Drawing.Point(91, 54);
            this.txtExcercisePrice.Name = "txtExcercisePrice";
            this.txtExcercisePrice.Size = new System.Drawing.Size(115, 20);
            this.txtExcercisePrice.TabIndex = 8;
            // 
            // txtInitialPrice
            // 
            this.txtInitialPrice.Location = new System.Drawing.Point(91, 28);
            this.txtInitialPrice.Name = "txtInitialPrice";
            this.txtInitialPrice.Size = new System.Drawing.Size(115, 20);
            this.txtInitialPrice.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Simulations";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Periods";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interest rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Down growth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Up growth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Excercise price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial price";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 284);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.picSpinner);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lstPrices);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrices;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.PictureBox picSpinner;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSimulations;
        private System.Windows.Forms.TextBox txtPeriods;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.TextBox txtDownGrowth;
        private System.Windows.Forms.TextBox txtUpGrowth;
        private System.Windows.Forms.TextBox txtExcercisePrice;
        private System.Windows.Forms.TextBox txtInitialPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

