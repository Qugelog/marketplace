
namespace MarketPlace
{
    partial class Register
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
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.passwordtexBox = new System.Windows.Forms.TextBox();
            this.confPassLabel = new System.Windows.Forms.Label();
            this.confirmPasstextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(37, 29);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(41, 14);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginLabel.Location = new System.Drawing.Point(37, 79);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(32, 14);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "Ник";
            this.loginLabel.Click += new System.EventHandler(this.loginLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordLabel.Location = new System.Drawing.Point(37, 129);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(51, 14);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Пароль";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(102, 26);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(341, 20);
            this.emailtextBox.TabIndex = 3;
            this.emailtextBox.TextChanged += new System.EventHandler(this.emailtextBox_TextChanged);
            // 
            // usernametextBox
            // 
            this.usernametextBox.Location = new System.Drawing.Point(102, 76);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(341, 20);
            this.usernametextBox.TabIndex = 4;
            // 
            // passwordtexBox
            // 
            this.passwordtexBox.Location = new System.Drawing.Point(102, 126);
            this.passwordtexBox.Name = "passwordtexBox";
            this.passwordtexBox.PasswordChar = '*';
            this.passwordtexBox.Size = new System.Drawing.Size(341, 20);
            this.passwordtexBox.TabIndex = 5;
            // 
            // confPassLabel
            // 
            this.confPassLabel.AutoSize = true;
            this.confPassLabel.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confPassLabel.Location = new System.Drawing.Point(36, 173);
            this.confPassLabel.Name = "confPassLabel";
            this.confPassLabel.Size = new System.Drawing.Size(52, 28);
            this.confPassLabel.TabIndex = 6;
            this.confPassLabel.Text = "Повтор \r\nпароля";
            // 
            // confirmPasstextBox
            // 
            this.confirmPasstextBox.Location = new System.Drawing.Point(102, 176);
            this.confirmPasstextBox.Name = "confirmPasstextBox";
            this.confirmPasstextBox.PasswordChar = '*';
            this.confirmPasstextBox.Size = new System.Drawing.Size(341, 20);
            this.confirmPasstextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(180, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 25);
            this.button1.TabIndex = 8;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 310);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.confirmPasstextBox);
            this.Controls.Add(this.confPassLabel);
            this.Controls.Add(this.passwordtexBox);
            this.Controls.Add(this.usernametextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "Register";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox passwordtexBox;
        private System.Windows.Forms.Label confPassLabel;
        private System.Windows.Forms.TextBox confirmPasstextBox;
        private System.Windows.Forms.Button button1;
    }
}