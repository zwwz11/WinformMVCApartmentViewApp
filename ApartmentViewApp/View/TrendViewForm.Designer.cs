namespace ApartmentViewApp.View
{
    partial class TrendViewForm
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
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtApartmentName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.comboLAWD_CD = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.deDEAL_YMD = new DevExpress.XtraEditors.DateEdit();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ApartmentViewApp.View.SearchWaitForm), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApartmentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboLAWD_CD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.DataBindings = null;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.Name = "Default Legend";
            this.chart.Location = new System.Drawing.Point(0, 46);
            this.chart.Name = "chart";
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.Size = new System.Drawing.Size(1150, 446);
            this.chart.TabIndex = 0;
            this.chart.ToolTipOptions.ShowForSeries = true;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtApartmentName);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.comboLAWD_CD);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.deDEAL_YMD);
            this.panelControl1.Controls.Add(this.btnSearch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1150, 46);
            this.panelControl1.TabIndex = 1;
            // 
            // txtApartmentName
            // 
            this.txtApartmentName.Location = new System.Drawing.Point(455, 13);
            this.txtApartmentName.Name = "txtApartmentName";
            this.txtApartmentName.Properties.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.txtApartmentName.Properties.Appearance.Options.UseFont = true;
            this.txtApartmentName.Size = new System.Drawing.Size(204, 22);
            this.txtApartmentName.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.labelControl3.Location = new System.Drawing.Point(413, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 15);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "아파트";
            // 
            // comboLAWD_CD
            // 
            this.comboLAWD_CD.Location = new System.Drawing.Point(250, 13);
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
            this.labelControl2.Location = new System.Drawing.Point(220, 16);
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
            this.labelControl1.Size = new System.Drawing.Size(68, 15);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "거래일자(년)";
            // 
            // deDEAL_YMD
            // 
            this.deDEAL_YMD.EditValue = null;
            this.deDEAL_YMD.Location = new System.Drawing.Point(97, 13);
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
            this.deDEAL_YMD.Properties.Mask.EditMask = "yyyy";
            this.deDEAL_YMD.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deDEAL_YMD.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
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
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // TrendViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 492);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.panelControl1);
            this.Name = "TrendViewForm";
            this.Text = "TrendViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtApartmentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboLAWD_CD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDEAL_YMD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chart;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtApartmentName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ImageComboBoxEdit comboLAWD_CD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit deDEAL_YMD;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
    }
}