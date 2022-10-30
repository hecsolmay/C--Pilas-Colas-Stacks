namespace Car_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtMinutes = new System.Windows.Forms.TextBox();
            this.txtSeconds = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerCars = new System.Windows.Forms.Timer(this.components);
            this.lblMensaje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAutosPintados = new System.Windows.Forms.TextBox();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.btnNegro = new System.Windows.Forms.Button();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.btnMorado = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnGris = new System.Windows.Forms.Button();
            this.pboxAtendido = new System.Windows.Forms.PictureBox();
            this.lblAtendido = new System.Windows.Forms.Label();
            this.lblAuto1 = new System.Windows.Forms.Label();
            this.pboxAuto1 = new System.Windows.Forms.PictureBox();
            this.lblAuto3 = new System.Windows.Forms.Label();
            this.pboxAuto3 = new System.Windows.Forms.PictureBox();
            this.lblAuto4 = new System.Windows.Forms.Label();
            this.pboxAuto4 = new System.Windows.Forms.PictureBox();
            this.lblAuto5 = new System.Windows.Forms.Label();
            this.pboxAuto5 = new System.Windows.Forms.PictureBox();
            this.lblAuto2 = new System.Windows.Forms.Label();
            this.pboxAuto2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRecordsTitle = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtendido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHours.Location = new System.Drawing.Point(732, 12);
            this.txtHours.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtHours.Multiline = true;
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(45, 37);
            this.txtHours.TabIndex = 0;
            this.txtHours.Text = "00";
            // 
            // txtMinutes
            // 
            this.txtMinutes.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMinutes.Location = new System.Drawing.Point(783, 12);
            this.txtMinutes.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtMinutes.Multiline = true;
            this.txtMinutes.Name = "txtMinutes";
            this.txtMinutes.ReadOnly = true;
            this.txtMinutes.Size = new System.Drawing.Size(45, 37);
            this.txtMinutes.TabIndex = 1;
            this.txtMinutes.Text = "00";
            // 
            // txtSeconds
            // 
            this.txtSeconds.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSeconds.Location = new System.Drawing.Point(834, 12);
            this.txtSeconds.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtSeconds.Multiline = true;
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.ReadOnly = true;
            this.txtSeconds.Size = new System.Drawing.Size(45, 37);
            this.txtSeconds.TabIndex = 2;
            this.txtSeconds.Text = "00";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(397, 396);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerCars
            // 
            this.timerCars.Tick += new System.EventHandler(this.timerCars_Tick);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMensaje.Location = new System.Drawing.Point(372, 348);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(123, 21);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Autos en cola : 2";
            this.lblMensaje.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(732, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autos Pintados :";
            // 
            // txtAutosPintados
            // 
            this.txtAutosPintados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAutosPintados.Location = new System.Drawing.Point(843, 65);
            this.txtAutosPintados.MaximumSize = new System.Drawing.Size(100, 100);
            this.txtAutosPintados.Name = "txtAutosPintados";
            this.txtAutosPintados.ReadOnly = true;
            this.txtAutosPintados.Size = new System.Drawing.Size(45, 16);
            this.txtAutosPintados.TabIndex = 6;
            this.txtAutosPintados.Text = "0";
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRojo.Location = new System.Drawing.Point(197, 98);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(88, 34);
            this.btnRojo.TabIndex = 7;
            this.btnRojo.Text = "Rojo";
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.Color.Yellow;
            this.btnAmarillo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmarillo.Location = new System.Drawing.Point(311, 98);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(88, 34);
            this.btnAmarillo.TabIndex = 8;
            this.btnAmarillo.Text = "Amarillo";
            this.btnAmarillo.UseVisualStyleBackColor = false;
            this.btnAmarillo.Click += new System.EventHandler(this.btnAmarillo_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Lime;
            this.btnVerde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerde.Location = new System.Drawing.Point(423, 98);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(88, 34);
            this.btnVerde.TabIndex = 9;
            this.btnVerde.Text = "Verde";
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // btnNegro
            // 
            this.btnNegro.BackColor = System.Drawing.Color.Brown;
            this.btnNegro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNegro.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnNegro.Location = new System.Drawing.Point(536, 98);
            this.btnNegro.Name = "btnNegro";
            this.btnNegro.Size = new System.Drawing.Size(88, 34);
            this.btnNegro.TabIndex = 10;
            this.btnNegro.Text = "Cafe";
            this.btnNegro.UseVisualStyleBackColor = false;
            this.btnNegro.Click += new System.EventHandler(this.btnNegro_Click);
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.Color.White;
            this.btnBlanco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlanco.Location = new System.Drawing.Point(197, 151);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(88, 34);
            this.btnBlanco.TabIndex = 11;
            this.btnBlanco.Text = "Blanco";
            this.btnBlanco.UseVisualStyleBackColor = false;
            this.btnBlanco.Click += new System.EventHandler(this.btnBlanco_Click);
            // 
            // btnMorado
            // 
            this.btnMorado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnMorado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMorado.Location = new System.Drawing.Point(311, 151);
            this.btnMorado.Name = "btnMorado";
            this.btnMorado.Size = new System.Drawing.Size(88, 34);
            this.btnMorado.TabIndex = 12;
            this.btnMorado.Text = "Morado";
            this.btnMorado.UseVisualStyleBackColor = false;
            this.btnMorado.Click += new System.EventHandler(this.btnMorado_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAzul.Location = new System.Drawing.Point(423, 151);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(88, 34);
            this.btnAzul.TabIndex = 13;
            this.btnAzul.Text = "Azul";
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnGris
            // 
            this.btnGris.BackColor = System.Drawing.Color.Gray;
            this.btnGris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGris.Location = new System.Drawing.Point(536, 151);
            this.btnGris.Name = "btnGris";
            this.btnGris.Size = new System.Drawing.Size(88, 34);
            this.btnGris.TabIndex = 14;
            this.btnGris.Text = "Gris";
            this.btnGris.UseVisualStyleBackColor = false;
            this.btnGris.Click += new System.EventHandler(this.btnGris_Click);
            // 
            // pboxAtendido
            // 
            this.pboxAtendido.Image = ((System.Drawing.Image)(resources.GetObject("pboxAtendido.Image")));
            this.pboxAtendido.Location = new System.Drawing.Point(766, 217);
            this.pboxAtendido.Name = "pboxAtendido";
            this.pboxAtendido.Size = new System.Drawing.Size(113, 60);
            this.pboxAtendido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAtendido.TabIndex = 15;
            this.pboxAtendido.TabStop = false;
            this.pboxAtendido.Visible = false;
            // 
            // lblAtendido
            // 
            this.lblAtendido.AutoSize = true;
            this.lblAtendido.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAtendido.Location = new System.Drawing.Point(779, 280);
            this.lblAtendido.Name = "lblAtendido";
            this.lblAtendido.Size = new System.Drawing.Size(89, 25);
            this.lblAtendido.TabIndex = 16;
            this.lblAtendido.Text = "Atendido";
            this.lblAtendido.Visible = false;
            // 
            // lblAuto1
            // 
            this.lblAuto1.AutoSize = true;
            this.lblAuto1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAuto1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuto1.ForeColor = System.Drawing.Color.Black;
            this.lblAuto1.Location = new System.Drawing.Point(627, 280);
            this.lblAuto1.Name = "lblAuto1";
            this.lblAuto1.Size = new System.Drawing.Size(89, 25);
            this.lblAuto1.TabIndex = 18;
            this.lblAuto1.Text = "Atendido";
            this.lblAuto1.Visible = false;
            // 
            // pboxAuto1
            // 
            this.pboxAuto1.Image = ((System.Drawing.Image)(resources.GetObject("pboxAuto1.Image")));
            this.pboxAuto1.Location = new System.Drawing.Point(614, 217);
            this.pboxAuto1.Name = "pboxAuto1";
            this.pboxAuto1.Size = new System.Drawing.Size(113, 60);
            this.pboxAuto1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAuto1.TabIndex = 17;
            this.pboxAuto1.TabStop = false;
            this.pboxAuto1.Visible = false;
            // 
            // lblAuto3
            // 
            this.lblAuto3.AutoSize = true;
            this.lblAuto3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuto3.Location = new System.Drawing.Point(359, 280);
            this.lblAuto3.Name = "lblAuto3";
            this.lblAuto3.Size = new System.Drawing.Size(89, 25);
            this.lblAuto3.TabIndex = 20;
            this.lblAuto3.Text = "Atendido";
            this.lblAuto3.Visible = false;
            // 
            // pboxAuto3
            // 
            this.pboxAuto3.Image = ((System.Drawing.Image)(resources.GetObject("pboxAuto3.Image")));
            this.pboxAuto3.Location = new System.Drawing.Point(346, 217);
            this.pboxAuto3.Name = "pboxAuto3";
            this.pboxAuto3.Size = new System.Drawing.Size(113, 60);
            this.pboxAuto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAuto3.TabIndex = 19;
            this.pboxAuto3.TabStop = false;
            this.pboxAuto3.Visible = false;
            // 
            // lblAuto4
            // 
            this.lblAuto4.AutoSize = true;
            this.lblAuto4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuto4.Location = new System.Drawing.Point(223, 280);
            this.lblAuto4.Name = "lblAuto4";
            this.lblAuto4.Size = new System.Drawing.Size(89, 25);
            this.lblAuto4.TabIndex = 22;
            this.lblAuto4.Text = "Atendido";
            this.lblAuto4.Visible = false;
            // 
            // pboxAuto4
            // 
            this.pboxAuto4.Image = ((System.Drawing.Image)(resources.GetObject("pboxAuto4.Image")));
            this.pboxAuto4.Location = new System.Drawing.Point(210, 217);
            this.pboxAuto4.Name = "pboxAuto4";
            this.pboxAuto4.Size = new System.Drawing.Size(113, 60);
            this.pboxAuto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAuto4.TabIndex = 21;
            this.pboxAuto4.TabStop = false;
            this.pboxAuto4.Visible = false;
            // 
            // lblAuto5
            // 
            this.lblAuto5.AutoSize = true;
            this.lblAuto5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuto5.Location = new System.Drawing.Point(74, 280);
            this.lblAuto5.Name = "lblAuto5";
            this.lblAuto5.Size = new System.Drawing.Size(89, 25);
            this.lblAuto5.TabIndex = 24;
            this.lblAuto5.Text = "Atendido";
            this.lblAuto5.Visible = false;
            // 
            // pboxAuto5
            // 
            this.pboxAuto5.Image = ((System.Drawing.Image)(resources.GetObject("pboxAuto5.Image")));
            this.pboxAuto5.Location = new System.Drawing.Point(61, 217);
            this.pboxAuto5.Name = "pboxAuto5";
            this.pboxAuto5.Size = new System.Drawing.Size(113, 60);
            this.pboxAuto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAuto5.TabIndex = 23;
            this.pboxAuto5.TabStop = false;
            this.pboxAuto5.Visible = false;
            // 
            // lblAuto2
            // 
            this.lblAuto2.AutoSize = true;
            this.lblAuto2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAuto2.Location = new System.Drawing.Point(497, 280);
            this.lblAuto2.Name = "lblAuto2";
            this.lblAuto2.Size = new System.Drawing.Size(89, 25);
            this.lblAuto2.TabIndex = 26;
            this.lblAuto2.Text = "Atendido";
            this.lblAuto2.Visible = false;
            // 
            // pboxAuto2
            // 
            this.pboxAuto2.Image = ((System.Drawing.Image)(resources.GetObject("pboxAuto2.Image")));
            this.pboxAuto2.Location = new System.Drawing.Point(484, 217);
            this.pboxAuto2.Name = "pboxAuto2";
            this.pboxAuto2.Size = new System.Drawing.Size(113, 60);
            this.pboxAuto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxAuto2.TabIndex = 25;
            this.pboxAuto2.TabStop = false;
            this.pboxAuto2.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(296, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Escoge la opcion correcta";
            // 
            // lblRecordsTitle
            // 
            this.lblRecordsTitle.AutoSize = true;
            this.lblRecordsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRecordsTitle.Location = new System.Drawing.Point(779, 98);
            this.lblRecordsTitle.Name = "lblRecordsTitle";
            this.lblRecordsTitle.Size = new System.Drawing.Size(70, 21);
            this.lblRecordsTitle.TabIndex = 28;
            this.lblRecordsTitle.Text = "Records\r\n";
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Location = new System.Drawing.Point(732, 128);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(0, 15);
            this.lblRecords.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 465);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblRecordsTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAuto2);
            this.Controls.Add(this.pboxAuto2);
            this.Controls.Add(this.lblAuto5);
            this.Controls.Add(this.pboxAuto5);
            this.Controls.Add(this.lblAuto4);
            this.Controls.Add(this.pboxAuto4);
            this.Controls.Add(this.lblAuto3);
            this.Controls.Add(this.pboxAuto3);
            this.Controls.Add(this.lblAuto1);
            this.Controls.Add(this.pboxAuto1);
            this.Controls.Add(this.lblAtendido);
            this.Controls.Add(this.pboxAtendido);
            this.Controls.Add(this.btnGris);
            this.Controls.Add(this.btnAzul);
            this.Controls.Add(this.btnMorado);
            this.Controls.Add(this.btnBlanco);
            this.Controls.Add(this.btnNegro);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.txtAutosPintados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtSeconds);
            this.Controls.Add(this.txtMinutes);
            this.Controls.Add(this.txtHours);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxAtendido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAuto2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtHours;
        private TextBox txtMinutes;
        private TextBox txtSeconds;
        private Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerCars;
        private Label lblMensaje;
        private Label label1;
        private TextBox txtAutosPintados;
        private Button btnRojo;
        private Button btnAmarillo;
        private Button btnVerde;
        private Button btnNegro;
        private Button btnBlanco;
        private Button btnMorado;
        private Button btnAzul;
        private Button btnGris;
        private PictureBox pboxAtendido;
        private Label lblAtendido;
        private Label lblAuto1;
        private PictureBox pboxAuto1;
        private Label lblAuto3;
        private PictureBox pboxAuto3;
        private Label lblAuto4;
        private PictureBox pboxAuto4;
        private Label lblAuto5;
        private PictureBox pboxAuto5;
        private Label lblAuto2;
        private PictureBox pboxAuto2;
        private Label label2;
        private Label lblRecordsTitle;
        private Label lblRecords;
    }
}