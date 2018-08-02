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
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPrices
            // 
            this.lstPrices.FormattingEnabled = true;
            this.lstPrices.Location = new System.Drawing.Point(12, 92);
            this.lstPrices.Name = "lstPrices";
            this.lstPrices.Size = new System.Drawing.Size(232, 173);
            this.lstPrices.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.Location = new System.Drawing.Point(62, 25);
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
            this.picSpinner.Location = new System.Drawing.Point(187, 36);
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
            this.lblCounter.Location = new System.Drawing.Point(59, 73);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(81, 13);
            this.lblCounter.TabIndex = 3;
            this.lblCounter.Text = "Task running: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 284);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.picSpinner);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lstPrices);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSpinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPrices;
        private System.Windows.Forms.Button btnOption;
        private System.Windows.Forms.PictureBox picSpinner;
        private System.Windows.Forms.Label lblCounter;
    }
}

