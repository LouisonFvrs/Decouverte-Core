namespace TP1_SLAM5
{
    partial class FormGestionCommandes
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numMontant = new NumericUpDown();
            dateAddCommande = new DateTimePicker();
            cbxAddCommande = new ComboBox();
            btnAddCommande = new Button();
            bsCli = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)numMontant).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsCli).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "Montant";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 65);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 119);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Clients";
            // 
            // numMontant
            // 
            numMontant.Location = new Point(12, 27);
            numMontant.Name = "numMontant";
            numMontant.Size = new Size(120, 23);
            numMontant.TabIndex = 3;
            // 
            // dateAddCommande
            // 
            dateAddCommande.Location = new Point(12, 83);
            dateAddCommande.Name = "dateAddCommande";
            dateAddCommande.Size = new Size(200, 23);
            dateAddCommande.TabIndex = 4;
            // 
            // cbxAddCommande
            // 
            cbxAddCommande.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxAddCommande.FormattingEnabled = true;
            cbxAddCommande.Location = new Point(12, 137);
            cbxAddCommande.Name = "cbxAddCommande";
            cbxAddCommande.Size = new Size(121, 23);
            cbxAddCommande.TabIndex = 5;
            // 
            // btnAddCommande
            // 
            btnAddCommande.Location = new Point(97, 190);
            btnAddCommande.Name = "btnAddCommande";
            btnAddCommande.Size = new Size(75, 23);
            btnAddCommande.TabIndex = 6;
            btnAddCommande.Text = "Ajouter";
            btnAddCommande.UseVisualStyleBackColor = true;
            btnAddCommande.Click += btnAddCommande_Click;
            // 
            // FormGestionCommandes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(268, 236);
            Controls.Add(btnAddCommande);
            Controls.Add(cbxAddCommande);
            Controls.Add(dateAddCommande);
            Controls.Add(numMontant);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormGestionCommandes";
            Text = "FormGestionCommandes";
            ((System.ComponentModel.ISupportInitialize)numMontant).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsCli).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numMontant;
        private DateTimePicker dateAddCommande;
        private ComboBox cbxAddCommande;
        private Button btnAddCommande;
        private BindingSource bsCli;
    }
}