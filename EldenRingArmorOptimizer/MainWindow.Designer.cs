
namespace EldenRingArmorOptimizer {
    partial class MainWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Blank Item",
            "Test",
            "#.#",
            "#.#",
            "#.#",
            "#.#",
            "#.#"}, -1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Blank Item",
            "#.#",
            "#.#",
            "#.#",
            "#.#",
            "#.#"}, -1);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEquip = new System.Windows.Forms.TabPage();
            this.listViewEquipment = new System.Windows.Forms.ListView();
            this.columnHeaderNam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderWgt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhys = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.listViewResults = new System.Windows.Forms.ListView();
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownMaxDiff = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownExWeight = new System.Windows.Forms.NumericUpDown();
            this.comboBoxDesiredLd = new System.Windows.Forms.ComboBox();
            this.labelSetXWgt = new System.Windows.Forms.Label();
            this.labelSetDLoad = new System.Windows.Forms.Label();
            this.labelSetWLim = new System.Windows.Forms.Label();
            this.labelSetPriority = new System.Windows.Forms.Label();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.numericUpDownWgtLimit = new System.Windows.Forms.NumericUpDown();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageEquip.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.tabPageSettings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDiff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWgtLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStart, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonRemove, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.Location = new System.Drawing.Point(463, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(113, 34);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "START SEARCH";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRemove.Location = new System.Drawing.Point(118, 3);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(109, 34);
            this.buttonRemove.TabIndex = 1;
            this.buttonRemove.Text = "Remove Selected";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 34);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Item";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabControl1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tabControl1, 5);
            this.tabControl1.Controls.Add(this.tabPageEquip);
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Controls.Add(this.tabPageSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(573, 233);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPageEquip
            // 
            this.tabPageEquip.Controls.Add(this.listViewEquipment);
            this.tabPageEquip.Location = new System.Drawing.Point(4, 22);
            this.tabPageEquip.Name = "tabPageEquip";
            this.tabPageEquip.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEquip.Size = new System.Drawing.Size(565, 207);
            this.tabPageEquip.TabIndex = 0;
            this.tabPageEquip.Text = "Helms";
            this.tabPageEquip.UseVisualStyleBackColor = true;
            // 
            // listViewEquipment
            // 
            this.listViewEquipment.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listViewEquipment.AllowColumnReorder = true;
            this.listViewEquipment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNam,
            this.columnHeaderType,
            this.columnHeaderWgt,
            this.columnHeaderPhys,
            this.columnHeaderMag,
            this.columnHeaderRes,
            this.columnHeaderPoi});
            this.listViewEquipment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewEquipment.FullRowSelect = true;
            this.listViewEquipment.GridLines = true;
            this.listViewEquipment.HideSelection = false;
            listViewItem13.StateImageIndex = 0;
            this.listViewEquipment.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem13});
            this.listViewEquipment.Location = new System.Drawing.Point(3, 3);
            this.listViewEquipment.Name = "listViewEquipment";
            this.listViewEquipment.Size = new System.Drawing.Size(559, 201);
            this.listViewEquipment.TabIndex = 0;
            this.listViewEquipment.UseCompatibleStateImageBehavior = false;
            this.listViewEquipment.View = System.Windows.Forms.View.Details;
            this.listViewEquipment.ItemActivate += new System.EventHandler(this.listView_Item_Click);
            // 
            // columnHeaderNam
            // 
            this.columnHeaderNam.Text = "Name";
            this.columnHeaderNam.Width = 217;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Text = "Type";
            this.columnHeaderType.Width = 78;
            // 
            // columnHeaderWgt
            // 
            this.columnHeaderWgt.Text = "Weight";
            this.columnHeaderWgt.Width = 50;
            // 
            // columnHeaderPhys
            // 
            this.columnHeaderPhys.Text = "Phys.";
            this.columnHeaderPhys.Width = 44;
            // 
            // columnHeaderMag
            // 
            this.columnHeaderMag.Text = "Magic";
            this.columnHeaderMag.Width = 45;
            // 
            // columnHeaderRes
            // 
            this.columnHeaderRes.Text = "Resist";
            this.columnHeaderRes.Width = 44;
            // 
            // columnHeaderPoi
            // 
            this.columnHeaderPoi.Text = "Poise";
            this.columnHeaderPoi.Width = 38;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.listViewResults);
            this.tabPageResults.Location = new System.Drawing.Point(4, 22);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(565, 207);
            this.tabPageResults.TabIndex = 5;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // listViewResults
            // 
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader19,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.listViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem14});
            this.listViewResults.Location = new System.Drawing.Point(3, 3);
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(559, 201);
            this.listViewResults.TabIndex = 1;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Helm";
            this.columnHeader19.Width = 75;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Chest";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gloves";
            this.columnHeader2.Width = 75;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Legs";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Score";
            this.columnHeader4.Width = 41;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Weight";
            this.columnHeader20.Width = 46;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Phys.";
            this.columnHeader21.Width = 41;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Magic";
            this.columnHeader22.Width = 42;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Resist";
            this.columnHeader23.Width = 45;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Poise";
            this.columnHeader24.Width = 40;
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.Controls.Add(this.tableLayoutPanel2);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Size = new System.Drawing.Size(565, 207);
            this.tabPageSettings.TabIndex = 4;
            this.tabPageSettings.Text = "Settings";
            this.tabPageSettings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownMaxDiff, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownExWeight, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxDesiredLd, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelSetXWgt, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelSetDLoad, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelSetWLim, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelSetPriority, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxPriority, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.numericUpDownWgtLimit, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(565, 207);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // numericUpDownMaxDiff
            // 
            this.numericUpDownMaxDiff.DecimalPlaces = 3;
            this.numericUpDownMaxDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownMaxDiff.Location = new System.Drawing.Point(103, 107);
            this.numericUpDownMaxDiff.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownMaxDiff.Name = "numericUpDownMaxDiff";
            this.numericUpDownMaxDiff.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownMaxDiff.TabIndex = 24;
            this.numericUpDownMaxDiff.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 26);
            this.label1.TabIndex = 23;
            this.label1.Text = "Max Difference";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.label1, "Highest difference allowed in results. Anything lower than the best current resul" +
        "t by this much will be omitted.  Lower values will process quicker!");
            // 
            // numericUpDownExWeight
            // 
            this.numericUpDownExWeight.DecimalPlaces = 3;
            this.numericUpDownExWeight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownExWeight.Location = new System.Drawing.Point(103, 81);
            this.numericUpDownExWeight.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownExWeight.Name = "numericUpDownExWeight";
            this.numericUpDownExWeight.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownExWeight.TabIndex = 22;
            this.numericUpDownExWeight.Value = new decimal(new int[] {
            139,
            0,
            0,
            65536});
            // 
            // comboBoxDesiredLd
            // 
            this.comboBoxDesiredLd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxDesiredLd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDesiredLd.FormattingEnabled = true;
            this.comboBoxDesiredLd.Items.AddRange(new object[] {
            "Light Load",
            "Medium Load",
            "Heavy Load",
            "Unlimited"});
            this.comboBoxDesiredLd.Location = new System.Drawing.Point(103, 55);
            this.comboBoxDesiredLd.Name = "comboBoxDesiredLd";
            this.comboBoxDesiredLd.Size = new System.Drawing.Size(154, 21);
            this.comboBoxDesiredLd.TabIndex = 18;
            // 
            // labelSetXWgt
            // 
            this.labelSetXWgt.AutoSize = true;
            this.labelSetXWgt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSetXWgt.Location = new System.Drawing.Point(3, 78);
            this.labelSetXWgt.Name = "labelSetXWgt";
            this.labelSetXWgt.Size = new System.Drawing.Size(94, 26);
            this.labelSetXWgt.TabIndex = 13;
            this.labelSetXWgt.Text = "Extra Weight";
            this.labelSetXWgt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelSetXWgt, "Weight of any extra items (Weapons, Shields, Talismans, etc). This will be the we" +
        "ight shown with all armor removed!");
            // 
            // labelSetDLoad
            // 
            this.labelSetDLoad.AutoSize = true;
            this.labelSetDLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSetDLoad.Location = new System.Drawing.Point(3, 52);
            this.labelSetDLoad.Name = "labelSetDLoad";
            this.labelSetDLoad.Size = new System.Drawing.Size(94, 26);
            this.labelSetDLoad.TabIndex = 6;
            this.labelSetDLoad.Text = "Max. Load";
            this.labelSetDLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelSetDLoad, "Limit results to Light, Medium, or Heavy load");
            // 
            // labelSetWLim
            // 
            this.labelSetWLim.AutoSize = true;
            this.labelSetWLim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSetWLim.Location = new System.Drawing.Point(3, 26);
            this.labelSetWLim.Name = "labelSetWLim";
            this.labelSetWLim.Size = new System.Drawing.Size(94, 26);
            this.labelSetWLim.TabIndex = 1;
            this.labelSetWLim.Text = "Weight Limit";
            this.labelSetWLim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelSetWLim, "Weight Limit as displayed in-game");
            // 
            // labelSetPriority
            // 
            this.labelSetPriority.AutoSize = true;
            this.labelSetPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSetPriority.Location = new System.Drawing.Point(3, 0);
            this.labelSetPriority.Name = "labelSetPriority";
            this.labelSetPriority.Size = new System.Drawing.Size(94, 26);
            this.labelSetPriority.TabIndex = 0;
            this.labelSetPriority.Text = "Priority";
            this.labelSetPriority.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.labelSetPriority, "What to aim for the highest value of");
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Total Combined",
            "Total Phys+Mag",
            "Phys+Mag+Poise",
            "Total Physical",
            "Total Magic",
            "Total Resistances",
            "Strike",
            "Slash",
            "Pierce",
            "Magic",
            "Fire",
            "Lightning",
            "Holy",
            "Poise",
            "Immunity",
            "Robustness",
            "Focus",
            "Vitality"});
            this.comboBoxPriority.Location = new System.Drawing.Point(103, 3);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(154, 21);
            this.comboBoxPriority.TabIndex = 14;
            // 
            // numericUpDownWgtLimit
            // 
            this.numericUpDownWgtLimit.DecimalPlaces = 3;
            this.numericUpDownWgtLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownWgtLimit.Location = new System.Drawing.Point(103, 29);
            this.numericUpDownWgtLimit.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numericUpDownWgtLimit.Name = "numericUpDownWgtLimit";
            this.numericUpDownWgtLimit.Size = new System.Drawing.Size(154, 20);
            this.numericUpDownWgtLimit.TabIndex = 15;
            this.numericUpDownWgtLimit.Value = new decimal(new int[] {
            857,
            0,
            0,
            65536});
            // 
            // progressBar1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.progressBar1, 5);
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(3, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(573, 14);
            this.progressBar1.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 299);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Elden Ring Optimizer";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEquip.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.tabPageSettings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxDiff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWgtLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEquip;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDownExWeight;
        private System.Windows.Forms.ComboBox comboBoxDesiredLd;
        private System.Windows.Forms.Label labelSetXWgt;
        private System.Windows.Forms.Label labelSetDLoad;
        private System.Windows.Forms.Label labelSetWLim;
        private System.Windows.Forms.Label labelSetPriority;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.NumericUpDown numericUpDownWgtLimit;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.ListView listViewEquipment;
        private System.Windows.Forms.ColumnHeader columnHeaderNam;
        private System.Windows.Forms.ColumnHeader columnHeaderPhys;
        private System.Windows.Forms.ColumnHeader columnHeaderMag;
        private System.Windows.Forms.ColumnHeader columnHeaderRes;
        private System.Windows.Forms.ColumnHeader columnHeaderWgt;
        private System.Windows.Forms.ColumnHeader columnHeaderPoi;
        private System.Windows.Forms.ListView listViewResults;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxDiff;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

