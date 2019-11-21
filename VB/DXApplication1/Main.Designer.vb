Namespace DXApplication
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl = New DevExpress.XtraGrid.GridControl()
			Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.skinRibbonGalleryBarItem = New DevExpress.XtraBars.SkinRibbonGalleryBarItem()
			Me.skinDropDownButtonItem = New DevExpress.XtraBars.SkinDropDownButtonItem()
			Me.skinPaletteRibbonGalleryBarItem = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
			Me.useDataTabletem = New DevExpress.XtraBars.BarButtonItem()
			Me.useSqlDataSourceItem = New DevExpress.XtraBars.BarButtonItem()
			Me.useEFItem = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgSkins = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl
			' 
			Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
			Me.gridControl.Location = New System.Drawing.Point(0, 158)
			Me.gridControl.MainView = Me.gridView
			Me.gridControl.Margin = New System.Windows.Forms.Padding(6)
			Me.gridControl.Name = "gridControl"
			Me.gridControl.Size = New System.Drawing.Size(884, 428)
			Me.gridControl.TabIndex = 0
			Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView})
			' 
			' gridView
			' 
			Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.gridColumn5, Me.gridColumn6, Me.gridColumn7, Me.gridColumn8, Me.gridColumn9})
			Me.gridView.DetailHeight = 748
			Me.gridView.FixedLineWidth = 4
			Me.gridView.GridControl = Me.gridControl
			Me.gridView.Name = "gridView"
			' 
			' gridColumn1
			' 
			Me.gridColumn1.FieldName = "ProductNumber"
			Me.gridColumn1.MinWidth = 45
			Me.gridColumn1.Name = "gridColumn1"
			Me.gridColumn1.Visible = True
			Me.gridColumn1.VisibleIndex = 0
			Me.gridColumn1.Width = 168
			' 
			' gridColumn2
			' 
			Me.gridColumn2.FieldName = "Name"
			Me.gridColumn2.MinWidth = 45
			Me.gridColumn2.Name = "gridColumn2"
			Me.gridColumn2.Visible = True
			Me.gridColumn2.VisibleIndex = 1
			Me.gridColumn2.Width = 168
			' 
			' gridColumn3
			' 
			Me.gridColumn3.FieldName = "Color"
			Me.gridColumn3.MinWidth = 45
			Me.gridColumn3.Name = "gridColumn3"
			Me.gridColumn3.Visible = True
			Me.gridColumn3.VisibleIndex = 2
			Me.gridColumn3.Width = 168
			' 
			' gridColumn4
			' 
			Me.gridColumn4.FieldName = "StandardCost"
			Me.gridColumn4.MinWidth = 45
			Me.gridColumn4.Name = "gridColumn4"
			Me.gridColumn4.Visible = True
			Me.gridColumn4.VisibleIndex = 3
			Me.gridColumn4.Width = 168
			' 
			' gridColumn5
			' 
			Me.gridColumn5.FieldName = "ListPrice"
			Me.gridColumn5.MinWidth = 45
			Me.gridColumn5.Name = "gridColumn5"
			Me.gridColumn5.Visible = True
			Me.gridColumn5.VisibleIndex = 4
			Me.gridColumn5.Width = 168
			' 
			' gridColumn6
			' 
			Me.gridColumn6.FieldName = "Size"
			Me.gridColumn6.MinWidth = 45
			Me.gridColumn6.Name = "gridColumn6"
			Me.gridColumn6.Visible = True
			Me.gridColumn6.VisibleIndex = 5
			Me.gridColumn6.Width = 168
			' 
			' gridColumn7
			' 
			Me.gridColumn7.FieldName = "Weight"
			Me.gridColumn7.MinWidth = 45
			Me.gridColumn7.Name = "gridColumn7"
			Me.gridColumn7.Visible = True
			Me.gridColumn7.VisibleIndex = 6
			Me.gridColumn7.Width = 168
			' 
			' gridColumn8
			' 
			Me.gridColumn8.FieldName = "SellStartDate"
			Me.gridColumn8.MinWidth = 45
			Me.gridColumn8.Name = "gridColumn8"
			Me.gridColumn8.Visible = True
			Me.gridColumn8.VisibleIndex = 7
			Me.gridColumn8.Width = 168
			' 
			' gridColumn9
			' 
			Me.gridColumn9.FieldName = "SellEndDate"
			Me.gridColumn9.MinWidth = 45
			Me.gridColumn9.Name = "gridColumn9"
			Me.gridColumn9.Visible = True
			Me.gridColumn9.VisibleIndex = 8
			Me.gridColumn9.Width = 168
			' 
			' ribbonControl
			' 
			Me.ribbonControl.ExpandCollapseItem.Id = 0
			Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl.ExpandCollapseItem, Me.ribbonControl.SearchEditItem, Me.skinRibbonGalleryBarItem, Me.skinDropDownButtonItem, Me.skinPaletteRibbonGalleryBarItem, Me.useDataTabletem, Me.useSqlDataSourceItem, Me.useEFItem})
			Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl.Margin = New System.Windows.Forms.Padding(6)
			Me.ribbonControl.MaxItemId = 5
			Me.ribbonControl.Name = "ribbonControl"
			Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage})
			Me.ribbonControl.Size = New System.Drawing.Size(884, 158)
			' 
			' skinRibbonGalleryBarItem
			' 
			Me.skinRibbonGalleryBarItem.Caption = "skinRibbonGalleryBarItem"
			Me.skinRibbonGalleryBarItem.Id = 1
			Me.skinRibbonGalleryBarItem.Name = "skinRibbonGalleryBarItem"
			' 
			' skinDropDownButtonItem
			' 
			Me.skinDropDownButtonItem.Id = 2
			Me.skinDropDownButtonItem.Name = "skinDropDownButtonItem"
			' 
			' skinPaletteRibbonGalleryBarItem
			' 
			Me.skinPaletteRibbonGalleryBarItem.Caption = "skinPaletteRibbonGalleryBarItem"
			Me.skinPaletteRibbonGalleryBarItem.Id = 3
			Me.skinPaletteRibbonGalleryBarItem.Name = "skinPaletteRibbonGalleryBarItem"
			' 
			' useDataTabletem
			' 
			Me.useDataTabletem.Caption = "Use DataTable"
			Me.useDataTabletem.Id = 2
			Me.useDataTabletem.Name = "useDataTabletem"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.useDataTabletem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BindToDataTable);
			' 
			' useSqlDataSourceItem
			' 
			Me.useSqlDataSourceItem.Caption = "Use SqlDataSource (read-only)"
			Me.useSqlDataSourceItem.Id = 3
			Me.useSqlDataSourceItem.Name = "useSqlDataSourceItem"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.useSqlDataSourceItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BindToSqlDataSource);
			' 
			' useEFItem
			' 
			Me.useEFItem.Caption = "Use Entity Framework" & vbCrLf
			Me.useEFItem.Id = 4
			Me.useEFItem.Name = "useEFItem"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.useEFItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BindToEF);
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Data"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.useDataTabletem)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.useSqlDataSourceItem)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.useEFItem)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "Azure Connection"
			' 
			' ribbonPage
			' 
			Me.ribbonPage.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgSkins})
			Me.ribbonPage.Name = "ribbonPage"
			Me.ribbonPage.Text = "View"
			' 
			' rpgSkins
			' 
			Me.rpgSkins.ItemLinks.Add(Me.skinDropDownButtonItem)
			Me.rpgSkins.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem)
			Me.rpgSkins.Name = "rpgSkins"
			Me.rpgSkins.Text = "Skins"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.Name = "sqlDataSource1"
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(884, 586)
			Me.Controls.Add(Me.gridControl)
			Me.Controls.Add(Me.ribbonControl)
			Me.Margin = New System.Windows.Forms.Padding(6)
			Me.Name = "Main"
			Me.Ribbon = Me.ribbonControl
			Me.Text = "Main"
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
			CType(Me.gridControl, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gridControl As DevExpress.XtraGrid.GridControl
		Private gridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpgSkins As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private skinRibbonGalleryBarItem As DevExpress.XtraBars.SkinRibbonGalleryBarItem
		Private skinDropDownButtonItem As DevExpress.XtraBars.SkinDropDownButtonItem
		Private skinPaletteRibbonGalleryBarItem As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents useDataTabletem As DevExpress.XtraBars.BarButtonItem
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private WithEvents useSqlDataSourceItem As DevExpress.XtraBars.BarButtonItem
		Private WithEvents useEFItem As DevExpress.XtraBars.BarButtonItem
		Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace
