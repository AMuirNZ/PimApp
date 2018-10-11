namespace PimApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblClicks = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClick = new System.Windows.Forms.Button();
            this.btnPimButton = new System.Windows.Forms.Button();
            this.txtPim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPimClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pim\'s App";
            // 
            // lblClicks
            // 
            this.lblClicks.AutoSize = true;
            this.lblClicks.Location = new System.Drawing.Point(508, 191);
            this.lblClicks.Name = "lblClicks";
            this.lblClicks.Size = new System.Drawing.Size(13, 13);
            this.lblClicks.TabIndex = 1;
            this.lblClicks.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clicks";
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(206, 186);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 3;
            this.btnClick.Text = "Button Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // btnPimButton
            // 
            this.btnPimButton.Location = new System.Drawing.Point(215, 280);
            this.btnPimButton.Name = "btnPimButton";
            this.btnPimButton.Size = new System.Drawing.Size(75, 23);
            this.btnPimButton.TabIndex = 4;
            this.btnPimButton.Text = "Pim Button";
            this.btnPimButton.UseVisualStyleBackColor = true;
            this.btnPimButton.Click += new System.EventHandler(this.btnPimButton_Click);
            // 
            // txtPim
            // 
            this.txtPim.Location = new System.Drawing.Point(423, 282);
            this.txtPim.Name = "txtPim";
            this.txtPim.Size = new System.Drawing.Size(100, 20);
            this.txtPim.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Pim Clicks";
            // 
            // lblPimClick
            // 
            this.lblPimClick.AutoSize = true;
            this.lblPimClick.Location = new System.Drawing.Point(658, 280);
            this.lblPimClick.Name = "lblPimClick";
            this.lblPimClick.Size = new System.Drawing.Size(13, 13);
            this.lblPimClick.TabIndex = 6;
            this.lblPimClick.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPimClick);
            this.Controls.Add(this.txtPim);
            this.Controls.Add(this.btnPimButton);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblClicks);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClicks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Button btnPimButton;
        private System.Windows.Forms.TextBox txtPim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPimClick;
    }
}

