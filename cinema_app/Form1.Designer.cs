
namespace cinema_app
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmb_film = new System.Windows.Forms.ComboBox();
            this.cmb_format = new System.Windows.Forms.ComboBox();
            this.cmb_sala = new System.Windows.Forms.ComboBox();
            this.cmb_hour = new System.Windows.Forms.ComboBox();
            this.lbl_film = new System.Windows.Forms.Label();
            this.lbl_format = new System.Windows.Forms.Label();
            this.lbl_sala = new System.Windows.Forms.Label();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.lbl_asiento = new System.Windows.Forms.Label();
            this.btn_asiento = new System.Windows.Forms.Button();
            this.btn_continue = new System.Windows.Forms.Button();
            this.pnl_first = new System.Windows.Forms.Panel();
            this.pnl_images_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnl_first.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 102);
            this.panel1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel10.BackgroundImage")));
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel10.Location = new System.Drawing.Point(12, 4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(382, 98);
            this.panel10.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(787, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // cmb_film
            // 
            this.cmb_film.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_film.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_film.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_film.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.cmb_film.FormattingEnabled = true;
            this.cmb_film.Location = new System.Drawing.Point(14, 90);
            this.cmb_film.Name = "cmb_film";
            this.cmb_film.Size = new System.Drawing.Size(265, 32);
            this.cmb_film.TabIndex = 7;
            this.cmb_film.Text = "---Elige una pelicula---";
            this.cmb_film.SelectedIndexChanged += new System.EventHandler(this.cmb_film_SelectedIndexChanged);
            // 
            // cmb_format
            // 
            this.cmb_format.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_format.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_format.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmb_format.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.cmb_format.FormattingEnabled = true;
            this.cmb_format.Location = new System.Drawing.Point(293, 90);
            this.cmb_format.Name = "cmb_format";
            this.cmb_format.Size = new System.Drawing.Size(238, 32);
            this.cmb_format.TabIndex = 8;
            this.cmb_format.Text = "---Elige un formato---";
            this.cmb_format.Visible = false;
            this.cmb_format.SelectedIndexChanged += new System.EventHandler(this.cmb_format_SelectedIndexChanged);
            // 
            // cmb_sala
            // 
            this.cmb_sala.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_sala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_sala.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmb_sala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.cmb_sala.FormattingEnabled = true;
            this.cmb_sala.Location = new System.Drawing.Point(550, 90);
            this.cmb_sala.Name = "cmb_sala";
            this.cmb_sala.Size = new System.Drawing.Size(212, 32);
            this.cmb_sala.TabIndex = 9;
            this.cmb_sala.Text = "---Elige una sala---";
            this.cmb_sala.Visible = false;
            this.cmb_sala.SelectedIndexChanged += new System.EventHandler(this.cmb_sala_SelectedIndexChanged);
            // 
            // cmb_hour
            // 
            this.cmb_hour.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cmb_hour.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_hour.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmb_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.cmb_hour.FormattingEnabled = true;
            this.cmb_hour.Location = new System.Drawing.Point(785, 90);
            this.cmb_hour.Name = "cmb_hour";
            this.cmb_hour.Size = new System.Drawing.Size(225, 32);
            this.cmb_hour.TabIndex = 10;
            this.cmb_hour.Text = "---Elige un horario---";
            this.cmb_hour.Visible = false;
            this.cmb_hour.SelectedIndexChanged += new System.EventHandler(this.cmb_hour_SelectedIndexChanged);
            // 
            // lbl_film
            // 
            this.lbl_film.AutoSize = true;
            this.lbl_film.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbl_film.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.lbl_film.Location = new System.Drawing.Point(34, 48);
            this.lbl_film.Name = "lbl_film";
            this.lbl_film.Size = new System.Drawing.Size(206, 24);
            this.lbl_film.TabIndex = 11;
            this.lbl_film.Text = "ELIGE UNA PELICULA";
            // 
            // lbl_format
            // 
            this.lbl_format.AutoSize = true;
            this.lbl_format.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbl_format.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.lbl_format.Location = new System.Drawing.Point(289, 48);
            this.lbl_format.Name = "lbl_format";
            this.lbl_format.Size = new System.Drawing.Size(104, 24);
            this.lbl_format.TabIndex = 12;
            this.lbl_format.Text = "FORMATO";
            this.lbl_format.Visible = false;
            // 
            // lbl_sala
            // 
            this.lbl_sala.AutoSize = true;
            this.lbl_sala.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbl_sala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.lbl_sala.Location = new System.Drawing.Point(546, 48);
            this.lbl_sala.Name = "lbl_sala";
            this.lbl_sala.Size = new System.Drawing.Size(163, 24);
            this.lbl_sala.TabIndex = 13;
            this.lbl_sala.Text = "ELEGI UNA SALA";
            this.lbl_sala.Visible = false;
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbl_hour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.lbl_hour.Location = new System.Drawing.Point(783, 48);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(188, 24);
            this.lbl_hour.TabIndex = 14;
            this.lbl_hour.Text = "ELEGI UN HORARIO";
            this.lbl_hour.Visible = false;
            // 
            // lbl_asiento
            // 
            this.lbl_asiento.AutoSize = true;
            this.lbl_asiento.Font = new System.Drawing.Font("Roboto", 12F);
            this.lbl_asiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.lbl_asiento.Location = new System.Drawing.Point(1036, 48);
            this.lbl_asiento.Name = "lbl_asiento";
            this.lbl_asiento.Size = new System.Drawing.Size(183, 24);
            this.lbl_asiento.TabIndex = 15;
            this.lbl_asiento.Text = "ELEGI UN ASIENTO";
            this.lbl_asiento.Visible = false;
            // 
            // btn_asiento
            // 
            this.btn_asiento.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_asiento.Font = new System.Drawing.Font("Roboto", 12F);
            this.btn_asiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.btn_asiento.Location = new System.Drawing.Point(1053, 84);
            this.btn_asiento.Name = "btn_asiento";
            this.btn_asiento.Size = new System.Drawing.Size(147, 43);
            this.btn_asiento.TabIndex = 16;
            this.btn_asiento.Text = "ASIENTOS";
            this.btn_asiento.UseVisualStyleBackColor = false;
            this.btn_asiento.Visible = false;
            this.btn_asiento.Click += new System.EventHandler(this.btn_asiento_Click);
            // 
            // btn_continue
            // 
            this.btn_continue.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_continue.Font = new System.Drawing.Font("Roboto", 12F);
            this.btn_continue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(182)))), ((int)(((byte)(222)))));
            this.btn_continue.Location = new System.Drawing.Point(886, 174);
            this.btn_continue.Name = "btn_continue";
            this.btn_continue.Size = new System.Drawing.Size(173, 41);
            this.btn_continue.TabIndex = 17;
            this.btn_continue.Text = "CONTINUAR";
            this.btn_continue.UseVisualStyleBackColor = false;
            this.btn_continue.Visible = false;
            this.btn_continue.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // pnl_first
            // 
            this.pnl_first.Controls.Add(this.pnl_images_container);
            this.pnl_first.Controls.Add(this.lbl_film);
            this.pnl_first.Controls.Add(this.btn_continue);
            this.pnl_first.Controls.Add(this.cmb_film);
            this.pnl_first.Controls.Add(this.btn_asiento);
            this.pnl_first.Controls.Add(this.cmb_format);
            this.pnl_first.Controls.Add(this.lbl_asiento);
            this.pnl_first.Controls.Add(this.cmb_sala);
            this.pnl_first.Controls.Add(this.lbl_hour);
            this.pnl_first.Controls.Add(this.cmb_hour);
            this.pnl_first.Controls.Add(this.lbl_sala);
            this.pnl_first.Controls.Add(this.lbl_format);
            this.pnl_first.Location = new System.Drawing.Point(177, 138);
            this.pnl_first.Name = "pnl_first";
            this.pnl_first.Size = new System.Drawing.Size(1280, 907);
            this.pnl_first.TabIndex = 18;
            // 
            // pnl_images_container
            // 
            this.pnl_images_container.Location = new System.Drawing.Point(71, 270);
            this.pnl_images_container.Name = "pnl_images_container";
            this.pnl_images_container.Size = new System.Drawing.Size(1156, 432);
            this.pnl_images_container.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1493, 1034);
            this.Controls.Add(this.pnl_first);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnl_first.ResumeLayout(false);
            this.pnl_first.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public  System.Windows.Forms.ComboBox cmb_film;
        public  System.Windows.Forms.ComboBox cmb_format;
        public  System.Windows.Forms.ComboBox cmb_sala;
        public  System.Windows.Forms.ComboBox cmb_hour;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_film;
        private System.Windows.Forms.Label lbl_format;
        private System.Windows.Forms.Label lbl_sala;
        private System.Windows.Forms.Label lbl_hour;
        private System.Windows.Forms.Label lbl_asiento;
        private System.Windows.Forms.Button btn_asiento;
        public  System.Windows.Forms.Button btn_continue;
        public  System.Windows.Forms.Panel pnl_first;
        private System.Windows.Forms.Panel pnl_images_container;
    }
}

