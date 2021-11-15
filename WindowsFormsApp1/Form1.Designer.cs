
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Database BoolDB = new Database("BoolDB",1,7,"A1","A500");
        public Database OneToFifty = new Database("onethrough50",1,18,"A1","N350");
        public Database Alphabet = new Database("Alphabet",1,31,"A1","Z1550");
        public Database OneToFive = new Database("Onethroughfive",1,33,"A1","AC5820");
        public Database FiftyNames = new Database("FiftyRandomNames",1,7,"A1","A1000");
        public Database ActiveDB = null;
        public string filepath = @"C:\Users\jdste\source\repos\AlgorithmApplication\WindowsFormsApp1\Properties\Info.txt";


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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KowalskiTime = new System.Windows.Forms.Label();
            this.KowalskiMem = new System.Windows.Forms.Label();
            this.KowalskiHot = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PRankTime = new System.Windows.Forms.Label();
            this.PRankMem = new System.Windows.Forms.Label();
            this.PRankHot = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MisraTime = new System.Windows.Forms.Label();
            this.MisraMem = new System.Windows.Forms.Label();
            this.MisraHot = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MuthuNATime = new System.Windows.Forms.Label();
            this.MuthuNAMem = new System.Windows.Forms.Label();
            this.MuthuNAHot = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LossyTime = new System.Windows.Forms.Label();
            this.LossyMem = new System.Windows.Forms.Label();
            this.LossyHot = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.DBSelector = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TimeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.ControlKey = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeChart)).BeginInit();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 104);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(238, 146);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KowalskiTime);
            this.panel1.Controls.Add(this.KowalskiMem);
            this.panel1.Controls.Add(this.KowalskiHot);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(757, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 117);
            this.panel1.TabIndex = 1;
            // 
            // KowalskiTime
            // 
            this.KowalskiTime.AutoSize = true;
            this.KowalskiTime.Location = new System.Drawing.Point(111, 72);
            this.KowalskiTime.Name = "KowalskiTime";
            this.KowalskiTime.Size = new System.Drawing.Size(86, 17);
            this.KowalskiTime.TabIndex = 5;
            this.KowalskiTime.Text = "{Time in ms}";
            // 
            // KowalskiMem
            // 
            this.KowalskiMem.AutoSize = true;
            this.KowalskiMem.Location = new System.Drawing.Point(114, 46);
            this.KowalskiMem.Name = "KowalskiMem";
            this.KowalskiMem.Size = new System.Drawing.Size(83, 17);
            this.KowalskiMem.TabIndex = 4;
            this.KowalskiMem.Text = "{RAM used}";
            // 
            // KowalskiHot
            // 
            this.KowalskiHot.AutoSize = true;
            this.KowalskiHot.Location = new System.Drawing.Point(100, 20);
            this.KowalskiHot.Name = "KowalskiHot";
            this.KowalskiHot.Size = new System.Drawing.Size(117, 17);
            this.KowalskiHot.TabIndex = 3;
            this.KowalskiHot.Text = "{Returned Value}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Memory Used:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hot Item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Runtime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(806, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kowalski Algorithm";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(806, 258);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(105, 17);
            this.label60.TabIndex = 16;
            this.label60.Text = "Misra Algorithm";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(519, 258);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(205, 17);
            this.label61.TabIndex = 17;
            this.label61.Text = "Muthu Algorithm (NonAdaptive)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(316, 258);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(108, 17);
            this.label62.TabIndex = 18;
            this.label62.Text = "Lossy Algorithm";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.PRankTime);
            this.panel2.Controls.Add(this.PRankMem);
            this.panel2.Controls.Add(this.PRankHot);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(12, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 117);
            this.panel2.TabIndex = 6;
            // 
            // PRankTime
            // 
            this.PRankTime.AutoSize = true;
            this.PRankTime.Location = new System.Drawing.Point(111, 72);
            this.PRankTime.Name = "PRankTime";
            this.PRankTime.Size = new System.Drawing.Size(86, 17);
            this.PRankTime.TabIndex = 5;
            this.PRankTime.Text = "{Time in ms}";
            // 
            // PRankMem
            // 
            this.PRankMem.AutoSize = true;
            this.PRankMem.Location = new System.Drawing.Point(114, 46);
            this.PRankMem.Name = "PRankMem";
            this.PRankMem.Size = new System.Drawing.Size(83, 17);
            this.PRankMem.TabIndex = 4;
            this.PRankMem.Text = "{RAM used}";
            // 
            // PRankHot
            // 
            this.PRankHot.AutoSize = true;
            this.PRankHot.Location = new System.Drawing.Point(100, 20);
            this.PRankHot.Name = "PRankHot";
            this.PRankHot.Size = new System.Drawing.Size(117, 17);
            this.PRankHot.TabIndex = 3;
            this.PRankHot.Text = "{Returned Value}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Memory Used:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Hot Item:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Runtime:";
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.MisraTime);
            this.panel3.Controls.Add(this.MisraMem);
            this.panel3.Controls.Add(this.MisraHot);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(757, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 117);
            this.panel3.TabIndex = 6;
            // 
            // MisraTime
            // 
            this.MisraTime.AutoSize = true;
            this.MisraTime.Location = new System.Drawing.Point(111, 72);
            this.MisraTime.Name = "MisraTime";
            this.MisraTime.Size = new System.Drawing.Size(86, 17);
            this.MisraTime.TabIndex = 5;
            this.MisraTime.Text = "{Time in ms}";
            // 
            // MisraMem
            // 
            this.MisraMem.AutoSize = true;
            this.MisraMem.Location = new System.Drawing.Point(114, 46);
            this.MisraMem.Name = "MisraMem";
            this.MisraMem.Size = new System.Drawing.Size(83, 17);
            this.MisraMem.TabIndex = 4;
            this.MisraMem.Text = "{RAM used}";
            // 
            // MisraHot
            // 
            this.MisraHot.AutoSize = true;
            this.MisraHot.Location = new System.Drawing.Point(100, 20);
            this.MisraHot.Name = "MisraHot";
            this.MisraHot.Size = new System.Drawing.Size(117, 17);
            this.MisraHot.TabIndex = 3;
            this.MisraHot.Text = "{Returned Value}";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 17);
            this.label18.TabIndex = 2;
            this.label18.Text = "Memory Used:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(64, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "Hot Item:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 72);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "Runtime:";
            // 
            // panel4
            // 
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.MuthuNATime);
            this.panel4.Controls.Add(this.MuthuNAMem);
            this.panel4.Controls.Add(this.MuthuNAHot);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Location = new System.Drawing.Point(509, 278);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 117);
            this.panel4.TabIndex = 6;
            // 
            // MuthuNATime
            // 
            this.MuthuNATime.AutoSize = true;
            this.MuthuNATime.Location = new System.Drawing.Point(111, 72);
            this.MuthuNATime.Name = "MuthuNATime";
            this.MuthuNATime.Size = new System.Drawing.Size(86, 17);
            this.MuthuNATime.TabIndex = 5;
            this.MuthuNATime.Text = "{Time in ms}";
            // 
            // MuthuNAMem
            // 
            this.MuthuNAMem.AutoSize = true;
            this.MuthuNAMem.Location = new System.Drawing.Point(114, 46);
            this.MuthuNAMem.Name = "MuthuNAMem";
            this.MuthuNAMem.Size = new System.Drawing.Size(83, 17);
            this.MuthuNAMem.TabIndex = 4;
            this.MuthuNAMem.Text = "{RAM used}";
            // 
            // MuthuNAHot
            // 
            this.MuthuNAHot.AutoSize = true;
            this.MuthuNAHot.Location = new System.Drawing.Point(100, 20);
            this.MuthuNAHot.Name = "MuthuNAHot";
            this.MuthuNAHot.Size = new System.Drawing.Size(117, 17);
            this.MuthuNAHot.TabIndex = 3;
            this.MuthuNAHot.Text = "{Returned Value}";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 17);
            this.label24.TabIndex = 2;
            this.label24.Text = "Memory Used:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(64, 17);
            this.label25.TabIndex = 1;
            this.label25.Text = "Hot Item:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(9, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(64, 17);
            this.label26.TabIndex = 0;
            this.label26.Text = "Runtime:";
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.LossyTime);
            this.panel5.Controls.Add(this.LossyMem);
            this.panel5.Controls.Add(this.LossyHot);
            this.panel5.Controls.Add(this.label30);
            this.panel5.Controls.Add(this.label31);
            this.panel5.Controls.Add(this.label32);
            this.panel5.Location = new System.Drawing.Point(270, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 117);
            this.panel5.TabIndex = 6;
            // 
            // LossyTime
            // 
            this.LossyTime.AutoSize = true;
            this.LossyTime.Location = new System.Drawing.Point(111, 72);
            this.LossyTime.Name = "LossyTime";
            this.LossyTime.Size = new System.Drawing.Size(86, 17);
            this.LossyTime.TabIndex = 5;
            this.LossyTime.Text = "{Time in ms}";
            // 
            // LossyMem
            // 
            this.LossyMem.AutoSize = true;
            this.LossyMem.Location = new System.Drawing.Point(114, 46);
            this.LossyMem.Name = "LossyMem";
            this.LossyMem.Size = new System.Drawing.Size(83, 17);
            this.LossyMem.TabIndex = 4;
            this.LossyMem.Text = "{RAM used}";
            // 
            // LossyHot
            // 
            this.LossyHot.AutoSize = true;
            this.LossyHot.Location = new System.Drawing.Point(100, 20);
            this.LossyHot.Name = "LossyHot";
            this.LossyHot.Size = new System.Drawing.Size(117, 17);
            this.LossyHot.TabIndex = 3;
            this.LossyHot.Text = "{Returned Value}";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 46);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(99, 17);
            this.label30.TabIndex = 2;
            this.label30.Text = "Memory Used:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(9, 20);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(64, 17);
            this.label31.TabIndex = 1;
            this.label31.Text = "Hot Item:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(9, 72);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(64, 17);
            this.label32.TabIndex = 0;
            this.label32.Text = "Runtime:";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(51, 258);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(137, 17);
            this.label33.TabIndex = 21;
            this.label33.Text = "PageRank Algorithm";
            // 
            // DBSelector
            // 
            this.DBSelector.FormattingEnabled = true;
            this.DBSelector.Items.AddRange(new object[] {
            "Boolean Database",
            "Alphabet Database",
            "One-to-Fifty Database",
            "One-to-Five Database",
            "Names Database"});
            this.DBSelector.Location = new System.Drawing.Point(12, 33);
            this.DBSelector.Name = "DBSelector";
            this.DBSelector.Size = new System.Drawing.Size(238, 24);
            this.DBSelector.TabIndex = 22;
            this.DBSelector.Text = "DataSet";
            this.DBSelector.SelectedIndexChanged += new System.EventHandler(this.DBSelector_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(92, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 25;
            this.button3.Text = "Run";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MemChart
            // 
            chartArea3.Name = "ChartArea1";
            this.MemChart.ChartAreas.Add(chartArea3);
            legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.MemChart.Legends.Add(legend3);
            this.MemChart.Location = new System.Drawing.Point(509, 42);
            this.MemChart.Name = "MemChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.MemChart.Series.Add(series3);
            this.MemChart.Size = new System.Drawing.Size(226, 208);
            this.MemChart.TabIndex = 26;
            this.MemChart.Text = "chart1";
            // 
            // TimeChart
            // 
            chartArea4.Name = "ChartArea1";
            this.TimeChart.ChartAreas.Add(chartArea4);
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.TimeChart.Legends.Add(legend4);
            this.TimeChart.Location = new System.Drawing.Point(264, 47);
            this.TimeChart.Name = "TimeChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.TimeChart.Series.Add(series4);
            this.TimeChart.Size = new System.Drawing.Size(224, 208);
            this.TimeChart.TabIndex = 27;
            this.TimeChart.Text = "chart2";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(336, 19);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(64, 17);
            this.label65.TabIndex = 6;
            this.label65.Text = "Runtime:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Location = new System.Drawing.Point(578, 19);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(99, 17);
            this.label66.TabIndex = 6;
            this.label66.Text = "Memory Used:";
            // 
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.ControlKey);
            this.panel9.Controls.Add(this.label71);
            this.panel9.Location = new System.Drawing.Point(757, 42);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 60);
            this.panel9.TabIndex = 7;
            // 
            // ControlKey
            // 
            this.ControlKey.AutoSize = true;
            this.ControlKey.Location = new System.Drawing.Point(100, 20);
            this.ControlKey.Name = "ControlKey";
            this.ControlKey.Size = new System.Drawing.Size(117, 17);
            this.ControlKey.TabIndex = 3;
            this.ControlKey.Text = "{Returned Value}";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Location = new System.Drawing.Point(9, 20);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(64, 17);
            this.label71.TabIndex = 1;
            this.label71.Text = "Hot Item:";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Location = new System.Drawing.Point(767, 19);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(53, 17);
            this.label67.TabIndex = 28;
            this.label67.Text = "Control";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 400);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.label66);
            this.Controls.Add(this.label65);
            this.Controls.Add(this.TimeChart);
            this.Controls.Add(this.MemChart);
            this.Controls.Add(this.label61);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DBSelector);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeChart)).EndInit();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label KowalskiTime;
        private System.Windows.Forms.Label KowalskiMem;
        private System.Windows.Forms.Label KowalskiHot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PRankTime;
        private System.Windows.Forms.Label PRankMem;
        private System.Windows.Forms.Label PRankHot;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label MisraTime;
        private System.Windows.Forms.Label MisraMem;
        private System.Windows.Forms.Label MisraHot;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label MuthuNATime;
        private System.Windows.Forms.Label MuthuNAMem;
        private System.Windows.Forms.Label MuthuNAHot;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LossyTime;
        private System.Windows.Forms.Label LossyMem;
        private System.Windows.Forms.Label LossyHot;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox DBSelector;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart MemChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TimeChart;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label ControlKey;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label67;
    }
}

