namespace ApartmentViewApp
{
    partial class ListViewForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.comboLAWD_CD = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deDEAL_YMD = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.gcList = new DevExpress.XtraGrid.GridControl();
            this.gvList = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuildYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAreaForExclusiveUse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFloor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDealYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDealMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDealDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDealAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJibun = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRegionalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelDealDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCancelDealType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboLAWD_CD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.comboLAWD_CD);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deDEAL_YMD);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1150, 46);
            this.panelControl1.TabIndex = 0;
            // 
            // comboLAWD_CD
            // 
            this.comboLAWD_CD.Location = new System.Drawing.Point(230, 13);
            this.comboLAWD_CD.Name = "comboLAWD_CD";
            this.comboLAWD_CD.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.comboLAWD_CD.Properties.Appearance.Options.UseFont = true;
            this.comboLAWD_CD.Properties.Appearance.Options.UseTextOptions = true;
            this.comboLAWD_CD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.comboLAWD_CD.Properties.AppearanceDropDown.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.comboLAWD_CD.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboLAWD_CD.Properties.AppearanceDropDown.Options.UseTextOptions = true;
            this.comboLAWD_CD.Properties.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.comboLAWD_CD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboLAWD_CD.Size = new System.Drawing.Size(138, 22);
            this.comboLAWD_CD.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.labelControl2.Location = new System.Drawing.Point(200, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 15);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "지역";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.labelControl1.Location = new System.Drawing.Point(23, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 15);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "거래년월";
            // 
            // deDEAL_YMD
            // 
            this.deDEAL_YMD.EditValue = null;
            this.deDEAL_YMD.Location = new System.Drawing.Point(77, 13);
            this.deDEAL_YMD.Name = "deDEAL_YMD";
            this.deDEAL_YMD.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.deDEAL_YMD.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.deDEAL_YMD.Properties.Appearance.Options.UseFont = true;
            this.deDEAL_YMD.Properties.Appearance.Options.UseTextOptions = true;
            this.deDEAL_YMD.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.deDEAL_YMD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDEAL_YMD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDEAL_YMD.Properties.Mask.EditMask = "yyyy-MM";
            this.deDEAL_YMD.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deDEAL_YMD.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearView;
            this.deDEAL_YMD.Size = new System.Drawing.Size(100, 22);
            this.deDEAL_YMD.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Location = new System.Drawing.Point(1006, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(132, 30);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "조회";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gcList
            // 
            this.gcList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcList.Location = new System.Drawing.Point(0, 46);
            this.gcList.MainView = this.gvList;
            this.gcList.Name = "gcList";
            this.gcList.Size = new System.Drawing.Size(1150, 446);
            this.gcList.TabIndex = 1;
            this.gcList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvList});
            // 
            // gvList
            // 
            this.gvList.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNo,
            this.colApartmentName,
            this.colBuildYear,
            this.colAreaForExclusiveUse,
            this.colFloor,
            this.colDear,
            this.colDealYear,
            this.colDealMonth,
            this.colDealDay,
            this.colDong,
            this.colDealAmount,
            this.colJibun,
            this.colRegionalCode,
            this.colCancelDealDay,
            this.colCancelDealType});
            this.gvList.GridControl = this.gcList;
            this.gvList.Name = "gvList";
            this.gvList.OptionsBehavior.Editable = false;
            this.gvList.OptionsView.ShowGroupPanel = false;
            this.gvList.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gvList_CustomColumnDisplayText);
            // 
            // colNo
            // 
            this.colNo.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colNo.AppearanceCell.Options.UseFont = true;
            this.colNo.AppearanceCell.Options.UseTextOptions = true;
            this.colNo.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colNo.AppearanceHeader.Options.UseFont = true;
            this.colNo.AppearanceHeader.Options.UseTextOptions = true;
            this.colNo.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colNo.Caption = "순번";
            this.colNo.FieldName = "No";
            this.colNo.Name = "colNo";
            this.colNo.Visible = true;
            this.colNo.VisibleIndex = 0;
            // 
            // colApartmentName
            // 
            this.colApartmentName.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colApartmentName.AppearanceCell.Options.UseFont = true;
            this.colApartmentName.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colApartmentName.AppearanceHeader.Options.UseFont = true;
            this.colApartmentName.AppearanceHeader.Options.UseTextOptions = true;
            this.colApartmentName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colApartmentName.Caption = "아파트";
            this.colApartmentName.FieldName = "ApartmentName";
            this.colApartmentName.Name = "colApartmentName";
            this.colApartmentName.Visible = true;
            this.colApartmentName.VisibleIndex = 3;
            this.colApartmentName.Width = 319;
            // 
            // colBuildYear
            // 
            this.colBuildYear.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colBuildYear.AppearanceCell.Options.UseFont = true;
            this.colBuildYear.AppearanceCell.Options.UseTextOptions = true;
            this.colBuildYear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBuildYear.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colBuildYear.AppearanceHeader.Options.UseFont = true;
            this.colBuildYear.AppearanceHeader.Options.UseTextOptions = true;
            this.colBuildYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBuildYear.Caption = "건축년도";
            this.colBuildYear.FieldName = "BuildYear";
            this.colBuildYear.Name = "colBuildYear";
            this.colBuildYear.Visible = true;
            this.colBuildYear.VisibleIndex = 2;
            this.colBuildYear.Width = 93;
            // 
            // colAreaForExclusiveUse
            // 
            this.colAreaForExclusiveUse.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colAreaForExclusiveUse.AppearanceCell.Options.UseFont = true;
            this.colAreaForExclusiveUse.AppearanceCell.Options.UseTextOptions = true;
            this.colAreaForExclusiveUse.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colAreaForExclusiveUse.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colAreaForExclusiveUse.AppearanceHeader.Options.UseFont = true;
            this.colAreaForExclusiveUse.AppearanceHeader.Options.UseTextOptions = true;
            this.colAreaForExclusiveUse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAreaForExclusiveUse.Caption = "전용면적";
            this.colAreaForExclusiveUse.FieldName = "AreaForExclusiveUse";
            this.colAreaForExclusiveUse.Name = "colAreaForExclusiveUse";
            this.colAreaForExclusiveUse.Visible = true;
            this.colAreaForExclusiveUse.VisibleIndex = 6;
            this.colAreaForExclusiveUse.Width = 135;
            // 
            // colFloor
            // 
            this.colFloor.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colFloor.AppearanceCell.Options.UseFont = true;
            this.colFloor.AppearanceCell.Options.UseTextOptions = true;
            this.colFloor.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFloor.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colFloor.AppearanceHeader.Options.UseFont = true;
            this.colFloor.AppearanceHeader.Options.UseTextOptions = true;
            this.colFloor.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colFloor.Caption = "층";
            this.colFloor.FieldName = "Floor";
            this.colFloor.Name = "colFloor";
            this.colFloor.Visible = true;
            this.colFloor.VisibleIndex = 5;
            this.colFloor.Width = 59;
            // 
            // colDear
            // 
            this.colDear.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDear.AppearanceCell.Options.UseFont = true;
            this.colDear.AppearanceCell.Options.UseTextOptions = true;
            this.colDear.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDear.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDear.AppearanceHeader.Options.UseFont = true;
            this.colDear.AppearanceHeader.Options.UseTextOptions = true;
            this.colDear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDear.Caption = "거래날짜";
            this.colDear.FieldName = "Dear";
            this.colDear.Name = "colDear";
            this.colDear.Visible = true;
            this.colDear.VisibleIndex = 7;
            this.colDear.Width = 217;
            // 
            // colDealYear
            // 
            this.colDealYear.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealYear.AppearanceCell.Options.UseFont = true;
            this.colDealYear.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealYear.AppearanceHeader.Options.UseFont = true;
            this.colDealYear.AppearanceHeader.Options.UseTextOptions = true;
            this.colDealYear.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDealYear.Caption = "년";
            this.colDealYear.FieldName = "DealYear";
            this.colDealYear.Name = "colDealYear";
            // 
            // colDealMonth
            // 
            this.colDealMonth.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealMonth.AppearanceCell.Options.UseFont = true;
            this.colDealMonth.AppearanceCell.Options.UseTextOptions = true;
            this.colDealMonth.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDealMonth.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealMonth.AppearanceHeader.Options.UseFont = true;
            this.colDealMonth.AppearanceHeader.Options.UseTextOptions = true;
            this.colDealMonth.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDealMonth.Caption = "월";
            this.colDealMonth.FieldName = "DealMonth";
            this.colDealMonth.Name = "colDealMonth";
            this.colDealMonth.Width = 76;
            // 
            // colDealDay
            // 
            this.colDealDay.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealDay.AppearanceCell.Options.UseFont = true;
            this.colDealDay.AppearanceCell.Options.UseTextOptions = true;
            this.colDealDay.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDealDay.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealDay.AppearanceHeader.Options.UseFont = true;
            this.colDealDay.AppearanceHeader.Options.UseTextOptions = true;
            this.colDealDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDealDay.Caption = "일";
            this.colDealDay.FieldName = "DealDay";
            this.colDealDay.Name = "colDealDay";
            this.colDealDay.Width = 57;
            // 
            // colDong
            // 
            this.colDong.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDong.AppearanceCell.Options.UseFont = true;
            this.colDong.AppearanceCell.Options.UseTextOptions = true;
            this.colDong.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDong.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDong.AppearanceHeader.Options.UseFont = true;
            this.colDong.AppearanceHeader.Options.UseTextOptions = true;
            this.colDong.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDong.Caption = "동";
            this.colDong.FieldName = "Dong";
            this.colDong.Name = "colDong";
            this.colDong.Visible = true;
            this.colDong.VisibleIndex = 1;
            this.colDong.Width = 115;
            // 
            // colDealAmount
            // 
            this.colDealAmount.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealAmount.AppearanceCell.Options.UseFont = true;
            this.colDealAmount.AppearanceCell.Options.UseTextOptions = true;
            this.colDealAmount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.colDealAmount.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colDealAmount.AppearanceHeader.Options.UseFont = true;
            this.colDealAmount.AppearanceHeader.Options.UseTextOptions = true;
            this.colDealAmount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDealAmount.Caption = "거래금액";
            this.colDealAmount.FieldName = "DealAmount";
            this.colDealAmount.Name = "colDealAmount";
            this.colDealAmount.Visible = true;
            this.colDealAmount.VisibleIndex = 8;
            this.colDealAmount.Width = 148;
            // 
            // colJibun
            // 
            this.colJibun.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colJibun.AppearanceCell.Options.UseFont = true;
            this.colJibun.AppearanceCell.Options.UseTextOptions = true;
            this.colJibun.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJibun.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colJibun.AppearanceHeader.Options.UseFont = true;
            this.colJibun.AppearanceHeader.Options.UseTextOptions = true;
            this.colJibun.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJibun.Caption = "지번";
            this.colJibun.FieldName = "Jibun";
            this.colJibun.Name = "colJibun";
            this.colJibun.Visible = true;
            this.colJibun.VisibleIndex = 4;
            this.colJibun.Width = 102;
            // 
            // colRegionalCode
            // 
            this.colRegionalCode.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colRegionalCode.AppearanceCell.Options.UseFont = true;
            this.colRegionalCode.AppearanceCell.Options.UseTextOptions = true;
            this.colRegionalCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegionalCode.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colRegionalCode.AppearanceHeader.Options.UseFont = true;
            this.colRegionalCode.AppearanceHeader.Options.UseTextOptions = true;
            this.colRegionalCode.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRegionalCode.Caption = "지역코드";
            this.colRegionalCode.FieldName = "RegionalCode";
            this.colRegionalCode.Name = "colRegionalCode";
            this.colRegionalCode.Width = 142;
            // 
            // colCancelDealDay
            // 
            this.colCancelDealDay.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colCancelDealDay.AppearanceCell.Options.UseFont = true;
            this.colCancelDealDay.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colCancelDealDay.AppearanceHeader.Options.UseFont = true;
            this.colCancelDealDay.AppearanceHeader.Options.UseTextOptions = true;
            this.colCancelDealDay.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCancelDealDay.Caption = "해제여부";
            this.colCancelDealDay.FieldName = "CancelDealDay";
            this.colCancelDealDay.Name = "colCancelDealDay";
            this.colCancelDealDay.Visible = true;
            this.colCancelDealDay.VisibleIndex = 9;
            this.colCancelDealDay.Width = 148;
            // 
            // colCancelDealType
            // 
            this.colCancelDealType.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colCancelDealType.AppearanceCell.Options.UseFont = true;
            this.colCancelDealType.AppearanceHeader.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.colCancelDealType.AppearanceHeader.Options.UseFont = true;
            this.colCancelDealType.AppearanceHeader.Options.UseTextOptions = true;
            this.colCancelDealType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCancelDealType.Caption = "해제사유발생일";
            this.colCancelDealType.FieldName = "CancelDealType";
            this.colCancelDealType.Name = "colCancelDealType";
            this.colCancelDealType.Visible = true;
            this.colCancelDealType.VisibleIndex = 10;
            this.colCancelDealType.Width = 221;
            // 
            // ListViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 492);
            this.Controls.Add(this.gcList);
            this.Controls.Add(this.panelControl1);
            this.Name = "ListViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboLAWD_CD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraGrid.GridControl gcList;
        private DevExpress.XtraGrid.Views.Grid.GridView gvList;
        private DevExpress.XtraGrid.Columns.GridColumn colApartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colBuildYear;
        private DevExpress.XtraGrid.Columns.GridColumn colAreaForExclusiveUse;
        private DevExpress.XtraGrid.Columns.GridColumn colFloor;
        private DevExpress.XtraGrid.Columns.GridColumn colDealMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colDealDay;
        private DevExpress.XtraGrid.Columns.GridColumn colDong;
        private DevExpress.XtraGrid.Columns.GridColumn colDealAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colJibun;
        private DevExpress.XtraGrid.Columns.GridColumn colRegionalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelDealDay;
        private DevExpress.XtraGrid.Columns.GridColumn colCancelDealType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deDEAL_YMD;
        private DevExpress.XtraEditors.ImageComboBoxEdit comboLAWD_CD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colDear;
        private DevExpress.XtraGrid.Columns.GridColumn colDealYear;
        private DevExpress.XtraGrid.Columns.GridColumn colNo;
    }
}