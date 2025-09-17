namespace Assignment_4._1._2
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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            NumbersTableLayoutPanel1 = new TableLayoutPanel();
            OperatorsTableLayoutPanel2 = new TableLayoutPanel();
            AnswerGroupBox1 = new GroupBox();
            OneBtn = new Button();
            TwoBtn = new Button();
            ThreeBtn = new Button();
            FourBtn = new Button();
            FiveBtn = new Button();
            SixBtn = new Button();
            SevenBtn = new Button();
            EightBtn = new Button();
            NineBtn = new Button();
            ClearBtn = new Button();
            ZeroBtn = new Button();
            PlusBtn = new Button();
            MinusBtn = new Button();
            MultiplyBtn = new Button();
            DivideBtn = new Button();
            EqualsBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            NumbersTableLayoutPanel1.SuspendLayout();
            OperatorsTableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(AnswerGroupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(455, 384);
            splitContainer1.SplitterDistance = 118;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(NumbersTableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(OperatorsTableLayoutPanel2);
            splitContainer2.Size = new Size(455, 262);
            splitContainer2.SplitterDistance = 310;
            splitContainer2.TabIndex = 0;
            // 
            // NumbersTableLayoutPanel1
            // 
            NumbersTableLayoutPanel1.ColumnCount = 3;
            NumbersTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            NumbersTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            NumbersTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            NumbersTableLayoutPanel1.Controls.Add(ZeroBtn, 1, 3);
            NumbersTableLayoutPanel1.Controls.Add(ClearBtn, 0, 3);
            NumbersTableLayoutPanel1.Controls.Add(NineBtn, 2, 2);
            NumbersTableLayoutPanel1.Controls.Add(EightBtn, 1, 2);
            NumbersTableLayoutPanel1.Controls.Add(SevenBtn, 0, 2);
            NumbersTableLayoutPanel1.Controls.Add(SixBtn, 2, 1);
            NumbersTableLayoutPanel1.Controls.Add(FiveBtn, 1, 1);
            NumbersTableLayoutPanel1.Controls.Add(FourBtn, 0, 1);
            NumbersTableLayoutPanel1.Controls.Add(ThreeBtn, 2, 0);
            NumbersTableLayoutPanel1.Controls.Add(TwoBtn, 1, 0);
            NumbersTableLayoutPanel1.Controls.Add(OneBtn, 0, 0);
            NumbersTableLayoutPanel1.Dock = DockStyle.Fill;
            NumbersTableLayoutPanel1.Location = new Point(0, 0);
            NumbersTableLayoutPanel1.Name = "NumbersTableLayoutPanel1";
            NumbersTableLayoutPanel1.RowCount = 4;
            NumbersTableLayoutPanel1.RowStyles.Add(new RowStyle());
            NumbersTableLayoutPanel1.RowStyles.Add(new RowStyle());
            NumbersTableLayoutPanel1.RowStyles.Add(new RowStyle());
            NumbersTableLayoutPanel1.RowStyles.Add(new RowStyle());
            NumbersTableLayoutPanel1.Size = new Size(310, 262);
            NumbersTableLayoutPanel1.TabIndex = 0;
            // 
            // OperatorsTableLayoutPanel2
            // 
            OperatorsTableLayoutPanel2.ColumnCount = 1;
            OperatorsTableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
            OperatorsTableLayoutPanel2.Controls.Add(EqualsBtn, 0, 4);
            OperatorsTableLayoutPanel2.Controls.Add(DivideBtn, 0, 3);
            OperatorsTableLayoutPanel2.Controls.Add(MultiplyBtn, 0, 2);
            OperatorsTableLayoutPanel2.Controls.Add(MinusBtn, 0, 1);
            OperatorsTableLayoutPanel2.Controls.Add(PlusBtn, 0, 0);
            OperatorsTableLayoutPanel2.Dock = DockStyle.Fill;
            OperatorsTableLayoutPanel2.Location = new Point(0, 0);
            OperatorsTableLayoutPanel2.Name = "OperatorsTableLayoutPanel2";
            OperatorsTableLayoutPanel2.RowCount = 5;
            OperatorsTableLayoutPanel2.RowStyles.Add(new RowStyle());
            OperatorsTableLayoutPanel2.RowStyles.Add(new RowStyle());
            OperatorsTableLayoutPanel2.RowStyles.Add(new RowStyle());
            OperatorsTableLayoutPanel2.RowStyles.Add(new RowStyle());
            OperatorsTableLayoutPanel2.RowStyles.Add(new RowStyle());
            OperatorsTableLayoutPanel2.Size = new Size(141, 262);
            OperatorsTableLayoutPanel2.TabIndex = 0;
            // 
            // AnswerGroupBox1
            // 
            AnswerGroupBox1.AutoSize = true;
            AnswerGroupBox1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AnswerGroupBox1.Dock = DockStyle.Fill;
            AnswerGroupBox1.Location = new Point(0, 0);
            AnswerGroupBox1.Name = "AnswerGroupBox1";
            AnswerGroupBox1.RightToLeft = RightToLeft.Yes;
            AnswerGroupBox1.Size = new Size(455, 118);
            AnswerGroupBox1.TabIndex = 0;
            AnswerGroupBox1.TabStop = false;
            AnswerGroupBox1.Text = "Answer Box";
            // 
            // OneBtn
            // 
            OneBtn.AutoSize = true;
            OneBtn.Location = new Point(3, 3);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(75, 42);
            OneBtn.TabIndex = 0;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            // 
            // TwoBtn
            // 
            TwoBtn.AutoSize = true;
            TwoBtn.Location = new Point(84, 3);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(75, 42);
            TwoBtn.TabIndex = 1;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            // 
            // ThreeBtn
            // 
            ThreeBtn.AutoSize = true;
            ThreeBtn.Location = new Point(165, 3);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(75, 42);
            ThreeBtn.TabIndex = 2;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            // 
            // FourBtn
            // 
            FourBtn.AutoSize = true;
            FourBtn.Location = new Point(3, 51);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(75, 42);
            FourBtn.TabIndex = 3;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            // 
            // FiveBtn
            // 
            FiveBtn.AutoSize = true;
            FiveBtn.Location = new Point(84, 51);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(75, 42);
            FiveBtn.TabIndex = 4;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            // 
            // SixBtn
            // 
            SixBtn.AutoSize = true;
            SixBtn.Location = new Point(165, 51);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(75, 42);
            SixBtn.TabIndex = 5;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            // 
            // SevenBtn
            // 
            SevenBtn.AutoSize = true;
            SevenBtn.Location = new Point(3, 99);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(75, 42);
            SevenBtn.TabIndex = 6;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            // 
            // EightBtn
            // 
            EightBtn.AutoSize = true;
            EightBtn.Location = new Point(84, 99);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(75, 42);
            EightBtn.TabIndex = 7;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            // 
            // NineBtn
            // 
            NineBtn.AutoSize = true;
            NineBtn.Location = new Point(165, 99);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(75, 42);
            NineBtn.TabIndex = 8;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            ClearBtn.AutoSize = true;
            ClearBtn.Location = new Point(3, 147);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 42);
            ClearBtn.TabIndex = 9;
            ClearBtn.Text = "C";
            ClearBtn.UseVisualStyleBackColor = true;
            // 
            // ZeroBtn
            // 
            ZeroBtn.AutoSize = true;
            ZeroBtn.Location = new Point(84, 147);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(75, 42);
            ZeroBtn.TabIndex = 10;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            // 
            // PlusBtn
            // 
            PlusBtn.AutoSize = true;
            PlusBtn.Location = new Point(3, 3);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(75, 42);
            PlusBtn.TabIndex = 11;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            // 
            // MinusBtn
            // 
            MinusBtn.AutoSize = true;
            MinusBtn.Location = new Point(3, 51);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(75, 42);
            MinusBtn.TabIndex = 12;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            // 
            // MultiplyBtn
            // 
            MultiplyBtn.AutoSize = true;
            MultiplyBtn.Location = new Point(3, 99);
            MultiplyBtn.Name = "MultiplyBtn";
            MultiplyBtn.Size = new Size(75, 42);
            MultiplyBtn.TabIndex = 13;
            MultiplyBtn.Text = "x";
            MultiplyBtn.UseVisualStyleBackColor = true;
            // 
            // DivideBtn
            // 
            DivideBtn.AutoSize = true;
            DivideBtn.Location = new Point(3, 147);
            DivideBtn.Name = "DivideBtn";
            DivideBtn.Size = new Size(75, 42);
            DivideBtn.TabIndex = 14;
            DivideBtn.Text = "/";
            DivideBtn.UseVisualStyleBackColor = true;
            // 
            // EqualsBtn
            // 
            EqualsBtn.AutoSize = true;
            EqualsBtn.Location = new Point(3, 195);
            EqualsBtn.Name = "EqualsBtn";
            EqualsBtn.Size = new Size(75, 42);
            EqualsBtn.TabIndex = 15;
            EqualsBtn.Text = "=";
            EqualsBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 384);
            Controls.Add(splitContainer1);
            Font = new Font("Arial", 20F);
            Margin = new Padding(7, 6, 7, 6);
            Name = "Form1";
            Text = "Calculator";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            NumbersTableLayoutPanel1.ResumeLayout(false);
            NumbersTableLayoutPanel1.PerformLayout();
            OperatorsTableLayoutPanel2.ResumeLayout(false);
            OperatorsTableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox AnswerGroupBox1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel NumbersTableLayoutPanel1;
        private TableLayoutPanel OperatorsTableLayoutPanel2;
        private Button SixBtn;
        private Button FiveBtn;
        private Button FourBtn;
        private Button ThreeBtn;
        private Button TwoBtn;
        private Button OneBtn;
        private Button ZeroBtn;
        private Button ClearBtn;
        private Button NineBtn;
        private Button EightBtn;
        private Button SevenBtn;
        private Button EqualsBtn;
        private Button DivideBtn;
        private Button MultiplyBtn;
        private Button MinusBtn;
        private Button PlusBtn;
    }
}
