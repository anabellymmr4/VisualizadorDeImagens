namespace VisualizadorDeImagens
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ShowBtn = new Button();
            ClearBtn = new Button();
            BackgroundBtn = new Button();
            CloseBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(886, 571);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(880, 507);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 516);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(60, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Esticar";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(ShowBtn);
            flowLayoutPanel1.Controls.Add(ClearBtn);
            flowLayoutPanel1.Controls.Add(BackgroundBtn);
            flowLayoutPanel1.Controls.Add(CloseBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(135, 516);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(748, 52);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // ShowBtn
            // 
            ShowBtn.AutoSize = true;
            ShowBtn.Location = new Point(579, 3);
            ShowBtn.Name = "ShowBtn";
            ShowBtn.Size = new Size(166, 25);
            ShowBtn.TabIndex = 0;
            ShowBtn.Text = "Mostrar uma imagem";
            ShowBtn.UseVisualStyleBackColor = true;
            ShowBtn.Click += ShowBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Location = new Point(455, 3);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(118, 25);
            ClearBtn.TabIndex = 1;
            ClearBtn.Text = "Limpar imagem ";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // BackgroundBtn
            // 
            BackgroundBtn.AutoSize = true;
            BackgroundBtn.Location = new Point(271, 3);
            BackgroundBtn.Name = "BackgroundBtn";
            BackgroundBtn.Size = new Size(178, 25);
            BackgroundBtn.TabIndex = 2;
            BackgroundBtn.Text = "Definir cor da tela de fundo ";
            BackgroundBtn.UseVisualStyleBackColor = true;
            BackgroundBtn.Click += BackgroundBtn_Click;
            // 
            // CloseBtn
            // 
            CloseBtn.AutoSize = true;
            CloseBtn.Location = new Point(168, 3);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(97, 25);
            CloseBtn.TabIndex = 3;
            CloseBtn.Text = "Fechar";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += button4_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 571);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Visualizador de Imagens";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button ShowBtn;
        private Button ClearBtn;
        private Button BackgroundBtn;
        private Button CloseBtn;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
