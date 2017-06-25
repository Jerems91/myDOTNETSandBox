namespace GestionFormation {
    partial class StagiaireForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.validerBtn = new System.Windows.Forms.Button();
            this.annulerBtn = new System.Windows.Forms.Button();
            this.detailsBox = new System.Windows.Forms.GroupBox();
            this.remiseLbl = new System.Windows.Forms.Label();
            this.remiseNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.regimeAlimentaireLbl = new System.Windows.Forms.Label();
            this.payeurLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.societeLbl = new System.Windows.Forms.Label();
            this.dateNaissanceLbl = new System.Windows.Forms.Label();
            this.prenomLbl = new System.Windows.Forms.Label();
            this.nomLbl = new System.Windows.Forms.Label();
            this.civiliteLbl = new System.Windows.Forms.Label();
            this.regimeAlimentaireCheckBox = new System.Windows.Forms.CheckBox();
            this.payeurComboBox = new System.Windows.Forms.ComboBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.societeTextBox = new System.Windows.Forms.TextBox();
            this.dateNaissanceTimePicker = new System.Windows.Forms.DateTimePicker();
            this.civiliteComboBox = new System.Windows.Forms.ComboBox();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.detailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remiseNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.validerBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.annulerBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(259, 303);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 35);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // validerBtn
            // 
            this.validerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.validerBtn.Location = new System.Drawing.Point(3, 3);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(94, 29);
            this.validerBtn.TabIndex = 0;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // annulerBtn
            // 
            this.annulerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.annulerBtn.Location = new System.Drawing.Point(103, 3);
            this.annulerBtn.Name = "annulerBtn";
            this.annulerBtn.Size = new System.Drawing.Size(94, 29);
            this.annulerBtn.TabIndex = 1;
            this.annulerBtn.Text = "Annuler";
            this.annulerBtn.UseVisualStyleBackColor = true;
            this.annulerBtn.Click += new System.EventHandler(this.annulerBtn_Click);
            // 
            // detailsBox
            // 
            this.detailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsBox.Controls.Add(this.remiseLbl);
            this.detailsBox.Controls.Add(this.remiseNumericUpDown);
            this.detailsBox.Controls.Add(this.regimeAlimentaireLbl);
            this.detailsBox.Controls.Add(this.payeurLbl);
            this.detailsBox.Controls.Add(this.emailLbl);
            this.detailsBox.Controls.Add(this.societeLbl);
            this.detailsBox.Controls.Add(this.dateNaissanceLbl);
            this.detailsBox.Controls.Add(this.prenomLbl);
            this.detailsBox.Controls.Add(this.nomLbl);
            this.detailsBox.Controls.Add(this.civiliteLbl);
            this.detailsBox.Controls.Add(this.regimeAlimentaireCheckBox);
            this.detailsBox.Controls.Add(this.payeurComboBox);
            this.detailsBox.Controls.Add(this.emailTextBox);
            this.detailsBox.Controls.Add(this.societeTextBox);
            this.detailsBox.Controls.Add(this.dateNaissanceTimePicker);
            this.detailsBox.Controls.Add(this.civiliteComboBox);
            this.detailsBox.Controls.Add(this.prenomTextBox);
            this.detailsBox.Controls.Add(this.nomTextBox);
            this.detailsBox.Location = new System.Drawing.Point(12, 12);
            this.detailsBox.Name = "detailsBox";
            this.detailsBox.Size = new System.Drawing.Size(447, 289);
            this.detailsBox.TabIndex = 1;
            this.detailsBox.TabStop = false;
            this.detailsBox.Text = "Détails";
            // 
            // remiseLbl
            // 
            this.remiseLbl.AutoSize = true;
            this.remiseLbl.Location = new System.Drawing.Point(57, 237);
            this.remiseLbl.Name = "remiseLbl";
            this.remiseLbl.Size = new System.Drawing.Size(42, 13);
            this.remiseLbl.TabIndex = 17;
            this.remiseLbl.Text = "Remise";
            // 
            // remiseNumericUpDown
            // 
            this.remiseNumericUpDown.DecimalPlaces = 2;
            this.remiseNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.remiseNumericUpDown.Location = new System.Drawing.Point(235, 235);
            this.remiseNumericUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.remiseNumericUpDown.Name = "remiseNumericUpDown";
            this.remiseNumericUpDown.Size = new System.Drawing.Size(148, 20);
            this.remiseNumericUpDown.TabIndex = 16;
            // 
            // regimeAlimentaireLbl
            // 
            this.regimeAlimentaireLbl.AutoSize = true;
            this.regimeAlimentaireLbl.Location = new System.Drawing.Point(57, 211);
            this.regimeAlimentaireLbl.Name = "regimeAlimentaireLbl";
            this.regimeAlimentaireLbl.Size = new System.Drawing.Size(96, 13);
            this.regimeAlimentaireLbl.TabIndex = 15;
            this.regimeAlimentaireLbl.Text = "Régime alimentaire";
            // 
            // payeurLbl
            // 
            this.payeurLbl.AutoSize = true;
            this.payeurLbl.Location = new System.Drawing.Point(57, 185);
            this.payeurLbl.Name = "payeurLbl";
            this.payeurLbl.Size = new System.Drawing.Size(40, 13);
            this.payeurLbl.TabIndex = 14;
            this.payeurLbl.Text = "Payeur";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Location = new System.Drawing.Point(57, 159);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(32, 13);
            this.emailLbl.TabIndex = 13;
            this.emailLbl.Text = "Email";
            // 
            // societeLbl
            // 
            this.societeLbl.AutoSize = true;
            this.societeLbl.Location = new System.Drawing.Point(57, 133);
            this.societeLbl.Name = "societeLbl";
            this.societeLbl.Size = new System.Drawing.Size(43, 13);
            this.societeLbl.TabIndex = 12;
            this.societeLbl.Text = "Société";
            // 
            // dateNaissanceLbl
            // 
            this.dateNaissanceLbl.AutoSize = true;
            this.dateNaissanceLbl.Location = new System.Drawing.Point(57, 107);
            this.dateNaissanceLbl.Name = "dateNaissanceLbl";
            this.dateNaissanceLbl.Size = new System.Drawing.Size(96, 13);
            this.dateNaissanceLbl.TabIndex = 11;
            this.dateNaissanceLbl.Text = "Date de naissance";
            // 
            // prenomLbl
            // 
            this.prenomLbl.AutoSize = true;
            this.prenomLbl.Location = new System.Drawing.Point(57, 81);
            this.prenomLbl.Name = "prenomLbl";
            this.prenomLbl.Size = new System.Drawing.Size(43, 13);
            this.prenomLbl.TabIndex = 10;
            this.prenomLbl.Text = "Prénom";
            // 
            // nomLbl
            // 
            this.nomLbl.AutoSize = true;
            this.nomLbl.Location = new System.Drawing.Point(57, 55);
            this.nomLbl.Name = "nomLbl";
            this.nomLbl.Size = new System.Drawing.Size(29, 13);
            this.nomLbl.TabIndex = 9;
            this.nomLbl.Text = "Nom";
            // 
            // civiliteLbl
            // 
            this.civiliteLbl.AutoSize = true;
            this.civiliteLbl.Location = new System.Drawing.Point(57, 29);
            this.civiliteLbl.Name = "civiliteLbl";
            this.civiliteLbl.Size = new System.Drawing.Size(37, 13);
            this.civiliteLbl.TabIndex = 8;
            this.civiliteLbl.Text = "Civilité";
            // 
            // regimeAlimentaireCheckBox
            // 
            this.regimeAlimentaireCheckBox.AutoSize = true;
            this.regimeAlimentaireCheckBox.Location = new System.Drawing.Point(235, 214);
            this.regimeAlimentaireCheckBox.Name = "regimeAlimentaireCheckBox";
            this.regimeAlimentaireCheckBox.Size = new System.Drawing.Size(15, 14);
            this.regimeAlimentaireCheckBox.TabIndex = 7;
            this.regimeAlimentaireCheckBox.UseVisualStyleBackColor = true;
            // 
            // payeurComboBox
            // 
            this.payeurComboBox.FormattingEnabled = true;
            this.payeurComboBox.Location = new System.Drawing.Point(235, 186);
            this.payeurComboBox.Name = "payeurComboBox";
            this.payeurComboBox.Size = new System.Drawing.Size(148, 21);
            this.payeurComboBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(235, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // societeTextBox
            // 
            this.societeTextBox.Location = new System.Drawing.Point(235, 132);
            this.societeTextBox.Name = "societeTextBox";
            this.societeTextBox.Size = new System.Drawing.Size(148, 20);
            this.societeTextBox.TabIndex = 4;
            // 
            // dateNaissanceTimePicker
            // 
            this.dateNaissanceTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNaissanceTimePicker.Location = new System.Drawing.Point(235, 105);
            this.dateNaissanceTimePicker.Name = "dateNaissanceTimePicker";
            this.dateNaissanceTimePicker.Size = new System.Drawing.Size(148, 20);
            this.dateNaissanceTimePicker.TabIndex = 3;
            this.dateNaissanceTimePicker.Value = new System.DateTime(2017, 6, 22, 9, 29, 27, 0);
            // 
            // civiliteComboBox
            // 
            this.civiliteComboBox.FormattingEnabled = true;
            this.civiliteComboBox.Location = new System.Drawing.Point(235, 26);
            this.civiliteComboBox.Name = "civiliteComboBox";
            this.civiliteComboBox.Size = new System.Drawing.Size(148, 21);
            this.civiliteComboBox.TabIndex = 2;
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(235, 79);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(148, 20);
            this.prenomTextBox.TabIndex = 1;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(235, 53);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(148, 20);
            this.nomTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // StagiaireForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 350);
            this.Controls.Add(this.detailsBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StagiaireForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StagiaireForm";
            this.Load += new System.EventHandler(this.StagiaireForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.detailsBox.ResumeLayout(false);
            this.detailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remiseNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Button annulerBtn;
        private System.Windows.Forms.GroupBox detailsBox;
        private System.Windows.Forms.ComboBox payeurComboBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox societeTextBox;
        private System.Windows.Forms.DateTimePicker dateNaissanceTimePicker;
        private System.Windows.Forms.ComboBox civiliteComboBox;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.CheckBox regimeAlimentaireCheckBox;
        private System.Windows.Forms.Label payeurLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label societeLbl;
        private System.Windows.Forms.Label dateNaissanceLbl;
        private System.Windows.Forms.Label prenomLbl;
        private System.Windows.Forms.Label nomLbl;
        private System.Windows.Forms.Label civiliteLbl;
        private System.Windows.Forms.Label regimeAlimentaireLbl;
        private System.Windows.Forms.Label remiseLbl;
        private System.Windows.Forms.NumericUpDown remiseNumericUpDown;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}