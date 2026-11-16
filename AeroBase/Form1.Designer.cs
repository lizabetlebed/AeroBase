namespace AeroBase
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
            panelSidebar = new Panel();
            btnRules = new Button();
            lblLogo = new Label();
            btnMaintenance = new Button();
            btnOverview = new Button();
            btnParts = new Button();
            btnDrones = new Button();
            panelMain = new Panel();
            btnDeleteDrone = new Button();
            btnEditDrone = new Button();
            txtSearch = new TextBox();
            dgvDrones = new DataGridView();
            panel3 = new Panel();
            label3 = new Label();
            lblMaintenanceDrones = new Label();
            panel2 = new Panel();
            label2 = new Label();
            lblReadyDrones = new Label();
            panel1 = new Panel();
            label1 = new Label();
            lblTotalDrones = new Label();
            btnAddDrone = new Button();
            lblPageTitle = new Label();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(24, 40, 64);
            panelSidebar.Controls.Add(btnRules);
            panelSidebar.Controls.Add(lblLogo);
            panelSidebar.Controls.Add(btnMaintenance);
            panelSidebar.Controls.Add(btnOverview);
            panelSidebar.Controls.Add(btnParts);
            panelSidebar.Controls.Add(btnDrones);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(200, 711);
            panelSidebar.TabIndex = 0;
            // 
            // btnRules
            // 
            btnRules.Location = new Point(22, 320);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(75, 23);
            btnRules.TabIndex = 5;
            btnRules.Text = "Правила";
            btnRules.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI", 16F);
            lblLogo.ForeColor = SystemColors.ControlLightLight;
            lblLogo.Location = new Point(44, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(105, 30);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "AeroBase";
            // 
            // btnMaintenance
            // 
            btnMaintenance.Location = new Point(22, 255);
            btnMaintenance.Name = "btnMaintenance";
            btnMaintenance.Size = new Size(103, 23);
            btnMaintenance.TabIndex = 4;
            btnMaintenance.Text = "Обслуживание";
            btnMaintenance.UseVisualStyleBackColor = true;
            // 
            // btnOverview
            // 
            btnOverview.Location = new Point(22, 77);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(75, 23);
            btnOverview.TabIndex = 1;
            btnOverview.Text = "Обзор";
            btnOverview.UseVisualStyleBackColor = true;
            // 
            // btnParts
            // 
            btnParts.Location = new Point(22, 191);
            btnParts.Name = "btnParts";
            btnParts.Size = new Size(115, 23);
            btnParts.TabIndex = 3;
            btnParts.Text = "Комплектующие";
            btnParts.UseVisualStyleBackColor = true;
            // 
            // btnDrones
            // 
            btnDrones.Location = new Point(22, 133);
            btnDrones.Name = "btnDrones";
            btnDrones.Size = new Size(109, 23);
            btnDrones.TabIndex = 2;
            btnDrones.Text = "Реестр БПЛА";
            btnDrones.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            panelMain.BackColor = Color.FromArgb(192, 255, 255);
            panelMain.Controls.Add(btnDeleteDrone);
            panelMain.Controls.Add(btnEditDrone);
            panelMain.Controls.Add(txtSearch);
            panelMain.Controls.Add(dgvDrones);
            panelMain.Controls.Add(panel3);
            panelMain.Controls.Add(panel2);
            panelMain.Controls.Add(panel1);
            panelMain.Controls.Add(btnAddDrone);
            panelMain.Controls.Add(lblPageTitle);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(200, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(984, 711);
            panelMain.TabIndex = 1;
            // 
            // btnDeleteDrone
            // 
            btnDeleteDrone.Location = new Point(121, 582);
            btnDeleteDrone.Name = "btnDeleteDrone";
            btnDeleteDrone.Size = new Size(75, 23);
            btnDeleteDrone.TabIndex = 9;
            btnDeleteDrone.Text = "Удалить";
            btnDeleteDrone.UseVisualStyleBackColor = true;
            btnDeleteDrone.Click += btnDeleteDrone_Click;
            // 
            // btnEditDrone
            // 
            btnEditDrone.Location = new Point(18, 582);
            btnEditDrone.Name = "btnEditDrone";
            btnEditDrone.Size = new Size(75, 23);
            btnEditDrone.TabIndex = 8;
            btnEditDrone.Text = "Изменить";
            btnEditDrone.UseVisualStyleBackColor = true;
            btnEditDrone.Click += btnEditDrone_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(412, 172);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(139, 23);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "Поиск по названию...";
            // 
            // dgvDrones
            // 
            dgvDrones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrones.BackgroundColor = SystemColors.ControlLight;
            dgvDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrones.Location = new Point(9, 201);
            dgvDrones.Name = "dgvDrones";
            dgvDrones.ReadOnly = true;
            dgvDrones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrones.Size = new Size(542, 325);
            dgvDrones.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblMaintenanceDrones);
            panel3.Location = new Point(368, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 81);
            panel3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 16);
            label3.Name = "label3";
            label3.Size = new Size(107, 15);
            label3.TabIndex = 1;
            label3.Text = "На обслуживании";
            // 
            // lblMaintenanceDrones
            // 
            lblMaintenanceDrones.AutoSize = true;
            lblMaintenanceDrones.Location = new Point(13, 45);
            lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            lblMaintenanceDrones.Size = new Size(107, 15);
            lblMaintenanceDrones.TabIndex = 0;
            lblMaintenanceDrones.Text = "На обслуживании";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblReadyDrones);
            panel2.Location = new Point(188, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 81);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 18);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Исправные";
            label2.Click += label2_Click;
            // 
            // lblReadyDrones
            // 
            lblReadyDrones.AutoSize = true;
            lblReadyDrones.Location = new Point(21, 47);
            lblReadyDrones.Name = "lblReadyDrones";
            lblReadyDrones.Size = new Size(70, 15);
            lblReadyDrones.TabIndex = 0;
            lblReadyDrones.Text = "Исправные";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblTotalDrones);
            panel1.Location = new Point(6, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 81);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 18);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Всего БПЛА";
            // 
            // lblTotalDrones
            // 
            lblTotalDrones.AutoSize = true;
            lblTotalDrones.Location = new Point(14, 47);
            lblTotalDrones.Name = "lblTotalDrones";
            lblTotalDrones.Size = new Size(73, 15);
            lblTotalDrones.TabIndex = 2;
            lblTotalDrones.Text = "Всего БПЛА";
            // 
            // btnAddDrone
            // 
            btnAddDrone.BackColor = Color.DodgerBlue;
            btnAddDrone.Location = new Point(451, 26);
            btnAddDrone.Name = "btnAddDrone";
            btnAddDrone.Size = new Size(127, 34);
            btnAddDrone.TabIndex = 1;
            btnAddDrone.Text = "+ Добавить БПЛА";
            btnAddDrone.UseVisualStyleBackColor = false;
            btnAddDrone.Click += btnAddDrone_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 18F);
            lblPageTitle.Location = new Point(18, 22);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(157, 32);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Реестр БПЛА";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 711);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            MinimumSize = new Size(1000, 650);
            Name = "Form1";
            Text = "Form1";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Label lblLogo;
        private Button btnRules;
        private Button btnMaintenance;
        private Button btnOverview;
        private Button btnParts;
        private Button btnDrones;
        private Panel panelMain;
        private Label lblTotalDrones;
        private Button btnAddDrone;
        private Label lblPageTitle;
        private Panel panel3;
        private Panel panel2;
        private Label lblReadyDrones;
        private Panel panel1;
        private DataGridView dgvDrones;
        private Label lblMaintenanceDrones;
        private Button btnDeleteDrone;
        private Button btnEditDrone;
        private TextBox txtSearch;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
