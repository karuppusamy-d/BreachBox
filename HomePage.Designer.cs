namespace BreachBox
{
    partial class BreachBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreachBox));
            this.input_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.submit_secure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(55, 87);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 34);
            this.submit.TabIndex = 2;
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
            this.password_input.Size = new System.Drawing.Size(270, 22);
            this.password_input.TabIndex = 1;
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
            this.input_label.TabIndex = 0;
            this.input_label.Text = "Welcome to BreachBox";
            // 
            // BreachBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 158);
            this.Controls.Add(this.input_label);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.submit_secure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BreachBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "BreachBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_label;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button submit_secure;
    }
}

