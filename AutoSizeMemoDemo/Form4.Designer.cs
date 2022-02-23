
namespace LayoutControlTabBackColor
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.propertyGridControl1 = new DevExpress.XtraVerticalGrid.PropertyGridControl();
            this.splitterControl1 = new DevExpress.XtraEditors.SplitterControl();
            this.propertyDescriptionControl1 = new DevExpress.XtraVerticalGrid.PropertyDescriptionControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.departmentsDataSet1 = new AutoSizeMemoDemo.DepartmentsDataSet();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.colID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPARENTID = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPARENTID = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colIMAGEINDEX = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colIMAGEINDEX = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colDEPARTMENT = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemAutoSizeMemoEdit1 = new AutoSizeMemo.RepositoryItemAutoSizeMemoEdit();
            this.layoutViewField_colDEPARTMENT = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colBUDGET = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colBUDGET = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colLOCATION = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colLOCATION = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPHONE1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPHONE1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.colPHONE2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_colPHONE2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.item1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.departmentsTableAdapter1 = new AutoSizeMemoDemo.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPARENTID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMAGEINDEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAutoSizeMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDEPARTMENT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBUDGET)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLOCATION)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPHONE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPHONE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinDropDownButtonItem1});
            this.barManager1.MaxItemId = 3;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.skinDropDownButtonItem1)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DisableClose = true;
            this.bar1.OptionsBar.DisableCustomization = true;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            this.skinDropDownButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(963, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 615);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(963, 21);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 586);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(963, 29);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 586);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("e5af3bc8-e32d-4824-b83e-60ec4f21f72b");
            this.dockPanel1.Location = new System.Drawing.Point(763, 29);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 586);
            this.dockPanel1.Text = "dockPanel1";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.propertyGridControl1);
            this.dockPanel1_Container.Controls.Add(this.splitterControl1);
            this.dockPanel1_Container.Controls.Add(this.propertyDescriptionControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(5, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(191, 557);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // propertyGridControl1
            // 
            this.propertyGridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGridControl1.Location = new System.Drawing.Point(0, 0);
            this.propertyGridControl1.MenuManager = this.barManager1;
            this.propertyGridControl1.Name = "propertyGridControl1";
            this.propertyGridControl1.Size = new System.Drawing.Size(191, 481);
            this.propertyGridControl1.TabIndex = 0;
            // 
            // splitterControl1
            // 
            this.splitterControl1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitterControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitterControl1.Location = new System.Drawing.Point(0, 481);
            this.splitterControl1.Name = "splitterControl1";
            this.splitterControl1.Size = new System.Drawing.Size(191, 6);
            this.splitterControl1.TabIndex = 2;
            this.splitterControl1.TabStop = false;
            // 
            // propertyDescriptionControl1
            // 
            this.propertyDescriptionControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertyDescriptionControl1.Location = new System.Drawing.Point(0, 487);
            this.propertyDescriptionControl1.Name = "propertyDescriptionControl1";
            this.propertyDescriptionControl1.Size = new System.Drawing.Size(191, 70);
            this.propertyDescriptionControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.DataMember = "Departments";
            this.gridControl1.DataSource = this.departmentsDataSet1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 29);
            this.gridControl1.MainView = this.layoutView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemAutoSizeMemoEdit1,
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(763, 586);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.layoutView1});
            // 
            // departmentsDataSet1
            // 
            this.departmentsDataSet1.DataSetName = "DepartmentsDataSet";
            this.departmentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutView1
            // 
            this.layoutView1.Appearance.FieldCaption.Options.UseTextOptions = true;
            this.layoutView1.Appearance.FieldCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutView1.Appearance.FieldEditingValue.Options.UseTextOptions = true;
            this.layoutView1.Appearance.FieldEditingValue.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutView1.Appearance.FieldValue.Options.UseTextOptions = true;
            this.layoutView1.Appearance.FieldValue.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutView1.CardMinSize = new System.Drawing.Size(203, 238);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.colID,
            this.colPARENTID,
            this.colIMAGEINDEX,
            this.colDEPARTMENT,
            this.colBUDGET,
            this.colLOCATION,
            this.colPHONE1,
            this.colPHONE2});
            this.layoutView1.GridControl = this.gridControl1;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row;
            this.layoutView1.TemplateCard = this.layoutViewCard1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.LayoutViewField = this.layoutViewField_colID;
            this.colID.Name = "colID";
            // 
            // layoutViewField_colID
            // 
            this.layoutViewField_colID.EditorPreferredWidth = 100;
            this.layoutViewField_colID.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_colID.Name = "layoutViewField_colID";
            this.layoutViewField_colID.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colID.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colPARENTID
            // 
            this.colPARENTID.FieldName = "PARENTID";
            this.colPARENTID.LayoutViewField = this.layoutViewField_colPARENTID;
            this.colPARENTID.Name = "colPARENTID";
            this.colPARENTID.Width = 116;
            // 
            // layoutViewField_colPARENTID
            // 
            this.layoutViewField_colPARENTID.EditorPreferredWidth = 100;
            this.layoutViewField_colPARENTID.Location = new System.Drawing.Point(0, 24);
            this.layoutViewField_colPARENTID.Name = "layoutViewField_colPARENTID";
            this.layoutViewField_colPARENTID.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colPARENTID.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colIMAGEINDEX
            // 
            this.colIMAGEINDEX.FieldName = "IMAGEINDEX";
            this.colIMAGEINDEX.LayoutViewField = this.layoutViewField_colIMAGEINDEX;
            this.colIMAGEINDEX.Name = "colIMAGEINDEX";
            this.colIMAGEINDEX.Width = 116;
            // 
            // layoutViewField_colIMAGEINDEX
            // 
            this.layoutViewField_colIMAGEINDEX.EditorPreferredWidth = 100;
            this.layoutViewField_colIMAGEINDEX.Location = new System.Drawing.Point(0, 48);
            this.layoutViewField_colIMAGEINDEX.Name = "layoutViewField_colIMAGEINDEX";
            this.layoutViewField_colIMAGEINDEX.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colIMAGEINDEX.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colDEPARTMENT
            // 
            this.colDEPARTMENT.Caption = "AutoSizeMemo";
            this.colDEPARTMENT.ColumnEdit = this.repositoryItemAutoSizeMemoEdit1;
            this.colDEPARTMENT.FieldName = "DEPARTMENT";
            this.colDEPARTMENT.LayoutViewField = this.layoutViewField_colDEPARTMENT;
            this.colDEPARTMENT.Name = "colDEPARTMENT";
            this.colDEPARTMENT.Width = 116;
            // 
            // repositoryItemAutoSizeMemoEdit1
            // 
            this.repositoryItemAutoSizeMemoEdit1.Appearance.BackColor = System.Drawing.SystemColors.Window;
            this.repositoryItemAutoSizeMemoEdit1.Appearance.Options.UseBackColor = true;
            this.repositoryItemAutoSizeMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemAutoSizeMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.repositoryItemAutoSizeMemoEdit1.AutoSizeInGridLayoutView = true;
            this.repositoryItemAutoSizeMemoEdit1.Name = "repositoryItemAutoSizeMemoEdit1";
            this.repositoryItemAutoSizeMemoEdit1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            // 
            // layoutViewField_colDEPARTMENT
            // 
            this.layoutViewField_colDEPARTMENT.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.layoutViewField_colDEPARTMENT.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutViewField_colDEPARTMENT.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutViewField_colDEPARTMENT.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutViewField_colDEPARTMENT.ContentVertAlignment = DevExpress.Utils.VertAlignment.Top;
            this.layoutViewField_colDEPARTMENT.EditorPreferredWidth = 100;
            this.layoutViewField_colDEPARTMENT.Location = new System.Drawing.Point(0, 72);
            this.layoutViewField_colDEPARTMENT.Name = "layoutViewField_colDEPARTMENT";
            this.layoutViewField_colDEPARTMENT.Size = new System.Drawing.Size(183, 21);
            this.layoutViewField_colDEPARTMENT.StartNewLine = true;
            this.layoutViewField_colDEPARTMENT.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colBUDGET
            // 
            this.colBUDGET.FieldName = "BUDGET";
            this.colBUDGET.LayoutViewField = this.layoutViewField_colBUDGET;
            this.colBUDGET.Name = "colBUDGET";
            this.colBUDGET.Width = 116;
            // 
            // layoutViewField_colBUDGET
            // 
            this.layoutViewField_colBUDGET.EditorPreferredWidth = 100;
            this.layoutViewField_colBUDGET.Location = new System.Drawing.Point(0, 93);
            this.layoutViewField_colBUDGET.Name = "layoutViewField_colBUDGET";
            this.layoutViewField_colBUDGET.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colBUDGET.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colLOCATION
            // 
            this.colLOCATION.FieldName = "LOCATION";
            this.colLOCATION.LayoutViewField = this.layoutViewField_colLOCATION;
            this.colLOCATION.Name = "colLOCATION";
            this.colLOCATION.Width = 116;
            // 
            // layoutViewField_colLOCATION
            // 
            this.layoutViewField_colLOCATION.EditorPreferredWidth = 100;
            this.layoutViewField_colLOCATION.Location = new System.Drawing.Point(0, 117);
            this.layoutViewField_colLOCATION.Name = "layoutViewField_colLOCATION";
            this.layoutViewField_colLOCATION.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colLOCATION.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colPHONE1
            // 
            this.colPHONE1.FieldName = "PHONE1";
            this.colPHONE1.LayoutViewField = this.layoutViewField_colPHONE1;
            this.colPHONE1.Name = "colPHONE1";
            this.colPHONE1.Width = 116;
            // 
            // layoutViewField_colPHONE1
            // 
            this.layoutViewField_colPHONE1.EditorPreferredWidth = 100;
            this.layoutViewField_colPHONE1.Location = new System.Drawing.Point(0, 141);
            this.layoutViewField_colPHONE1.Name = "layoutViewField_colPHONE1";
            this.layoutViewField_colPHONE1.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colPHONE1.TextSize = new System.Drawing.Size(74, 13);
            // 
            // colPHONE2
            // 
            this.colPHONE2.FieldName = "PHONE2";
            this.colPHONE2.LayoutViewField = this.layoutViewField_colPHONE2;
            this.colPHONE2.Name = "colPHONE2";
            this.colPHONE2.Width = 116;
            // 
            // layoutViewField_colPHONE2
            // 
            this.layoutViewField_colPHONE2.EditorPreferredWidth = 100;
            this.layoutViewField_colPHONE2.Location = new System.Drawing.Point(0, 165);
            this.layoutViewField_colPHONE2.Name = "layoutViewField_colPHONE2";
            this.layoutViewField_colPHONE2.Size = new System.Drawing.Size(183, 24);
            this.layoutViewField_colPHONE2.TextSize = new System.Drawing.Size(74, 13);
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colID,
            this.layoutViewField_colPARENTID,
            this.layoutViewField_colIMAGEINDEX,
            this.layoutViewField_colDEPARTMENT,
            this.layoutViewField_colBUDGET,
            this.layoutViewField_colLOCATION,
            this.layoutViewField_colPHONE1,
            this.layoutViewField_colPHONE2,
            this.item1});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // item1
            // 
            this.item1.AllowHotTrack = false;
            this.item1.CustomizationFormText = "item1";
            this.item1.Location = new System.Drawing.Point(0, 189);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(183, 35);
            this.item1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // departmentsTableAdapter1
            // 
            this.departmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 636);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form4.IconOptions.Icon")));
            this.Name = "Form4";
            this.Text = "Form 4: AutoSizeMemo in GridControl with LayoutView";
            this.Load += new System.EventHandler(this.FormGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertyGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPARENTID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colIMAGEINDEX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemAutoSizeMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDEPARTMENT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBUDGET)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colLOCATION)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPHONE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colPHONE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraVerticalGrid.PropertyGridControl propertyGridControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SplitterControl splitterControl1;
        private DevExpress.XtraVerticalGrid.PropertyDescriptionControl propertyDescriptionControl1;
        private AutoSizeMemoDemo.DepartmentsDataSet departmentsDataSet1;
        private AutoSizeMemoDemo.DepartmentsDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter1;
        private AutoSizeMemo.RepositoryItemAutoSizeMemoEdit repositoryItemAutoSizeMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPARENTID;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colIMAGEINDEX;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colDEPARTMENT;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colBUDGET;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colLOCATION;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPHONE1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn colPHONE2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPARENTID;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colIMAGEINDEX;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDEPARTMENT;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBUDGET;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colLOCATION;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPHONE1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colPHONE2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.EmptySpaceItem item1;
    }
}

