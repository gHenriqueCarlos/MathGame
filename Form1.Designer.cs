namespace MathGame
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            lbPoints = new Label();
            lbErrors = new Label();
            lbLevel = new Label();
            panel2 = new Panel();
            checkBox1 = new CheckBox();
            cbRandomQuestions = new CheckBox();
            cbNextQuestion = new CheckBox();
            lbResult = new Label();
            pbTimeQuestion = new ProgressBar();
            panel3 = new Panel();
            btnNewQuestion = new Button();
            lbQuestion = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(159, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 52);
            label1.TabIndex = 0;
            label1.Text = "MathGame";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(528, 57);
            panel1.TabIndex = 1;
            // 
            // lbPoints
            // 
            lbPoints.AutoSize = true;
            lbPoints.Font = new Font("Segoe UI", 15F);
            lbPoints.ForeColor = Color.White;
            lbPoints.Location = new Point(12, 129);
            lbPoints.Name = "lbPoints";
            lbPoints.Size = new Size(120, 28);
            lbPoints.TabIndex = 2;
            lbPoints.Text = "Acertos: 100";
            // 
            // lbErrors
            // 
            lbErrors.AutoSize = true;
            lbErrors.Font = new Font("Segoe UI", 15F);
            lbErrors.ForeColor = Color.White;
            lbErrors.Location = new Point(230, 129);
            lbErrors.Name = "lbErrors";
            lbErrors.Size = new Size(98, 28);
            lbErrors.TabIndex = 3;
            lbErrors.Text = "Erros: 100";
            // 
            // lbLevel
            // 
            lbLevel.AutoSize = true;
            lbLevel.Font = new Font("Segoe UI", 15F);
            lbLevel.ForeColor = Color.White;
            lbLevel.Location = new Point(442, 129);
            lbLevel.Name = "lbLevel";
            lbLevel.Size = new Size(88, 28);
            lbLevel.TabIndex = 4;
            lbLevel.Text = "Nível: 10";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(49, 51, 56);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(cbRandomQuestions);
            panel2.Controls.Add(cbNextQuestion);
            panel2.Controls.Add(lbResult);
            panel2.Controls.Add(pbTimeQuestion);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(12, 207);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 354);
            panel2.TabIndex = 5;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(165, 332);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(212, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Próxima questão automaticamente";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbRandomQuestions
            // 
            cbRandomQuestions.AutoSize = true;
            cbRandomQuestions.Checked = true;
            cbRandomQuestions.CheckState = CheckState.Checked;
            cbRandomQuestions.ForeColor = Color.White;
            cbRandomQuestions.Location = new Point(384, 332);
            cbRandomQuestions.Name = "cbRandomQuestions";
            cbRandomQuestions.Size = new Size(121, 19);
            cbRandomQuestions.TabIndex = 6;
            cbRandomQuestions.Text = "Questões Diversas";
            cbRandomQuestions.UseVisualStyleBackColor = true;
            // 
            // cbNextQuestion
            // 
            cbNextQuestion.AutoSize = true;
            cbNextQuestion.Checked = true;
            cbNextQuestion.CheckState = CheckState.Checked;
            cbNextQuestion.ForeColor = Color.White;
            cbNextQuestion.Location = new Point(19, 332);
            cbNextQuestion.Name = "cbNextQuestion";
            cbNextQuestion.Size = new Size(144, 19);
            cbNextQuestion.TabIndex = 5;
            cbNextQuestion.Text = "Tempo para responder";
            cbNextQuestion.UseVisualStyleBackColor = true;
            cbNextQuestion.CheckedChanged += cbTimeToRespond_CheckedChanged;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new Font("Segoe UI", 22F);
            lbResult.ForeColor = Color.White;
            lbResult.Location = new Point(137, 167);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(253, 41);
            lbResult.TabIndex = 2;
            lbResult.Text = "Resposta Correta!";
            // 
            // pbTimeQuestion
            // 
            pbTimeQuestion.Location = new Point(19, 211);
            pbTimeQuestion.Name = "pbTimeQuestion";
            pbTimeQuestion.Size = new Size(486, 23);
            pbTimeQuestion.TabIndex = 4;
            pbTimeQuestion.Click += pbTimeQuestion_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnNewQuestion);
            panel3.Controls.Add(lbQuestion);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(528, 133);
            panel3.TabIndex = 3;
            // 
            // btnNewQuestion
            // 
            btnNewQuestion.Font = new Font("Segoe UI", 12F);
            btnNewQuestion.Location = new Point(444, 3);
            btnNewQuestion.Name = "btnNewQuestion";
            btnNewQuestion.Size = new Size(81, 56);
            btnNewQuestion.TabIndex = 3;
            btnNewQuestion.Text = "Nova Questão";
            btnNewQuestion.UseVisualStyleBackColor = true;
            btnNewQuestion.Click += btnNewQuestion_Click;
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Segoe UI", 30F);
            lbQuestion.ForeColor = Color.White;
            lbQuestion.Location = new Point(3, 56);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(173, 54);
            lbQuestion.TabIndex = 1;
            lbQuestion.Text = "100x100";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 22F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(295, 41);
            label5.TabIndex = 0;
            label5.Text = "Responda a questão:";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(button4, 3, 0);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button1, 1, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 0);
            tableLayoutPanel1.Location = new Point(16, 251);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(512, 78);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(387, 3);
            button4.Name = "button4";
            button4.Size = new Size(102, 69);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(259, 3);
            button3.Name = "button3";
            button3.Size = new Size(102, 69);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(131, 3);
            button1.Name = "button1";
            button1.Size = new Size(102, 69);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(102, 69);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // timer2
            // 
            timer2.Interval = 2000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 31, 34);
            ClientSize = new Size(552, 573);
            Controls.Add(panel2);
            Controls.Add(lbLevel);
            Controls.Add(lbErrors);
            Controls.Add(lbPoints);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label lbPoints;
        private Label lbErrors;
        private Label lbLevel;
        private Panel panel2;
        private Label lbQuestion;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Button button2;
        private Label label5;
        private Panel panel3;
        private ProgressBar pbTimeQuestion;
        private Label lbResult;
        private CheckBox cbNextQuestion;
        private CheckBox cbRandomQuestions;
        private Button btnNewQuestion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CheckBox checkBox1;
    }
}
