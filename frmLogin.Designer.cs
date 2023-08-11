namespace HP3
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.loginBgPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.loginTxtbUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.loginImgUser = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.loginLblTittle = new Bunifu.UI.WinForms.BunifuLabel();
            this.loginBgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // loginBgPanel
            // 
            this.loginBgPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.loginBgPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBgPanel.BackgroundImage")));
            this.loginBgPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBgPanel.BorderColor = System.Drawing.Color.Transparent;
            this.loginBgPanel.BorderRadius = 3;
            this.loginBgPanel.BorderThickness = 1;
            this.loginBgPanel.Controls.Add(this.loginTxtbUser);
            this.loginBgPanel.Controls.Add(this.loginImgUser);
            this.loginBgPanel.Controls.Add(this.loginLblTittle);
            this.loginBgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBgPanel.Location = new System.Drawing.Point(0, 0);
            this.loginBgPanel.Name = "loginBgPanel";
            this.loginBgPanel.ShowBorders = true;
            this.loginBgPanel.Size = new System.Drawing.Size(284, 361);
            this.loginBgPanel.TabIndex = 0;
            // 
            // loginTxtbUser
            // 
            this.loginTxtbUser.AcceptsReturn = false;
            this.loginTxtbUser.AcceptsTab = false;
            this.loginTxtbUser.AnimationSpeed = 200;
            this.loginTxtbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginTxtbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginTxtbUser.BackColor = System.Drawing.Color.Transparent;
            this.loginTxtbUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginTxtbUser.BackgroundImage")));
            this.loginTxtbUser.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(122)))));
            this.loginTxtbUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.loginTxtbUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            this.loginTxtbUser.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.loginTxtbUser.BorderRadius = 25;
            this.loginTxtbUser.BorderThickness = 1;
            this.loginTxtbUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginTxtbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbUser.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.loginTxtbUser.DefaultText = "";
            this.loginTxtbUser.FillColor = System.Drawing.Color.White;
            this.loginTxtbUser.HideSelection = true;
            this.loginTxtbUser.IconLeft = global::HP3.Properties.Resources.imgUserSmall2;
            this.loginTxtbUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbUser.IconPadding = 10;
            this.loginTxtbUser.IconRight = null;
            this.loginTxtbUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbUser.Lines = new string[0];
            this.loginTxtbUser.Location = new System.Drawing.Point(47, 247);
            this.loginTxtbUser.MaxLength = 32767;
            this.loginTxtbUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginTxtbUser.Modified = false;
            this.loginTxtbUser.Multiline = false;
            this.loginTxtbUser.Name = "loginTxtbUser";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(122)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbUser.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.loginTxtbUser.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbUser.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbUser.OnIdleState = stateProperties4;
            this.loginTxtbUser.Padding = new System.Windows.Forms.Padding(3);
            this.loginTxtbUser.PasswordChar = '\0';
            this.loginTxtbUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.loginTxtbUser.PlaceholderText = "Enter text";
            this.loginTxtbUser.ReadOnly = false;
            this.loginTxtbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTxtbUser.SelectedText = "";
            this.loginTxtbUser.SelectionLength = 0;
            this.loginTxtbUser.SelectionStart = 0;
            this.loginTxtbUser.ShortcutsEnabled = true;
            this.loginTxtbUser.Size = new System.Drawing.Size(175, 37);
            this.loginTxtbUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.loginTxtbUser.TabIndex = 2;
            this.loginTxtbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTxtbUser.TextMarginBottom = 0;
            this.loginTxtbUser.TextMarginLeft = 3;
            this.loginTxtbUser.TextMarginTop = 0;
            this.loginTxtbUser.TextPlaceholder = "Enter text";
            this.loginTxtbUser.UseSystemPasswordChar = false;
            this.loginTxtbUser.WordWrap = true;
            // 
            // loginImgUser
            // 
            this.loginImgUser.AllowFocused = false;
            this.loginImgUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginImgUser.AutoSizeHeight = true;
            this.loginImgUser.BorderRadius = 65;
            this.loginImgUser.Image = global::HP3.Properties.Resources.imgUser2;
            this.loginImgUser.IsCircle = true;
            this.loginImgUser.Location = new System.Drawing.Point(60, 99);
            this.loginImgUser.Name = "loginImgUser";
            this.loginImgUser.Size = new System.Drawing.Size(130, 130);
            this.loginImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginImgUser.TabIndex = 1;
            this.loginImgUser.TabStop = false;
            this.loginImgUser.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // loginLblTittle
            // 
            this.loginLblTittle.AllowParentOverrides = false;
            this.loginLblTittle.AutoEllipsis = false;
            this.loginLblTittle.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginLblTittle.CursorType = System.Windows.Forms.Cursors.Default;
            this.loginLblTittle.Font = new System.Drawing.Font("Urbanist", 18F);
            this.loginLblTittle.Location = new System.Drawing.Point(94, 62);
            this.loginLblTittle.Name = "loginLblTittle";
            this.loginLblTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginLblTittle.Size = new System.Drawing.Size(57, 31);
            this.loginLblTittle.TabIndex = 0;
            this.loginLblTittle.Text = "Login";
            this.loginLblTittle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.loginLblTittle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // frmLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.loginBgPanel);
            this.Font = new System.Drawing.Font("Urbanist", 18F);
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.loginBgPanel.ResumeLayout(false);
            this.loginBgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImgUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuPanel loginBgPanel;
        private Bunifu.UI.WinForms.BunifuPictureBox loginImgUser;
        private Bunifu.UI.WinForms.BunifuLabel loginLblTittle;
        private Bunifu.UI.WinForms.BunifuTextBox loginTxtbUser;
    }
}

