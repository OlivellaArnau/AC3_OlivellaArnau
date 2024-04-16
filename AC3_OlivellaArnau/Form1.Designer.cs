namespace AC3_OlivellaArnau
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gBGestio = new GroupBox();
            tBTotal = new TextBox();
            tBConsumDPC = new TextBox();
            tBActivitat = new TextBox();
            tBXarxa = new TextBox();
            lbTotal = new Label();
            lbConsumDPC = new Label();
            lbActivitats = new Label();
            lbXarxa = new Label();
            tBPoblacio = new TextBox();
            comboBox1 = new ComboBox();
            cBAny = new ComboBox();
            lbPoblació = new Label();
            lBComponent = new Label();
            lBAny = new Label();
            gBStats = new GroupBox();
            lbCDPCbaix2 = new Label();
            lbCDPCalt2 = new Label();
            lbCDMitja2 = new Label();
            lbPoblacio2 = new Label();
            lbCDMitja = new Label();
            lbCDPCalt = new Label();
            lbCDPCbaix = new Label();
            lbPoblacio = new Label();
            btSave = new Button();
            bTClean = new Button();
            dgConsum = new DataGridView();
            consumBindingSource = new BindingSource(components);
            gBGestio.SuspendLayout();
            gBStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)consumBindingSource).BeginInit();
            SuspendLayout();
            // 
            // gBGestio
            // 
            gBGestio.Controls.Add(tBTotal);
            gBGestio.Controls.Add(tBConsumDPC);
            gBGestio.Controls.Add(tBActivitat);
            gBGestio.Controls.Add(tBXarxa);
            gBGestio.Controls.Add(lbTotal);
            gBGestio.Controls.Add(lbConsumDPC);
            gBGestio.Controls.Add(lbActivitats);
            gBGestio.Controls.Add(lbXarxa);
            gBGestio.Controls.Add(tBPoblacio);
            gBGestio.Controls.Add(comboBox1);
            gBGestio.Controls.Add(cBAny);
            gBGestio.Controls.Add(lbPoblació);
            gBGestio.Controls.Add(lBComponent);
            gBGestio.Controls.Add(lBAny);
            gBGestio.Location = new Point(12, 12);
            gBGestio.Name = "gBGestio";
            gBGestio.Size = new Size(589, 233);
            gBGestio.TabIndex = 2;
            gBGestio.TabStop = false;
            gBGestio.Text = "Gestió de dades demogràfques de regions";
            // 
            // tBTotal
            // 
            tBTotal.Location = new Point(491, 159);
            tBTotal.Name = "tBTotal";
            tBTotal.Size = new Size(92, 23);
            tBTotal.TabIndex = 6;
            // 
            // tBConsumDPC
            // 
            tBConsumDPC.Location = new Point(491, 104);
            tBConsumDPC.Name = "tBConsumDPC";
            tBConsumDPC.Size = new Size(92, 23);
            tBConsumDPC.TabIndex = 5;
            // 
            // tBActivitat
            // 
            tBActivitat.Location = new Point(136, 167);
            tBActivitat.Name = "tBActivitat";
            tBActivitat.Size = new Size(138, 23);
            tBActivitat.TabIndex = 4;
            // 
            // tBXarxa
            // 
            tBXarxa.Location = new Point(32, 167);
            tBXarxa.Name = "tBXarxa";
            tBXarxa.Size = new Size(92, 23);
            tBXarxa.TabIndex = 3;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTotal.Location = new Point(367, 167);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(34, 15);
            lbTotal.TabIndex = 9;
            lbTotal.Text = "Total";
            lbTotal.Click += label1_Click_2;
            // 
            // lbConsumDPC
            // 
            lbConsumDPC.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbConsumDPC.Location = new Point(367, 104);
            lbConsumDPC.Name = "lbConsumDPC";
            lbConsumDPC.Size = new Size(118, 36);
            lbConsumDPC.TabIndex = 8;
            lbConsumDPC.Text = "Consum domèsitic per càpita";
            // 
            // lbActivitats
            // 
            lbActivitats.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbActivitats.Location = new Point(136, 108);
            lbActivitats.Name = "lbActivitats";
            lbActivitats.Size = new Size(174, 35);
            lbActivitats.TabIndex = 7;
            lbActivitats.Text = "Activitats econòmiques i fonts pròpiesèstic Xarxa";
            // 
            // lbXarxa
            // 
            lbXarxa.AutoSize = true;
            lbXarxa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbXarxa.Location = new Point(32, 107);
            lbXarxa.Name = "lbXarxa";
            lbXarxa.Size = new Size(95, 15);
            lbXarxa.TabIndex = 6;
            lbXarxa.Text = "Domèstic Xarxa";
            lbXarxa.Click += label1_Click_1;
            // 
            // tBPoblacio
            // 
            tBPoblacio.Location = new Point(282, 50);
            tBPoblacio.Name = "tBPoblacio";
            tBPoblacio.Size = new Size(150, 23);
            tBPoblacio.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(135, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(139, 23);
            comboBox1.TabIndex = 1;
            // 
            // cBAny
            // 
            cBAny.FormattingEnabled = true;
            cBAny.Location = new Point(32, 50);
            cBAny.Name = "cBAny";
            cBAny.Size = new Size(92, 23);
            cBAny.TabIndex = 0;
            cBAny.SelectedIndexChanged += cBAny_SelectedIndexChanged;
            // 
            // lbPoblació
            // 
            lbPoblació.AutoSize = true;
            lbPoblació.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPoblació.Location = new Point(282, 32);
            lbPoblació.Name = "lbPoblació";
            lbPoblació.Size = new Size(53, 15);
            lbPoblació.TabIndex = 2;
            lbPoblació.Text = "Població";
            // 
            // lBComponent
            // 
            lBComponent.AutoSize = true;
            lBComponent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lBComponent.Location = new Point(135, 32);
            lBComponent.Name = "lBComponent";
            lBComponent.Size = new Size(72, 15);
            lBComponent.TabIndex = 1;
            lBComponent.Text = "Component";
            // 
            // lBAny
            // 
            lBAny.AutoSize = true;
            lBAny.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lBAny.Location = new Point(32, 32);
            lBAny.Name = "lBAny";
            lBAny.Size = new Size(28, 15);
            lBAny.TabIndex = 0;
            lBAny.Text = "Any";
            // 
            // gBStats
            // 
            gBStats.Controls.Add(lbCDPCbaix2);
            gBStats.Controls.Add(lbCDPCalt2);
            gBStats.Controls.Add(lbCDMitja2);
            gBStats.Controls.Add(lbPoblacio2);
            gBStats.Controls.Add(lbCDMitja);
            gBStats.Controls.Add(lbCDPCalt);
            gBStats.Controls.Add(lbCDPCbaix);
            gBStats.Controls.Add(lbPoblacio);
            gBStats.Location = new Point(607, 12);
            gBStats.Name = "gBStats";
            gBStats.Size = new Size(360, 233);
            gBStats.TabIndex = 3;
            gBStats.TabStop = false;
            gBStats.Text = "Estadístiques";
            // 
            // lbCDPCbaix2
            // 
            lbCDPCbaix2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCDPCbaix2.ForeColor = SystemColors.HotTrack;
            lbCDPCbaix2.Location = new Point(288, 202);
            lbCDPCbaix2.Name = "lbCDPCbaix2";
            lbCDPCbaix2.Size = new Size(66, 28);
            lbCDPCbaix2.TabIndex = 21;
            lbCDPCbaix2.Text = " ";
            // 
            // lbCDPCalt2
            // 
            lbCDPCalt2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCDPCalt2.ForeColor = SystemColors.HotTrack;
            lbCDPCalt2.Location = new Point(288, 142);
            lbCDPCalt2.Name = "lbCDPCalt2";
            lbCDPCalt2.Size = new Size(66, 28);
            lbCDPCalt2.TabIndex = 20;
            lbCDPCalt2.Text = " ";
            // 
            // lbCDMitja2
            // 
            lbCDMitja2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCDMitja2.ForeColor = SystemColors.HotTrack;
            lbCDMitja2.Location = new Point(288, 87);
            lbCDMitja2.Name = "lbCDMitja2";
            lbCDMitja2.Size = new Size(66, 28);
            lbCDMitja2.TabIndex = 19;
            lbCDMitja2.Text = " ";
            // 
            // lbPoblacio2
            // 
            lbPoblacio2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPoblacio2.ForeColor = SystemColors.HotTrack;
            lbPoblacio2.Location = new Point(288, 32);
            lbPoblacio2.Name = "lbPoblacio2";
            lbPoblacio2.Size = new Size(66, 28);
            lbPoblacio2.TabIndex = 18;
            lbPoblacio2.Text = " ";
            // 
            // lbCDMitja
            // 
            lbCDMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCDMitja.Location = new Point(21, 87);
            lbCDMitja.Name = "lbCDMitja";
            lbCDMitja.Size = new Size(220, 28);
            lbCDMitja.TabIndex = 17;
            lbCDMitja.Text = "Consum dòmestic mitjà:";
            // 
            // lbCDPCalt
            // 
            lbCDPCalt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCDPCalt.Location = new Point(21, 142);
            lbCDPCalt.Name = "lbCDPCalt";
            lbCDPCalt.Size = new Size(220, 28);
            lbCDPCalt.TabIndex = 16;
            lbCDPCalt.Text = "Consum dòmestic per càpita més alt:";
            lbCDPCalt.Click += label1_Click_3;
            // 
            // lbCDPCbaix
            // 
            lbCDPCbaix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbCDPCbaix.Location = new Point(21, 202);
            lbCDPCbaix.Name = "lbCDPCbaix";
            lbCDPCbaix.Size = new Size(220, 28);
            lbCDPCbaix.TabIndex = 15;
            lbCDPCbaix.Text = "Consum dòmestic per càpita més baix:";
            // 
            // lbPoblacio
            // 
            lbPoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbPoblacio.Location = new Point(21, 32);
            lbPoblacio.Name = "lbPoblacio";
            lbPoblacio.Size = new Size(132, 28);
            lbPoblacio.TabIndex = 14;
            lbPoblacio.Text = "Població > 20000 hab.:";
            // 
            // btSave
            // 
            btSave.Location = new Point(526, 251);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 4;
            btSave.Text = "Guardar";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // bTClean
            // 
            bTClean.Location = new Point(445, 251);
            bTClean.Name = "bTClean";
            bTClean.Size = new Size(75, 23);
            bTClean.TabIndex = 5;
            bTClean.Text = "Natejar";
            bTClean.UseVisualStyleBackColor = true;
            // 
            // dgConsum
            // 
            dgConsum.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsum.Location = new Point(67, 288);
            dgConsum.Name = "dgConsum";
            dgConsum.Size = new Size(844, 150);
            dgConsum.TabIndex = 7;
            dgConsum.CellContentClick += dataGridView1_CellContentClick;
            // 
            // consumBindingSource
            // 
            consumBindingSource.DataSource = typeof(Model.Consum);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 450);
            Controls.Add(dgConsum);
            Controls.Add(bTClean);
            Controls.Add(btSave);
            Controls.Add(gBStats);
            Controls.Add(gBGestio);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques de regions";
            gBGestio.ResumeLayout(false);
            gBGestio.PerformLayout();
            gBStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgConsum).EndInit();
            ((System.ComponentModel.ISupportInitialize)consumBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitolSeccio1;
        private GroupBox gBGestio;
        private GroupBox gBStats;
        private Label lbPoblació;
        private Label lBComponent;
        private Label lBAny;
        private Label lbXarxa;
        private TextBox tBPoblacio;
        private ComboBox comboBox1;
        private ComboBox cBAny;
        private Label lbActivitats;
        private Label lbTotal;
        private Label lbConsumDPC;
        private TextBox tBTotal;
        private TextBox tBConsumDPC;
        private TextBox tBActivitat;
        private TextBox tBXarxa;
        private Label lbCDPCalt;
        private Label lbCDPCbaix;
        private Label lbPoblacio;
        private Label lbPoblacio2;
        private Label lbCDMitja;
        private Label lbCDPCbaix2;
        private Label lbCDPCalt2;
        private Label lbCDMitja2;
        private Button btSave;
        private Button bTClean;
        private DataGridView dgConsum;
        private BindingSource consumBindingSource;
    }
}
