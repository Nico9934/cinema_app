namespace cinema_app
{
    partial class Asientos
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
            this.cb_a1 = new System.Windows.Forms.CheckBox();
            this.cb_a2 = new System.Windows.Forms.CheckBox();
            this.cb_a3 = new System.Windows.Forms.CheckBox();
            this.cb_a4 = new System.Windows.Forms.CheckBox();
            this.cb_a5 = new System.Windows.Forms.CheckBox();
            this.gb_asientos = new System.Windows.Forms.GroupBox();
            this.btn_confirm_asientos = new System.Windows.Forms.Button();
            this.gb_asientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(84, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 12);
            this.panel1.TabIndex = 1;
            // 
            // cb_a1
            // 
            this.cb_a1.AutoSize = true;
            this.cb_a1.Location = new System.Drawing.Point(123, 46);
            this.cb_a1.Name = "cb_a1";
            this.cb_a1.Size = new System.Drawing.Size(18, 17);
            this.cb_a1.TabIndex = 25;
            this.cb_a1.Tag = "A-1";
            this.cb_a1.UseVisualStyleBackColor = true;
            // 
            // cb_a2
            // 
            this.cb_a2.AutoSize = true;
            this.cb_a2.Location = new System.Drawing.Point(147, 46);
            this.cb_a2.Name = "cb_a2";
            this.cb_a2.Size = new System.Drawing.Size(18, 17);
            this.cb_a2.TabIndex = 26;
            this.cb_a2.Tag = "A-2";
            this.cb_a2.UseVisualStyleBackColor = true;
            // 
            // cb_a3
            // 
            this.cb_a3.AutoSize = true;
            this.cb_a3.Location = new System.Drawing.Point(171, 46);
            this.cb_a3.Name = "cb_a3";
            this.cb_a3.Size = new System.Drawing.Size(18, 17);
            this.cb_a3.TabIndex = 27;
            this.cb_a3.Tag = "A-3";
            this.cb_a3.UseVisualStyleBackColor = true;
            // 
            // cb_a4
            // 
            this.cb_a4.AutoSize = true;
            this.cb_a4.Location = new System.Drawing.Point(195, 46);
            this.cb_a4.Name = "cb_a4";
            this.cb_a4.Size = new System.Drawing.Size(18, 17);
            this.cb_a4.TabIndex = 28;
            this.cb_a4.Tag = "A-4";
            this.cb_a4.UseVisualStyleBackColor = true;
            // 
            // cb_a5
            // 
            this.cb_a5.AutoSize = true;
            this.cb_a5.Location = new System.Drawing.Point(219, 46);
            this.cb_a5.Name = "cb_a5";
            this.cb_a5.Size = new System.Drawing.Size(18, 17);
            this.cb_a5.TabIndex = 29;
            this.cb_a5.Tag = "A-5";
            this.cb_a5.UseVisualStyleBackColor = true;
            // 
            // gb_asientos
            // 
            this.gb_asientos.Controls.Add(this.cb_a3);
            this.gb_asientos.Controls.Add(this.cb_a5);
            this.gb_asientos.Controls.Add(this.cb_a1);
            this.gb_asientos.Controls.Add(this.cb_a4);
            this.gb_asientos.Controls.Add(this.cb_a2);
            this.gb_asientos.Location = new System.Drawing.Point(84, 60);
            this.gb_asientos.Name = "gb_asientos";
            this.gb_asientos.Size = new System.Drawing.Size(384, 199);
            this.gb_asientos.TabIndex = 30;
            this.gb_asientos.TabStop = false;
            // 
            // btn_confirm_asientos
            // 
            this.btn_confirm_asientos.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_confirm_asientos.Font = new System.Drawing.Font("Roboto", 12F);
            this.btn_confirm_asientos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.btn_confirm_asientos.Location = new System.Drawing.Point(207, 275);
            this.btn_confirm_asientos.Name = "btn_confirm_asientos";
            this.btn_confirm_asientos.Size = new System.Drawing.Size(142, 33);
            this.btn_confirm_asientos.TabIndex = 31;
            this.btn_confirm_asientos.Text = "Confirmar";
            this.btn_confirm_asientos.UseVisualStyleBackColor = false;
            this.btn_confirm_asientos.Click += new System.EventHandler(this.btn_confirm_asientos_Click);
            // 
            // Asientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(527, 332);
            this.Controls.Add(this.btn_confirm_asientos);
            this.Controls.Add(this.gb_asientos);
            this.Controls.Add(this.panel1);
            this.Name = "Asientos";
            this.Text = "Asientos";
            this.gb_asientos.ResumeLayout(false);
            this.gb_asientos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_a1;
        private System.Windows.Forms.CheckBox cb_a2;
        private System.Windows.Forms.CheckBox cb_a3;
        private System.Windows.Forms.CheckBox cb_a4;
        private System.Windows.Forms.CheckBox cb_a5;
        private System.Windows.Forms.GroupBox gb_asientos;
        private System.Windows.Forms.Button btn_confirm_asientos;
    }
}