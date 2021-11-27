
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public double percentage = .05;
        public double k;
        public bool RunNonadaptive;
        private int phi;
        public int delta;
        int NAk, Misrak;
        private double epsilon, gama;
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KowalskiAllHot = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GamaInput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.EpsilonInput = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.KowalskiTime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.KowalskiMem = new System.Windows.Forms.Label();
            this.PhiInput = new System.Windows.Forms.NumericUpDown();
            this.DeltaInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BoyerTime = new System.Windows.Forms.Label();
            this.BoyerMem = new System.Windows.Forms.Label();
            this.BoyerHot = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.MisrakInput = new System.Windows.Forms.NumericUpDown();
            this.MisraTime = new System.Windows.Forms.Label();
            this.MisraMem = new System.Windows.Forms.Label();
            this.MisraHot = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.MuthuNATime = new System.Windows.Forms.Label();
            this.NAkInput = new System.Windows.Forms.NumericUpDown();
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.ControlKey = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamaInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhiInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaInput)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisrakInput)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NAkInput)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.KowalskiAllHot);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.GamaInput);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.EpsilonInput);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.KowalskiTime);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.KowalskiMem);
            this.panel1.Controls.Add(this.PhiInput);
            this.panel1.Controls.Add(this.DeltaInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(11, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 370);
            this.panel1.TabIndex = 1;
            // 
            // KowalskiAllHot
            // 
            this.KowalskiAllHot.AutoSize = true;
            this.KowalskiAllHot.Location = new System.Drawing.Point(38, 46);
            this.KowalskiAllHot.Name = "KowalskiAllHot";
            this.KowalskiAllHot.Size = new System.Drawing.Size(117, 17);
            this.KowalskiAllHot.TabIndex = 39;
            this.KowalskiAllHot.Text = "{Returned Value}";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(165, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Hot Items past threshold:";
            // 
            // GamaInput
            // 
            this.GamaInput.DecimalPlaces = 2;
            this.GamaInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.GamaInput.Location = new System.Drawing.Point(127, 297);
            this.GamaInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.GamaInput.Name = "GamaInput";
            this.GamaInput.Size = new System.Drawing.Size(61, 22);
            this.GamaInput.TabIndex = 37;
            this.GamaInput.Value = new decimal(new int[] {
            85,
            0,
            0,
            65536});
            this.GamaInput.ValueChanged += new System.EventHandler(this.GamaInput_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 297);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 17);
            this.label9.TabIndex = 36;
            this.label9.Text = "Gama = Epsilon/";
            // 
            // EpsilonInput
            // 
            this.EpsilonInput.DecimalPlaces = 2;
            this.EpsilonInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.EpsilonInput.Location = new System.Drawing.Point(69, 257);
            this.EpsilonInput.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            131072});
            this.EpsilonInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.EpsilonInput.Name = "EpsilonInput";
            this.EpsilonInput.Size = new System.Drawing.Size(61, 22);
            this.EpsilonInput.TabIndex = 35;
            this.EpsilonInput.Value = new decimal(new int[] {
            20,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 34;
            this.label8.Text = "Epsilon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Phi";
            // 
            // KowalskiTime
            // 
            this.KowalskiTime.AutoSize = true;
            this.KowalskiTime.Location = new System.Drawing.Point(100, 101);
            this.KowalskiTime.Name = "KowalskiTime";
            this.KowalskiTime.Size = new System.Drawing.Size(86, 17);
            this.KowalskiTime.TabIndex = 5;
            this.KowalskiTime.Text = "{Time in ms}";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Delta";
            // 
            // KowalskiMem
            // 
            this.KowalskiMem.AutoSize = true;
            this.KowalskiMem.Location = new System.Drawing.Point(108, 72);
            this.KowalskiMem.Name = "KowalskiMem";
            this.KowalskiMem.Size = new System.Drawing.Size(88, 17);
            this.KowalskiMem.TabIndex = 4;
            this.KowalskiMem.Text = "{Bytes used}";
            // 
            // PhiInput
            // 
            this.PhiInput.Location = new System.Drawing.Point(69, 185);
            this.PhiInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PhiInput.Name = "PhiInput";
            this.PhiInput.Size = new System.Drawing.Size(61, 22);
            this.PhiInput.TabIndex = 32;
            this.PhiInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.PhiInput.ValueChanged += new System.EventHandler(this.PhiInput_ValueChanged);
            // 
            // DeltaInput
            // 
            this.DeltaInput.Location = new System.Drawing.Point(69, 222);
            this.DeltaInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeltaInput.Name = "DeltaInput";
            this.DeltaInput.Size = new System.Drawing.Size(61, 22);
            this.DeltaInput.TabIndex = 31;
            this.DeltaInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DeltaInput.ValueChanged += new System.EventHandler(this.DeltaInput_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Memory Used:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Runtime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kowalski Algorithm";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(1054, 172);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(105, 17);
            this.label60.TabIndex = 16;
            this.label60.Text = "Misra Algorithm";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(767, 172);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(205, 17);
            this.label61.TabIndex = 17;
            this.label61.Text = "Muthu Algorithm (NonAdaptive)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(302, 172);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(108, 17);
            this.label62.TabIndex = 18;
            this.label62.Text = "Lossy Algorithm";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.BoyerTime);
            this.panel2.Controls.Add(this.BoyerMem);
            this.panel2.Controls.Add(this.BoyerHot);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Location = new System.Drawing.Point(501, 192);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 370);
            this.panel2.TabIndex = 6;
            // 
            // BoyerTime
            // 
            this.BoyerTime.AutoSize = true;
            this.BoyerTime.Location = new System.Drawing.Point(111, 72);
            this.BoyerTime.Name = "BoyerTime";
            this.BoyerTime.Size = new System.Drawing.Size(86, 17);
            this.BoyerTime.TabIndex = 5;
            this.BoyerTime.Text = "{Time in ms}";
            // 
            // BoyerMem
            // 
            this.BoyerMem.AutoSize = true;
            this.BoyerMem.Location = new System.Drawing.Point(114, 46);
            this.BoyerMem.Name = "BoyerMem";
            this.BoyerMem.Size = new System.Drawing.Size(88, 17);
            this.BoyerMem.TabIndex = 4;
            this.BoyerMem.Text = "{Bytes used}";
            // 
            // BoyerHot
            // 
            this.BoyerHot.AutoSize = true;
            this.BoyerHot.Location = new System.Drawing.Point(100, 20);
            this.BoyerHot.Name = "BoyerHot";
            this.BoyerHot.Size = new System.Drawing.Size(117, 17);
            this.BoyerHot.TabIndex = 3;
            this.BoyerHot.Text = "{Returned Value}";
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
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.MisrakInput);
            this.panel3.Controls.Add(this.MisraTime);
            this.panel3.Controls.Add(this.MisraMem);
            this.panel3.Controls.Add(this.MisraHot);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Location = new System.Drawing.Point(1005, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 370);
            this.panel3.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 38;
            this.label10.Text = "k";
            // 
            // MisrakInput
            // 
            this.MisrakInput.DecimalPlaces = 2;
            this.MisrakInput.Location = new System.Drawing.Point(71, 133);
            this.MisrakInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MisrakInput.Name = "MisrakInput";
            this.MisrakInput.Size = new System.Drawing.Size(61, 22);
            this.MisrakInput.TabIndex = 38;
            this.MisrakInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MisrakInput.ValueChanged += new System.EventHandler(this.MisrakInput_ValueChanged);
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
            this.MisraMem.Size = new System.Drawing.Size(88, 17);
            this.MisraMem.TabIndex = 4;
            this.MisraMem.Text = "{Bytes used}";
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
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.MuthuNATime);
            this.panel4.Controls.Add(this.NAkInput);
            this.panel4.Controls.Add(this.MuthuNAMem);
            this.panel4.Controls.Add(this.MuthuNAHot);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Controls.Add(this.label25);
            this.panel4.Controls.Add(this.label26);
            this.panel4.Location = new System.Drawing.Point(757, 192);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 370);
            this.panel4.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 39;
            this.label11.Text = "k";
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
            // NAkInput
            // 
            this.NAkInput.DecimalPlaces = 2;
            this.NAkInput.Location = new System.Drawing.Point(68, 133);
            this.NAkInput.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NAkInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NAkInput.Name = "NAkInput";
            this.NAkInput.Size = new System.Drawing.Size(74, 22);
            this.NAkInput.TabIndex = 40;
            this.NAkInput.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NAkInput.ValueChanged += new System.EventHandler(this.NAkInput_ValueChanged);
            // 
            // MuthuNAMem
            // 
            this.MuthuNAMem.AutoSize = true;
            this.MuthuNAMem.Location = new System.Drawing.Point(114, 46);
            this.MuthuNAMem.Name = "MuthuNAMem";
            this.MuthuNAMem.Size = new System.Drawing.Size(88, 17);
            this.MuthuNAMem.TabIndex = 4;
            this.MuthuNAMem.Text = "{Bytes used}";
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
            this.panel5.Location = new System.Drawing.Point(256, 192);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 370);
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
            this.LossyMem.Size = new System.Drawing.Size(88, 17);
            this.LossyMem.TabIndex = 4;
            this.LossyMem.Text = "{Bytes used}";
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
            this.label33.Location = new System.Drawing.Point(540, 172);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(153, 17);
            this.label33.TabIndex = 21;
            this.label33.Text = "Boyer-Moore Algorithm";
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
            // panel9
            // 
            this.panel9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.ControlKey);
            this.panel9.Controls.Add(this.label71);
            this.panel9.Location = new System.Drawing.Point(305, 33);
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
            this.label67.Location = new System.Drawing.Point(315, 10);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(53, 17);
            this.label67.TabIndex = 28;
            this.label67.Text = "Control";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(167, 30);
            this.button4.TabIndex = 29;
            this.button4.Text = "Refresh Databases";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(558, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(167, 30);
            this.button5.TabIndex = 30;
            this.button5.Text = "Test Different Variables";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(770, 32);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(167, 25);
            this.button6.TabIndex = 31;
            this.button6.Text = "Runy # Times:";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(943, 32);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 22);
            this.numericUpDown1.TabIndex = 41;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 574);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label67);
            this.Controls.Add(this.panel9);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GamaInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpsilonInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhiInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeltaInput)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MisrakInput)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NAkInput)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label KowalskiTime;
        private System.Windows.Forms.Label KowalskiMem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label BoyerTime;
        private System.Windows.Forms.Label BoyerMem;
        private System.Windows.Forms.Label BoyerHot;
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
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label ControlKey;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.NumericUpDown DeltaInput;
        private System.Windows.Forms.NumericUpDown PhiInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown EpsilonInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown GamaInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown MisrakInput;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown NAkInput;
        private System.Windows.Forms.Label KowalskiAllHot;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

