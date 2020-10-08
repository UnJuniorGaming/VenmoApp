namespace VenmoApp
{
	partial class VenmoForm
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
			this.labelVenmoUsers = new System.Windows.Forms.Label();
			this.VenmoUsers = new System.Windows.Forms.Label();
			this.payerComboBox = new System.Windows.Forms.ComboBox();
			this.payeeComboBox = new System.Windows.Forms.ComboBox();
			this.payFromAccountListBox = new System.Windows.Forms.ListBox();
			this.paymentAmountUpDown = new System.Windows.Forms.NumericUpDown();
			this.payButton = new System.Windows.Forms.Button();
			this.payerLabel = new System.Windows.Forms.Label();
			this.payeeLabel = new System.Windows.Forms.Label();
			this.payFromAccountLabel = new System.Windows.Forms.Label();
			this.paymentLabel = new System.Windows.Forms.Label();
			this.payToAccountListBox = new System.Windows.Forms.ListBox();
			this.payToAccountLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.paymentAmountUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// labelVenmoUsers
			// 
			this.labelVenmoUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelVenmoUsers.Location = new System.Drawing.Point(12, 42);
			this.labelVenmoUsers.Name = "labelVenmoUsers";
			this.labelVenmoUsers.Size = new System.Drawing.Size(224, 399);
			this.labelVenmoUsers.TabIndex = 0;
			// 
			// VenmoUsers
			// 
			this.VenmoUsers.AutoSize = true;
			this.VenmoUsers.Location = new System.Drawing.Point(12, 20);
			this.VenmoUsers.Name = "VenmoUsers";
			this.VenmoUsers.Size = new System.Drawing.Size(73, 13);
			this.VenmoUsers.TabIndex = 1;
			this.VenmoUsers.Text = "Venmo Users:";
			this.VenmoUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// payerComboBox
			// 
			this.payerComboBox.FormattingEnabled = true;
			this.payerComboBox.Items.AddRange(new object[] {
            "Junior",
            "Pain",
            "Crusher",
            "Rusty",
            "Adam",
            "Seggsy"});
			this.payerComboBox.Location = new System.Drawing.Point(260, 52);
			this.payerComboBox.Name = "payerComboBox";
			this.payerComboBox.Size = new System.Drawing.Size(121, 21);
			this.payerComboBox.TabIndex = 2;
			// 
			// payeeComboBox
			// 
			this.payeeComboBox.FormattingEnabled = true;
			this.payeeComboBox.Items.AddRange(new object[] {
            "Junior",
            "Pain",
            "Crusher",
            "Rusty",
            "Adam",
            "Seggsy"});
			this.payeeComboBox.Location = new System.Drawing.Point(405, 52);
			this.payeeComboBox.Name = "payeeComboBox";
			this.payeeComboBox.Size = new System.Drawing.Size(121, 21);
			this.payeeComboBox.TabIndex = 3;
			// 
			// payFromAccountListBox
			// 
			this.payFromAccountListBox.FormattingEnabled = true;
			this.payFromAccountListBox.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account"});
			this.payFromAccountListBox.Location = new System.Drawing.Point(260, 126);
			this.payFromAccountListBox.Name = "payFromAccountListBox";
			this.payFromAccountListBox.Size = new System.Drawing.Size(120, 43);
			this.payFromAccountListBox.TabIndex = 4;
			// 
			// paymentAmountUpDown
			// 
			this.paymentAmountUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.paymentAmountUpDown.Location = new System.Drawing.Point(260, 217);
			this.paymentAmountUpDown.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.paymentAmountUpDown.Name = "paymentAmountUpDown";
			this.paymentAmountUpDown.ReadOnly = true;
			this.paymentAmountUpDown.Size = new System.Drawing.Size(120, 20);
			this.paymentAmountUpDown.TabIndex = 5;
			this.paymentAmountUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// payButton
			// 
			this.payButton.Location = new System.Drawing.Point(405, 197);
			this.payButton.Name = "payButton";
			this.payButton.Size = new System.Drawing.Size(120, 40);
			this.payButton.TabIndex = 6;
			this.payButton.Text = "Pay";
			this.payButton.UseVisualStyleBackColor = true;
			this.payButton.Click += new System.EventHandler(this.payButton_Click);
			// 
			// payerLabel
			// 
			this.payerLabel.AutoSize = true;
			this.payerLabel.Location = new System.Drawing.Point(257, 36);
			this.payerLabel.Name = "payerLabel";
			this.payerLabel.Size = new System.Drawing.Size(34, 13);
			this.payerLabel.TabIndex = 7;
			this.payerLabel.Text = "Payer";
			// 
			// payeeLabel
			// 
			this.payeeLabel.AutoSize = true;
			this.payeeLabel.Location = new System.Drawing.Point(402, 36);
			this.payeeLabel.Name = "payeeLabel";
			this.payeeLabel.Size = new System.Drawing.Size(37, 13);
			this.payeeLabel.TabIndex = 8;
			this.payeeLabel.Text = "Payee";
			// 
			// payFromAccountLabel
			// 
			this.payFromAccountLabel.AutoSize = true;
			this.payFromAccountLabel.Location = new System.Drawing.Point(257, 110);
			this.payFromAccountLabel.Name = "payFromAccountLabel";
			this.payFromAccountLabel.Size = new System.Drawing.Size(94, 13);
			this.payFromAccountLabel.TabIndex = 9;
			this.payFromAccountLabel.Text = "Pay From Account";
			// 
			// paymentLabel
			// 
			this.paymentLabel.AutoSize = true;
			this.paymentLabel.Location = new System.Drawing.Point(257, 201);
			this.paymentLabel.Name = "paymentLabel";
			this.paymentLabel.Size = new System.Drawing.Size(87, 13);
			this.paymentLabel.TabIndex = 10;
			this.paymentLabel.Text = "Payment Amount";
			// 
			// payToAccountListBox
			// 
			this.payToAccountListBox.FormattingEnabled = true;
			this.payToAccountListBox.Items.AddRange(new object[] {
            "Checking Account",
            "Savings Account"});
			this.payToAccountListBox.Location = new System.Drawing.Point(405, 126);
			this.payToAccountListBox.Name = "payToAccountListBox";
			this.payToAccountListBox.Size = new System.Drawing.Size(120, 43);
			this.payToAccountListBox.TabIndex = 11;
			// 
			// payToAccountLabel
			// 
			this.payToAccountLabel.AutoSize = true;
			this.payToAccountLabel.Location = new System.Drawing.Point(402, 110);
			this.payToAccountLabel.Name = "payToAccountLabel";
			this.payToAccountLabel.Size = new System.Drawing.Size(84, 13);
			this.payToAccountLabel.TabIndex = 12;
			this.payToAccountLabel.Text = "Pay To Account";
			// 
			// VenmoForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 450);
			this.Controls.Add(this.payToAccountLabel);
			this.Controls.Add(this.payToAccountListBox);
			this.Controls.Add(this.paymentLabel);
			this.Controls.Add(this.payFromAccountLabel);
			this.Controls.Add(this.payeeLabel);
			this.Controls.Add(this.payerLabel);
			this.Controls.Add(this.payButton);
			this.Controls.Add(this.paymentAmountUpDown);
			this.Controls.Add(this.payFromAccountListBox);
			this.Controls.Add(this.payeeComboBox);
			this.Controls.Add(this.payerComboBox);
			this.Controls.Add(this.VenmoUsers);
			this.Controls.Add(this.labelVenmoUsers);
			this.Name = "VenmoForm";
			this.Text = "Venmo";
			this.Load += new System.EventHandler(this.VenmoApp_Load);
			((System.ComponentModel.ISupportInitialize)(this.paymentAmountUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelVenmoUsers;
		private System.Windows.Forms.Label VenmoUsers;
		private System.Windows.Forms.ComboBox payerComboBox;
		private System.Windows.Forms.ComboBox payeeComboBox;
		private System.Windows.Forms.ListBox payFromAccountListBox;
		private System.Windows.Forms.NumericUpDown paymentAmountUpDown;
		private System.Windows.Forms.Button payButton;
		private System.Windows.Forms.Label payerLabel;
		private System.Windows.Forms.Label payeeLabel;
		private System.Windows.Forms.Label payFromAccountLabel;
		private System.Windows.Forms.Label paymentLabel;
		private System.Windows.Forms.ListBox payToAccountListBox;
		private System.Windows.Forms.Label payToAccountLabel;
	}
}

