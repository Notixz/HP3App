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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.loginBgPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.loginBttStart = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.loginTxtbPassword = new Bunifu.UI.WinForms.BunifuTextBox();
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
            this.loginBgPanel.Controls.Add(this.loginBttStart);
            this.loginBgPanel.Controls.Add(this.loginTxtbPassword);
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
            // loginBttStart
            // 
            this.loginBttStart.AllowAnimations = true;
            this.loginBttStart.AllowMouseEffects = true;
            this.loginBttStart.AllowToggling = false;
            this.loginBttStart.AnimationSpeed = 200;
            this.loginBttStart.AutoGenerateColors = false;
            this.loginBttStart.AutoRoundBorders = false;
            this.loginBttStart.AutoSizeLeftIcon = true;
            this.loginBttStart.AutoSizeRightIcon = true;
            this.loginBttStart.BackColor = System.Drawing.Color.Transparent;
            this.loginBttStart.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.loginBttStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBttStart.BackgroundImage")));
            this.loginBttStart.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBttStart.ButtonText = "Iniciar";
            this.loginBttStart.ButtonTextMarginLeft = 0;
            this.loginBttStart.ColorContrastOnClick = 45;
            this.loginBttStart.ColorContrastOnHover = 45;
            this.loginBttStart.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.loginBttStart.CustomizableEdges = borderEdges1;
            this.loginBttStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.loginBttStart.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBttStart.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBttStart.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBttStart.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.loginBttStart.Font = new System.Drawing.Font("Urbanist", 12F);
            this.loginBttStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.loginBttStart.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginBttStart.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.loginBttStart.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.loginBttStart.IconMarginLeft = 11;
            this.loginBttStart.IconPadding = 10;
            this.loginBttStart.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.loginBttStart.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.loginBttStart.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.loginBttStart.IconSize = 25;
            this.loginBttStart.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.loginBttStart.IdleBorderRadius = 20;
            this.loginBttStart.IdleBorderThickness = 1;
            this.loginBttStart.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.loginBttStart.IdleIconLeftImage = null;
            this.loginBttStart.IdleIconRightImage = null;
            this.loginBttStart.IndicateFocus = false;
            this.loginBttStart.Location = new System.Drawing.Point(80, 300);
            this.loginBttStart.Name = "loginBttStart";
            this.loginBttStart.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.loginBttStart.OnDisabledState.BorderRadius = 20;
            this.loginBttStart.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBttStart.OnDisabledState.BorderThickness = 1;
            this.loginBttStart.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.loginBttStart.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.loginBttStart.OnDisabledState.IconLeftImage = null;
            this.loginBttStart.OnDisabledState.IconRightImage = null;
            this.loginBttStart.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(48)))));
            this.loginBttStart.onHoverState.BorderRadius = 20;
            this.loginBttStart.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBttStart.onHoverState.BorderThickness = 1;
            this.loginBttStart.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(139)))), ((int)(((byte)(178)))));
            this.loginBttStart.onHoverState.ForeColor = System.Drawing.Color.White;
            this.loginBttStart.onHoverState.IconLeftImage = null;
            this.loginBttStart.onHoverState.IconRightImage = null;
            this.loginBttStart.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.loginBttStart.OnIdleState.BorderRadius = 20;
            this.loginBttStart.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBttStart.OnIdleState.BorderThickness = 1;
            this.loginBttStart.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(124)))));
            this.loginBttStart.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.loginBttStart.OnIdleState.IconLeftImage = null;
            this.loginBttStart.OnIdleState.IconRightImage = null;
            this.loginBttStart.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBttStart.OnPressedState.BorderRadius = 20;
            this.loginBttStart.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.loginBttStart.OnPressedState.BorderThickness = 1;
            this.loginBttStart.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.loginBttStart.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.loginBttStart.OnPressedState.IconLeftImage = null;
            this.loginBttStart.OnPressedState.IconRightImage = null;
            this.loginBttStart.Size = new System.Drawing.Size(125, 30);
            this.loginBttStart.TabIndex = 2;
            this.loginBttStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBttStart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginBttStart.TextMarginLeft = 0;
            this.loginBttStart.TextPadding = new System.Windows.Forms.Padding(0);
            this.loginBttStart.UseDefaultRadiusAndThickness = true;
            this.loginBttStart.Click += new System.EventHandler(this.loginBttStart_Click);
            // 
            // loginTxtbPassword
            // 
            this.loginTxtbPassword.AcceptsReturn = false;
            this.loginTxtbPassword.AcceptsTab = true;
            this.loginTxtbPassword.AnimationSpeed = 200;
            this.loginTxtbPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginTxtbPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginTxtbPassword.BackColor = System.Drawing.Color.Transparent;
            this.loginTxtbPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginTxtbPassword.BackgroundImage")));
            this.loginTxtbPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(122)))));
            this.loginTxtbPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.loginTxtbPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            this.loginTxtbPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            this.loginTxtbPassword.BorderRadius = 25;
            this.loginTxtbPassword.BorderThickness = 1;
            this.loginTxtbPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginTxtbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbPassword.DefaultFont = new System.Drawing.Font("Urbanist", 11F);
            this.loginTxtbPassword.DefaultText = "";
            this.loginTxtbPassword.FillColor = System.Drawing.Color.White;
            this.loginTxtbPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginTxtbPassword.HideSelection = true;
            this.loginTxtbPassword.IconLeft = global::HP3.Properties.Resources.icoPasswordBlack;
            this.loginTxtbPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbPassword.IconPadding = 8;
            this.loginTxtbPassword.IconRight = null;
            this.loginTxtbPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbPassword.Lines = new string[0];
            this.loginTxtbPassword.Location = new System.Drawing.Point(55, 251);
            this.loginTxtbPassword.MaxLength = 32767;
            this.loginTxtbPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginTxtbPassword.Modified = false;
            this.loginTxtbPassword.Multiline = false;
            this.loginTxtbPassword.Name = "loginTxtbPassword";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(122)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.loginTxtbPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbPassword.OnIdleState = stateProperties4;
            this.loginTxtbPassword.Padding = new System.Windows.Forms.Padding(3);
            this.loginTxtbPassword.PasswordChar = '\0';
            this.loginTxtbPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.loginTxtbPassword.PlaceholderText = "Contraseña";
            this.loginTxtbPassword.ReadOnly = false;
            this.loginTxtbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTxtbPassword.SelectedText = "";
            this.loginTxtbPassword.SelectionLength = 0;
            this.loginTxtbPassword.SelectionStart = 0;
            this.loginTxtbPassword.ShortcutsEnabled = true;
            this.loginTxtbPassword.Size = new System.Drawing.Size(175, 36);
            this.loginTxtbPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.loginTxtbPassword.TabIndex = 1;
            this.loginTxtbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTxtbPassword.TextMarginBottom = 0;
            this.loginTxtbPassword.TextMarginLeft = 10;
            this.loginTxtbPassword.TextMarginTop = -1;
            this.loginTxtbPassword.TextPlaceholder = "Contraseña";
            this.loginTxtbPassword.UseSystemPasswordChar = false;
            this.loginTxtbPassword.WordWrap = true;
            // 
            // loginTxtbUser
            // 
            this.loginTxtbUser.AcceptsReturn = false;
            this.loginTxtbUser.AcceptsTab = true;
            this.loginTxtbUser.AnimationSpeed = 200;
            this.loginTxtbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.loginTxtbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.loginTxtbUser.AutoScrollMargin = new System.Drawing.Size(0, 10);
            this.loginTxtbUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
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
            this.loginTxtbUser.DefaultFont = new System.Drawing.Font("Urbanist", 11F);
            this.loginTxtbUser.DefaultText = "";
            this.loginTxtbUser.FillColor = System.Drawing.Color.White;
            this.loginTxtbUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginTxtbUser.HideSelection = true;
            this.loginTxtbUser.IconLeft = global::HP3.Properties.Resources.icoMailBlack;
            this.loginTxtbUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbUser.IconPadding = 8;
            this.loginTxtbUser.IconRight = null;
            this.loginTxtbUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTxtbUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.loginTxtbUser.Lines = new string[0];
            this.loginTxtbUser.Location = new System.Drawing.Point(55, 210);
            this.loginTxtbUser.MaxLength = 32767;
            this.loginTxtbUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.loginTxtbUser.Modified = false;
            this.loginTxtbUser.Multiline = false;
            this.loginTxtbUser.Name = "loginTxtbUser";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(61)))), ((int)(((byte)(122)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbUser.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.loginTxtbUser.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(90)))), ((int)(((byte)(153)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbUser.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(13)))), ((int)(((byte)(37)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ControlText;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.loginTxtbUser.OnIdleState = stateProperties8;
            this.loginTxtbUser.Padding = new System.Windows.Forms.Padding(3);
            this.loginTxtbUser.PasswordChar = '\0';
            this.loginTxtbUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.loginTxtbUser.PlaceholderText = "Usuario";
            this.loginTxtbUser.ReadOnly = false;
            this.loginTxtbUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTxtbUser.SelectedText = "";
            this.loginTxtbUser.SelectionLength = 0;
            this.loginTxtbUser.SelectionStart = 0;
            this.loginTxtbUser.ShortcutsEnabled = true;
            this.loginTxtbUser.Size = new System.Drawing.Size(175, 36);
            this.loginTxtbUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.loginTxtbUser.TabIndex = 0;
            this.loginTxtbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginTxtbUser.TextMarginBottom = 0;
            this.loginTxtbUser.TextMarginLeft = 10;
            this.loginTxtbUser.TextMarginTop = -1;
            this.loginTxtbUser.TextPlaceholder = "Usuario";
            this.loginTxtbUser.UseSystemPasswordChar = false;
            this.loginTxtbUser.WordWrap = true;
            // 
            // loginImgUser
            // 
            this.loginImgUser.AllowFocused = false;
            this.loginImgUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginImgUser.AutoSizeHeight = true;
            this.loginImgUser.BorderRadius = 65;
            this.loginImgUser.Image = global::HP3.Properties.Resources.imgUserBlack;
            this.loginImgUser.IsCircle = false;
            this.loginImgUser.Location = new System.Drawing.Point(77, 66);
            this.loginImgUser.Name = "loginImgUser";
            this.loginImgUser.Size = new System.Drawing.Size(130, 130);
            this.loginImgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.loginLblTittle.Location = new System.Drawing.Point(114, 30);
            this.loginLblTittle.Name = "loginLblTittle";
            this.loginLblTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginLblTittle.Size = new System.Drawing.Size(57, 31);
            this.loginLblTittle.TabIndex = 3;
            this.loginLblTittle.TabStop = false;
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
            this.TopMost = true;
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
        private Bunifu.UI.WinForms.BunifuTextBox loginTxtbPassword;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton loginBttStart;
    }
}

