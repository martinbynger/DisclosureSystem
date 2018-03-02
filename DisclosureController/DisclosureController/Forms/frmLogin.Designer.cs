namespace DisclosureController.Forms
{
    partial class frmLogin
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
            this.ultraFormManager1 = new Infragistics.Win.UltraWinForm.UltraFormManager(this.components);
            this.frmLogin_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
            this.cmdCancel = new Infragistics.Win.Misc.UltraButton();
            this.cmdOK = new Infragistics.Win.Misc.UltraButton();
            this.txtPassword = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtUserID = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this._frmLogin_UltraFormManager_Dock_Area_Left = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._frmLogin_UltraFormManager_Dock_Area_Right = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._frmLogin_UltraFormManager_Dock_Area_Top = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._frmLogin_UltraFormManager_Dock_Area_Bottom = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).BeginInit();
            this.frmLogin_Fill_Panel.ClientArea.SuspendLayout();
            this.frmLogin_Fill_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID)).BeginInit();
            this.SuspendLayout();
            // 
            // ultraFormManager1
            // 
            this.ultraFormManager1.Form = this;
            // 
            // frmLogin_Fill_Panel
            // 
            // 
            // frmLogin_Fill_Panel.ClientArea
            // 
            this.frmLogin_Fill_Panel.ClientArea.Controls.Add(this.cmdCancel);
            this.frmLogin_Fill_Panel.ClientArea.Controls.Add(this.cmdOK);
            this.frmLogin_Fill_Panel.ClientArea.Controls.Add(this.txtPassword);
            this.frmLogin_Fill_Panel.ClientArea.Controls.Add(this.txtUserID);
            this.frmLogin_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.frmLogin_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmLogin_Fill_Panel.Location = new System.Drawing.Point(8, 32);
            this.frmLogin_Fill_Panel.Name = "frmLogin_Fill_Panel";
            this.frmLogin_Fill_Panel.Size = new System.Drawing.Size(268, 221);
            this.frmLogin_Fill_Panel.TabIndex = 0;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(44, 181);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 3;
            this.cmdCancel.Text = "Cancel";
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(169, 181);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(75, 23);
            this.cmdOK.TabIndex = 2;
            this.cmdOK.Text = "OK";
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(44, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.NullText = "Password";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUserID
            // 
            this.txtUserID.Location = new System.Drawing.Point(44, 39);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.NullText = "UserID";
            this.txtUserID.Size = new System.Drawing.Size(163, 21);
            this.txtUserID.TabIndex = 0;
            // 
            // _frmLogin_UltraFormManager_Dock_Area_Left
            // 
            this._frmLogin_UltraFormManager_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmLogin_UltraFormManager_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmLogin_UltraFormManager_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Left;
            this._frmLogin_UltraFormManager_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmLogin_UltraFormManager_Dock_Area_Left.FormManager = this.ultraFormManager1;
            this._frmLogin_UltraFormManager_Dock_Area_Left.InitialResizeAreaExtent = 8;
            this._frmLogin_UltraFormManager_Dock_Area_Left.Location = new System.Drawing.Point(0, 32);
            this._frmLogin_UltraFormManager_Dock_Area_Left.Name = "_frmLogin_UltraFormManager_Dock_Area_Left";
            this._frmLogin_UltraFormManager_Dock_Area_Left.Size = new System.Drawing.Size(8, 221);
            // 
            // _frmLogin_UltraFormManager_Dock_Area_Right
            // 
            this._frmLogin_UltraFormManager_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmLogin_UltraFormManager_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmLogin_UltraFormManager_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Right;
            this._frmLogin_UltraFormManager_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmLogin_UltraFormManager_Dock_Area_Right.FormManager = this.ultraFormManager1;
            this._frmLogin_UltraFormManager_Dock_Area_Right.InitialResizeAreaExtent = 8;
            this._frmLogin_UltraFormManager_Dock_Area_Right.Location = new System.Drawing.Point(276, 32);
            this._frmLogin_UltraFormManager_Dock_Area_Right.Name = "_frmLogin_UltraFormManager_Dock_Area_Right";
            this._frmLogin_UltraFormManager_Dock_Area_Right.Size = new System.Drawing.Size(8, 221);
            // 
            // _frmLogin_UltraFormManager_Dock_Area_Top
            // 
            this._frmLogin_UltraFormManager_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmLogin_UltraFormManager_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmLogin_UltraFormManager_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Top;
            this._frmLogin_UltraFormManager_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmLogin_UltraFormManager_Dock_Area_Top.FormManager = this.ultraFormManager1;
            this._frmLogin_UltraFormManager_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._frmLogin_UltraFormManager_Dock_Area_Top.Name = "_frmLogin_UltraFormManager_Dock_Area_Top";
            this._frmLogin_UltraFormManager_Dock_Area_Top.Size = new System.Drawing.Size(284, 32);
            // 
            // _frmLogin_UltraFormManager_Dock_Area_Bottom
            // 
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Bottom;
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.FormManager = this.ultraFormManager1;
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.InitialResizeAreaExtent = 8;
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 253);
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.Name = "_frmLogin_UltraFormManager_Dock_Area_Bottom";
            this._frmLogin_UltraFormManager_Dock_Area_Bottom.Size = new System.Drawing.Size(284, 8);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.frmLogin_Fill_Panel);
            this.Controls.Add(this._frmLogin_UltraFormManager_Dock_Area_Left);
            this.Controls.Add(this._frmLogin_UltraFormManager_Dock_Area_Right);
            this.Controls.Add(this._frmLogin_UltraFormManager_Dock_Area_Top);
            this.Controls.Add(this._frmLogin_UltraFormManager_Dock_Area_Bottom);
            this.Name = "frmLogin";
            this.Text = "frmLogin";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).EndInit();
            this.frmLogin_Fill_Panel.ClientArea.ResumeLayout(false);
            this.frmLogin_Fill_Panel.ClientArea.PerformLayout();
            this.frmLogin_Fill_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinForm.UltraFormManager ultraFormManager1;
        private Infragistics.Win.Misc.UltraPanel frmLogin_Fill_Panel;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmLogin_UltraFormManager_Dock_Area_Left;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmLogin_UltraFormManager_Dock_Area_Right;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmLogin_UltraFormManager_Dock_Area_Top;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmLogin_UltraFormManager_Dock_Area_Bottom;
        private Infragistics.Win.Misc.UltraButton cmdCancel;
        private Infragistics.Win.Misc.UltraButton cmdOK;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtPassword;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtUserID;
    }
}