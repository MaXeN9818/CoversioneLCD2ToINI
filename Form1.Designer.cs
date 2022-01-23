
namespace CreazioneIniMateriali
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Insert = new System.Windows.Forms.RichTextBox();
            this.lbl_Out = new System.Windows.Forms.RichTextBox();
            this.btn_Converti = new System.Windows.Forms.Button();
            this.btn_Copia = new System.Windows.Forms.Button();
            this.btn_Incolla = new System.Windows.Forms.Button();
            this.btn_Cancella = new System.Windows.Forms.Button();
            this.btn_Cancella2 = new System.Windows.Forms.Button();
            this.btn_Incolla2 = new System.Windows.Forms.Button();
            this.btn_Copia2 = new System.Windows.Forms.Button();
            this.cmb_SelezioneMateriali = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Insert
            // 
            this.lbl_Insert.Location = new System.Drawing.Point(12, 12);
            this.lbl_Insert.Name = "lbl_Insert";
            this.lbl_Insert.Size = new System.Drawing.Size(330, 391);
            this.lbl_Insert.TabIndex = 2;
            this.lbl_Insert.Text = "";
            // 
            // lbl_Out
            // 
            this.lbl_Out.Location = new System.Drawing.Point(458, 12);
            this.lbl_Out.Name = "lbl_Out";
            this.lbl_Out.Size = new System.Drawing.Size(330, 391);
            this.lbl_Out.TabIndex = 3;
            this.lbl_Out.Text = "";
            // 
            // btn_Converti
            // 
            this.btn_Converti.Location = new System.Drawing.Point(348, 167);
            this.btn_Converti.Name = "btn_Converti";
            this.btn_Converti.Size = new System.Drawing.Size(104, 105);
            this.btn_Converti.TabIndex = 4;
            this.btn_Converti.Text = "CONVERTI -->";
            this.btn_Converti.UseVisualStyleBackColor = true;
            this.btn_Converti.Click += new System.EventHandler(this.btn_Converti_Click);
            // 
            // btn_Copia
            // 
            this.btn_Copia.Location = new System.Drawing.Point(52, 410);
            this.btn_Copia.Name = "btn_Copia";
            this.btn_Copia.Size = new System.Drawing.Size(75, 23);
            this.btn_Copia.TabIndex = 5;
            this.btn_Copia.Text = "Copia";
            this.btn_Copia.UseVisualStyleBackColor = true;
            this.btn_Copia.Click += new System.EventHandler(this.btn_Copia_Click);
            // 
            // btn_Incolla
            // 
            this.btn_Incolla.Location = new System.Drawing.Point(133, 410);
            this.btn_Incolla.Name = "btn_Incolla";
            this.btn_Incolla.Size = new System.Drawing.Size(75, 23);
            this.btn_Incolla.TabIndex = 6;
            this.btn_Incolla.Text = "Incolla";
            this.btn_Incolla.UseVisualStyleBackColor = true;
            this.btn_Incolla.Click += new System.EventHandler(this.btn_Incolla_Click);
            // 
            // btn_Cancella
            // 
            this.btn_Cancella.Location = new System.Drawing.Point(214, 410);
            this.btn_Cancella.Name = "btn_Cancella";
            this.btn_Cancella.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancella.TabIndex = 7;
            this.btn_Cancella.Text = "Cancella";
            this.btn_Cancella.UseVisualStyleBackColor = true;
            this.btn_Cancella.Click += new System.EventHandler(this.btn_Cancella_Click);
            // 
            // btn_Cancella2
            // 
            this.btn_Cancella2.Location = new System.Drawing.Point(678, 410);
            this.btn_Cancella2.Name = "btn_Cancella2";
            this.btn_Cancella2.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancella2.TabIndex = 10;
            this.btn_Cancella2.Text = "Cancella";
            this.btn_Cancella2.UseVisualStyleBackColor = true;
            this.btn_Cancella2.Click += new System.EventHandler(this.btn_Cancella2_Click);
            // 
            // btn_Incolla2
            // 
            this.btn_Incolla2.Location = new System.Drawing.Point(597, 410);
            this.btn_Incolla2.Name = "btn_Incolla2";
            this.btn_Incolla2.Size = new System.Drawing.Size(75, 23);
            this.btn_Incolla2.TabIndex = 9;
            this.btn_Incolla2.Text = "Incolla";
            this.btn_Incolla2.UseVisualStyleBackColor = true;
            this.btn_Incolla2.Click += new System.EventHandler(this.btn_Incolla2_Click);
            // 
            // btn_Copia2
            // 
            this.btn_Copia2.Location = new System.Drawing.Point(516, 410);
            this.btn_Copia2.Name = "btn_Copia2";
            this.btn_Copia2.Size = new System.Drawing.Size(75, 23);
            this.btn_Copia2.TabIndex = 8;
            this.btn_Copia2.Text = "Copia";
            this.btn_Copia2.UseVisualStyleBackColor = true;
            this.btn_Copia2.Click += new System.EventHandler(this.btn_Copia2_Click);
            // 
            // cmb_SelezioneMateriali
            // 
            this.cmb_SelezioneMateriali.CausesValidation = false;
            this.cmb_SelezioneMateriali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelezioneMateriali.FormattingEnabled = true;
            this.cmb_SelezioneMateriali.Items.AddRange(new object[] {
            "Vari",
            "Lingotti",
            "Ore"});
            this.cmb_SelezioneMateriali.Location = new System.Drawing.Point(348, 317);
            this.cmb_SelezioneMateriali.Name = "cmb_SelezioneMateriali";
            this.cmb_SelezioneMateriali.Size = new System.Drawing.Size(104, 21);
            this.cmb_SelezioneMateriali.TabIndex = 1;
            this.cmb_SelezioneMateriali.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo Di Materiale";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_SelezioneMateriali);
            this.Controls.Add(this.btn_Cancella2);
            this.Controls.Add(this.btn_Incolla2);
            this.Controls.Add(this.btn_Copia2);
            this.Controls.Add(this.btn_Cancella);
            this.Controls.Add(this.btn_Incolla);
            this.Controls.Add(this.btn_Copia);
            this.Controls.Add(this.btn_Converti);
            this.Controls.Add(this.lbl_Out);
            this.Controls.Add(this.lbl_Insert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Convertitore Materiali";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox lbl_Insert;
        private System.Windows.Forms.RichTextBox lbl_Out;
        private System.Windows.Forms.Button btn_Converti;
        private System.Windows.Forms.Button btn_Copia;
        private System.Windows.Forms.Button btn_Incolla;
        private System.Windows.Forms.Button btn_Cancella;
        private System.Windows.Forms.Button btn_Cancella2;
        private System.Windows.Forms.Button btn_Incolla2;
        private System.Windows.Forms.Button btn_Copia2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SelezioneMateriali;
    }
}

