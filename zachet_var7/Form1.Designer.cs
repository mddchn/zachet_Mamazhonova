
namespace zachet_var7
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
        protected override void Dispose (bool disposing)
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
        private void InitializeComponent ()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.deleteButton_Click = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Объединение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton_Click
            // 
            this.deleteButton_Click.Location = new System.Drawing.Point(53, 209);
            this.deleteButton_Click.Name = "deleteButton_Click";
            this.deleteButton_Click.Size = new System.Drawing.Size(147, 32);
            this.deleteButton_Click.TabIndex = 1;
            this.deleteButton_Click.Text = "Удаление";
            this.deleteButton_Click.UseVisualStyleBackColor = true;
            this.deleteButton_Click.Click += new System.EventHandler(this.deleteButton_Click_Click);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Печенье",
            "Шоколад",
            "Масло сливочное",
            "Масло оливковое"});
            this.groupComboBox.Location = new System.Drawing.Point(53, 60);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(185, 23);
            this.groupComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.deleteButton_Click);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button deleteButton_Click;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label1;
    }
}

