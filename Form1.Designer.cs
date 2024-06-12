namespace MAY2024JoseMariJaysonCayabyab
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
            sortBtn = new Button();
            stringBox = new TextBox();
            sortSelector = new ComboBox();
            sortedString = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // sortBtn
            // 
            sortBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sortBtn.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortBtn.Location = new Point(12, 283);
            sortBtn.Name = "sortBtn";
            sortBtn.Size = new Size(285, 63);
            sortBtn.TabIndex = 0;
            sortBtn.Text = "SORT";
            sortBtn.UseVisualStyleBackColor = true;
            sortBtn.Click += SortBtn_Click;
            // 
            // stringBox
            // 
            stringBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            stringBox.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stringBox.Location = new Point(12, 203);
            stringBox.Name = "stringBox";
            stringBox.Size = new Size(795, 28);
            stringBox.TabIndex = 1;
            // 
            // sortSelector
            // 
            sortSelector.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sortSelector.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortSelector.FormattingEnabled = true;
            sortSelector.Items.AddRange(new object[] { "BubbleSort", "MergeSort" });
            sortSelector.Location = new Point(12, 119);
            sortSelector.Name = "sortSelector";
            sortSelector.Size = new Size(217, 29);
            sortSelector.TabIndex = 2;
            sortSelector.Text = "Select Sorting Method";
            // 
            // sortedString
            // 
            sortedString.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sortedString.AutoSize = true;
            sortedString.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortedString.Location = new Point(12, 368);
            sortedString.Name = "sortedString";
            sortedString.Size = new Size(272, 21);
            sortedString.TabIndex = 3;
            sortedString.Text = "[SORTED STRING APPEARS HERE]";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(12, 84);
            label1.Name = "label1";
            label1.Size = new Size(274, 23);
            label1.TabIndex = 4;
            label1.Text = "Step 1: Select an Algorithm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(10, 165);
            label2.Name = "label2";
            label2.Size = new Size(219, 23);
            label2.TabIndex = 5;
            label2.Text = "Step 2: Input any Text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(12, 247);
            label3.Name = "label3";
            label3.Size = new Size(265, 23);
            label3.TabIndex = 6;
            label3.Text = "Step 3: Press Button to Sort";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkRed;
            label4.Location = new Point(222, 19);
            label4.Name = "label4";
            label4.Size = new Size(418, 32);
            label4.TabIndex = 7;
            label4.Text = "WELCOME TO MY APPLICATION";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(503, 422);
            label5.Name = "label5";
            label5.Size = new Size(304, 21);
            label5.TabIndex = 8;
            label5.Text = "BY: JOSE MARI JAYSON CAYABYAB";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(819, 452);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sortedString);
            Controls.Add(sortSelector);
            Controls.Add(stringBox);
            Controls.Add(sortBtn);
            Name = "Form1";
            Text = "String Sort Application";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button sortBtn;
        private TextBox stringBox;
        private ComboBox sortSelector;
        private Label sortedString;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
