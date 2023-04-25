namespace BattleShip
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
            btnConsola = new Button();
            txtConsola = new TextBox();
            btnMain1 = new Button();
            SuspendLayout();
            // 
            // btnConsola
            // 
            btnConsola.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnConsola.Location = new Point(12, 12);
            btnConsola.Name = "btnConsola";
            btnConsola.Size = new Size(112, 34);
            btnConsola.TabIndex = 0;
            btnConsola.Text = "Consola";
            btnConsola.UseVisualStyleBackColor = true;
            btnConsola.Click += btnConsola_Click;
            // 
            // txtConsola
            // 
            txtConsola.Location = new Point(154, 15);
            txtConsola.Multiline = true;
            txtConsola.Name = "txtConsola";
            txtConsola.Size = new Size(634, 423);
            txtConsola.TabIndex = 1;
            // 
            // btnMain1
            // 
            btnMain1.Location = new Point(12, 65);
            btnMain1.Name = "btnMain1";
            btnMain1.Size = new Size(112, 34);
            btnMain1.TabIndex = 2;
            btnMain1.Text = "Main1";
            btnMain1.UseVisualStyleBackColor = true;
            btnMain1.Click += btnMain1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMain1);
            Controls.Add(txtConsola);
            Controls.Add(btnConsola);
            Name = "Form1";
            Text = "Batallitas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConsola;
        private TextBox txtConsola;
        private Button btnMain1;
    }
}