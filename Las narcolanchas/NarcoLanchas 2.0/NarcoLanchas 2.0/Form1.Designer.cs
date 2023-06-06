namespace NarcoLanchas_2._0
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
            btnMain1 = new Button();
            btnMain2 = new Button();
            textBox1 = new TextBox();
            btnConsola = new Button();
            btnMain3 = new Button();
            btnMain4 = new Button();
            SuspendLayout();
            // 
            // btnMain1
            // 
            btnMain1.Location = new Point(12, 161);
            btnMain1.Name = "btnMain1";
            btnMain1.Size = new Size(133, 50);
            btnMain1.TabIndex = 0;
            btnMain1.Text = "Main1";
            btnMain1.UseVisualStyleBackColor = true;
            // 
            // btnMain2
            // 
            btnMain2.Location = new Point(12, 329);
            btnMain2.Name = "btnMain2";
            btnMain2.Size = new Size(133, 50);
            btnMain2.TabIndex = 1;
            btnMain2.Text = "Main 2";
            btnMain2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1233, 689);
            textBox1.TabIndex = 2;
            // 
            // btnConsola
            // 
            btnConsola.Location = new Point(12, 12);
            btnConsola.Name = "btnConsola";
            btnConsola.Size = new Size(133, 50);
            btnConsola.TabIndex = 3;
            btnConsola.Text = "Clear Cons.";
            btnConsola.UseVisualStyleBackColor = true;
            // 
            // btnMain3
            // 
            btnMain3.Location = new Point(12, 502);
            btnMain3.Name = "btnMain3";
            btnMain3.Size = new Size(133, 50);
            btnMain3.TabIndex = 4;
            btnMain3.Text = "Main 3";
            btnMain3.UseVisualStyleBackColor = true;
            // 
            // btnMain4
            // 
            btnMain4.Location = new Point(12, 651);
            btnMain4.Name = "btnMain4";
            btnMain4.Size = new Size(133, 50);
            btnMain4.TabIndex = 5;
            btnMain4.Text = "P4 Battle";
            btnMain4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 713);
            Controls.Add(btnMain4);
            Controls.Add(btnMain3);
            Controls.Add(btnConsola);
            Controls.Add(textBox1);
            Controls.Add(btnMain2);
            Controls.Add(btnMain1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMain1;
        private Button btnMain2;
        private TextBox textBox1;
        private Button btnConsola;
        private Button btnMain3;
        private Button btnMain4;
    }
}