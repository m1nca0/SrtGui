namespace SrtGui
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
            txtSentence = new TextBox();
            label1 = new Label();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // txtSentence
            // 
            txtSentence.Location = new Point(12, 26);
            txtSentence.Name = "txtSentence";
            txtSentence.Size = new Size(258, 23);
            txtSentence.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Исходная строка";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 55);
            button1.Name = "button1";
            button1.Size = new Size(258, 23);
            button1.TabIndex = 2;
            button1.Text = "НАЖМИ МЕНЯ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(276, 84);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtSentence);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSentence;
        private Label label1;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
    }
}
