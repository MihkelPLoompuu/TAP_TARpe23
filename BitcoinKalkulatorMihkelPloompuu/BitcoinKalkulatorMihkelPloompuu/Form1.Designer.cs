namespace BitcoinKalkulatorMihkelPloompuu
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
            this.BitcoinAmountinput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.currencyselector = new System.Windows.Forms.ComboBox();
            this.tulemuslabel = new System.Windows.Forms.Label();
            this.resultlable = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BitcoinAmountinput
            // 
            this.BitcoinAmountinput.Location = new System.Drawing.Point(12, 25);
            this.BitcoinAmountinput.Name = "BitcoinAmountinput";
            this.BitcoinAmountinput.Size = new System.Drawing.Size(100, 20);
            this.BitcoinAmountinput.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mitu bitcoini konverteerida tahad?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Vali valuuta millesse konverteerida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Konverteeri:";
            // 
            // currencyselector
            // 
            this.currencyselector.FormattingEnabled = true;
            this.currencyselector.Items.AddRange(new object[] {
            "EUR",
            "USD",
            "GBP",
            "EEK"});
            this.currencyselector.Location = new System.Drawing.Point(12, 66);
            this.currencyselector.Name = "currencyselector";
            this.currencyselector.Size = new System.Drawing.Size(121, 21);
            this.currencyselector.TabIndex = 6;
            this.currencyselector.Text = "Vali valuuta";
            // 
            // tulemuslabel
            // 
            this.tulemuslabel.AutoSize = true;
            this.tulemuslabel.Location = new System.Drawing.Point(12, 366);
            this.tulemuslabel.Name = "tulemuslabel";
            this.tulemuslabel.Size = new System.Drawing.Size(50, 13);
            this.tulemuslabel.TabIndex = 7;
            this.tulemuslabel.Text = "Tulemus:";
            this.tulemuslabel.Visible = false;
            // 
            // resultlable
            // 
            this.resultlable.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.resultlable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultlable.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.resultlable.Location = new System.Drawing.Point(12, 382);
            this.resultlable.Name = "resultlable";
            this.resultlable.Size = new System.Drawing.Size(350, 73);
            this.resultlable.TabIndex = 7;
            this.resultlable.Text = "None";
            this.resultlable.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(583, 463);
            this.Controls.Add(this.resultlable);
            this.Controls.Add(this.tulemuslabel);
            this.Controls.Add(this.currencyselector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BitcoinAmountinput);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BitcoinAmountinput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox currencyselector;
        private System.Windows.Forms.Label tulemuslabel;
        private System.Windows.Forms.TextBox resultlable;
    }
}

