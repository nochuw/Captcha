namespace PR4.Models
{
    partial class CaptchForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.LabelCaptch = new System.Windows.Forms.Label();
            this.textBoxCaptch = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(305, 190);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(162, 45);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обновить капчу";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // LabelCaptch
            // 
            this.LabelCaptch.AutoSize = true;
            this.LabelCaptch.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelCaptch.Location = new System.Drawing.Point(306, 60);
            this.LabelCaptch.Name = "LabelCaptch";
            this.LabelCaptch.Size = new System.Drawing.Size(152, 76);
            this.LabelCaptch.TabIndex = 1;
            this.LabelCaptch.Text = "label1";
            // 
            // textBoxCaptch
            // 
            this.textBoxCaptch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCaptch.Location = new System.Drawing.Point(234, 307);
            this.textBoxCaptch.Name = "textBoxCaptch";
            this.textBoxCaptch.Size = new System.Drawing.Size(309, 29);
            this.textBoxCaptch.TabIndex = 2;
            this.textBoxCaptch.TextChanged += new System.EventHandler(this.textBoxCaptch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CaptchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 448);
            this.Controls.Add(this.textBoxCaptch);
            this.Controls.Add(this.LabelCaptch);
            this.Controls.Add(this.buttonUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaptchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CaptchForm";
            this.Load += new System.EventHandler(this.CaptchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label LabelCaptch;
        private System.Windows.Forms.TextBox textBoxCaptch;
        private System.Windows.Forms.Timer timer1;
    }
}