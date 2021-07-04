
namespace Presentacion
{
    partial class FormOpcionesCarta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOpcionesCarta));
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.panelBuscarEditar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblBuscarEditar = new System.Windows.Forms.Label();
            this.panelCrear = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCrear = new System.Windows.Forms.Button();
            this.lblCrear = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.redondeoBuscarEditar = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.redondeoCrear = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelOpciones.SuspendLayout();
            this.panelBuscarEditar.SuspendLayout();
            this.panelCrear.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.panelBuscarEditar);
            this.panelOpciones.Controls.Add(this.panelCrear);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(0, 172);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(800, 278);
            this.panelOpciones.TabIndex = 5;
            // 
            // panelBuscarEditar
            // 
            this.panelBuscarEditar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelBuscarEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscarEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBuscarEditar.BackgroundImage")));
            this.panelBuscarEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBuscarEditar.Controls.Add(this.btnBuscar);
            this.panelBuscarEditar.Controls.Add(this.lblBuscarEditar);
            this.panelBuscarEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBuscarEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBuscarEditar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscarEditar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscarEditar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelBuscarEditar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelBuscarEditar.Location = new System.Drawing.Point(416, 55);
            this.panelBuscarEditar.Name = "panelBuscarEditar";
            this.panelBuscarEditar.Quality = 10;
            this.panelBuscarEditar.Size = new System.Drawing.Size(206, 179);
            this.panelBuscarEditar.TabIndex = 3;
            this.panelBuscarEditar.TabStop = true;
            this.panelBuscarEditar.Click += new System.EventHandler(this.panelBuscarEditar_Click);
            this.panelBuscarEditar.Enter += new System.EventHandler(this.panelBuscarEditar_MouseEnter);
            this.panelBuscarEditar.MouseEnter += new System.EventHandler(this.panelBuscarEditar_MouseEnter);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscar.BackgroundImage")));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnBuscar.Location = new System.Drawing.Point(81, 92);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 50);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.panelBuscarEditar_Click);
            this.btnBuscar.Enter += new System.EventHandler(this.panelBuscarEditar_MouseEnter);
            this.btnBuscar.MouseEnter += new System.EventHandler(this.panelBuscarEditar_MouseEnter);
            // 
            // lblBuscarEditar
            // 
            this.lblBuscarEditar.AutoSize = true;
            this.lblBuscarEditar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscarEditar.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblBuscarEditar.Location = new System.Drawing.Point(7, 33);
            this.lblBuscarEditar.Name = "lblBuscarEditar";
            this.lblBuscarEditar.Size = new System.Drawing.Size(198, 33);
            this.lblBuscarEditar.TabIndex = 2;
            this.lblBuscarEditar.Text = "Buscar - Editar";
            this.lblBuscarEditar.Click += new System.EventHandler(this.panelBuscarEditar_Click);
            this.lblBuscarEditar.Enter += new System.EventHandler(this.panelBuscarEditar_MouseEnter);
            this.lblBuscarEditar.MouseEnter += new System.EventHandler(this.panelBuscarEditar_MouseEnter);
            // 
            // panelCrear
            // 
            this.panelCrear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelCrear.BackgroundImage")));
            this.panelCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCrear.Controls.Add(this.btnCrear);
            this.panelCrear.Controls.Add(this.lblCrear);
            this.panelCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCrear.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrear.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCrear.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.panelCrear.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(41)))));
            this.panelCrear.Location = new System.Drawing.Point(204, 55);
            this.panelCrear.Name = "panelCrear";
            this.panelCrear.Quality = 10;
            this.panelCrear.Size = new System.Drawing.Size(206, 179);
            this.panelCrear.TabIndex = 2;
            this.panelCrear.TabStop = true;
            this.panelCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.panelCrear.Enter += new System.EventHandler(this.panelCrear_MouseEnter);
            this.panelCrear.MouseEnter += new System.EventHandler(this.panelCrear_MouseEnter);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCrear.BackgroundImage")));
            this.btnCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(54)))));
            this.btnCrear.Location = new System.Drawing.Point(83, 92);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(0);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(50, 50);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.btnCrear.Enter += new System.EventHandler(this.panelCrear_MouseEnter);
            this.btnCrear.MouseEnter += new System.EventHandler(this.panelCrear_MouseEnter);
            // 
            // lblCrear
            // 
            this.lblCrear.AutoSize = true;
            this.lblCrear.BackColor = System.Drawing.Color.Transparent;
            this.lblCrear.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.lblCrear.Location = new System.Drawing.Point(64, 33);
            this.lblCrear.Name = "lblCrear";
            this.lblCrear.Size = new System.Drawing.Size(89, 33);
            this.lblCrear.TabIndex = 0;
            this.lblCrear.Text = "Crear";
            this.lblCrear.Click += new System.EventHandler(this.panelCrear_Click);
            this.lblCrear.Enter += new System.EventHandler(this.panelCrear_MouseEnter);
            this.lblCrear.MouseEnter += new System.EventHandler(this.panelCrear_MouseEnter);
            // 
            // panelTitulo
            // 
            this.panelTitulo.Controls.Add(this.button1);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(800, 172);
            this.panelTitulo.TabIndex = 4;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(79)))), ((int)(((byte)(115)))), ((int)(((byte)(143)))));
            this.lblTitulo.Location = new System.Drawing.Point(280, 47);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(240, 78);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CARTA";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // redondeoBuscarEditar
            // 
            this.redondeoBuscarEditar.ElipseRadius = 20;
            this.redondeoBuscarEditar.TargetControl = this.panelBuscarEditar;
            // 
            // redondeoCrear
            // 
            this.redondeoCrear.ElipseRadius = 20;
            this.redondeoCrear.TargetControl = this.panelCrear;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(187)))), ((int)(((byte)(42)))), ((int)(((byte)(89)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.button1.Location = new System.Drawing.Point(123, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 11;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormOpcionesCarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(60)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelOpciones);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOpcionesCarta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOpcionesCarta";
            this.Load += new System.EventHandler(this.FormOpcionesCarta_Load);
            this.panelOpciones.ResumeLayout(false);
            this.panelBuscarEditar.ResumeLayout(false);
            this.panelBuscarEditar.PerformLayout();
            this.panelCrear.ResumeLayout(false);
            this.panelCrear.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private Bunifu.Framework.UI.BunifuGradientPanel panelBuscarEditar;
        private System.Windows.Forms.Label lblBuscarEditar;
        private Bunifu.Framework.UI.BunifuGradientPanel panelCrear;
        private System.Windows.Forms.Label lblCrear;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCrear;
        private Bunifu.Framework.UI.BunifuElipse redondeoBuscarEditar;
        private Bunifu.Framework.UI.BunifuElipse redondeoCrear;
        private System.Windows.Forms.Button button1;
    }
}