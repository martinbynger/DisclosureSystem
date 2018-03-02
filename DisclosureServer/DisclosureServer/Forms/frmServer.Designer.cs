namespace DisclosureServer
{
    partial class frmServer
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
            Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode1 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
            Infragistics.Win.UltraWinTree.UltraTreeNode ultraTreeNode2 = new Infragistics.Win.UltraWinTree.UltraTreeNode();
            this.trvConnectedClients = new Infragistics.Win.UltraWinTree.UltraTree();
            this.ultraFormManager1 = new Infragistics.Win.UltraWinForm.UltraFormManager(this.components);
            this.frmServer_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
            this._frmServer_UltraFormManager_Dock_Area_Left = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._frmServer_UltraFormManager_Dock_Area_Right = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._frmServer_UltraFormManager_Dock_Area_Top = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this._frmServer_UltraFormManager_Dock_Area_Bottom = new Infragistics.Win.UltraWinForm.UltraFormDockArea();
            this.txtMessages = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.txtErrors = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            ((System.ComponentModel.ISupportInitialize)(this.trvConnectedClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).BeginInit();
            this.frmServer_Fill_Panel.ClientArea.SuspendLayout();
            this.frmServer_Fill_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // trvConnectedClients
            // 
            this.trvConnectedClients.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvConnectedClients.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.trvConnectedClients.Location = new System.Drawing.Point(0, 0);
            this.trvConnectedClients.Name = "trvConnectedClients";
            this.trvConnectedClients.NodeConnectorColor = System.Drawing.SystemColors.ControlDark;
            ultraTreeNode1.Text = "Authenticated Clients";
            ultraTreeNode2.Text = "Connected Clients";
            this.trvConnectedClients.Nodes.AddRange(new Infragistics.Win.UltraWinTree.UltraTreeNode[] {
            ultraTreeNode1,
            ultraTreeNode2});
            this.trvConnectedClients.Size = new System.Drawing.Size(293, 560);
            this.trvConnectedClients.TabIndex = 0;
            // 
            // ultraFormManager1
            // 
            this.ultraFormManager1.Form = this;
            // 
            // frmServer_Fill_Panel
            // 
            // 
            // frmServer_Fill_Panel.ClientArea
            // 
            this.frmServer_Fill_Panel.ClientArea.Controls.Add(this.txtErrors);
            this.frmServer_Fill_Panel.ClientArea.Controls.Add(this.txtMessages);
            this.frmServer_Fill_Panel.ClientArea.Controls.Add(this.trvConnectedClients);
            this.frmServer_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.frmServer_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmServer_Fill_Panel.Location = new System.Drawing.Point(8, 32);
            this.frmServer_Fill_Panel.Name = "frmServer_Fill_Panel";
            this.frmServer_Fill_Panel.Size = new System.Drawing.Size(884, 560);
            this.frmServer_Fill_Panel.TabIndex = 0;
            // 
            // _frmServer_UltraFormManager_Dock_Area_Left
            // 
            this._frmServer_UltraFormManager_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmServer_UltraFormManager_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmServer_UltraFormManager_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Left;
            this._frmServer_UltraFormManager_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmServer_UltraFormManager_Dock_Area_Left.FormManager = this.ultraFormManager1;
            this._frmServer_UltraFormManager_Dock_Area_Left.InitialResizeAreaExtent = 8;
            this._frmServer_UltraFormManager_Dock_Area_Left.Location = new System.Drawing.Point(0, 32);
            this._frmServer_UltraFormManager_Dock_Area_Left.Name = "_frmServer_UltraFormManager_Dock_Area_Left";
            this._frmServer_UltraFormManager_Dock_Area_Left.Size = new System.Drawing.Size(8, 560);
            // 
            // _frmServer_UltraFormManager_Dock_Area_Right
            // 
            this._frmServer_UltraFormManager_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmServer_UltraFormManager_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmServer_UltraFormManager_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Right;
            this._frmServer_UltraFormManager_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmServer_UltraFormManager_Dock_Area_Right.FormManager = this.ultraFormManager1;
            this._frmServer_UltraFormManager_Dock_Area_Right.InitialResizeAreaExtent = 8;
            this._frmServer_UltraFormManager_Dock_Area_Right.Location = new System.Drawing.Point(892, 32);
            this._frmServer_UltraFormManager_Dock_Area_Right.Name = "_frmServer_UltraFormManager_Dock_Area_Right";
            this._frmServer_UltraFormManager_Dock_Area_Right.Size = new System.Drawing.Size(8, 560);
            // 
            // _frmServer_UltraFormManager_Dock_Area_Top
            // 
            this._frmServer_UltraFormManager_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmServer_UltraFormManager_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmServer_UltraFormManager_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Top;
            this._frmServer_UltraFormManager_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmServer_UltraFormManager_Dock_Area_Top.FormManager = this.ultraFormManager1;
            this._frmServer_UltraFormManager_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._frmServer_UltraFormManager_Dock_Area_Top.Name = "_frmServer_UltraFormManager_Dock_Area_Top";
            this._frmServer_UltraFormManager_Dock_Area_Top.Size = new System.Drawing.Size(900, 32);
            // 
            // _frmServer_UltraFormManager_Dock_Area_Bottom
            // 
            this._frmServer_UltraFormManager_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmServer_UltraFormManager_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmServer_UltraFormManager_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinForm.DockedPosition.Bottom;
            this._frmServer_UltraFormManager_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmServer_UltraFormManager_Dock_Area_Bottom.FormManager = this.ultraFormManager1;
            this._frmServer_UltraFormManager_Dock_Area_Bottom.InitialResizeAreaExtent = 8;
            this._frmServer_UltraFormManager_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 592);
            this._frmServer_UltraFormManager_Dock_Area_Bottom.Name = "_frmServer_UltraFormManager_Dock_Area_Bottom";
            this._frmServer_UltraFormManager_Dock_Area_Bottom.Size = new System.Drawing.Size(900, 8);
            // 
            // txtMessages
            // 
            this.txtMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessages.Location = new System.Drawing.Point(293, 0);
            this.txtMessages.Multiline = true;
            this.txtMessages.Name = "txtMessages";
            this.txtMessages.Size = new System.Drawing.Size(591, 560);
            this.txtMessages.TabIndex = 1;
            // 
            // txtErrors
            // 
            this.txtErrors.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtErrors.Location = new System.Drawing.Point(591, 0);
            this.txtErrors.Multiline = true;
            this.txtErrors.Name = "txtErrors";
            this.txtErrors.Size = new System.Drawing.Size(293, 560);
            this.txtErrors.TabIndex = 2;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.frmServer_Fill_Panel);
            this.Controls.Add(this._frmServer_UltraFormManager_Dock_Area_Left);
            this.Controls.Add(this._frmServer_UltraFormManager_Dock_Area_Right);
            this.Controls.Add(this._frmServer_UltraFormManager_Dock_Area_Top);
            this.Controls.Add(this._frmServer_UltraFormManager_Dock_Area_Bottom);
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Disclosure Server";
            this.Load += new System.EventHandler(this.frmServer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trvConnectedClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ultraFormManager1)).EndInit();
            this.frmServer_Fill_Panel.ClientArea.ResumeLayout(false);
            this.frmServer_Fill_Panel.ClientArea.PerformLayout();
            this.frmServer_Fill_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtErrors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.UltraWinTree.UltraTree trvConnectedClients;
        private Infragistics.Win.UltraWinForm.UltraFormManager ultraFormManager1;
        private Infragistics.Win.Misc.UltraPanel frmServer_Fill_Panel;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmServer_UltraFormManager_Dock_Area_Left;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmServer_UltraFormManager_Dock_Area_Right;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmServer_UltraFormManager_Dock_Area_Top;
        private Infragistics.Win.UltraWinForm.UltraFormDockArea _frmServer_UltraFormManager_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtErrors;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor txtMessages;
    }
}

