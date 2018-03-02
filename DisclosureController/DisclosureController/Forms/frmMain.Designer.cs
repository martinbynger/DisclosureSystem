namespace DisclosureController
{
    partial class frmMain
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
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab1 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribReports");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab2 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribFailures");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab3 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribInformation");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab4 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribExceptions");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab5 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribbon1");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab6 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribCompanies");
            Infragistics.Win.UltraWinToolbars.RibbonTab ribbonTab7 = new Infragistics.Win.UltraWinToolbars.RibbonTab("ribSystem");
            this.Form1_Fill_Panel = new Infragistics.Win.Misc.UltraPanel();
            this.ultraToolbarsManager1 = new Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(this.components);
            this._frmMain_Toolbars_Dock_Area_Left = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._frmMain_Toolbars_Dock_Area_Right = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._frmMain_Toolbars_Dock_Area_Top = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this._frmMain_Toolbars_Dock_Area_Bottom = new Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea();
            this.Form1_Fill_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // Form1_Fill_Panel
            // 
            this.Form1_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Form1_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Form1_Fill_Panel.Location = new System.Drawing.Point(8, 162);
            this.Form1_Fill_Panel.Name = "Form1_Fill_Panel";
            this.Form1_Fill_Panel.Size = new System.Drawing.Size(1264, 598);
            this.Form1_Fill_Panel.TabIndex = 0;
            // 
            // ultraToolbarsManager1
            // 
            this.ultraToolbarsManager1.DesignerFlags = 1;
            this.ultraToolbarsManager1.DockWithinContainer = this;
            this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof(System.Windows.Forms.Form);
            this.ultraToolbarsManager1.MenuAnimationStyle = Infragistics.Win.UltraWinToolbars.MenuAnimationStyle.Fade;
            ribbonTab1.Caption = "Reports";
            ribbonTab2.Caption = "Failures";
            ribbonTab3.Caption = "Information Requests";
            ribbonTab4.Caption = "Exceptions";
            ribbonTab5.Caption = "Users + Devices";
            ribbonTab6.Caption = "Companies";
            ribbonTab7.Caption = "System Types";
            this.ultraToolbarsManager1.Ribbon.NonInheritedRibbonTabs.AddRange(new Infragistics.Win.UltraWinToolbars.RibbonTab[] {
            ribbonTab1,
            ribbonTab2,
            ribbonTab3,
            ribbonTab4,
            ribbonTab5,
            ribbonTab6,
            ribbonTab7});
            this.ultraToolbarsManager1.Ribbon.Visible = true;
            // 
            // _frmMain_Toolbars_Dock_Area_Left
            // 
            this._frmMain_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmMain_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmMain_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left;
            this._frmMain_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmMain_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 8;
            this._frmMain_Toolbars_Dock_Area_Left.Location = new System.Drawing.Point(0, 162);
            this._frmMain_Toolbars_Dock_Area_Left.Name = "_frmMain_Toolbars_Dock_Area_Left";
            this._frmMain_Toolbars_Dock_Area_Left.Size = new System.Drawing.Size(8, 598);
            this._frmMain_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _frmMain_Toolbars_Dock_Area_Right
            // 
            this._frmMain_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmMain_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmMain_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right;
            this._frmMain_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmMain_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 8;
            this._frmMain_Toolbars_Dock_Area_Right.Location = new System.Drawing.Point(1272, 162);
            this._frmMain_Toolbars_Dock_Area_Right.Name = "_frmMain_Toolbars_Dock_Area_Right";
            this._frmMain_Toolbars_Dock_Area_Right.Size = new System.Drawing.Size(8, 598);
            this._frmMain_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _frmMain_Toolbars_Dock_Area_Top
            // 
            this._frmMain_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmMain_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmMain_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top;
            this._frmMain_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmMain_Toolbars_Dock_Area_Top.Location = new System.Drawing.Point(0, 0);
            this._frmMain_Toolbars_Dock_Area_Top.Name = "_frmMain_Toolbars_Dock_Area_Top";
            this._frmMain_Toolbars_Dock_Area_Top.Size = new System.Drawing.Size(1280, 162);
            this._frmMain_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // _frmMain_Toolbars_Dock_Area_Bottom
            // 
            this._frmMain_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this._frmMain_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this._frmMain_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom;
            this._frmMain_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._frmMain_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 8;
            this._frmMain_Toolbars_Dock_Area_Bottom.Location = new System.Drawing.Point(0, 760);
            this._frmMain_Toolbars_Dock_Area_Bottom.Name = "_frmMain_Toolbars_Dock_Area_Bottom";
            this._frmMain_Toolbars_Dock_Area_Bottom.Size = new System.Drawing.Size(1280, 8);
            this._frmMain_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.Form1_Fill_Panel);
            this.Controls.Add(this._frmMain_Toolbars_Dock_Area_Left);
            this.Controls.Add(this._frmMain_Toolbars_Dock_Area_Right);
            this.Controls.Add(this._frmMain_Toolbars_Dock_Area_Bottom);
            this.Controls.Add(this._frmMain_Toolbars_Dock_Area_Top);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Disclosure Controller";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Form1_Fill_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ultraToolbarsManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.Misc.UltraPanel Form1_Fill_Panel;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsManager ultraToolbarsManager1;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmMain_Toolbars_Dock_Area_Left;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmMain_Toolbars_Dock_Area_Right;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmMain_Toolbars_Dock_Area_Bottom;
        private Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea _frmMain_Toolbars_Dock_Area_Top;
    }
}

