namespace CSharpExersices
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
            button1 = new Button();
            modalSelector = new CheckBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 0;
            button1.Text = "Nueva imagen";
            button1.UseVisualStyleBackColor = true;
            button1.MouseClick += OnNewImageClick;
            // 
            // modalSelector
            // 
            modalSelector.AutoSize = true;
            modalSelector.Location = new Point(37, 38);
            modalSelector.Name = "modalSelector";
            modalSelector.Size = new Size(67, 23);
            modalSelector.TabIndex = 1;
            modalSelector.Text = "Modal";
            modalSelector.UseVisualStyleBackColor = true;
            modalSelector.CheckedChanged += ModalSelectorCheckedChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(602, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(602, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 26);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(473, 226);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(604, 85);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(604, 161);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 10;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(37, 187);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(32, 23);
            radioButton1.TabIndex = 16;
            radioButton1.Text = "/";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(37, 158);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(33, 23);
            radioButton2.TabIndex = 15;
            radioButton2.Text = "*";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(37, 129);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(33, 23);
            radioButton3.TabIndex = 14;
            radioButton3.Text = "-";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(37, 101);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(37, 23);
            radioButton4.TabIndex = 13;
            radioButton4.TabStop = true;
            radioButton4.Text = "+";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButton1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(modalSelector);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private CheckBox modalSelector;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
    }
}
