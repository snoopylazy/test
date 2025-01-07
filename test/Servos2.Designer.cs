namespace test
{
    partial class Servos2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbTableStatus = new System.Windows.Forms.Label();
            this.lbCurrent = new System.Windows.Forms.Label();
            this.lb_Inform = new System.Windows.Forms.Label();
            this.Resturant = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lbTable = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resturant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.lbX);
            this.panel1.Controls.Add(this.lbTable);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(-5, -13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 98);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(3, 107);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(110, 413);
            this.panel4.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Bisque;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-81, 443);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(913, 107);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(3, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(110, 413);
            this.panel3.TabIndex = 4;
            // 
            // lbTableStatus
            // 
            this.lbTableStatus.AutoSize = true;
            this.lbTableStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTableStatus.Location = new System.Drawing.Point(247, 94);
            this.lbTableStatus.Name = "lbTableStatus";
            this.lbTableStatus.Size = new System.Drawing.Size(151, 31);
            this.lbTableStatus.TabIndex = 6;
            this.lbTableStatus.Text = "Table status";
            // 
            // lbCurrent
            // 
            this.lbCurrent.AutoSize = true;
            this.lbCurrent.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrent.Location = new System.Drawing.Point(63, 289);
            this.lbCurrent.Name = "lbCurrent";
            this.lbCurrent.Size = new System.Drawing.Size(146, 26);
            this.lbCurrent.TabIndex = 8;
            this.lbCurrent.Text = "Current status";
            // 
            // lb_Inform
            // 
            this.lb_Inform.AutoSize = true;
            this.lb_Inform.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Inform.Location = new System.Drawing.Point(63, 325);
            this.lb_Inform.Name = "lb_Inform";
            this.lb_Inform.Size = new System.Drawing.Size(421, 50);
            this.lb_Inform.TabIndex = 11;
            this.lb_Inform.Text = "We are plessed inform you that this table No. 1\r\n is currently available for occu" +
    "pation";
            // 
            // Resturant
            // 
            this.Resturant.Image = global::test.Properties.Resources.d04fc6ea_b8cd_463d_a1ee_429dbcd79bd0;
            this.Resturant.Location = new System.Drawing.Point(223, 128);
            this.Resturant.Name = "Resturant";
            this.Resturant.Size = new System.Drawing.Size(187, 160);
            this.Resturant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resturant.TabIndex = 7;
            this.Resturant.TabStop = false;
            // 
            // logo
            // 
            this.logo.Image = global::test.Properties.Resources.Brown_Culinary_Hunter_Food_Logo;
            this.logo.Location = new System.Drawing.Point(-5, -19);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(134, 135);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 12;
            this.logo.TabStop = false;
            this.logo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbTable
            // 
            this.lbTable.AutoSize = true;
            this.lbTable.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTable.Location = new System.Drawing.Point(465, 36);
            this.lbTable.Name = "lbTable";
            this.lbTable.Size = new System.Drawing.Size(138, 31);
            this.lbTable.TabIndex = 15;
            this.lbTable.Text = "Table No.1";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.BackColor = System.Drawing.Color.OrangeRed;
            this.lbX.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbX.Location = new System.Drawing.Point(603, 35);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(30, 31);
            this.lbX.TabIndex = 16;
            this.lbX.Text = "X";
            // 
            // Servos2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 499);
            this.Controls.Add(this.lb_Inform);
            this.Controls.Add(this.lbCurrent);
            this.Controls.Add(this.Resturant);
            this.Controls.Add(this.lbTableStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Servos2";
            this.Text = "Servos2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Resturant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbTableStatus;
        private System.Windows.Forms.PictureBox Resturant;
        private System.Windows.Forms.Label lbCurrent;
        private System.Windows.Forms.Label lb_Inform;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lbTable;
        private System.Windows.Forms.Label lbX;
    }
}