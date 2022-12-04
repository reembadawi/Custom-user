namespace Custom_User_Controls
{
    partial class Form1
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
            this.usestate1 = new Custom_User_Controls.Usestate();
            this.btnFetState = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usestate1
            // 
            this.usestate1.Location = new System.Drawing.Point(37, 35);
            this.usestate1.Name = "usestate1";
            this.usestate1.Size = new System.Drawing.Size(356, 38);
            this.usestate1.TabIndex = 0;
            // 
            // btnFetState
            // 
            this.btnFetState.Location = new System.Drawing.Point(177, 191);
            this.btnFetState.Name = "btnFetState";
            this.btnFetState.Size = new System.Drawing.Size(75, 23);
            this.btnFetState.TabIndex = 1;
            this.btnFetState.Text = "State";
            this.btnFetState.UseVisualStyleBackColor = true;
            this.btnFetState.Click += new System.EventHandler(this.btnFetState_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 450);
            this.Controls.Add(this.btnFetState);
            this.Controls.Add(this.usestate1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Usestate usestate1;
        private System.Windows.Forms.Button btnFetState;
    }
}

