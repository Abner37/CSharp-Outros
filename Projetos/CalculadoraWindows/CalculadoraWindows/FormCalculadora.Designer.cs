namespace CalculadoraWindows
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.lblCalculadora = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblMiniDisplay = new System.Windows.Forms.Label();
            this.panelBotoes = new System.Windows.Forms.Panel();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnMaisBarraMenos = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnRaizQuadrada = new System.Windows.Forms.Button();
            this.btnXElevado2 = new System.Windows.Forms.Button();
            this.btn1BarraX = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnMVezes = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMMenos = new System.Windows.Forms.Button();
            this.btnMMais = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.lblPadrao = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pctRelogio = new System.Windows.Forms.PictureBox();
            this.pctRelogioBack = new System.Windows.Forms.PictureBox();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.pctMenuBack = new System.Windows.Forms.PictureBox();
            this.panelBarra.SuspendLayout();
            this.panelDisplay.SuspendLayout();
            this.panelBotoes.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelogio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelogioBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelBarra.Controls.Add(this.btnMinimizar);
            this.panelBarra.Controls.Add(this.lblCalculadora);
            this.panelBarra.Controls.Add(this.btnFechar);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(320, 31);
            this.panelBarra.TabIndex = 0;
            this.panelBarra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelBarraSuperior_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizar.ForeColor = System.Drawing.Color.White;
            this.btnMinimizar.Location = new System.Drawing.Point(242, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(39, 30);
            this.btnMinimizar.TabIndex = 0;
            this.btnMinimizar.Text = "--";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // lblCalculadora
            // 
            this.lblCalculadora.AutoSize = true;
            this.lblCalculadora.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculadora.ForeColor = System.Drawing.Color.White;
            this.lblCalculadora.Location = new System.Drawing.Point(5, 7);
            this.lblCalculadora.Name = "lblCalculadora";
            this.lblCalculadora.Size = new System.Drawing.Size(74, 17);
            this.lblCalculadora.TabIndex = 4;
            this.lblCalculadora.Text = "Calculadora";
            this.lblCalculadora.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCalculadora_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(281, 0);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(39, 30);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panelDisplay
            // 
            this.panelDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelDisplay.Controls.Add(this.lblDisplay);
            this.panelDisplay.Controls.Add(this.lblMiniDisplay);
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDisplay.Location = new System.Drawing.Point(0, 73);
            this.panelDisplay.Name = "panelDisplay";
            this.panelDisplay.Size = new System.Drawing.Size(320, 92);
            this.panelDisplay.TabIndex = 2;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDisplay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblDisplay.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(0, 30);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(320, 55);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMiniDisplay
            // 
            this.lblMiniDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMiniDisplay.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniDisplay.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblMiniDisplay.Location = new System.Drawing.Point(0, 0);
            this.lblMiniDisplay.Name = "lblMiniDisplay";
            this.lblMiniDisplay.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblMiniDisplay.Size = new System.Drawing.Size(320, 27);
            this.lblMiniDisplay.TabIndex = 1;
            this.lblMiniDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelBotoes
            // 
            this.panelBotoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelBotoes.Controls.Add(this.btnIgual);
            this.panelBotoes.Controls.Add(this.btnVirgula);
            this.panelBotoes.Controls.Add(this.btn0);
            this.panelBotoes.Controls.Add(this.btnMaisBarraMenos);
            this.panelBotoes.Controls.Add(this.btnMais);
            this.panelBotoes.Controls.Add(this.btn3);
            this.panelBotoes.Controls.Add(this.btn2);
            this.panelBotoes.Controls.Add(this.btn1);
            this.panelBotoes.Controls.Add(this.btnMenos);
            this.panelBotoes.Controls.Add(this.btn6);
            this.panelBotoes.Controls.Add(this.btn5);
            this.panelBotoes.Controls.Add(this.btn4);
            this.panelBotoes.Controls.Add(this.btnVezes);
            this.panelBotoes.Controls.Add(this.btn9);
            this.panelBotoes.Controls.Add(this.btn8);
            this.panelBotoes.Controls.Add(this.btn7);
            this.panelBotoes.Controls.Add(this.btnDividir);
            this.panelBotoes.Controls.Add(this.btnRaizQuadrada);
            this.panelBotoes.Controls.Add(this.btnXElevado2);
            this.panelBotoes.Controls.Add(this.btn1BarraX);
            this.panelBotoes.Controls.Add(this.btnBackspace);
            this.panelBotoes.Controls.Add(this.btnC);
            this.panelBotoes.Controls.Add(this.btnCE);
            this.panelBotoes.Controls.Add(this.btnPercent);
            this.panelBotoes.Controls.Add(this.btnMVezes);
            this.panelBotoes.Controls.Add(this.btnMS);
            this.panelBotoes.Controls.Add(this.btnMMenos);
            this.panelBotoes.Controls.Add(this.btnMMais);
            this.panelBotoes.Controls.Add(this.btnMR);
            this.panelBotoes.Controls.Add(this.btnMC);
            this.panelBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotoes.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelBotoes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelBotoes.Location = new System.Drawing.Point(0, 165);
            this.panelBotoes.Name = "panelBotoes";
            this.panelBotoes.Size = new System.Drawing.Size(320, 338);
            this.panelBotoes.TabIndex = 3;
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(130)))));
            this.btnIgual.FlatAppearance.BorderSize = 0;
            this.btnIgual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(180)))));
            this.btnIgual.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(170)))));
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Calibri", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.White;
            this.btnIgual.Location = new System.Drawing.Point(239, 285);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(76, 49);
            this.btnIgual.TabIndex = 17;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnVirgula.FlatAppearance.BorderSize = 0;
            this.btnVirgula.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnVirgula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVirgula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVirgula.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.ForeColor = System.Drawing.Color.White;
            this.btnVirgula.Location = new System.Drawing.Point(161, 285);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(76, 49);
            this.btnVirgula.TabIndex = 28;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(83, 285);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(76, 49);
            this.btn0.TabIndex = 18;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnMaisBarraMenos
            // 
            this.btnMaisBarraMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnMaisBarraMenos.FlatAppearance.BorderSize = 0;
            this.btnMaisBarraMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMaisBarraMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMaisBarraMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaisBarraMenos.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisBarraMenos.ForeColor = System.Drawing.Color.White;
            this.btnMaisBarraMenos.Location = new System.Drawing.Point(5, 285);
            this.btnMaisBarraMenos.Name = "btnMaisBarraMenos";
            this.btnMaisBarraMenos.Size = new System.Drawing.Size(76, 49);
            this.btnMaisBarraMenos.TabIndex = 29;
            this.btnMaisBarraMenos.Text = "+/-";
            this.btnMaisBarraMenos.UseVisualStyleBackColor = false;
            // 
            // btnMais
            // 
            this.btnMais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMais.FlatAppearance.BorderSize = 0;
            this.btnMais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMais.Font = new System.Drawing.Font("Calibri", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMais.ForeColor = System.Drawing.Color.White;
            this.btnMais.Location = new System.Drawing.Point(239, 234);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(76, 49);
            this.btnMais.TabIndex = 16;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = false;
            this.btnMais.Click += new System.EventHandler(this.btnMais_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(161, 234);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(76, 49);
            this.btn3.TabIndex = 21;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(83, 234);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(76, 49);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(5, 234);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(76, 49);
            this.btn1.TabIndex = 19;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnMenos
            // 
            this.btnMenos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnMenos.FlatAppearance.BorderSize = 0;
            this.btnMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenos.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenos.ForeColor = System.Drawing.Color.White;
            this.btnMenos.Location = new System.Drawing.Point(239, 183);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(76, 49);
            this.btnMenos.TabIndex = 15;
            this.btnMenos.Text = "_";
            this.btnMenos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMenos.UseVisualStyleBackColor = false;
            this.btnMenos.Click += new System.EventHandler(this.btnMenos_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(161, 183);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(76, 49);
            this.btn6.TabIndex = 24;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(83, 183);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(76, 49);
            this.btn5.TabIndex = 23;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(5, 183);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(76, 49);
            this.btn4.TabIndex = 22;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btnVezes
            // 
            this.btnVezes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnVezes.FlatAppearance.BorderSize = 0;
            this.btnVezes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnVezes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVezes.Font = new System.Drawing.Font("Calibri", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVezes.ForeColor = System.Drawing.Color.White;
            this.btnVezes.Location = new System.Drawing.Point(239, 132);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(76, 49);
            this.btnVezes.TabIndex = 14;
            this.btnVezes.Text = "x";
            this.btnVezes.UseVisualStyleBackColor = false;
            this.btnVezes.Click += new System.EventHandler(this.btnVezes_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(161, 132);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(76, 49);
            this.btn9.TabIndex = 27;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(83, 132);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(76, 49);
            this.btn8.TabIndex = 26;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(5, 132);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(76, 49);
            this.btn7.TabIndex = 25;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnDividir.FlatAppearance.BorderSize = 0;
            this.btnDividir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDividir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDividir.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDividir.ForeColor = System.Drawing.Color.White;
            this.btnDividir.Image = ((System.Drawing.Image)(resources.GetObject("btnDividir.Image")));
            this.btnDividir.Location = new System.Drawing.Point(239, 81);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(76, 49);
            this.btnDividir.TabIndex = 13;
            this.btnDividir.UseVisualStyleBackColor = false;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnRaizQuadrada
            // 
            this.btnRaizQuadrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnRaizQuadrada.FlatAppearance.BorderSize = 0;
            this.btnRaizQuadrada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnRaizQuadrada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRaizQuadrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaizQuadrada.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaizQuadrada.ForeColor = System.Drawing.Color.White;
            this.btnRaizQuadrada.Image = ((System.Drawing.Image)(resources.GetObject("btnRaizQuadrada.Image")));
            this.btnRaizQuadrada.Location = new System.Drawing.Point(161, 81);
            this.btnRaizQuadrada.Name = "btnRaizQuadrada";
            this.btnRaizQuadrada.Size = new System.Drawing.Size(76, 49);
            this.btnRaizQuadrada.TabIndex = 12;
            this.btnRaizQuadrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRaizQuadrada.UseVisualStyleBackColor = false;
            // 
            // btnXElevado2
            // 
            this.btnXElevado2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnXElevado2.FlatAppearance.BorderSize = 0;
            this.btnXElevado2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnXElevado2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnXElevado2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXElevado2.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXElevado2.ForeColor = System.Drawing.Color.White;
            this.btnXElevado2.Location = new System.Drawing.Point(83, 81);
            this.btnXElevado2.Name = "btnXElevado2";
            this.btnXElevado2.Size = new System.Drawing.Size(76, 49);
            this.btnXElevado2.TabIndex = 11;
            this.btnXElevado2.Text = "x2";
            this.btnXElevado2.UseVisualStyleBackColor = false;
            // 
            // btn1BarraX
            // 
            this.btn1BarraX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn1BarraX.FlatAppearance.BorderSize = 0;
            this.btn1BarraX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn1BarraX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1BarraX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1BarraX.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1BarraX.ForeColor = System.Drawing.Color.White;
            this.btn1BarraX.Location = new System.Drawing.Point(5, 81);
            this.btn1BarraX.Name = "btn1BarraX";
            this.btn1BarraX.Size = new System.Drawing.Size(76, 49);
            this.btn1BarraX.TabIndex = 10;
            this.btn1BarraX.Text = "1/x";
            this.btn1BarraX.UseVisualStyleBackColor = false;
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnBackspace.FlatAppearance.BorderSize = 0;
            this.btnBackspace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnBackspace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBackspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackspace.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.Image = ((System.Drawing.Image)(resources.GetObject("btnBackspace.Image")));
            this.btnBackspace.Location = new System.Drawing.Point(239, 30);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(76, 49);
            this.btnBackspace.TabIndex = 9;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(161, 30);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(76, 49);
            this.btnC.TabIndex = 8;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(83, 30);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(76, 49);
            this.btnCE.TabIndex = 7;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPercent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(5, 30);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(76, 49);
            this.btnPercent.TabIndex = 6;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = false;
            // 
            // btnMVezes
            // 
            this.btnMVezes.Enabled = false;
            this.btnMVezes.FlatAppearance.BorderSize = 0;
            this.btnMVezes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMVezes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMVezes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMVezes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMVezes.ForeColor = System.Drawing.Color.White;
            this.btnMVezes.Location = new System.Drawing.Point(263, 0);
            this.btnMVezes.Name = "btnMVezes";
            this.btnMVezes.Size = new System.Drawing.Size(51, 28);
            this.btnMVezes.TabIndex = 5;
            this.btnMVezes.Text = "M*";
            this.btnMVezes.UseVisualStyleBackColor = true;
            // 
            // btnMS
            // 
            this.btnMS.FlatAppearance.BorderSize = 0;
            this.btnMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMS.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.ForeColor = System.Drawing.Color.White;
            this.btnMS.Location = new System.Drawing.Point(212, 0);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(51, 28);
            this.btnMS.TabIndex = 4;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = true;
            // 
            // btnMMenos
            // 
            this.btnMMenos.FlatAppearance.BorderSize = 0;
            this.btnMMenos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMMenos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMMenos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMenos.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMenos.ForeColor = System.Drawing.Color.White;
            this.btnMMenos.Location = new System.Drawing.Point(160, 0);
            this.btnMMenos.Name = "btnMMenos";
            this.btnMMenos.Size = new System.Drawing.Size(51, 28);
            this.btnMMenos.TabIndex = 3;
            this.btnMMenos.Text = "M-";
            this.btnMMenos.UseVisualStyleBackColor = true;
            // 
            // btnMMais
            // 
            this.btnMMais.FlatAppearance.BorderSize = 0;
            this.btnMMais.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMMais.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMMais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMMais.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMais.ForeColor = System.Drawing.Color.White;
            this.btnMMais.Location = new System.Drawing.Point(109, 0);
            this.btnMMais.Name = "btnMMais";
            this.btnMMais.Size = new System.Drawing.Size(51, 28);
            this.btnMMais.TabIndex = 2;
            this.btnMMais.Text = "M+";
            this.btnMMais.UseVisualStyleBackColor = true;
            // 
            // btnMR
            // 
            this.btnMR.Enabled = false;
            this.btnMR.FlatAppearance.BorderSize = 0;
            this.btnMR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMR.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.ForeColor = System.Drawing.Color.White;
            this.btnMR.Location = new System.Drawing.Point(57, 0);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(51, 28);
            this.btnMR.TabIndex = 1;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = true;
            // 
            // btnMC
            // 
            this.btnMC.Enabled = false;
            this.btnMC.FlatAppearance.BorderSize = 0;
            this.btnMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMC.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.ForeColor = System.Drawing.Color.White;
            this.btnMC.Location = new System.Drawing.Point(6, 0);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(51, 28);
            this.btnMC.TabIndex = 0;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = true;
            // 
            // lblPadrao
            // 
            this.lblPadrao.AutoSize = true;
            this.lblPadrao.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPadrao.ForeColor = System.Drawing.Color.White;
            this.lblPadrao.Location = new System.Drawing.Point(47, 6);
            this.lblPadrao.Name = "lblPadrao";
            this.lblPadrao.Size = new System.Drawing.Size(82, 29);
            this.lblPadrao.TabIndex = 11;
            this.lblPadrao.Text = "Padrão";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.pctRelogio);
            this.panelMenu.Controls.Add(this.pctRelogioBack);
            this.panelMenu.Controls.Add(this.pctMenu);
            this.panelMenu.Controls.Add(this.pctMenuBack);
            this.panelMenu.Controls.Add(this.lblPadrao);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 31);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(320, 42);
            this.panelMenu.TabIndex = 1;
            // 
            // pctRelogio
            // 
            this.pctRelogio.BackColor = System.Drawing.Color.Transparent;
            this.pctRelogio.Image = ((System.Drawing.Image)(resources.GetObject("pctRelogio.Image")));
            this.pctRelogio.Location = new System.Drawing.Point(286, 10);
            this.pctRelogio.Name = "pctRelogio";
            this.pctRelogio.Size = new System.Drawing.Size(25, 23);
            this.pctRelogio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctRelogio.TabIndex = 15;
            this.pctRelogio.TabStop = false;
            // 
            // pctRelogioBack
            // 
            this.pctRelogioBack.Location = new System.Drawing.Point(278, 1);
            this.pctRelogioBack.Name = "pctRelogioBack";
            this.pctRelogioBack.Size = new System.Drawing.Size(42, 40);
            this.pctRelogioBack.TabIndex = 16;
            this.pctRelogioBack.TabStop = false;
            this.pctRelogioBack.MouseLeave += new System.EventHandler(this.pctRelogioBack_MouseLeave);
            // 
            // pctMenu
            // 
            this.pctMenu.BackColor = System.Drawing.Color.Transparent;
            this.pctMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctMenu.Image")));
            this.pctMenu.Location = new System.Drawing.Point(9, 10);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(25, 23);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMenu.TabIndex = 10;
            this.pctMenu.TabStop = false;
            // 
            // pctMenuBack
            // 
            this.pctMenuBack.Location = new System.Drawing.Point(0, 1);
            this.pctMenuBack.Name = "pctMenuBack";
            this.pctMenuBack.Size = new System.Drawing.Size(42, 40);
            this.pctMenuBack.TabIndex = 14;
            this.pctMenuBack.TabStop = false;
            this.pctMenuBack.MouseLeave += new System.EventHandler(this.pctMenuBack_MouseLeave);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 503);
            this.Controls.Add(this.panelBotoes);
            this.Controls.Add(this.panelDisplay);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FormCalculadora";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCalculadora_KeyDown);
            this.panelBarra.ResumeLayout(false);
            this.panelBarra.PerformLayout();
            this.panelDisplay.ResumeLayout(false);
            this.panelBotoes.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelogio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRelogioBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenuBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Label lblCalculadora;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelBotoes;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnMVezes;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMMenos;
        private System.Windows.Forms.Button btnMMais;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Label lblPadrao;
        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.PictureBox pctMenuBack;
        private System.Windows.Forms.PictureBox pctRelogio;
        private System.Windows.Forms.PictureBox pctRelogioBack;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnRaizQuadrada;
        private System.Windows.Forms.Button btnXElevado2;
        private System.Windows.Forms.Button btn1BarraX;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMaisBarraMenos;
        private System.Windows.Forms.Label lblMiniDisplay;
        private System.Windows.Forms.Label lblDisplay;
    }
}

