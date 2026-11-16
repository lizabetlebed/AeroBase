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
            lblLogo = new Label();
            btnOverview = new Button();
            btnDrones = new Button();
            btnParts = new Button();
            btnMaintenance = new Button();
            btnRules = new Button();
            panelMain = new Panel();
            lblPageTitle = new Label();
            btnAddDrone = new Button();
            lblTotalDrones = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblReadyDrones = new Label();
            lblMaintenanceDrones = new Label();
            dgvDrones = new DataGridView();
            txtSearch = new TextBox();
            btnEditDrone = new Button();
            btnDeleteDrone = new Button();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).BeginInit();
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
            // btnOverview
            // 
            btnOverview.Location = new Point(22, 77);
            btnOverview.Name = "btnOverview";
            btnOverview.Size = new Size(75, 23);
            btnOverview.TabIndex = 1;
            btnOverview.Text = "Обзор";
            btnOverview.UseVisualStyleBackColor = true;
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
            // btnParts
            // 
            btnParts.Location = new Point(22, 191);
            btnParts.Name = "btnParts";
            btnParts.Size = new Size(115, 23);
            btnParts.TabIndex = 3;
            btnParts.Text = "Комплектующие";
            btnParts.UseVisualStyleBackColor = true;
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
            // btnRules
            // 
            btnRules.Location = new Point(22, 320);
            btnRules.Name = "btnRules";
            btnRules.Size = new Size(75, 23);
            btnRules.TabIndex = 5;
            btnRules.Text = "Правила";
            btnRules.UseVisualStyleBackColor = true;
            btnRules.Click += button5_Click;
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
            // btnAddDrone
            // 
            btnAddDrone.BackColor = Color.DodgerBlue;
            btnAddDrone.Location = new Point(451, 26);
            btnAddDrone.Name = "btnAddDrone";
            btnAddDrone.Size = new Size(127, 34);
            btnAddDrone.TabIndex = 1;
            btnAddDrone.Text = "+ Добавить БПЛА";
            btnAddDrone.UseVisualStyleBackColor = false;
            // 
            // lblTotalDrones
            // 
            lblTotalDrones.AutoSize = true;
            lblTotalDrones.Location = new Point(3, 9);
            lblTotalDrones.Name = "lblTotalDrones";
            lblTotalDrones.Size = new Size(73, 15);
            lblTotalDrones.TabIndex = 2;
            lblTotalDrones.Text = "Всего БПЛА";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblTotalDrones);
            panel1.Location = new Point(6, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 81);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblReadyDrones);
            panel2.Location = new Point(188, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(162, 81);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblMaintenanceDrones);
            panel3.Location = new Point(368, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(183, 81);
            panel3.TabIndex = 5;
            // 
            // lblReadyDrones
            // 
            lblReadyDrones.AutoSize = true;
            lblReadyDrones.Location = new Point(12, 9);
            lblReadyDrones.Name = "lblReadyDrones";
            lblReadyDrones.Size = new Size(70, 15);
            lblReadyDrones.TabIndex = 0;
            lblReadyDrones.Text = "Исправные";
            lblReadyDrones.Click += lblReadyDrones_Click;
            // 
            // lblMaintenanceDrones
            // 
            lblMaintenanceDrones.AutoSize = true;
            lblMaintenanceDrones.Location = new Point(13, 8);
            lblMaintenanceDrones.Name = "lblMaintenanceDrones";
            lblMaintenanceDrones.Size = new Size(107, 15);
            lblMaintenanceDrones.TabIndex = 0;
            lblMaintenanceDrones.Text = "На обслуживании";
            // 
            // dgvDrones
            // 
            dgvDrones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDrones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrones.Location = new Point(9, 201);
            dgvDrones.Name = "dgvDrones";
            dgvDrones.ReadOnly = true;
            dgvDrones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDrones.Size = new Size(542, 325);
            dgvDrones.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(412, 172);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(139, 23);
            txtSearch.TabIndex = 7;
            txtSearch.Text = "Поиск по названию...";
            // 
            // btnEditDrone
            // 
            btnEditDrone.Location = new Point(18, 582);
            btnEditDrone.Name = "btnEditDrone";
            btnEditDrone.Size = new Size(75, 23);
            btnEditDrone.TabIndex = 8;
            btnEditDrone.Text = "Изменить";
            btnEditDrone.UseVisualStyleBackColor = true;
            // 
            // btnDeleteDrone
            // 
            btnDeleteDrone.Location = new Point(121, 582);
            btnDeleteDrone.Name = "btnDeleteDrone";
            btnDeleteDrone.Size = new Size(75, 23);
            btnDeleteDrone.TabIndex = 9;
            btnDeleteDrone.Text = "Удалить";
            btnDeleteDrone.UseVisualStyleBackColor = true;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrones).EndInit();
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
    }
}
