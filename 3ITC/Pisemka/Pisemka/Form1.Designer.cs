namespace Pisemka
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
            textBox_name = new TextBox();
            button_add = new Button();
            button_remove = new Button();
            textBox_email = new TextBox();
            listBox1 = new ListBox();
            label_name = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(87, 51);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(233, 27);
            textBox_name.TabIndex = 0;
            // 
            // button_add
            // 
            button_add.Location = new Point(87, 153);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 1;
            button_add.Text = "Přidat";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // button_remove
            // 
            button_remove.Location = new Point(187, 153);
            button_remove.Name = "button_remove";
            button_remove.Size = new Size(133, 29);
            button_remove.TabIndex = 2;
            button_remove.Text = "Odeber kontakt";
            button_remove.UseVisualStyleBackColor = true;
            button_remove.Click += button_remove_Click;
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(88, 90);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(233, 27);
            textBox_email.TabIndex = 3;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(354, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 304);
            listBox1.TabIndex = 4;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(26, 51);
            label_name.Name = "label_name";
            label_name.Size = new Size(55, 20);
            label_name.TabIndex = 5;
            label_name.Text = "Jméno:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 93);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 6;
            label2.Text = "E-mail:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 359);
            Controls.Add(label2);
            Controls.Add(label_name);
            Controls.Add(listBox1);
            Controls.Add(textBox_email);
            Controls.Add(button_remove);
            Controls.Add(button_add);
            Controls.Add(textBox_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_name;
        private Button button_add;
        private Button button_remove;
        private TextBox textBox_email;
        private ListBox listBox1;
        private Label label_name;
        private Label label2;
    }
}