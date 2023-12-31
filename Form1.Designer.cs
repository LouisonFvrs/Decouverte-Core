﻿namespace TP1_SLAM5
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
            dgvData = new DataGridView();
            menuStrip1 = new MenuStrip();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            auteursToolStripMenuItem = new ToolStripMenuItem();
            commandesToolStripMenuItem = new ToolStripMenuItem();
            partitionsToolStripMenuItem = new ToolStripMenuItem();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            bsData = new BindingSource(components);
            cbxClient = new ComboBox();
            bsCli = new BindingSource(components);
            num = new NumericUpDown();
            cbxComande = new ComboBox();
            bsCmd = new BindingSource(components);
            cbx_style = new ComboBox();
            bsStyle = new BindingSource(components);
            addButton = new Button();
            btnEdit = new Button();
            btnDelCmd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCli).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCmd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).BeginInit();
            SuspendLayout();
            // 
            // dgvData
            // 
            dgvData.AllowUserToAddRows = false;
            dgvData.AllowUserToDeleteRows = false;
            dgvData.AllowUserToResizeColumns = false;
            dgvData.AllowUserToResizeRows = false;
            dgvData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(45, 44);
            dgvData.Name = "dgvData";
            dgvData.RowTemplate.Height = 25;
            dgvData.Size = new Size(711, 310);
            dgvData.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientsToolStripMenuItem, auteursToolStripMenuItem, commandesToolStripMenuItem, partitionsToolStripMenuItem, quitterToolStripMenuItem });
            menuStrip1.Location = new Point(3, 3);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(335, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(55, 20);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click;
            // 
            // auteursToolStripMenuItem
            // 
            auteursToolStripMenuItem.Name = "auteursToolStripMenuItem";
            auteursToolStripMenuItem.Size = new Size(60, 20);
            auteursToolStripMenuItem.Text = "Auteurs";
            auteursToolStripMenuItem.Click += auteursToolStripMenuItem_Click;
            // 
            // commandesToolStripMenuItem
            // 
            commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            commandesToolStripMenuItem.Size = new Size(87, 20);
            commandesToolStripMenuItem.Text = "Commandes";
            commandesToolStripMenuItem.Click += commandesToolStripMenuItem_Click;
            // 
            // partitionsToolStripMenuItem
            // 
            partitionsToolStripMenuItem.Name = "partitionsToolStripMenuItem";
            partitionsToolStripMenuItem.Size = new Size(69, 20);
            partitionsToolStripMenuItem.Text = "Partitions";
            partitionsToolStripMenuItem.Click += partitionsToolStripMenuItem_Click;
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(56, 20);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // cbxClient
            // 
            cbxClient.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxClient.FormattingEnabled = true;
            cbxClient.Location = new Point(45, 377);
            cbxClient.Name = "cbxClient";
            cbxClient.Size = new Size(121, 23);
            cbxClient.TabIndex = 2;
            // 
            // bsCli
            // 
            bsCli.CurrentChanged += bsCli_CurrentChanged;
            // 
            // num
            // 
            num.Location = new Point(636, 377);
            num.Name = "num";
            num.Size = new Size(120, 23);
            num.TabIndex = 3;
            num.Visible = false;
            num.ValueChanged += num_ValueChanged;
            // 
            // cbxComande
            // 
            cbxComande.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxComande.FormattingEnabled = true;
            cbxComande.Location = new Point(45, 377);
            cbxComande.Name = "cbxComande";
            cbxComande.Size = new Size(121, 23);
            cbxComande.TabIndex = 4;
            cbxComande.Visible = false;
            // 
            // bsCmd
            // 
            bsCmd.CurrentChanged += bsCmd_CurrentChanged;
            // 
            // cbx_style
            // 
            cbx_style.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_style.FormattingEnabled = true;
            cbx_style.Location = new Point(45, 377);
            cbx_style.Name = "cbx_style";
            cbx_style.Size = new Size(121, 23);
            cbx_style.TabIndex = 5;
            cbx_style.Visible = false;
            // 
            // bsStyle
            // 
            bsStyle.CurrentChanged += bsStyle_CurrentChanged;
            // 
            // addButton
            // 
            addButton.Location = new Point(535, 415);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Ajouter";
            addButton.UseVisualStyleBackColor = true;
            addButton.Visible = false;
            addButton.Click += addButton_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(454, 415);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Modifier";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Visible = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelCmd
            // 
            btnDelCmd.Location = new Point(373, 415);
            btnDelCmd.Name = "btnDelCmd";
            btnDelCmd.Size = new Size(75, 23);
            btnDelCmd.TabIndex = 8;
            btnDelCmd.Text = "Supprimer";
            btnDelCmd.UseVisualStyleBackColor = true;
            btnDelCmd.Visible = false;
            btnDelCmd.Click += btnDelCmd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelCmd);
            Controls.Add(btnEdit);
            Controls.Add(addButton);
            Controls.Add(cbx_style);
            Controls.Add(cbxComande);
            Controls.Add(num);
            Controls.Add(cbxClient);
            Controls.Add(dgvData);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsData).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCli).EndInit();
            ((System.ComponentModel.ISupportInitialize)num).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCmd).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsStyle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvData;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem auteursToolStripMenuItem;
        private ToolStripMenuItem commandesToolStripMenuItem;
        private ToolStripMenuItem partitionsToolStripMenuItem;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private BindingSource bsData;
        private ComboBox cbxClient;
        private BindingSource bsCli;
        private NumericUpDown num;
        private ComboBox cbxComande;
        private BindingSource bsCmd;
        private ComboBox cbx_style;
        private BindingSource bsStyle;
        private Button addButton;
        private Button btnEdit;
        private Button btnDelCmd;
    }
}