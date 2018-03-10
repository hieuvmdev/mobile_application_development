namespace PTUD_EX1_LAB1
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
            this.NameApp = new System.Windows.Forms.Label();
            this.RS = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tLat = new System.Windows.Forms.TextBox();
            this.tLong = new System.Windows.Forms.TextBox();
            this.bConvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameApp
            // 
            this.NameApp.AutoSize = true;
            this.NameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameApp.Location = new System.Drawing.Point(29, 20);
            this.NameApp.Name = "NameApp";
            this.NameApp.Size = new System.Drawing.Size(318, 25);
            this.NameApp.TabIndex = 0;
            this.NameApp.Text = "Convert Coordinates to Address";
            // 
            // RS
            // 
            this.RS.AutoSize = true;
            this.RS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RS.Location = new System.Drawing.Point(31, 213);
            this.RS.Name = "RS";
            this.RS.Size = new System.Drawing.Size(81, 16);
            this.RS.TabIndex = 1;
            this.RS.Text = "ADDRESS";
            // 
            // lResult
            // 
            this.lResult.AutoSize = true;
            this.lResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lResult.Location = new System.Drawing.Point(118, 213);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(66, 16);
            this.lResult.TabIndex = 2;
            this.lResult.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "LAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "LONG";
            // 
            // tLat
            // 
            this.tLat.Location = new System.Drawing.Point(121, 71);
            this.tLat.Name = "tLat";
            this.tLat.Size = new System.Drawing.Size(253, 20);
            this.tLat.TabIndex = 5;
            // 
            // tLong
            // 
            this.tLong.Location = new System.Drawing.Point(121, 120);
            this.tLong.Name = "tLong";
            this.tLong.Size = new System.Drawing.Size(253, 20);
            this.tLong.TabIndex = 6;
            // 
            // bConvert
            // 
            this.bConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bConvert.Location = new System.Drawing.Point(137, 161);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(118, 29);
            this.bConvert.TabIndex = 7;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.bConvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 353);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.tLong);
            this.Controls.Add(this.tLat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.RS);
            this.Controls.Add(this.NameApp);
            this.Name = "Form1";
            this.Text = "Bai tap 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameApp;
        private System.Windows.Forms.Label RS;
        private System.Windows.Forms.Label lResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLat;
        private System.Windows.Forms.TextBox tLong;
        private System.Windows.Forms.Button bConvert;
    }
}

