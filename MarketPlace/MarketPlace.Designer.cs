
namespace MarketPlace
{
    partial class MarketPlace
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.userTab = new System.Windows.Forms.TabControl();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.balanceLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.userTab.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTab
            // 
            this.userTab.Controls.Add(this.profileTab);
            this.userTab.Controls.Add(this.tabPage2);
            this.userTab.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTab.Location = new System.Drawing.Point(-1, -1);
            this.userTab.Name = "userTab";
            this.userTab.SelectedIndex = 0;
            this.userTab.Size = new System.Drawing.Size(805, 453);
            this.userTab.TabIndex = 0;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.balanceLabel);
            this.profileTab.Controls.Add(this.usernameLabel);
            this.profileTab.Location = new System.Drawing.Point(4, 23);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(797, 426);
            this.profileTab.TabIndex = 0;
            this.profileTab.Text = "Профиль";
            this.profileTab.UseVisualStyleBackColor = true;
            this.profileTab.Click += new System.EventHandler(this.profileTab_Click);
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(51, 42);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(50, 14);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Баланс";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(48, 7);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(32, 14);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "Ник";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MarketPlace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userTab);
            this.Name = "MarketPlace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarketPlace";
            this.Load += new System.EventHandler(this.MarketPlace_Load);
            this.userTab.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.profileTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl userTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.Label usernameLabel;
    }
}

