
namespace FFTApplication
{
    partial class MainWindow
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GraphTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TimeDomain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FreqDomain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FreqBar = new System.Windows.Forms.TrackBar();
            this.FreqLbl = new System.Windows.Forms.Label();
            this.FreqBtnDown = new System.Windows.Forms.Button();
            this.FreqBtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FreqBtnUp = new System.Windows.Forms.Button();
            this.ComponentBtnLYT = new System.Windows.Forms.TableLayoutPanel();
            this.FreqSltBtnDel = new System.Windows.Forms.Button();
            this.PrvBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.MainWindowLayout = new System.Windows.Forms.TableLayoutPanel();
            this.UIPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StaticLbl = new System.Windows.Forms.Label();
            this.StaticBtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StaticBtnDown = new System.Windows.Forms.Button();
            this.StaticBtnUp = new System.Windows.Forms.Button();
            this.StaticBtnApply = new System.Windows.Forms.Button();
            this.StaticBar = new System.Windows.Forms.TrackBar();
            this.PhaseControlPanal = new System.Windows.Forms.TableLayoutPanel();
            this.PhaseLbl = new System.Windows.Forms.Label();
            this.PhaseBtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PhaseBtnDown = new System.Windows.Forms.Button();
            this.PhaseBtnUp = new System.Windows.Forms.Button();
            this.PhaseBar = new System.Windows.Forms.TrackBar();
            this.MagBtnPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MagLbl = new System.Windows.Forms.Label();
            this.MagBtnLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MagBtnDown = new System.Windows.Forms.Button();
            this.MagBtnUp = new System.Windows.Forms.Button();
            this.MagBar = new System.Windows.Forms.TrackBar();
            this.ComponentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TItleLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PlaySoundBtn = new System.Windows.Forms.Button();
            this.FreqLblSlt = new System.Windows.Forms.Label();
            this.FreqControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SecondControlPanal = new System.Windows.Forms.TableLayoutPanel();
            this.DurationQuantLbl = new System.Windows.Forms.Label();
            this.DurationBar = new System.Windows.Forms.TrackBar();
            this.DurationLbl = new System.Windows.Forms.Label();
            this.PortionBar = new System.Windows.Forms.TrackBar();
            this.PortionLbl = new System.Windows.Forms.Label();
            this.PortionQuantLbl = new System.Windows.Forms.Label();
            this.GraphTableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqDomain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqBar)).BeginInit();
            this.FreqBtnLayout.SuspendLayout();
            this.ComponentBtnLYT.SuspendLayout();
            this.MainWindowLayout.SuspendLayout();
            this.UIPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.StaticBtnLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StaticBar)).BeginInit();
            this.PhaseControlPanal.SuspendLayout();
            this.PhaseBtnLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhaseBar)).BeginInit();
            this.MagBtnPanel.SuspendLayout();
            this.MagBtnLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MagBar)).BeginInit();
            this.ComponentPanel.SuspendLayout();
            this.TItleLayout.SuspendLayout();
            this.FreqControlPanel.SuspendLayout();
            this.SecondControlPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortionBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GraphTableLayout
            // 
            this.GraphTableLayout.ColumnCount = 1;
            this.GraphTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.GraphTableLayout.Controls.Add(this.TimeDomain, 0, 0);
            this.GraphTableLayout.Controls.Add(this.FreqDomain, 0, 1);
            this.GraphTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GraphTableLayout.Location = new System.Drawing.Point(274, 4);
            this.GraphTableLayout.Margin = new System.Windows.Forms.Padding(4);
            this.GraphTableLayout.Name = "GraphTableLayout";
            this.GraphTableLayout.RowCount = 2;
            this.GraphTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GraphTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GraphTableLayout.Size = new System.Drawing.Size(804, 545);
            this.GraphTableLayout.TabIndex = 1;
            // 
            // TimeDomain
            // 
            this.TimeDomain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.TimeDomain.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.TimeDomain.Legends.Add(legend1);
            this.TimeDomain.Location = new System.Drawing.Point(4, 4);
            this.TimeDomain.Margin = new System.Windows.Forms.Padding(4);
            this.TimeDomain.Name = "TimeDomain";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "Wave";
            this.TimeDomain.Series.Add(series1);
            this.TimeDomain.Size = new System.Drawing.Size(796, 264);
            this.TimeDomain.TabIndex = 0;
            this.TimeDomain.Text = "chart1";
            // 
            // FreqDomain
            // 
            chartArea2.Name = "ChartArea1";
            this.FreqDomain.ChartAreas.Add(chartArea2);
            this.FreqDomain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.FreqDomain.Legends.Add(legend2);
            this.FreqDomain.Location = new System.Drawing.Point(4, 276);
            this.FreqDomain.Margin = new System.Windows.Forms.Padding(4);
            this.FreqDomain.Name = "FreqDomain";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Freq";
            this.FreqDomain.Series.Add(series2);
            this.FreqDomain.Size = new System.Drawing.Size(796, 265);
            this.FreqDomain.TabIndex = 1;
            this.FreqDomain.Text = "chart2";
            // 
            // FreqBar
            // 
            this.FreqBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqBar.Location = new System.Drawing.Point(4, 25);
            this.FreqBar.Margin = new System.Windows.Forms.Padding(4);
            this.FreqBar.Maximum = 500;
            this.FreqBar.Name = "FreqBar";
            this.FreqBar.Size = new System.Drawing.Size(196, 35);
            this.FreqBar.TabIndex = 3;
            this.FreqBar.TickFrequency = 10;
            this.FreqBar.Scroll += new System.EventHandler(this.FreqBar_Scroll);
            // 
            // FreqLbl
            // 
            this.FreqLbl.AutoSize = true;
            this.FreqLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqLbl.Location = new System.Drawing.Point(4, 0);
            this.FreqLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FreqLbl.Name = "FreqLbl";
            this.FreqLbl.Size = new System.Drawing.Size(196, 21);
            this.FreqLbl.TabIndex = 4;
            this.FreqLbl.Text = "0 Hz\r\n";
            this.FreqLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreqBtnDown
            // 
            this.FreqBtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqBtnDown.Location = new System.Drawing.Point(4, 4);
            this.FreqBtnDown.Margin = new System.Windows.Forms.Padding(4);
            this.FreqBtnDown.Name = "FreqBtnDown";
            this.FreqBtnDown.Size = new System.Drawing.Size(90, 28);
            this.FreqBtnDown.TabIndex = 5;
            this.FreqBtnDown.Text = "Decrease";
            this.FreqBtnDown.UseVisualStyleBackColor = true;
            this.FreqBtnDown.Click += new System.EventHandler(this.FreqBtnDown_Click);
            // 
            // FreqBtnLayout
            // 
            this.FreqBtnLayout.ColumnCount = 2;
            this.FreqBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FreqBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.FreqBtnLayout.Controls.Add(this.FreqBtnDown, 0, 0);
            this.FreqBtnLayout.Controls.Add(this.FreqBtnUp, 1, 0);
            this.FreqBtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqBtnLayout.Location = new System.Drawing.Point(4, 68);
            this.FreqBtnLayout.Margin = new System.Windows.Forms.Padding(4);
            this.FreqBtnLayout.Name = "FreqBtnLayout";
            this.FreqBtnLayout.RowCount = 1;
            this.FreqBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FreqBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.FreqBtnLayout.Size = new System.Drawing.Size(196, 36);
            this.FreqBtnLayout.TabIndex = 6;
            // 
            // FreqBtnUp
            // 
            this.FreqBtnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqBtnUp.Location = new System.Drawing.Point(102, 4);
            this.FreqBtnUp.Margin = new System.Windows.Forms.Padding(4);
            this.FreqBtnUp.Name = "FreqBtnUp";
            this.FreqBtnUp.Size = new System.Drawing.Size(90, 28);
            this.FreqBtnUp.TabIndex = 6;
            this.FreqBtnUp.Text = "Increase";
            this.FreqBtnUp.UseVisualStyleBackColor = true;
            this.FreqBtnUp.Click += new System.EventHandler(this.FreqBtnUp_Click);
            // 
            // ComponentBtnLYT
            // 
            this.ComponentBtnLYT.ColumnCount = 3;
            this.ComponentBtnLYT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComponentBtnLYT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComponentBtnLYT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ComponentBtnLYT.Controls.Add(this.FreqSltBtnDel, 0, 0);
            this.ComponentBtnLYT.Controls.Add(this.PrvBtn, 0, 0);
            this.ComponentBtnLYT.Controls.Add(this.NextBtn, 2, 0);
            this.ComponentBtnLYT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentBtnLYT.Location = new System.Drawing.Point(4, 44);
            this.ComponentBtnLYT.Margin = new System.Windows.Forms.Padding(4);
            this.ComponentBtnLYT.Name = "ComponentBtnLYT";
            this.ComponentBtnLYT.RowCount = 1;
            this.ComponentBtnLYT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ComponentBtnLYT.Size = new System.Drawing.Size(196, 33);
            this.ComponentBtnLYT.TabIndex = 7;
            // 
            // FreqSltBtnDel
            // 
            this.FreqSltBtnDel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqSltBtnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreqSltBtnDel.Location = new System.Drawing.Point(69, 4);
            this.FreqSltBtnDel.Margin = new System.Windows.Forms.Padding(4);
            this.FreqSltBtnDel.Name = "FreqSltBtnDel";
            this.FreqSltBtnDel.Size = new System.Drawing.Size(57, 25);
            this.FreqSltBtnDel.TabIndex = 7;
            this.FreqSltBtnDel.Text = "X";
            this.FreqSltBtnDel.UseVisualStyleBackColor = true;
            this.FreqSltBtnDel.Click += new System.EventHandler(this.FreqSltBtnDel_Click);
            // 
            // PrvBtn
            // 
            this.PrvBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PrvBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrvBtn.Location = new System.Drawing.Point(4, 4);
            this.PrvBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PrvBtn.Name = "PrvBtn";
            this.PrvBtn.Size = new System.Drawing.Size(57, 25);
            this.PrvBtn.TabIndex = 5;
            this.PrvBtn.Text = "-";
            this.PrvBtn.UseVisualStyleBackColor = true;
            this.PrvBtn.Click += new System.EventHandler(this.PrvBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(134, 4);
            this.NextBtn.Margin = new System.Windows.Forms.Padding(4);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(58, 25);
            this.NextBtn.TabIndex = 6;
            this.NextBtn.Text = "+";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // MainWindowLayout
            // 
            this.MainWindowLayout.ColumnCount = 3;
            this.MainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.MainWindowLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.MainWindowLayout.Controls.Add(this.GraphTableLayout, 2, 0);
            this.MainWindowLayout.Controls.Add(this.UIPanel, 0, 0);
            this.MainWindowLayout.Controls.Add(this.SecondControlPanal, 1, 0);
            this.MainWindowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainWindowLayout.Location = new System.Drawing.Point(0, 0);
            this.MainWindowLayout.Name = "MainWindowLayout";
            this.MainWindowLayout.RowCount = 1;
            this.MainWindowLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainWindowLayout.Size = new System.Drawing.Size(1082, 553);
            this.MainWindowLayout.TabIndex = 9;
            // 
            // UIPanel
            // 
            this.UIPanel.ColumnCount = 1;
            this.UIPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.UIPanel.Controls.Add(this.tableLayoutPanel1, 0, 4);
            this.UIPanel.Controls.Add(this.PhaseControlPanal, 0, 3);
            this.UIPanel.Controls.Add(this.MagBtnPanel, 0, 2);
            this.UIPanel.Controls.Add(this.ComponentPanel, 0, 0);
            this.UIPanel.Controls.Add(this.FreqControlPanel, 0, 1);
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIPanel.Location = new System.Drawing.Point(3, 3);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.RowCount = 5;
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.UIPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.UIPanel.Size = new System.Drawing.Size(210, 547);
            this.UIPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.StaticLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.StaticBtnLayout, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.StaticBar, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 432);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 112);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // StaticLbl
            // 
            this.StaticLbl.AutoSize = true;
            this.StaticLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticLbl.Location = new System.Drawing.Point(4, 0);
            this.StaticLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StaticLbl.Name = "StaticLbl";
            this.StaticLbl.Size = new System.Drawing.Size(196, 22);
            this.StaticLbl.TabIndex = 4;
            this.StaticLbl.Text = "0% Static";
            this.StaticLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StaticBtnLayout
            // 
            this.StaticBtnLayout.ColumnCount = 3;
            this.StaticBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.StaticBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.StaticBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.StaticBtnLayout.Controls.Add(this.StaticBtnDown, 0, 0);
            this.StaticBtnLayout.Controls.Add(this.StaticBtnUp, 2, 0);
            this.StaticBtnLayout.Controls.Add(this.StaticBtnApply, 1, 0);
            this.StaticBtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticBtnLayout.Location = new System.Drawing.Point(4, 70);
            this.StaticBtnLayout.Margin = new System.Windows.Forms.Padding(4);
            this.StaticBtnLayout.Name = "StaticBtnLayout";
            this.StaticBtnLayout.RowCount = 1;
            this.StaticBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StaticBtnLayout.Size = new System.Drawing.Size(196, 38);
            this.StaticBtnLayout.TabIndex = 6;
            // 
            // StaticBtnDown
            // 
            this.StaticBtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticBtnDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticBtnDown.Location = new System.Drawing.Point(4, 4);
            this.StaticBtnDown.Margin = new System.Windows.Forms.Padding(4);
            this.StaticBtnDown.Name = "StaticBtnDown";
            this.StaticBtnDown.Size = new System.Drawing.Size(57, 30);
            this.StaticBtnDown.TabIndex = 5;
            this.StaticBtnDown.Text = "-";
            this.StaticBtnDown.UseVisualStyleBackColor = true;
            this.StaticBtnDown.Click += new System.EventHandler(this.StaticBtnDown_Click);
            // 
            // StaticBtnUp
            // 
            this.StaticBtnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticBtnUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StaticBtnUp.Location = new System.Drawing.Point(134, 4);
            this.StaticBtnUp.Margin = new System.Windows.Forms.Padding(4);
            this.StaticBtnUp.Name = "StaticBtnUp";
            this.StaticBtnUp.Size = new System.Drawing.Size(58, 30);
            this.StaticBtnUp.TabIndex = 6;
            this.StaticBtnUp.Text = "+";
            this.StaticBtnUp.UseVisualStyleBackColor = true;
            this.StaticBtnUp.Click += new System.EventHandler(this.StaticBtnUp_Click);
            // 
            // StaticBtnApply
            // 
            this.StaticBtnApply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticBtnApply.Location = new System.Drawing.Point(68, 3);
            this.StaticBtnApply.Name = "StaticBtnApply";
            this.StaticBtnApply.Size = new System.Drawing.Size(59, 32);
            this.StaticBtnApply.TabIndex = 7;
            this.StaticBtnApply.Text = "Apply";
            this.StaticBtnApply.UseVisualStyleBackColor = true;
            this.StaticBtnApply.Click += new System.EventHandler(this.StaticBtnApply_Click);
            // 
            // StaticBar
            // 
            this.StaticBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StaticBar.Location = new System.Drawing.Point(4, 26);
            this.StaticBar.Margin = new System.Windows.Forms.Padding(4);
            this.StaticBar.Maximum = 100;
            this.StaticBar.Name = "StaticBar";
            this.StaticBar.Size = new System.Drawing.Size(196, 36);
            this.StaticBar.TabIndex = 3;
            this.StaticBar.TickFrequency = 10;
            this.StaticBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PhaseControlPanal
            // 
            this.PhaseControlPanal.ColumnCount = 1;
            this.PhaseControlPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PhaseControlPanal.Controls.Add(this.PhaseLbl, 0, 0);
            this.PhaseControlPanal.Controls.Add(this.PhaseBtnLayout, 0, 2);
            this.PhaseControlPanal.Controls.Add(this.PhaseBar, 0, 1);
            this.PhaseControlPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhaseControlPanal.Location = new System.Drawing.Point(3, 318);
            this.PhaseControlPanal.Name = "PhaseControlPanal";
            this.PhaseControlPanal.RowCount = 3;
            this.PhaseControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PhaseControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PhaseControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.PhaseControlPanal.Size = new System.Drawing.Size(204, 108);
            this.PhaseControlPanal.TabIndex = 3;
            // 
            // PhaseLbl
            // 
            this.PhaseLbl.AutoSize = true;
            this.PhaseLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhaseLbl.Location = new System.Drawing.Point(4, 0);
            this.PhaseLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhaseLbl.Name = "PhaseLbl";
            this.PhaseLbl.Size = new System.Drawing.Size(196, 21);
            this.PhaseLbl.TabIndex = 4;
            this.PhaseLbl.Text = "0 Phase";
            this.PhaseLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PhaseBtnLayout
            // 
            this.PhaseBtnLayout.ColumnCount = 2;
            this.PhaseBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhaseBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.PhaseBtnLayout.Controls.Add(this.PhaseBtnDown, 0, 0);
            this.PhaseBtnLayout.Controls.Add(this.PhaseBtnUp, 1, 0);
            this.PhaseBtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhaseBtnLayout.Location = new System.Drawing.Point(4, 68);
            this.PhaseBtnLayout.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseBtnLayout.Name = "PhaseBtnLayout";
            this.PhaseBtnLayout.RowCount = 1;
            this.PhaseBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PhaseBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.PhaseBtnLayout.Size = new System.Drawing.Size(196, 36);
            this.PhaseBtnLayout.TabIndex = 6;
            // 
            // PhaseBtnDown
            // 
            this.PhaseBtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhaseBtnDown.Location = new System.Drawing.Point(4, 4);
            this.PhaseBtnDown.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseBtnDown.Name = "PhaseBtnDown";
            this.PhaseBtnDown.Size = new System.Drawing.Size(90, 28);
            this.PhaseBtnDown.TabIndex = 5;
            this.PhaseBtnDown.Text = "Decrease";
            this.PhaseBtnDown.UseVisualStyleBackColor = true;
            this.PhaseBtnDown.Click += new System.EventHandler(this.PhaseBtnDown_Click);
            // 
            // PhaseBtnUp
            // 
            this.PhaseBtnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhaseBtnUp.Location = new System.Drawing.Point(102, 4);
            this.PhaseBtnUp.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseBtnUp.Name = "PhaseBtnUp";
            this.PhaseBtnUp.Size = new System.Drawing.Size(90, 28);
            this.PhaseBtnUp.TabIndex = 6;
            this.PhaseBtnUp.Text = "Increase";
            this.PhaseBtnUp.UseVisualStyleBackColor = true;
            this.PhaseBtnUp.Click += new System.EventHandler(this.PhaseBtnUp_Click);
            // 
            // PhaseBar
            // 
            this.PhaseBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhaseBar.Location = new System.Drawing.Point(4, 25);
            this.PhaseBar.Margin = new System.Windows.Forms.Padding(4);
            this.PhaseBar.Maximum = 100;
            this.PhaseBar.Minimum = -100;
            this.PhaseBar.Name = "PhaseBar";
            this.PhaseBar.Size = new System.Drawing.Size(196, 35);
            this.PhaseBar.TabIndex = 3;
            this.PhaseBar.TickFrequency = 10;
            this.PhaseBar.Scroll += new System.EventHandler(this.PhaseBar_Scroll);
            // 
            // MagBtnPanel
            // 
            this.MagBtnPanel.ColumnCount = 1;
            this.MagBtnPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MagBtnPanel.Controls.Add(this.MagLbl, 0, 0);
            this.MagBtnPanel.Controls.Add(this.MagBtnLayout, 0, 2);
            this.MagBtnPanel.Controls.Add(this.MagBar, 0, 1);
            this.MagBtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagBtnPanel.Location = new System.Drawing.Point(3, 204);
            this.MagBtnPanel.Name = "MagBtnPanel";
            this.MagBtnPanel.RowCount = 3;
            this.MagBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MagBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MagBtnPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MagBtnPanel.Size = new System.Drawing.Size(204, 108);
            this.MagBtnPanel.TabIndex = 2;
            // 
            // MagLbl
            // 
            this.MagLbl.AutoSize = true;
            this.MagLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagLbl.Location = new System.Drawing.Point(4, 0);
            this.MagLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MagLbl.Name = "MagLbl";
            this.MagLbl.Size = new System.Drawing.Size(196, 21);
            this.MagLbl.TabIndex = 4;
            this.MagLbl.Text = "1 Mag";
            this.MagLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MagBtnLayout
            // 
            this.MagBtnLayout.ColumnCount = 2;
            this.MagBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MagBtnLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MagBtnLayout.Controls.Add(this.MagBtnDown, 0, 0);
            this.MagBtnLayout.Controls.Add(this.MagBtnUp, 1, 0);
            this.MagBtnLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagBtnLayout.Location = new System.Drawing.Point(4, 68);
            this.MagBtnLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MagBtnLayout.Name = "MagBtnLayout";
            this.MagBtnLayout.RowCount = 1;
            this.MagBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MagBtnLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.MagBtnLayout.Size = new System.Drawing.Size(196, 36);
            this.MagBtnLayout.TabIndex = 6;
            // 
            // MagBtnDown
            // 
            this.MagBtnDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagBtnDown.Location = new System.Drawing.Point(4, 4);
            this.MagBtnDown.Margin = new System.Windows.Forms.Padding(4);
            this.MagBtnDown.Name = "MagBtnDown";
            this.MagBtnDown.Size = new System.Drawing.Size(90, 28);
            this.MagBtnDown.TabIndex = 5;
            this.MagBtnDown.Text = "Decrease";
            this.MagBtnDown.UseVisualStyleBackColor = true;
            this.MagBtnDown.Click += new System.EventHandler(this.MagBtnDown_Click);
            // 
            // MagBtnUp
            // 
            this.MagBtnUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagBtnUp.Location = new System.Drawing.Point(102, 4);
            this.MagBtnUp.Margin = new System.Windows.Forms.Padding(4);
            this.MagBtnUp.Name = "MagBtnUp";
            this.MagBtnUp.Size = new System.Drawing.Size(90, 28);
            this.MagBtnUp.TabIndex = 6;
            this.MagBtnUp.Text = "Increase";
            this.MagBtnUp.UseVisualStyleBackColor = true;
            this.MagBtnUp.Click += new System.EventHandler(this.MagBtnUp_Click);
            // 
            // MagBar
            // 
            this.MagBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MagBar.LargeChange = 10;
            this.MagBar.Location = new System.Drawing.Point(4, 25);
            this.MagBar.Margin = new System.Windows.Forms.Padding(4);
            this.MagBar.Maximum = 100;
            this.MagBar.Name = "MagBar";
            this.MagBar.Size = new System.Drawing.Size(196, 35);
            this.MagBar.TabIndex = 3;
            this.MagBar.TickFrequency = 10;
            this.MagBar.Value = 20;
            this.MagBar.Scroll += new System.EventHandler(this.MagBar_Scroll);
            // 
            // ComponentPanel
            // 
            this.ComponentPanel.ColumnCount = 1;
            this.ComponentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentPanel.Controls.Add(this.ComponentBtnLYT, 0, 1);
            this.ComponentPanel.Controls.Add(this.TItleLayout, 0, 0);
            this.ComponentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentPanel.Location = new System.Drawing.Point(3, 3);
            this.ComponentPanel.Name = "ComponentPanel";
            this.ComponentPanel.RowCount = 2;
            this.ComponentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ComponentPanel.Size = new System.Drawing.Size(204, 81);
            this.ComponentPanel.TabIndex = 0;
            // 
            // TItleLayout
            // 
            this.TItleLayout.ColumnCount = 2;
            this.TItleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TItleLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TItleLayout.Controls.Add(this.PlaySoundBtn, 1, 0);
            this.TItleLayout.Controls.Add(this.FreqLblSlt, 0, 0);
            this.TItleLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TItleLayout.Location = new System.Drawing.Point(3, 3);
            this.TItleLayout.Name = "TItleLayout";
            this.TItleLayout.RowCount = 1;
            this.TItleLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TItleLayout.Size = new System.Drawing.Size(198, 34);
            this.TItleLayout.TabIndex = 8;
            // 
            // PlaySoundBtn
            // 
            this.PlaySoundBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlaySoundBtn.Location = new System.Drawing.Point(141, 3);
            this.PlaySoundBtn.Name = "PlaySoundBtn";
            this.PlaySoundBtn.Size = new System.Drawing.Size(54, 28);
            this.PlaySoundBtn.TabIndex = 0;
            this.PlaySoundBtn.Text = "Play";
            this.PlaySoundBtn.UseVisualStyleBackColor = true;
            this.PlaySoundBtn.Click += new System.EventHandler(this.PlaySoundBtn_Click);
            // 
            // FreqLblSlt
            // 
            this.FreqLblSlt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FreqLblSlt.AutoSize = true;
            this.FreqLblSlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreqLblSlt.Location = new System.Drawing.Point(3, 0);
            this.FreqLblSlt.Name = "FreqLblSlt";
            this.FreqLblSlt.Size = new System.Drawing.Size(132, 34);
            this.FreqLblSlt.TabIndex = 1;
            this.FreqLblSlt.Text = "Frequency 1";
            this.FreqLblSlt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FreqControlPanel
            // 
            this.FreqControlPanel.ColumnCount = 1;
            this.FreqControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FreqControlPanel.Controls.Add(this.FreqLbl, 0, 0);
            this.FreqControlPanel.Controls.Add(this.FreqBtnLayout, 0, 2);
            this.FreqControlPanel.Controls.Add(this.FreqBar, 0, 1);
            this.FreqControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FreqControlPanel.Location = new System.Drawing.Point(3, 90);
            this.FreqControlPanel.Name = "FreqControlPanel";
            this.FreqControlPanel.RowCount = 3;
            this.FreqControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.FreqControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.FreqControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.FreqControlPanel.Size = new System.Drawing.Size(204, 108);
            this.FreqControlPanel.TabIndex = 1;
            // 
            // SecondControlPanal
            // 
            this.SecondControlPanal.ColumnCount = 1;
            this.SecondControlPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondControlPanal.Controls.Add(this.DurationQuantLbl, 0, 4);
            this.SecondControlPanal.Controls.Add(this.DurationBar, 0, 5);
            this.SecondControlPanal.Controls.Add(this.DurationLbl, 0, 3);
            this.SecondControlPanal.Controls.Add(this.PortionBar, 0, 2);
            this.SecondControlPanal.Controls.Add(this.PortionLbl, 0, 0);
            this.SecondControlPanal.Controls.Add(this.PortionQuantLbl, 0, 1);
            this.SecondControlPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondControlPanal.Location = new System.Drawing.Point(219, 3);
            this.SecondControlPanal.Name = "SecondControlPanal";
            this.SecondControlPanal.RowCount = 6;
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SecondControlPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SecondControlPanal.Size = new System.Drawing.Size(48, 547);
            this.SecondControlPanal.TabIndex = 3;
            // 
            // DurationQuantLbl
            // 
            this.DurationQuantLbl.AutoSize = true;
            this.DurationQuantLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationQuantLbl.Location = new System.Drawing.Point(3, 381);
            this.DurationQuantLbl.Name = "DurationQuantLbl";
            this.DurationQuantLbl.Size = new System.Drawing.Size(42, 27);
            this.DurationQuantLbl.TabIndex = 5;
            this.DurationQuantLbl.Text = "0.5";
            this.DurationQuantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DurationBar
            // 
            this.DurationBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DurationBar.LargeChange = 1;
            this.DurationBar.Location = new System.Drawing.Point(3, 411);
            this.DurationBar.Maximum = 100;
            this.DurationBar.Minimum = 1;
            this.DurationBar.Name = "DurationBar";
            this.DurationBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.DurationBar.Size = new System.Drawing.Size(42, 133);
            this.DurationBar.TabIndex = 3;
            this.DurationBar.Value = 25;
            this.DurationBar.Scroll += new System.EventHandler(this.DurationBar_Scroll);
            // 
            // DurationLbl
            // 
            this.DurationLbl.AutoSize = true;
            this.DurationLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DurationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLbl.Location = new System.Drawing.Point(3, 272);
            this.DurationLbl.Name = "DurationLbl";
            this.DurationLbl.Size = new System.Drawing.Size(42, 109);
            this.DurationLbl.TabIndex = 2;
            this.DurationLbl.Text = "T\r\ni\r\nm\r\ne\r\n";
            this.DurationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortionBar
            // 
            this.PortionBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PortionBar.LargeChange = 1;
            this.PortionBar.Location = new System.Drawing.Point(3, 139);
            this.PortionBar.Maximum = 100;
            this.PortionBar.Minimum = 1;
            this.PortionBar.Name = "PortionBar";
            this.PortionBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.PortionBar.Size = new System.Drawing.Size(42, 130);
            this.PortionBar.TabIndex = 0;
            this.PortionBar.Value = 10;
            this.PortionBar.Scroll += new System.EventHandler(this.PortionBar_Scroll);
            // 
            // PortionLbl
            // 
            this.PortionLbl.AutoSize = true;
            this.PortionLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortionLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortionLbl.Location = new System.Drawing.Point(3, 0);
            this.PortionLbl.Name = "PortionLbl";
            this.PortionLbl.Size = new System.Drawing.Size(42, 109);
            this.PortionLbl.TabIndex = 1;
            this.PortionLbl.Text = "Z\r\no\r\no\r\nm\r\n";
            this.PortionLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortionQuantLbl
            // 
            this.PortionQuantLbl.AutoSize = true;
            this.PortionQuantLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PortionQuantLbl.Location = new System.Drawing.Point(3, 109);
            this.PortionQuantLbl.Name = "PortionQuantLbl";
            this.PortionQuantLbl.Size = new System.Drawing.Size(42, 27);
            this.PortionQuantLbl.TabIndex = 4;
            this.PortionQuantLbl.Text = "0.1";
            this.PortionQuantLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 553);
            this.Controls.Add(this.MainWindowLayout);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 600);
            this.Name = "MainWindow";
            this.Text = "Fast Fourier Transform";
            this.GraphTableLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TimeDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqDomain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreqBar)).EndInit();
            this.FreqBtnLayout.ResumeLayout(false);
            this.ComponentBtnLYT.ResumeLayout(false);
            this.MainWindowLayout.ResumeLayout(false);
            this.UIPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.StaticBtnLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StaticBar)).EndInit();
            this.PhaseControlPanal.ResumeLayout(false);
            this.PhaseControlPanal.PerformLayout();
            this.PhaseBtnLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PhaseBar)).EndInit();
            this.MagBtnPanel.ResumeLayout(false);
            this.MagBtnPanel.PerformLayout();
            this.MagBtnLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MagBar)).EndInit();
            this.ComponentPanel.ResumeLayout(false);
            this.TItleLayout.ResumeLayout(false);
            this.TItleLayout.PerformLayout();
            this.FreqControlPanel.ResumeLayout(false);
            this.FreqControlPanel.PerformLayout();
            this.SecondControlPanal.ResumeLayout(false);
            this.SecondControlPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DurationBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PortionBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel GraphTableLayout;
        private System.Windows.Forms.DataVisualization.Charting.Chart TimeDomain;
        private System.Windows.Forms.DataVisualization.Charting.Chart FreqDomain;
        private System.Windows.Forms.TrackBar FreqBar;
        private System.Windows.Forms.Label FreqLbl;
        private System.Windows.Forms.Button FreqBtnDown;
        private System.Windows.Forms.TableLayoutPanel FreqBtnLayout;
        private System.Windows.Forms.Button FreqBtnUp;
        private System.Windows.Forms.TableLayoutPanel ComponentBtnLYT;
        private System.Windows.Forms.Button PrvBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.TableLayoutPanel MainWindowLayout;
        private System.Windows.Forms.TableLayoutPanel UIPanel;
        private System.Windows.Forms.TableLayoutPanel ComponentPanel;
        private System.Windows.Forms.TableLayoutPanel FreqControlPanel;
        private System.Windows.Forms.TableLayoutPanel PhaseControlPanal;
        private System.Windows.Forms.Label PhaseLbl;
        private System.Windows.Forms.TableLayoutPanel PhaseBtnLayout;
        private System.Windows.Forms.Button PhaseBtnDown;
        private System.Windows.Forms.Button PhaseBtnUp;
        private System.Windows.Forms.TrackBar PhaseBar;
        private System.Windows.Forms.TableLayoutPanel MagBtnPanel;
        private System.Windows.Forms.Label MagLbl;
        private System.Windows.Forms.TableLayoutPanel MagBtnLayout;
        private System.Windows.Forms.Button MagBtnDown;
        private System.Windows.Forms.Button MagBtnUp;
        private System.Windows.Forms.TrackBar MagBar;
        private System.Windows.Forms.Button FreqSltBtnDel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label StaticLbl;
        private System.Windows.Forms.TableLayoutPanel StaticBtnLayout;
        private System.Windows.Forms.Button StaticBtnDown;
        private System.Windows.Forms.Button StaticBtnUp;
        private System.Windows.Forms.TrackBar StaticBar;
        private System.Windows.Forms.Button StaticBtnApply;
        private System.Windows.Forms.TableLayoutPanel SecondControlPanal;
        private System.Windows.Forms.TrackBar DurationBar;
        private System.Windows.Forms.Label DurationLbl;
        private System.Windows.Forms.TrackBar PortionBar;
        private System.Windows.Forms.Label PortionLbl;
        private System.Windows.Forms.Label DurationQuantLbl;
        private System.Windows.Forms.Label PortionQuantLbl;
        private System.Windows.Forms.TableLayoutPanel TItleLayout;
        private System.Windows.Forms.Button PlaySoundBtn;
        private System.Windows.Forms.Label FreqLblSlt;
    }
}

