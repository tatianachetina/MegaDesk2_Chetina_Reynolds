namespace MegaDesk_Chetina
{
    partial class AddQuote
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelDepth = new System.Windows.Forms.Label();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelRushDays = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelDrawers = new System.Windows.Forms.Label();
            this.buttonMainMenu = new System.Windows.Forms.Button();
            this.buttonSaveQuotes = new System.Windows.Forms.Button();
            this.textBoxClientName = new System.Windows.Forms.TextBox();
            this.comboBoxRushDays = new System.Windows.Forms.ComboBox();
            this.comboBoxMaterial = new System.Windows.Forms.ComboBox();
            this.comboBoxDrawers = new System.Windows.Forms.ComboBox();
            this.depthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.widthErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.numUpDownDeskDepth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownDeskWidth = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDeskDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDeskWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(32, 39);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(95, 20);
            this.labelClientName.TabIndex = 0;
            this.labelClientName.Text = "Client Name";
            // 
            // labelDepth
            // 
            this.labelDepth.AutoSize = true;
            this.labelDepth.Location = new System.Drawing.Point(32, 86);
            this.labelDepth.Name = "labelDepth";
            this.labelDepth.Size = new System.Drawing.Size(94, 20);
            this.labelDepth.TabIndex = 1;
            this.labelDepth.Text = "Desk Depth";
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(32, 131);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(91, 20);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Desk Width";
            // 
            // labelRushDays
            // 
            this.labelRushDays.AutoSize = true;
            this.labelRushDays.Location = new System.Drawing.Point(32, 177);
            this.labelRushDays.Name = "labelRushDays";
            this.labelRushDays.Size = new System.Drawing.Size(87, 20);
            this.labelRushDays.TabIndex = 4;
            this.labelRushDays.Text = "Rush Days";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(32, 224);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(65, 20);
            this.labelMaterial.TabIndex = 5;
            this.labelMaterial.Text = "Material";
            // 
            // labelDrawers
            // 
            this.labelDrawers.AutoSize = true;
            this.labelDrawers.Location = new System.Drawing.Point(32, 266);
            this.labelDrawers.Name = "labelDrawers";
            this.labelDrawers.Size = new System.Drawing.Size(68, 20);
            this.labelDrawers.TabIndex = 6;
            this.labelDrawers.Text = "Drawers";
            // 
            // buttonMainMenu
            // 
            this.buttonMainMenu.Location = new System.Drawing.Point(35, 337);
            this.buttonMainMenu.Name = "buttonMainMenu";
            this.buttonMainMenu.Size = new System.Drawing.Size(125, 38);
            this.buttonMainMenu.TabIndex = 9;
            this.buttonMainMenu.Text = "Main Menu";
            this.buttonMainMenu.UseVisualStyleBackColor = true;
            this.buttonMainMenu.Click += new System.EventHandler(this.ButtonMainMenu_Click);
            // 
            // buttonSaveQuotes
            // 
            this.buttonSaveQuotes.Location = new System.Drawing.Point(240, 337);
            this.buttonSaveQuotes.Name = "buttonSaveQuotes";
            this.buttonSaveQuotes.Size = new System.Drawing.Size(125, 38);
            this.buttonSaveQuotes.TabIndex = 10;
            this.buttonSaveQuotes.Text = "Save Quotes";
            this.buttonSaveQuotes.UseVisualStyleBackColor = true;
       
            // 
            // textBoxClientName
            // 
            this.textBoxClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClientName.Location = new System.Drawing.Point(130, 33);
            this.textBoxClientName.Name = "textBoxClientName";
            this.textBoxClientName.Size = new System.Drawing.Size(235, 26);
            this.textBoxClientName.TabIndex = 12;
            // 
            // comboBoxRushDays
            // 
            this.comboBoxRushDays.FormattingEnabled = true;
            this.comboBoxRushDays.Items.AddRange(new object[] {
            "Rush 3 Day",
            "Rush 5 Day",
            "Rush 7 Day",
            "NoRush 14 Day"});
            this.comboBoxRushDays.Location = new System.Drawing.Point(130, 169);
            this.comboBoxRushDays.Name = "comboBoxRushDays";
            this.comboBoxRushDays.Size = new System.Drawing.Size(120, 28);
            this.comboBoxRushDays.TabIndex = 15;
            // 
            // comboBoxMaterial
            // 
            this.comboBoxMaterial.FormattingEnabled = true;
            this.comboBoxMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Rosewood",
            "Veneer",
            "Pine"});
            this.comboBoxMaterial.Location = new System.Drawing.Point(130, 216);
            this.comboBoxMaterial.Name = "comboBoxMaterial";
            this.comboBoxMaterial.Size = new System.Drawing.Size(120, 28);
            this.comboBoxMaterial.TabIndex = 16;
            // 
            // comboBoxDrawers
            // 
            this.comboBoxDrawers.FormattingEnabled = true;
            this.comboBoxDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBoxDrawers.Location = new System.Drawing.Point(130, 263);
            this.comboBoxDrawers.Name = "comboBoxDrawers";
            this.comboBoxDrawers.Size = new System.Drawing.Size(120, 28);
            this.comboBoxDrawers.TabIndex = 17;
            // 
            // depthErrorProvider
            // 
            this.depthErrorProvider.ContainerControl = this;
            // 
            // widthErrorProvider
            // 
            this.widthErrorProvider.ContainerControl = this;
            // 
            // numUpDownDeskDepth
            // 
            this.numUpDownDeskDepth.Location = new System.Drawing.Point(130, 82);
            this.numUpDownDeskDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numUpDownDeskDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numUpDownDeskDepth.Name = "numUpDownDeskDepth";
            this.numUpDownDeskDepth.Size = new System.Drawing.Size(120, 26);
            this.numUpDownDeskDepth.TabIndex = 18;
            this.numUpDownDeskDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numUpDownDeskWidth
            // 
            this.numUpDownDeskWidth.Location = new System.Drawing.Point(130, 126);
            this.numUpDownDeskWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numUpDownDeskWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numUpDownDeskWidth.Name = "numUpDownDeskWidth";
            this.numUpDownDeskWidth.Size = new System.Drawing.Size(120, 26);
            this.numUpDownDeskWidth.TabIndex = 19;
            this.numUpDownDeskWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(403, 423);
            this.Controls.Add(this.numUpDownDeskWidth);
            this.Controls.Add(this.numUpDownDeskDepth);
            this.Controls.Add(this.comboBoxDrawers);
            this.Controls.Add(this.comboBoxMaterial);
            this.Controls.Add(this.comboBoxRushDays);
            this.Controls.Add(this.textBoxClientName);
            this.Controls.Add(this.buttonSaveQuotes);
            this.Controls.Add(this.buttonMainMenu);
            this.Controls.Add(this.labelDrawers);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelRushDays);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.labelDepth);
            this.Controls.Add(this.labelClientName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            ((System.ComponentModel.ISupportInitialize)(this.depthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDeskDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownDeskWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelDepth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelRushDays;
        private System.Windows.Forms.Label labelMaterial;
        private System.Windows.Forms.Label labelDrawers;
        private System.Windows.Forms.Button buttonMainMenu;
        private System.Windows.Forms.Button buttonSaveQuotes;
        private System.Windows.Forms.TextBox textBoxClientName;
        private System.Windows.Forms.ComboBox comboBoxRushDays;
        private System.Windows.Forms.ComboBox comboBoxMaterial;
        private System.Windows.Forms.ComboBox comboBoxDrawers;
        private System.Windows.Forms.ErrorProvider depthErrorProvider;
        private System.Windows.Forms.ErrorProvider widthErrorProvider;
        private System.Windows.Forms.NumericUpDown numUpDownDeskWidth;
        private System.Windows.Forms.NumericUpDown numUpDownDeskDepth;
    }
}