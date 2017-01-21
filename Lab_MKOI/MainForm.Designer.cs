namespace Lab_MKOI
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MKOIMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addConstantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mulConstToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negativToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitPlainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labThreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.histToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otsuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labFourStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lowFrequencyFilterStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.averageFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.highFreequencyFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laplassianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsharpMaskingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightMedianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maxFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labFiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findPointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeFindToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.beforePictureBox = new System.Windows.Forms.PictureBox();
            this.afterPictureBox = new System.Windows.Forms.PictureBox();
            this.MKOIMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MKOIMenuStrip
            // 
            this.MKOIMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.labOneToolStripMenuItem,
            this.labTwoToolStripMenuItem,
            this.labThreeToolStripMenuItem,
            this.labFourStripMenuItem,
            this.labFiveToolStripMenuItem});
            this.MKOIMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MKOIMenuStrip.Name = "MKOIMenuStrip";
            this.MKOIMenuStrip.Size = new System.Drawing.Size(756, 24);
            this.MKOIMenuStrip.TabIndex = 0;
            this.MKOIMenuStrip.Text = "MKOIMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.openToolStripMenuItem.Text = "Открыть изображение";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // labOneToolStripMenuItem
            // 
            this.labOneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addConstantToolStripMenuItem,
            this.mulConstToolStripMenuItem,
            this.negativToolStripMenuItem,
            this.logToolStripMenuItem,
            this.powerToolStripMenuItem});
            this.labOneToolStripMenuItem.Name = "labOneToolStripMenuItem";
            this.labOneToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.labOneToolStripMenuItem.Text = "Первая лаба ";
            // 
            // addConstantToolStripMenuItem
            // 
            this.addConstantToolStripMenuItem.Name = "addConstantToolStripMenuItem";
            this.addConstantToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.addConstantToolStripMenuItem.Text = "Добавить константу";
            this.addConstantToolStripMenuItem.Click += new System.EventHandler(this.addConstantToolStripMenuItem_Click);
            // 
            // mulConstToolStripMenuItem
            // 
            this.mulConstToolStripMenuItem.Name = "mulConstToolStripMenuItem";
            this.mulConstToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.mulConstToolStripMenuItem.Text = "Умножить на константу";
            this.mulConstToolStripMenuItem.Click += new System.EventHandler(this.mulConstToolStripMenuItem_Click);
            // 
            // negativToolStripMenuItem
            // 
            this.negativToolStripMenuItem.Name = "negativToolStripMenuItem";
            this.negativToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.negativToolStripMenuItem.Text = "Негатив";
            this.negativToolStripMenuItem.Click += new System.EventHandler(this.negativToolStripMenuItem_Click);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.logToolStripMenuItem.Text = "Логарифмическое преобразование";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(271, 22);
            this.powerToolStripMenuItem.Text = "Возведение в степень";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // labTwoToolStripMenuItem
            // 
            this.labTwoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histCreateToolStripMenuItem,
            this.bitPlainToolStripMenuItem,
            this.linearContrastToolStripMenuItem});
            this.labTwoToolStripMenuItem.Name = "labTwoToolStripMenuItem";
            this.labTwoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.labTwoToolStripMenuItem.Text = "Вторая лаба";
            // 
            // histCreateToolStripMenuItem
            // 
            this.histCreateToolStripMenuItem.Name = "histCreateToolStripMenuItem";
            this.histCreateToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.histCreateToolStripMenuItem.Text = "Построить гистограмму";
            this.histCreateToolStripMenuItem.Click += new System.EventHandler(this.histCreateToolStripMenuItem_Click);
            // 
            // bitPlainToolStripMenuItem
            // 
            this.bitPlainToolStripMenuItem.Name = "bitPlainToolStripMenuItem";
            this.bitPlainToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.bitPlainToolStripMenuItem.Text = "Битовые плоскости";
            this.bitPlainToolStripMenuItem.Click += new System.EventHandler(this.bitPlainToolStripMenuItem_Click);
            // 
            // linearContrastToolStripMenuItem
            // 
            this.linearContrastToolStripMenuItem.Name = "linearContrastToolStripMenuItem";
            this.linearContrastToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.linearContrastToolStripMenuItem.Text = "Линейное контрастирование";
            this.linearContrastToolStripMenuItem.Click += new System.EventHandler(this.linearContrastToolStripMenuItem_Click);
            // 
            // labThreeToolStripMenuItem
            // 
            this.labThreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.histToolStripMenuItem,
            this.gradToolStripMenuItem,
            this.otsuToolStripMenuItem});
            this.labThreeToolStripMenuItem.Name = "labThreeToolStripMenuItem";
            this.labThreeToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.labThreeToolStripMenuItem.Text = "Третья лаба";
            // 
            // histToolStripMenuItem
            // 
            this.histToolStripMenuItem.Name = "histToolStripMenuItem";
            this.histToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.histToolStripMenuItem.Text = "Пороговая обработка (гистограмма)";
            this.histToolStripMenuItem.Click += new System.EventHandler(this.histToolStripMenuItem_Click);
            // 
            // gradToolStripMenuItem
            // 
            this.gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            this.gradToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.gradToolStripMenuItem.Text = "Пороговая обработка (градиент)";
            this.gradToolStripMenuItem.Click += new System.EventHandler(this.gradToolStripMenuItem_Click);
            // 
            // otsuToolStripMenuItem
            // 
            this.otsuToolStripMenuItem.Name = "otsuToolStripMenuItem";
            this.otsuToolStripMenuItem.Size = new System.Drawing.Size(278, 22);
            this.otsuToolStripMenuItem.Text = "Пороговая обработка (Оцу)";
            this.otsuToolStripMenuItem.Click += new System.EventHandler(this.otsuToolStripMenuItem_Click);
            // 
            // labFourStripMenuItem
            // 
            this.labFourStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lowFrequencyFilterStripMenuItem,
            this.highFreequencyFilterToolStripMenuItem,
            this.medianFilterToolStripMenuItem,
            this.weightMedianFilterToolStripMenuItem,
            this.maxFilterToolStripMenuItem,
            this.minFilterToolStripMenuItem});
            this.labFourStripMenuItem.Name = "labFourStripMenuItem";
            this.labFourStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.labFourStripMenuItem.Text = "Четвертая лаба";
            // 
            // lowFrequencyFilterStripMenuItem
            // 
            this.lowFrequencyFilterStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.averageFilterToolStripMenuItem,
            this.gaussFilterToolStripMenuItem});
            this.lowFrequencyFilterStripMenuItem.Name = "lowFrequencyFilterStripMenuItem";
            this.lowFrequencyFilterStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.lowFrequencyFilterStripMenuItem.Text = "Низкочастотные фильтры";
            // 
            // averageFilterToolStripMenuItem
            // 
            this.averageFilterToolStripMenuItem.Name = "averageFilterToolStripMenuItem";
            this.averageFilterToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.averageFilterToolStripMenuItem.Text = "Однородный усредняющий";
            this.averageFilterToolStripMenuItem.Click += new System.EventHandler(this.averageFilterToolStripMenuItem_Click);
            // 
            // gaussFilterToolStripMenuItem
            // 
            this.gaussFilterToolStripMenuItem.Name = "gaussFilterToolStripMenuItem";
            this.gaussFilterToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.gaussFilterToolStripMenuItem.Text = "Гаусса";
            this.gaussFilterToolStripMenuItem.Click += new System.EventHandler(this.gaussFilterToolStripMenuItem_Click);
            // 
            // highFreequencyFilterToolStripMenuItem
            // 
            this.highFreequencyFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laplassianToolStripMenuItem,
            this.unsharpMaskingToolStripMenuItem});
            this.highFreequencyFilterToolStripMenuItem.Name = "highFreequencyFilterToolStripMenuItem";
            this.highFreequencyFilterToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.highFreequencyFilterToolStripMenuItem.Text = "Высокочастотные фильтры";
            // 
            // laplassianToolStripMenuItem
            // 
            this.laplassianToolStripMenuItem.Name = "laplassianToolStripMenuItem";
            this.laplassianToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.laplassianToolStripMenuItem.Text = "На основе лаплассиана";
            this.laplassianToolStripMenuItem.Click += new System.EventHandler(this.laplassianToolStripMenuItem_Click);
            // 
            // unsharpMaskingToolStripMenuItem
            // 
            this.unsharpMaskingToolStripMenuItem.Name = "unsharpMaskingToolStripMenuItem";
            this.unsharpMaskingToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.unsharpMaskingToolStripMenuItem.Text = "Нерезкое маскирование";
            this.unsharpMaskingToolStripMenuItem.Click += new System.EventHandler(this.unsharpMaskingToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.medianFilterToolStripMenuItem.Text = "Медианный фильтр";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // weightMedianFilterToolStripMenuItem
            // 
            this.weightMedianFilterToolStripMenuItem.Name = "weightMedianFilterToolStripMenuItem";
            this.weightMedianFilterToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.weightMedianFilterToolStripMenuItem.Text = "Взвешенный медианный фильтр";
            this.weightMedianFilterToolStripMenuItem.Click += new System.EventHandler(this.weightMedianFilterToolStripMenuItem_Click);
            // 
            // maxFilterToolStripMenuItem
            // 
            this.maxFilterToolStripMenuItem.Name = "maxFilterToolStripMenuItem";
            this.maxFilterToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.maxFilterToolStripMenuItem.Text = "Фильтр максимума";
            this.maxFilterToolStripMenuItem.Click += new System.EventHandler(this.maxFilterToolStripMenuItem_Click);
            // 
            // minFilterToolStripMenuItem
            // 
            this.minFilterToolStripMenuItem.Name = "minFilterToolStripMenuItem";
            this.minFilterToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.minFilterToolStripMenuItem.Text = "Фильтр минимума";
            this.minFilterToolStripMenuItem.Click += new System.EventHandler(this.minFilterToolStripMenuItem_Click);
            // 
            // labFiveToolStripMenuItem
            // 
            this.labFiveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findPointsToolStripMenuItem,
            this.lineFindToolStripMenuItem,
            this.edgeFindToolStripMenuItem});
            this.labFiveToolStripMenuItem.Name = "labFiveToolStripMenuItem";
            this.labFiveToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.labFiveToolStripMenuItem.Text = "Пятая лаба";
            // 
            // findPointsToolStripMenuItem
            // 
            this.findPointsToolStripMenuItem.Name = "findPointsToolStripMenuItem";
            this.findPointsToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.findPointsToolStripMenuItem.Text = "Обнаружение точек";
            this.findPointsToolStripMenuItem.Click += new System.EventHandler(this.findPointsToolStripMenuItem_Click);
            // 
            // lineFindToolStripMenuItem
            // 
            this.lineFindToolStripMenuItem.Name = "lineFindToolStripMenuItem";
            this.lineFindToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.lineFindToolStripMenuItem.Text = "Обнаружение линий";
            this.lineFindToolStripMenuItem.Click += new System.EventHandler(this.обнаружениеЛинийToolStripMenuItem_Click);
            // 
            // edgeFindToolStripMenuItem
            // 
            this.edgeFindToolStripMenuItem.Name = "edgeFindToolStripMenuItem";
            this.edgeFindToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.edgeFindToolStripMenuItem.Text = "Обнаружение краев";
            this.edgeFindToolStripMenuItem.Click += new System.EventHandler(this.edgeFindToolStripMenuItem_Click);
            // 
            // beforePictureBox
            // 
            this.beforePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.beforePictureBox.Location = new System.Drawing.Point(12, 27);
            this.beforePictureBox.Name = "beforePictureBox";
            this.beforePictureBox.Size = new System.Drawing.Size(351, 421);
            this.beforePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.beforePictureBox.TabIndex = 1;
            this.beforePictureBox.TabStop = false;
            // 
            // afterPictureBox
            // 
            this.afterPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.afterPictureBox.Location = new System.Drawing.Point(369, 27);
            this.afterPictureBox.Name = "afterPictureBox";
            this.afterPictureBox.Size = new System.Drawing.Size(375, 421);
            this.afterPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.afterPictureBox.TabIndex = 2;
            this.afterPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 460);
            this.Controls.Add(this.afterPictureBox);
            this.Controls.Add(this.beforePictureBox);
            this.Controls.Add(this.MKOIMenuStrip);
            this.MainMenuStrip = this.MKOIMenuStrip;
            this.Name = "MainForm";
            this.Text = "MKOI";
            this.MKOIMenuStrip.ResumeLayout(false);
            this.MKOIMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.beforePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afterPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MKOIMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem labOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addConstantToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.PictureBox beforePictureBox;
        public System.Windows.Forms.PictureBox afterPictureBox;
        private System.Windows.Forms.ToolStripMenuItem mulConstToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negativToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitPlainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearContrastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labThreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem histToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otsuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labFourStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lowFrequencyFilterStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem averageFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem highFreequencyFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laplassianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsharpMaskingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maxFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightMedianFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labFiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findPointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineFindToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeFindToolStripMenuItem;
    }
}

