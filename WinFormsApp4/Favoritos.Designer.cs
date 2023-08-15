namespace WinFormsApp4
{
    partial class Favoritos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.Location = new Point(8, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 2);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 8);
            label1.Name = "label1";
            label1.Size = new Size(115, 21);
            label1.TabIndex = 1;
            label1.Text = "Meus Favoritos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 32);
            label2.Name = "label2";
            label2.Size = new Size(229, 15);
            label2.TabIndex = 2;
            label2.Text = "Aqui você encontra a sua lista de favoritos";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(91, 86);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 199);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(216, 328);
            button1.Name = "button1";
            button1.Size = new Size(120, 24);
            button1.TabIndex = 4;
            button1.Text = "Excluir Favorito";
            button1.UseVisualStyleBackColor = true;
            // 
            // Favoritos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 370);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Favoritos";
            Text = "Favoritos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Button button1;
    }
}