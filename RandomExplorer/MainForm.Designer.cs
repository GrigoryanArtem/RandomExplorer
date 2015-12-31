namespace RandomExplorer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._scMain = new System.Windows.Forms.SplitContainer();
            this._tlpPicture = new System.Windows.Forms.TableLayoutPanel();
            this._pictureMain = new Tao.Platform.Windows.SimpleOpenGlControl();
            this._tplMainSideBar = new System.Windows.Forms.TableLayoutPanel();
            this._lbScheduleTitle = new System.Windows.Forms.Label();
            this._lbxSchedules = new System.Windows.Forms.ListBox();
            this._btnInfo = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnRemove = new System.Windows.Forms.Button();
            this._btnSettings = new System.Windows.Forms.Button();
            this._btnStart = new System.Windows.Forms.Button();
            this._scSideBar = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._scMain)).BeginInit();
            this._scMain.Panel1.SuspendLayout();
            this._scMain.Panel2.SuspendLayout();
            this._scMain.SuspendLayout();
            this._tlpPicture.SuspendLayout();
            this._tplMainSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._scSideBar)).BeginInit();
            this._scSideBar.Panel1.SuspendLayout();
            this._scSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _scMain
            // 
            this._scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scMain.Location = new System.Drawing.Point(0, 0);
            this._scMain.Name = "_scMain";
            // 
            // _scMain.Panel1
            // 
            this._scMain.Panel1.Controls.Add(this._tlpPicture);
            this._scMain.Panel1.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            // 
            // _scMain.Panel2
            // 
            this._scMain.Panel2.Controls.Add(this._scSideBar);
            this._scMain.Panel2.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this._scMain.Size = new System.Drawing.Size(790, 414);
            this._scMain.SplitterDistance = 507;
            this._scMain.TabIndex = 0;
            // 
            // _tlpPicture
            // 
            this._tlpPicture.ColumnCount = 1;
            this._tlpPicture.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpPicture.Controls.Add(this._pictureMain, 0, 0);
            this._tlpPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpPicture.Location = new System.Drawing.Point(10, 10);
            this._tlpPicture.Margin = new System.Windows.Forms.Padding(0);
            this._tlpPicture.Name = "_tlpPicture";
            this._tlpPicture.RowCount = 1;
            this._tlpPicture.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._tlpPicture.Size = new System.Drawing.Size(497, 394);
            this._tlpPicture.TabIndex = 0;
            // 
            // _pictureMain
            // 
            this._pictureMain.AccumBits = ((byte)(0));
            this._pictureMain.AutoCheckErrors = false;
            this._pictureMain.AutoFinish = false;
            this._pictureMain.AutoMakeCurrent = true;
            this._pictureMain.AutoSwapBuffers = true;
            this._pictureMain.BackColor = System.Drawing.Color.Black;
            this._pictureMain.ColorBits = ((byte)(32));
            this._pictureMain.DepthBits = ((byte)(16));
            this._pictureMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pictureMain.Location = new System.Drawing.Point(0, 0);
            this._pictureMain.Margin = new System.Windows.Forms.Padding(0);
            this._pictureMain.Name = "_pictureMain";
            this._pictureMain.Size = new System.Drawing.Size(497, 394);
            this._pictureMain.StencilBits = ((byte)(0));
            this._pictureMain.TabIndex = 0;
            // 
            // _tplMainSideBar
            // 
            this._tplMainSideBar.ColumnCount = 1;
            this._tplMainSideBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tplMainSideBar.Controls.Add(this._lbScheduleTitle, 0, 0);
            this._tplMainSideBar.Controls.Add(this._lbxSchedules, 0, 1);
            this._tplMainSideBar.Controls.Add(this._btnInfo, 0, 2);
            this._tplMainSideBar.Controls.Add(this._btnAdd, 0, 3);
            this._tplMainSideBar.Controls.Add(this._btnRemove, 0, 4);
            this._tplMainSideBar.Controls.Add(this._btnSettings, 0, 5);
            this._tplMainSideBar.Controls.Add(this._btnStart, 0, 6);
            this._tplMainSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tplMainSideBar.Location = new System.Drawing.Point(0, 0);
            this._tplMainSideBar.Margin = new System.Windows.Forms.Padding(0);
            this._tplMainSideBar.Name = "_tplMainSideBar";
            this._tplMainSideBar.RowCount = 7;
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tplMainSideBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this._tplMainSideBar.Size = new System.Drawing.Size(269, 394);
            this._tplMainSideBar.TabIndex = 0;
            // 
            // _lbScheduleTitle
            // 
            this._lbScheduleTitle.AutoSize = true;
            this._lbScheduleTitle.BackColor = System.Drawing.Color.LightGray;
            this._lbScheduleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbScheduleTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this._lbScheduleTitle.Location = new System.Drawing.Point(0, 0);
            this._lbScheduleTitle.Margin = new System.Windows.Forms.Padding(0);
            this._lbScheduleTitle.Name = "_lbScheduleTitle";
            this._lbScheduleTitle.Size = new System.Drawing.Size(269, 20);
            this._lbScheduleTitle.TabIndex = 0;
            this._lbScheduleTitle.Text = "Графики";
            this._lbScheduleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lbxSchedules
            // 
            this._lbxSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this._lbxSchedules.FormattingEnabled = true;
            this._lbxSchedules.ItemHeight = 14;
            this._lbxSchedules.Location = new System.Drawing.Point(0, 20);
            this._lbxSchedules.Margin = new System.Windows.Forms.Padding(0);
            this._lbxSchedules.Name = "_lbxSchedules";
            this._lbxSchedules.Size = new System.Drawing.Size(269, 199);
            this._lbxSchedules.TabIndex = 1;
            // 
            // _btnInfo
            // 
            this._btnInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnInfo.Location = new System.Drawing.Point(0, 222);
            this._btnInfo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._btnInfo.Name = "_btnInfo";
            this._btnInfo.Size = new System.Drawing.Size(269, 32);
            this._btnInfo.TabIndex = 2;
            this._btnInfo.Text = "Информация";
            this._btnInfo.UseVisualStyleBackColor = true;
            // 
            // _btnAdd
            // 
            this._btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnAdd.Location = new System.Drawing.Point(0, 257);
            this._btnAdd.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(269, 32);
            this._btnAdd.TabIndex = 3;
            this._btnAdd.Text = "Добавить";
            this._btnAdd.UseVisualStyleBackColor = true;
            // 
            // _btnRemove
            // 
            this._btnRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnRemove.Location = new System.Drawing.Point(0, 292);
            this._btnRemove.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._btnRemove.Name = "_btnRemove";
            this._btnRemove.Size = new System.Drawing.Size(269, 32);
            this._btnRemove.TabIndex = 4;
            this._btnRemove.Text = "Удалить";
            this._btnRemove.UseVisualStyleBackColor = true;
            // 
            // _btnSettings
            // 
            this._btnSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnSettings.Location = new System.Drawing.Point(0, 327);
            this._btnSettings.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._btnSettings.Name = "_btnSettings";
            this._btnSettings.Size = new System.Drawing.Size(269, 32);
            this._btnSettings.TabIndex = 5;
            this._btnSettings.Text = "Настройки";
            this._btnSettings.UseVisualStyleBackColor = true;
            this._btnSettings.Click += new System.EventHandler(this.btnSettingsClick);
            // 
            // _btnStart
            // 
            this._btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this._btnStart.Location = new System.Drawing.Point(0, 362);
            this._btnStart.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this._btnStart.Name = "_btnStart";
            this._btnStart.Size = new System.Drawing.Size(269, 32);
            this._btnStart.TabIndex = 6;
            this._btnStart.Text = "Запустить";
            this._btnStart.UseVisualStyleBackColor = true;
            // 
            // _scSideBar
            // 
            this._scSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scSideBar.Location = new System.Drawing.Point(0, 10);
            this._scSideBar.Margin = new System.Windows.Forms.Padding(0);
            this._scSideBar.Name = "_scSideBar";
            // 
            // _scSideBar.Panel1
            // 
            this._scSideBar.Panel1.Controls.Add(this._tplMainSideBar);
            this._scSideBar.Panel2Collapsed = true;
            this._scSideBar.Size = new System.Drawing.Size(269, 394);
            this._scSideBar.SplitterDistance = 136;
            this._scSideBar.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 414);
            this.Controls.Add(this._scMain);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Random Explorer";
            this._scMain.Panel1.ResumeLayout(false);
            this._scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._scMain)).EndInit();
            this._scMain.ResumeLayout(false);
            this._tlpPicture.ResumeLayout(false);
            this._tplMainSideBar.ResumeLayout(false);
            this._tplMainSideBar.PerformLayout();
            this._scSideBar.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._scSideBar)).EndInit();
            this._scSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer _scMain;
        private System.Windows.Forms.TableLayoutPanel _tlpPicture;
        private Tao.Platform.Windows.SimpleOpenGlControl _pictureMain;
        private System.Windows.Forms.TableLayoutPanel _tplMainSideBar;
        private System.Windows.Forms.Label _lbScheduleTitle;
        private System.Windows.Forms.ListBox _lbxSchedules;
        private System.Windows.Forms.Button _btnInfo;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnRemove;
        private System.Windows.Forms.Button _btnSettings;
        private System.Windows.Forms.Button _btnStart;
        private System.Windows.Forms.SplitContainer _scSideBar;
    }
}

