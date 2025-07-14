namespace Counting_Project_Example
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
            label1 = new Label();
            label2 = new Label();
            textEntry1 = new TextBox();
            resultBox = new TextBox();
            textEntry2 = new TextBox();
            label3 = new Label();
            addButton = new Button();
            subButton = new Button();
            multButton = new Button();
            divButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 74);
            label1.Name = "label1";
            label1.Size = new Size(113, 38);
            label1.TabIndex = 0;
            label1.Text = "ENTRY:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(392, 74);
            label2.Name = "label2";
            label2.Size = new Size(122, 38);
            label2.TabIndex = 1;
            label2.Text = "RESULT:";
            // 
            // textEntry1
            // 
            textEntry1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEntry1.Location = new Point(150, 74);
            textEntry1.Name = "textEntry1";
            textEntry1.Size = new Size(194, 43);
            textEntry1.TabIndex = 2;
            textEntry1.TextChanged += textBox1_TextChanged;
            // 
            // resultBox
            // 
            resultBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            resultBox.Location = new Point(520, 74);
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(236, 43);
            resultBox.TabIndex = 3;
            resultBox.TextChanged += textBox2_TextChanged;
            // 
            // textEntry2
            // 
            textEntry2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textEntry2.Location = new Point(174, 161);
            textEntry2.Name = "textEntry2";
            textEntry2.Size = new Size(170, 43);
            textEntry2.TabIndex = 4;
            textEntry2.TextChanged += textBox3_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 164);
            label3.Name = "label3";
            label3.Size = new Size(137, 38);
            label3.TabIndex = 5;
            label3.Text = "ENTRY 2:";
            label3.Click += label3_Click;
            // 
            // addButton
            // 
            addButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(31, 245);
            addButton.Name = "addButton";
            addButton.Size = new Size(60, 60);
            addButton.TabIndex = 6;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // subButton
            // 
            subButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            subButton.Location = new Point(97, 245);
            subButton.Name = "subButton";
            subButton.Size = new Size(60, 60);
            subButton.TabIndex = 7;
            subButton.Text = "-";
            subButton.UseVisualStyleBackColor = true;
            subButton.Click += button2_Click;
            // 
            // multButton
            // 
            multButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            multButton.Location = new Point(163, 245);
            multButton.Name = "multButton";
            multButton.Size = new Size(60, 60);
            multButton.TabIndex = 8;
            multButton.Text = "*";
            multButton.UseVisualStyleBackColor = true;
            multButton.Click += button3_Click;
            // 
            // divButton
            // 
            divButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            divButton.Location = new Point(229, 245);
            divButton.Name = "divButton";
            divButton.Size = new Size(60, 60);
            divButton.TabIndex = 9;
            divButton.Text = "/";
            divButton.UseVisualStyleBackColor = true;
            divButton.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(divButton);
            Controls.Add(multButton);
            Controls.Add(subButton);
            Controls.Add(addButton);
            Controls.Add(label3);
            Controls.Add(textEntry2);
            Controls.Add(resultBox);
            Controls.Add(textEntry1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textEntry1;
        private TextBox resultBox;
        private TextBox textEntry2;
        private Label label3;
        private Button addButton;
        private Button subButton;
        private Button multButton;
        private Button divButton;
    }
}
