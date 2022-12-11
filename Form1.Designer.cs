namespace PowerLab4
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
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radCash = new System.Windows.Forms.RadioButton();
            this.radCreditCard = new System.Windows.Forms.RadioButton();
            this.grpLocation = new System.Windows.Forms.GroupBox();
            this.chkBoxFlightInc = new System.Windows.Forms.CheckBox();
            this.radMexico = new System.Windows.Forms.RadioButton();
            this.radFlorida = new System.Windows.Forms.RadioButton();
            this.radCuba = new System.Windows.Forms.RadioButton();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxTripInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblDisplayInfo = new System.Windows.Forms.Label();
            this.grpBook.SuspendLayout();
            this.grpLocation.SuspendLayout();
            this.grpBoxTripInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.btnBook);
            this.grpBook.Controls.Add(this.btnReset);
            this.grpBook.Controls.Add(this.lblPrice);
            this.grpBook.Controls.Add(this.label2);
            this.grpBook.Controls.Add(this.radCash);
            this.grpBook.Controls.Add(this.radCreditCard);
            this.grpBook.Controls.Add(this.grpLocation);
            this.grpBook.Controls.Add(this.txtPeople);
            this.grpBook.Controls.Add(this.label1);
            this.grpBook.Location = new System.Drawing.Point(15, 18);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(210, 306);
            this.grpBook.TabIndex = 0;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(101, 267);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(69, 33);
            this.btnBook.TabIndex = 3;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 267);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(69, 33);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(62, 232);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(133, 27);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // radCash
            // 
            this.radCash.AutoSize = true;
            this.radCash.Location = new System.Drawing.Point(12, 210);
            this.radCash.Name = "radCash";
            this.radCash.Size = new System.Drawing.Size(58, 19);
            this.radCash.TabIndex = 1;
            this.radCash.TabStop = true;
            this.radCash.Text = "Cash";
            this.radCash.UseVisualStyleBackColor = true;
            // 
            // radCreditCard
            // 
            this.radCreditCard.AutoSize = true;
            this.radCreditCard.Location = new System.Drawing.Point(12, 185);
            this.radCreditCard.Name = "radCreditCard";
            this.radCreditCard.Size = new System.Drawing.Size(101, 19);
            this.radCreditCard.TabIndex = 0;
            this.radCreditCard.TabStop = true;
            this.radCreditCard.Text = "Credit Card";
            this.radCreditCard.UseVisualStyleBackColor = true;
            // 
            // grpLocation
            // 
            this.grpLocation.BackColor = System.Drawing.Color.Pink;
            this.grpLocation.Controls.Add(this.chkBoxFlightInc);
            this.grpLocation.Controls.Add(this.radMexico);
            this.grpLocation.Controls.Add(this.radFlorida);
            this.grpLocation.Controls.Add(this.radCuba);
            this.grpLocation.Location = new System.Drawing.Point(6, 47);
            this.grpLocation.Name = "grpLocation";
            this.grpLocation.Size = new System.Drawing.Size(198, 132);
            this.grpLocation.TabIndex = 1;
            this.grpLocation.TabStop = false;
            this.grpLocation.Text = "Select Location";
            // 
            // chkBoxFlightInc
            // 
            this.chkBoxFlightInc.AutoSize = true;
            this.chkBoxFlightInc.Enabled = false;
            this.chkBoxFlightInc.Location = new System.Drawing.Point(6, 98);
            this.chkBoxFlightInc.Name = "chkBoxFlightInc";
            this.chkBoxFlightInc.Size = new System.Drawing.Size(122, 19);
            this.chkBoxFlightInc.TabIndex = 3;
            this.chkBoxFlightInc.Text = "Flight Included";
            this.chkBoxFlightInc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chkBoxFlightInc.UseVisualStyleBackColor = true;
            // 
            // radMexico
            // 
            this.radMexico.AutoSize = true;
            this.radMexico.Location = new System.Drawing.Point(6, 72);
            this.radMexico.Name = "radMexico";
            this.radMexico.Size = new System.Drawing.Size(71, 19);
            this.radMexico.TabIndex = 2;
            this.radMexico.TabStop = true;
            this.radMexico.Text = "Mexico";
            this.radMexico.UseVisualStyleBackColor = true;
            // 
            // radFlorida
            // 
            this.radFlorida.AutoSize = true;
            this.radFlorida.Location = new System.Drawing.Point(6, 47);
            this.radFlorida.Name = "radFlorida";
            this.radFlorida.Size = new System.Drawing.Size(71, 19);
            this.radFlorida.TabIndex = 1;
            this.radFlorida.TabStop = true;
            this.radFlorida.Text = "Florida";
            this.radFlorida.UseVisualStyleBackColor = true;
            // 
            // radCuba
            // 
            this.radCuba.AutoSize = true;
            this.radCuba.Location = new System.Drawing.Point(6, 22);
            this.radCuba.Name = "radCuba";
            this.radCuba.Size = new System.Drawing.Size(59, 19);
            this.radCuba.TabIndex = 0;
            this.radCuba.TabStop = true;
            this.radCuba.Text = "Cuba";
            this.radCuba.UseVisualStyleBackColor = true;
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(65, 18);
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(130, 23);
            this.txtPeople.TabIndex = 0;
            this.txtPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "People:";
            // 
            // grpBoxTripInfo
            // 
            this.grpBoxTripInfo.Controls.Add(this.btnConfirm);
            this.grpBoxTripInfo.Controls.Add(this.lblDisplayInfo);
            this.grpBoxTripInfo.Location = new System.Drawing.Point(235, 18);
            this.grpBoxTripInfo.Name = "grpBoxTripInfo";
            this.grpBoxTripInfo.Size = new System.Drawing.Size(238, 306);
            this.grpBoxTripInfo.TabIndex = 1;
            this.grpBoxTripInfo.TabStop = false;
            this.grpBoxTripInfo.Text = "Trip Information";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(81, 267);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(69, 33);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "&Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblDisplayInfo
            // 
            this.lblDisplayInfo.BackColor = System.Drawing.Color.HotPink;
            this.lblDisplayInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDisplayInfo.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDisplayInfo.Location = new System.Drawing.Point(7, 22);
            this.lblDisplayInfo.Name = "lblDisplayInfo";
            this.lblDisplayInfo.Size = new System.Drawing.Size(225, 237);
            this.lblDisplayInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(494, 336);
            this.Controls.Add(this.grpBoxTripInfo);
            this.Controls.Add(this.grpBook);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking by: Tony Power";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpLocation.ResumeLayout(false);
            this.grpLocation.PerformLayout();
            this.grpBoxTripInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grpBook;
        private Label label1;
        private TextBox txtPeople;
        private GroupBox grpLocation;
        private CheckBox chkBoxFlightInc;
        private RadioButton radMexico;
        private RadioButton radFlorida;
        private RadioButton radCuba;
        private Label lblPrice;
        private Label label2;
        private RadioButton radCash;
        private RadioButton radCreditCard;
        private Button btnBook;
        private Button btnReset;
        private GroupBox grpBoxTripInfo;
        private Button btnConfirm;
        private Label lblDisplayInfo;
    }
}