namespace WindowsFormsFitness
{
    partial class Log_in
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_in));
            this.bttnEnter = new System.Windows.Forms.Button();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox();
            this.textBoxLogin = new MaterialSkin.Controls.MaterialTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxCapcha = new MaterialSkin.Controls.MaterialTextBox();
            this.labelCapcha = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnEnter
            // 
            this.bttnEnter.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bttnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bttnEnter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bttnEnter.Location = new System.Drawing.Point(488, 592);
            this.bttnEnter.Name = "bttnEnter";
            this.bttnEnter.Size = new System.Drawing.Size(393, 54);
            this.bttnEnter.TabIndex = 12;
            this.bttnEnter.Text = "Войти";
            this.bttnEnter.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.Hint = "Пароль";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(488, 412);
            this.textBoxPassword.MaxLength = 50;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Multiline = false;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(393, 50);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.Text = "";
            this.textBoxPassword.TrailingIcon = null;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.AnimateReadOnly = false;
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLogin.Depth = 0;
            this.textBoxLogin.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLogin.Hint = "Логин";
            this.textBoxLogin.LeadingIcon = null;
            this.textBoxLogin.Location = new System.Drawing.Point(488, 346);
            this.textBoxLogin.MaxLength = 50;
            this.textBoxLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLogin.Multiline = false;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(393, 50);
            this.textBoxLogin.TabIndex = 10;
            this.textBoxLogin.Text = "";
            this.textBoxLogin.TrailingIcon = null;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(483, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(398, 209);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxCapcha
            // 
            this.textBoxCapcha.AnimateReadOnly = false;
            this.textBoxCapcha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCapcha.Depth = 0;
            this.textBoxCapcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCapcha.Hint = "Капча";
            this.textBoxCapcha.LeadingIcon = null;
            this.textBoxCapcha.Location = new System.Drawing.Point(488, 503);
            this.textBoxCapcha.MaxLength = 50;
            this.textBoxCapcha.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCapcha.Multiline = false;
            this.textBoxCapcha.Name = "textBoxCapcha";
            this.textBoxCapcha.Size = new System.Drawing.Size(393, 50);
            this.textBoxCapcha.TabIndex = 13;
            this.textBoxCapcha.Text = "";
            this.textBoxCapcha.TrailingIcon = null;
            // 
            // labelCapcha
            // 
            this.labelCapcha.AutoSize = true;
            this.labelCapcha.Depth = 0;
            this.labelCapcha.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.labelCapcha.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelCapcha.Location = new System.Drawing.Point(643, 481);
            this.labelCapcha.MouseState = MaterialSkin.MouseState.HOVER;
            this.labelCapcha.Name = "labelCapcha";
            this.labelCapcha.Size = new System.Drawing.Size(59, 19);
            this.labelCapcha.TabIndex = 14;
            this.labelCapcha.Text = "UYyNUg";
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 760);
            this.Controls.Add(this.labelCapcha);
            this.Controls.Add(this.textBoxCapcha);
            this.Controls.Add(this.bttnEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Log_in";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnEnter;
        private MaterialSkin.Controls.MaterialTextBox textBoxPassword;
        private MaterialSkin.Controls.MaterialTextBox textBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTextBox textBoxCapcha;
        private MaterialSkin.Controls.MaterialLabel labelCapcha;
    }
}

