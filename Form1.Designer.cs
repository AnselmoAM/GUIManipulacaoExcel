namespace GUIManipulaçãoExcel
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
            TableLayoutPanel tableLayoutPanel1;
            txtOrigem = new TextBox();
            btnSelecionarDestino = new Button();
            btnSelecionarOrigem = new Button();
            txtDestino = new TextBox();
            btnAtualizar = new Button();
            cmbAbaDestino = new ComboBox();
            lblAbaDestino = new Label();
            txtLog = new TextBox();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(txtOrigem, 0, 0);
            tableLayoutPanel1.Controls.Add(btnSelecionarDestino, 0, 6);
            tableLayoutPanel1.Controls.Add(btnSelecionarOrigem, 0, 2);
            tableLayoutPanel1.Controls.Add(txtDestino, 0, 4);
            tableLayoutPanel1.Controls.Add(btnAtualizar, 0, 11);
            tableLayoutPanel1.Controls.Add(cmbAbaDestino, 0, 9);
            tableLayoutPanel1.Controls.Add(lblAbaDestino, 0, 8);
            tableLayoutPanel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(38, 30);
            tableLayoutPanel1.MinimumSize = new Size(0, 26);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.Size = new Size(479, 269);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txtOrigem
            // 
            txtOrigem.Anchor = AnchorStyles.None;
            txtOrigem.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOrigem.Location = new Point(19, 3);
            txtOrigem.Name = "txtOrigem";
            txtOrigem.Size = new Size(441, 25);
            txtOrigem.TabIndex = 2;
            txtOrigem.TextChanged += textBox1_TextChanged;
            // 
            // btnSelecionarDestino
            // 
            btnSelecionarDestino.Anchor = AnchorStyles.None;
            btnSelecionarDestino.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelecionarDestino.Location = new Point(183, 133);
            btnSelecionarDestino.Name = "btnSelecionarDestino";
            btnSelecionarDestino.Size = new Size(112, 24);
            btnSelecionarDestino.TabIndex = 1;
            btnSelecionarDestino.Text = "Selecionar Destino";
            btnSelecionarDestino.UseVisualStyleBackColor = true;
            btnSelecionarDestino.Click += btnSelecionarDestino_Click;
            // 
            // btnSelecionarOrigem
            // 
            btnSelecionarOrigem.Anchor = AnchorStyles.None;
            btnSelecionarOrigem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelecionarOrigem.Location = new Point(183, 43);
            btnSelecionarOrigem.Name = "btnSelecionarOrigem";
            btnSelecionarOrigem.Size = new Size(112, 24);
            btnSelecionarOrigem.TabIndex = 0;
            btnSelecionarOrigem.Text = "Selecionar Origem";
            btnSelecionarOrigem.UseVisualStyleBackColor = true;
            btnSelecionarOrigem.Click += btnSelecionarOrigem_Click;
            // 
            // txtDestino
            // 
            txtDestino.Anchor = AnchorStyles.None;
            txtDestino.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDestino.Location = new Point(19, 93);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(441, 25);
            txtDestino.TabIndex = 3;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Anchor = AnchorStyles.None;
            btnAtualizar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(183, 240);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(112, 24);
            btnAtualizar.TabIndex = 5;
            btnAtualizar.Text = "Atualizar Dados";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // cmbAbaDestino
            // 
            cmbAbaDestino.Anchor = AnchorStyles.None;
            cmbAbaDestino.CausesValidation = false;
            cmbAbaDestino.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAbaDestino.FormattingEnabled = true;
            cmbAbaDestino.Location = new Point(164, 198);
            cmbAbaDestino.Name = "cmbAbaDestino";
            cmbAbaDestino.Size = new Size(150, 25);
            cmbAbaDestino.TabIndex = 4;
            cmbAbaDestino.Text = "          Aguarde...";
            cmbAbaDestino.SelectedIndexChanged += cmbAbaDestino_SelectedIndexChanged;
            // 
            // lblAbaDestino
            // 
            lblAbaDestino.Anchor = AnchorStyles.Bottom;
            lblAbaDestino.AutoSize = true;
            lblAbaDestino.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAbaDestino.Location = new Point(165, 182);
            lblAbaDestino.Name = "lblAbaDestino";
            lblAbaDestino.Size = new Size(149, 13);
            lblAbaDestino.TabIndex = 6;
            lblAbaDestino.Text = "Aba da Planilha de Destino:";
            // 
            // txtLog
            // 
            txtLog.BorderStyle = BorderStyle.FixedSingle;
            txtLog.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLog.Location = new Point(0, 317);
            txtLog.Multiline = true;
            txtLog.Name = "txtLog";
            txtLog.ReadOnly = true;
            txtLog.ScrollBars = ScrollBars.Vertical;
            txtLog.Size = new Size(799, 132);
            txtLog.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.None;
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(120, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(558, 305);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Planilhas (somente .xlsx)";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(799, 311);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(txtLog);
            Name = "Form1";
            Text = "Atualização de Dados";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSelecionarOrigem;
        private Button btnSelecionarDestino;
        private TextBox txtOrigem;
        private TextBox txtDestino;
        private ComboBox cmbAbaDestino;
        private Button btnAtualizar;
        private TextBox txtLog;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblAbaDestino;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
