namespace RandomNumberGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_generate = new System.Windows.Forms.Button();
            this.txt_minValue = new System.Windows.Forms.TextBox();
            this.txt_maxValue = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label_headline = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_generate
            // 
            this.btn_generate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_generate.Location = new System.Drawing.Point(314, 170);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(96, 42);
            this.btn_generate.TabIndex = 0;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // txt_minValue
            // 
            this.txt_minValue.Location = new System.Drawing.Point(212, 78);
            this.txt_minValue.Name = "txt_minValue";
            this.txt_minValue.Size = new System.Drawing.Size(65, 20);
            this.txt_minValue.TabIndex = 1;
            this.txt_minValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_minValue_KeyDown);
            this.txt_minValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minValue_KeyPress);
            // 
            // txt_maxValue
            // 
            this.txt_maxValue.Location = new System.Drawing.Point(322, 77);
            this.txt_maxValue.Name = "txt_maxValue";
            this.txt_maxValue.Size = new System.Drawing.Size(65, 20);
            this.txt_maxValue.TabIndex = 2;
            this.txt_maxValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_maxValue_KeyDown);
            this.txt_maxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_maxValue_KeyPress);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(212, 126);
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(65, 20);
            this.txt_result.TabIndex = 3;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(12, 170);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(96, 42);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label_headline
            // 
            this.label_headline.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_headline.Location = new System.Drawing.Point(9, 9);
            this.label_headline.Name = "label_headline";
            this.label_headline.Size = new System.Drawing.Size(401, 42);
            this.label_headline.TabIndex = 5;
            this.label_headline.Text = "Random Number Generator";
            this.label_headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generate a number between";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "and";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result.Location = new System.Drawing.Point(152, 127);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(54, 19);
            this.label_result.TabIndex = 8;
            this.label_result.Text = "Result:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 224);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_headline);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_maxValue);
            this.Controls.Add(this.txt_minValue);
            this.Controls.Add(this.btn_generate);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Random Number Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.TextBox txt_minValue;
        private System.Windows.Forms.TextBox txt_maxValue;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label_headline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_result;
    }
}

