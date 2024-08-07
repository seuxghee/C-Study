namespace PointNet
{
    partial class frm_PA_Test20240807
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinGrid.UltraGridBand ultraGridBand1 = new Infragistics.Win.UltraWinGrid.UltraGridBand("", -1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn21 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PATID", 0);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn22 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("PATNAME", 1);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn23 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("BIRTHDATE", 2);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn24 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("SEX", 3);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn25 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HOMEADDR", 4);
            Infragistics.Win.UltraWinGrid.UltraGridColumn ultraGridColumn26 = new Infragistics.Win.UltraWinGrid.UltraGridColumn("HANDPHONENO", 5);
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.UltraWinScrollBar.ScrollBarLook scrollBarLook1 = new Infragistics.Win.UltraWinScrollBar.ScrollBarLook();
            this.utgrdPatList = new Infragistics.Win.UltraWinGrid.UltraGrid();
            this.uttxtSearch = new Infragistics.Win.UltraWinEditors.UltraTextEditor();
            this.utbtnSearch = new Infragistics.Win.Misc.UltraButton();
            ((System.ComponentModel.ISupportInitialize)(this.utgrdPatList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uttxtSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // utgrdPatList
            // 
            this.utgrdPatList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            appearance1.BackColor = System.Drawing.Color.White;
            appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.utgrdPatList.DisplayLayout.Appearance = appearance1;
            this.utgrdPatList.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
            ultraGridColumn21.Header.VisiblePosition = 0;
            ultraGridColumn21.Width = 448;
            ultraGridColumn22.Header.VisiblePosition = 1;
            ultraGridColumn22.Width = 111;
            ultraGridColumn23.Header.VisiblePosition = 2;
            ultraGridColumn23.Width = 132;
            ultraGridColumn24.Header.VisiblePosition = 3;
            ultraGridColumn24.Width = 166;
            ultraGridColumn25.Header.VisiblePosition = 4;
            ultraGridColumn25.Width = 205;
            ultraGridColumn26.Header.VisiblePosition = 5;
            ultraGridColumn26.Width = 255;
            ultraGridBand1.Columns.AddRange(new object[] {
            ultraGridColumn21,
            ultraGridColumn22,
            ultraGridColumn23,
            ultraGridColumn24,
            ultraGridColumn25,
            ultraGridColumn26});
            appearance2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            appearance2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            ultraGridBand1.Override.ActiveRowAppearance = appearance2;
            ultraGridBand1.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            appearance3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            appearance3.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            ultraGridBand1.Override.HotTrackRowAppearance = appearance3;
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            appearance4.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            ultraGridBand1.Override.SelectedRowAppearance = appearance4;
            this.utgrdPatList.DisplayLayout.BandsSerializer.Add(ultraGridBand1);
            this.utgrdPatList.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.utgrdPatList.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            this.utgrdPatList.DisplayLayout.EmptyRowSettings.ShowEmptyRows = true;
            this.utgrdPatList.DisplayLayout.EmptyRowSettings.Style = Infragistics.Win.UltraWinGrid.EmptyRowStyle.ExtendRowSelector;
            appearance5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance5.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance5.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance5.BorderColor = System.Drawing.SystemColors.Window;
            this.utgrdPatList.DisplayLayout.GroupByBox.Appearance = appearance5;
            appearance6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.utgrdPatList.DisplayLayout.GroupByBox.BandLabelAppearance = appearance6;
            this.utgrdPatList.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance7.BackColor2 = System.Drawing.SystemColors.Control;
            appearance7.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.utgrdPatList.DisplayLayout.GroupByBox.PromptAppearance = appearance7;
            this.utgrdPatList.DisplayLayout.MaxColScrollRegions = 1;
            this.utgrdPatList.DisplayLayout.MaxRowScrollRegions = 1;
            appearance8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            appearance8.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            this.utgrdPatList.DisplayLayout.Override.ActiveRowAppearance = appearance8;
            appearance9.BorderColor = System.Drawing.Color.Silver;
            appearance9.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.utgrdPatList.DisplayLayout.Override.CellAppearance = appearance9;
            this.utgrdPatList.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.RowSelect;
            this.utgrdPatList.DisplayLayout.Override.CellPadding = 0;
            appearance10.BackColor = System.Drawing.SystemColors.Control;
            appearance10.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance10.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.BorderColor = System.Drawing.SystemColors.Window;
            this.utgrdPatList.DisplayLayout.Override.GroupByRowAppearance = appearance10;
            appearance11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            appearance11.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            appearance11.TextHAlignAsString = "Center";
            this.utgrdPatList.DisplayLayout.Override.HeaderAppearance = appearance11;
            this.utgrdPatList.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.utgrdPatList.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            appearance12.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(250)))));
            this.utgrdPatList.DisplayLayout.Override.HotTrackRowAppearance = appearance12;
            this.utgrdPatList.DisplayLayout.Override.MultiCellSelectionMode = Infragistics.Win.UltraWinGrid.MultiCellSelectionMode.Standard;
            appearance13.BackColor = System.Drawing.SystemColors.Window;
            appearance13.BorderColor = System.Drawing.Color.Silver;
            this.utgrdPatList.DisplayLayout.Override.RowAppearance = appearance13;
            this.utgrdPatList.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            appearance14.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(230)))), ((int)(((byte)(247)))));
            appearance14.ForeColor = System.Drawing.Color.Black;
            this.utgrdPatList.DisplayLayout.Override.SelectedRowAppearance = appearance14;
            appearance15.BackColor = System.Drawing.SystemColors.ControlLight;
            this.utgrdPatList.DisplayLayout.Override.TemplateAddRowAppearance = appearance15;
            scrollBarLook1.ViewStyle = Infragistics.Win.UltraWinScrollBar.ScrollBarViewStyle.Office2013;
            this.utgrdPatList.DisplayLayout.ScrollBarLook = scrollBarLook1;
            this.utgrdPatList.DisplayLayout.Scrollbars = Infragistics.Win.UltraWinGrid.Scrollbars.Vertical;
            this.utgrdPatList.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.utgrdPatList.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.utgrdPatList.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.utgrdPatList.Location = new System.Drawing.Point(22, 64);
            this.utgrdPatList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.utgrdPatList.Name = "utgrdPatList";
            this.utgrdPatList.Size = new System.Drawing.Size(1336, 624);
            this.utgrdPatList.TabIndex = 170;
            this.utgrdPatList.UseFlatMode = Infragistics.Win.DefaultableBoolean.True;
            this.utgrdPatList.UseOsThemes = Infragistics.Win.DefaultableBoolean.False;
            // 
            // uttxtSearch
            // 
            this.uttxtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uttxtSearch.Location = new System.Drawing.Point(22, 21);
            this.uttxtSearch.Name = "uttxtSearch";
            this.uttxtSearch.Size = new System.Drawing.Size(1255, 27);
            this.uttxtSearch.TabIndex = 171;
            // 
            // utbtnSearch
            // 
            this.utbtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.utbtnSearch.Location = new System.Drawing.Point(1283, 25);
            this.utbtnSearch.Name = "utbtnSearch";
            this.utbtnSearch.Size = new System.Drawing.Size(75, 23);
            this.utbtnSearch.TabIndex = 172;
            this.utbtnSearch.Text = "검색";
            this.utbtnSearch.Click += new System.EventHandler(this.utbtnSearch_Click);
            // 
            // frm_PA_Test20240807
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 701);
            this.Controls.Add(this.utbtnSearch);
            this.Controls.Add(this.uttxtSearch);
            this.Controls.Add(this.utgrdPatList);
            this.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_PA_Test20240807";
            this.ShowIcon = false;
            this.Text = "frm_PA_Test20240807";
            ((System.ComponentModel.ISupportInitialize)(this.utgrdPatList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uttxtSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Infragistics.Win.UltraWinGrid.UltraGrid utgrdPatList;
        private Infragistics.Win.UltraWinEditors.UltraTextEditor uttxtSearch;
        private Infragistics.Win.Misc.UltraButton utbtnSearch;
    }
}