
namespace TestRestAPIPriority
{
    partial class FormScenario
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRunSc1 = new System.Windows.Forms.Button();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnRun2 = new System.Windows.Forms.Button();
            this.lbl4Digits = new System.Windows.Forms.Label();
            this.txt4Digits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(627, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRunSc1
            // 
            this.btnRunSc1.Location = new System.Drawing.Point(420, 11);
            this.btnRunSc1.Name = "btnRunSc1";
            this.btnRunSc1.Size = new System.Drawing.Size(75, 38);
            this.btnRunSc1.TabIndex = 8;
            this.btnRunSc1.Text = "Run 1";
            this.btnRunSc1.UseVisualStyleBackColor = true;
            this.btnRunSc1.Click += new System.EventHandler(this.btnRunSc1_Click);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(16, 81);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(686, 648);
            this.txtResponse.TabIndex = 7;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(12, 17);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(55, 20);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(110, 11);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(304, 26);
            this.txtPhone.TabIndex = 5;
            // 
            // btnRun2
            // 
            this.btnRun2.Location = new System.Drawing.Point(501, 11);
            this.btnRun2.Name = "btnRun2";
            this.btnRun2.Size = new System.Drawing.Size(75, 38);
            this.btnRun2.TabIndex = 10;
            this.btnRun2.Text = "Run 2";
            this.btnRun2.UseVisualStyleBackColor = true;
            this.btnRun2.Click += new System.EventHandler(this.btnRunSc2_Click);
            // 
            // lbl4Digits
            // 
            this.lbl4Digits.AutoSize = true;
            this.lbl4Digits.Location = new System.Drawing.Point(12, 49);
            this.lbl4Digits.Name = "lbl4Digits";
            this.lbl4Digits.Size = new System.Drawing.Size(58, 20);
            this.lbl4Digits.TabIndex = 12;
            this.lbl4Digits.Text = "4Digits";
            // 
            // txt4Digits
            // 
            this.txt4Digits.Location = new System.Drawing.Point(110, 43);
            this.txt4Digits.Name = "txt4Digits";
            this.txt4Digits.Size = new System.Drawing.Size(304, 26);
            this.txt4Digits.TabIndex = 11;
            // 
            // FormScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 759);
            this.Controls.Add(this.lbl4Digits);
            this.Controls.Add(this.txt4Digits);
            this.Controls.Add(this.btnRun2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRunSc1);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.MaximizeBox = false;
            this.Name = "FormScenario";
            this.Text = "FormScenario";
            this.Shown += new System.EventHandler(this.FormScenario_Shown);
            this.ResizeBegin += new System.EventHandler(this.FormScenario_ResizeBegin);
            this.SizeChanged += new System.EventHandler(this.FormScenario_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRunSc1;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnRun2;
        private System.Windows.Forms.Label lbl4Digits;
        private System.Windows.Forms.TextBox txt4Digits;
    }
}