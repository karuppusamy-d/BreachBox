namespace BreachBox
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
            this.submit = new System.Windows.Forms.Button();
            this.password_input = new System.Windows.Forms.TextBox();
            this.submit_secure = new System.Windows.Forms.Button();
            this.input_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(55, 87);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 34);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // password_input
            // 
            this.password_input.AccessibleDescription = "Enter your password";
            this.password_input.Location = new System.Drawing.Point(55, 50);
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.ShortcutsEnabled = false;
            this.password_input.Size = new System.Drawing.Size(270, 22);
            this.password_input.TabIndex = 2;
            // 
            // submit_secure
            // 
            this.submit_secure.Location = new System.Drawing.Point(136, 87);
            this.submit_secure.Name = "submit_secure";
            this.submit_secure.Size = new System.Drawing.Size(138, 34);
            this.submit_secure.TabIndex = 3;
            this.submit_secure.Text = "Submit Secure";
            this.submit_secure.UseVisualStyleBackColor = true;
            this.submit_secure.Click += new System.EventHandler(this.submit_secure_Click);
            // 
            // input_label
            // 
            this.input_label.AutoSize = true;
            this.input_label.Location = new System.Drawing.Point(52, 22);
            this.input_label.Name = "input_label";
            this.input_label.Size = new System.Drawing.Size(148, 16);
            this.input_label.TabIndex = 4;
            this.input_label.Text = "Welcome to BreachBox";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 158);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.submit_secure);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.submit);
            this.Name = "Form1";
            this.Text = "BreachBox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button submit_secure;
        private System.Windows.Forms.Label input_label;
    }
}

