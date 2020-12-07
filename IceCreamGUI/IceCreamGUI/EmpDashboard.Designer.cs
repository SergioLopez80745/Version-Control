namespace IceCreamGUI
{
    partial class EmpDashboard
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
            this.btnPayCash = new System.Windows.Forms.Button();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.radTwentyPercent = new System.Windows.Forms.RadioButton();
            this.radFifteenPercent = new System.Windows.Forms.RadioButton();
            this.radTenPercent = new System.Windows.Forms.RadioButton();
            this.radFivePercent = new System.Windows.Forms.RadioButton();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.btnPayDebit = new System.Windows.Forms.Button();
            this.btnPayCredit = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.lblTotalDue = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpMenuFlavors = new System.Windows.Forms.GroupBox();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkCereal = new System.Windows.Forms.CheckBox();
            this.chkOreos = new System.Windows.Forms.CheckBox();
            this.chkChocolateChip = new System.Windows.Forms.CheckBox();
            this.chkCookie = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radChocolate = new System.Windows.Forms.RadioButton();
            this.radVanilla = new System.Windows.Forms.RadioButton();
            this.radStrawberry = new System.Windows.Forms.RadioButton();
            this.radSherbert = new System.Windows.Forms.RadioButton();
            this.radCoffee = new System.Windows.Forms.RadioButton();
            this.radBanana = new System.Windows.Forms.RadioButton();
            this.grpOrder.SuspendLayout();
            this.grpMenuFlavors.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPayCash
            // 
            this.btnPayCash.Location = new System.Drawing.Point(25, 532);
            this.btnPayCash.Name = "btnPayCash";
            this.btnPayCash.Size = new System.Drawing.Size(141, 59);
            this.btnPayCash.TabIndex = 1;
            this.btnPayCash.Text = "Pay Cash";
            this.btnPayCash.UseVisualStyleBackColor = true;
            this.btnPayCash.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.radTwentyPercent);
            this.grpOrder.Controls.Add(this.radFifteenPercent);
            this.grpOrder.Controls.Add(this.radTenPercent);
            this.grpOrder.Controls.Add(this.radFivePercent);
            this.grpOrder.Controls.Add(this.txtTip);
            this.grpOrder.Controls.Add(this.label1);
            this.grpOrder.Controls.Add(this.txtTotalDue);
            this.grpOrder.Controls.Add(this.txtTax);
            this.grpOrder.Controls.Add(this.txtSubTotal);
            this.grpOrder.Controls.Add(this.btnPayDebit);
            this.grpOrder.Controls.Add(this.btnPayCredit);
            this.grpOrder.Controls.Add(this.lstCart);
            this.grpOrder.Controls.Add(this.lblTotalDue);
            this.grpOrder.Controls.Add(this.lblTax);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.btnPayCash);
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(515, 662);
            this.grpOrder.TabIndex = 3;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // radTwentyPercent
            // 
            this.radTwentyPercent.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTwentyPercent.Location = new System.Drawing.Point(310, 491);
            this.radTwentyPercent.Name = "radTwentyPercent";
            this.radTwentyPercent.Size = new System.Drawing.Size(88, 34);
            this.radTwentyPercent.TabIndex = 34;
            this.radTwentyPercent.TabStop = true;
            this.radTwentyPercent.Text = "20% Tip";
            this.radTwentyPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTwentyPercent.UseVisualStyleBackColor = true;
            // 
            // radFifteenPercent
            // 
            this.radFifteenPercent.Appearance = System.Windows.Forms.Appearance.Button;
            this.radFifteenPercent.Location = new System.Drawing.Point(181, 492);
            this.radFifteenPercent.Name = "radFifteenPercent";
            this.radFifteenPercent.Size = new System.Drawing.Size(88, 34);
            this.radFifteenPercent.TabIndex = 33;
            this.radFifteenPercent.TabStop = true;
            this.radFifteenPercent.Text = "15% Tip";
            this.radFifteenPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radFifteenPercent.UseVisualStyleBackColor = true;
            // 
            // radTenPercent
            // 
            this.radTenPercent.Appearance = System.Windows.Forms.Appearance.Button;
            this.radTenPercent.Location = new System.Drawing.Point(310, 439);
            this.radTenPercent.Name = "radTenPercent";
            this.radTenPercent.Size = new System.Drawing.Size(88, 34);
            this.radTenPercent.TabIndex = 32;
            this.radTenPercent.TabStop = true;
            this.radTenPercent.Text = "10% Tip";
            this.radTenPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radTenPercent.UseVisualStyleBackColor = true;
            // 
            // radFivePercent
            // 
            this.radFivePercent.Appearance = System.Windows.Forms.Appearance.Button;
            this.radFivePercent.Location = new System.Drawing.Point(181, 439);
            this.radFivePercent.Name = "radFivePercent";
            this.radFivePercent.Size = new System.Drawing.Size(88, 34);
            this.radFivePercent.TabIndex = 13;
            this.radFivePercent.TabStop = true;
            this.radFivePercent.Text = "5% Tip";
            this.radFivePercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radFivePercent.UseVisualStyleBackColor = true;
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(68, 505);
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.Size = new System.Drawing.Size(80, 20);
            this.txtTip.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Tax: ";
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Location = new System.Drawing.Point(68, 479);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.ReadOnly = true;
            this.txtTotalDue.Size = new System.Drawing.Size(80, 20);
            this.txtTotalDue.TabIndex = 29;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(68, 453);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(80, 20);
            this.txtTax.TabIndex = 28;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(68, 427);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(80, 20);
            this.txtSubTotal.TabIndex = 27;
            // 
            // btnPayDebit
            // 
            this.btnPayDebit.Location = new System.Drawing.Point(349, 532);
            this.btnPayDebit.Name = "btnPayDebit";
            this.btnPayDebit.Size = new System.Drawing.Size(141, 59);
            this.btnPayDebit.TabIndex = 25;
            this.btnPayDebit.Text = "Pay Debit";
            this.btnPayDebit.UseVisualStyleBackColor = true;
            this.btnPayDebit.Click += new System.EventHandler(this.btnPayDebit_Click);
            // 
            // btnPayCredit
            // 
            this.btnPayCredit.Location = new System.Drawing.Point(181, 532);
            this.btnPayCredit.Name = "btnPayCredit";
            this.btnPayCredit.Size = new System.Drawing.Size(141, 59);
            this.btnPayCredit.TabIndex = 24;
            this.btnPayCredit.Text = "Pay Credit";
            this.btnPayCredit.UseVisualStyleBackColor = true;
            this.btnPayCredit.Click += new System.EventHandler(this.btnPayCredit_Click);
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(6, 69);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(503, 355);
            this.lstCart.TabIndex = 17;
            // 
            // lblTotalDue
            // 
            this.lblTotalDue.AutoSize = true;
            this.lblTotalDue.Location = new System.Drawing.Point(5, 482);
            this.lblTotalDue.Name = "lblTotalDue";
            this.lblTotalDue.Size = new System.Drawing.Size(57, 13);
            this.lblTotalDue.TabIndex = 12;
            this.lblTotalDue.Text = "Total Due:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(34, 460);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 13);
            this.lblTax.TabIndex = 11;
            this.lblTax.Text = "Tax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 430);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sub Total:";
            // 
            // grpMenuFlavors
            // 
            this.grpMenuFlavors.Controls.Add(this.radBanana);
            this.grpMenuFlavors.Controls.Add(this.radCoffee);
            this.grpMenuFlavors.Controls.Add(this.radSherbert);
            this.grpMenuFlavors.Controls.Add(this.radStrawberry);
            this.grpMenuFlavors.Controls.Add(this.radVanilla);
            this.grpMenuFlavors.Controls.Add(this.radChocolate);
            this.grpMenuFlavors.Location = new System.Drawing.Point(533, 139);
            this.grpMenuFlavors.Name = "grpMenuFlavors";
            this.grpMenuFlavors.Size = new System.Drawing.Size(442, 232);
            this.grpMenuFlavors.TabIndex = 4;
            this.grpMenuFlavors.TabStop = false;
            this.grpMenuFlavors.Text = "Menu Flavors";
            // 
            // grpToppings
            // 
            this.grpToppings.Controls.Add(this.chkNuts);
            this.grpToppings.Controls.Add(this.chkCereal);
            this.grpToppings.Controls.Add(this.chkOreos);
            this.grpToppings.Controls.Add(this.chkChocolateChip);
            this.grpToppings.Controls.Add(this.chkCookie);
            this.grpToppings.Controls.Add(this.chkSprinkles);
            this.grpToppings.Location = new System.Drawing.Point(539, 377);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(442, 232);
            this.grpToppings.TabIndex = 5;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkNuts
            // 
            this.chkNuts.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNuts.Location = new System.Drawing.Point(300, 96);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(131, 64);
            this.chkNuts.TabIndex = 19;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkCereal
            // 
            this.chkCereal.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCereal.Location = new System.Drawing.Point(153, 96);
            this.chkCereal.Name = "chkCereal";
            this.chkCereal.Size = new System.Drawing.Size(131, 64);
            this.chkCereal.TabIndex = 18;
            this.chkCereal.Text = "Cereal";
            this.chkCereal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCereal.UseVisualStyleBackColor = true;
            // 
            // chkOreos
            // 
            this.chkOreos.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkOreos.Location = new System.Drawing.Point(6, 96);
            this.chkOreos.Name = "chkOreos";
            this.chkOreos.Size = new System.Drawing.Size(131, 64);
            this.chkOreos.TabIndex = 17;
            this.chkOreos.Text = "Oreos";
            this.chkOreos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkOreos.UseVisualStyleBackColor = true;
            // 
            // chkChocolateChip
            // 
            this.chkChocolateChip.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChocolateChip.Location = new System.Drawing.Point(300, 26);
            this.chkChocolateChip.Name = "chkChocolateChip";
            this.chkChocolateChip.Size = new System.Drawing.Size(131, 64);
            this.chkChocolateChip.TabIndex = 16;
            this.chkChocolateChip.Text = "Chocolate Chip";
            this.chkChocolateChip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkChocolateChip.UseVisualStyleBackColor = true;
            // 
            // chkCookie
            // 
            this.chkCookie.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCookie.Location = new System.Drawing.Point(153, 26);
            this.chkCookie.Name = "chkCookie";
            this.chkCookie.Size = new System.Drawing.Size(131, 64);
            this.chkCookie.TabIndex = 15;
            this.chkCookie.Text = "Cookie";
            this.chkCookie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCookie.UseVisualStyleBackColor = true;
            // 
            // chkSprinkles
            // 
            this.chkSprinkles.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSprinkles.Location = new System.Drawing.Point(6, 26);
            this.chkSprinkles.Name = "chkSprinkles";
            this.chkSprinkles.Size = new System.Drawing.Size(131, 64);
            this.chkSprinkles.TabIndex = 14;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(533, 12);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(442, 121);
            this.grpSize.TabIndex = 6;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radMedium
            // 
            this.radMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMedium.Location = new System.Drawing.Point(153, 35);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(131, 64);
            this.radMedium.TabIndex = 12;
            this.radMedium.TabStop = true;
            this.radMedium.Text = "Medium";
            this.radMedium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radMedium.UseVisualStyleBackColor = true;
            // 
            // radLarge
            // 
            this.radLarge.Appearance = System.Windows.Forms.Appearance.Button;
            this.radLarge.Location = new System.Drawing.Point(300, 35);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(131, 64);
            this.radLarge.TabIndex = 11;
            this.radLarge.TabStop = true;
            this.radLarge.Text = "Large";
            this.radLarge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radLarge.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.Appearance = System.Windows.Forms.Appearance.Button;
            this.radSmall.Location = new System.Drawing.Point(6, 35);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(131, 64);
            this.radSmall.TabIndex = 9;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(834, 615);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 59);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Ice Cream";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(687, 615);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 59);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(540, 615);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(141, 59);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radChocolate
            // 
            this.radChocolate.Appearance = System.Windows.Forms.Appearance.Button;
            this.radChocolate.Location = new System.Drawing.Point(17, 42);
            this.radChocolate.Name = "radChocolate";
            this.radChocolate.Size = new System.Drawing.Size(131, 64);
            this.radChocolate.TabIndex = 10;
            this.radChocolate.TabStop = true;
            this.radChocolate.Text = "Chocolate";
            this.radChocolate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radChocolate.UseVisualStyleBackColor = true;
            // 
            // radVanilla
            // 
            this.radVanilla.Appearance = System.Windows.Forms.Appearance.Button;
            this.radVanilla.Location = new System.Drawing.Point(154, 42);
            this.radVanilla.Name = "radVanilla";
            this.radVanilla.Size = new System.Drawing.Size(131, 64);
            this.radVanilla.TabIndex = 11;
            this.radVanilla.TabStop = true;
            this.radVanilla.Text = "Vanilla";
            this.radVanilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radVanilla.UseVisualStyleBackColor = true;
            // 
            // radStrawberry
            // 
            this.radStrawberry.Appearance = System.Windows.Forms.Appearance.Button;
            this.radStrawberry.Location = new System.Drawing.Point(301, 42);
            this.radStrawberry.Name = "radStrawberry";
            this.radStrawberry.Size = new System.Drawing.Size(131, 64);
            this.radStrawberry.TabIndex = 12;
            this.radStrawberry.TabStop = true;
            this.radStrawberry.Text = "Strawberry";
            this.radStrawberry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radStrawberry.UseVisualStyleBackColor = true;
            // 
            // radSherbert
            // 
            this.radSherbert.Appearance = System.Windows.Forms.Appearance.Button;
            this.radSherbert.Location = new System.Drawing.Point(17, 138);
            this.radSherbert.Name = "radSherbert";
            this.radSherbert.Size = new System.Drawing.Size(131, 64);
            this.radSherbert.TabIndex = 13;
            this.radSherbert.TabStop = true;
            this.radSherbert.Text = "Sherbert";
            this.radSherbert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radSherbert.UseVisualStyleBackColor = true;
            // 
            // radCoffee
            // 
            this.radCoffee.Appearance = System.Windows.Forms.Appearance.Button;
            this.radCoffee.Location = new System.Drawing.Point(159, 138);
            this.radCoffee.Name = "radCoffee";
            this.radCoffee.Size = new System.Drawing.Size(131, 64);
            this.radCoffee.TabIndex = 14;
            this.radCoffee.TabStop = true;
            this.radCoffee.Text = "Coffee";
            this.radCoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radCoffee.UseVisualStyleBackColor = true;
            // 
            // radBanana
            // 
            this.radBanana.Appearance = System.Windows.Forms.Appearance.Button;
            this.radBanana.Location = new System.Drawing.Point(296, 138);
            this.radBanana.Name = "radBanana";
            this.radBanana.Size = new System.Drawing.Size(131, 64);
            this.radBanana.TabIndex = 15;
            this.radBanana.TabStop = true;
            this.radBanana.Text = "Banana";
            this.radBanana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBanana.UseVisualStyleBackColor = true;
            // 
            // EmpDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(987, 683);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpMenuFlavors);
            this.Controls.Add(this.grpOrder);
            this.Name = "EmpDashboard";
            this.Text = "Empolyee Dashboard";
            this.Load += new System.EventHandler(this.EmpDashboard_Load);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.grpMenuFlavors.ResumeLayout(false);
            this.grpToppings.ResumeLayout(false);
            this.grpSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPayCash;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Label lblTotalDue;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMenuFlavors;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkCereal;
        private System.Windows.Forms.CheckBox chkOreos;
        private System.Windows.Forms.CheckBox chkChocolateChip;
        private System.Windows.Forms.CheckBox chkCookie;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPayDebit;
        private System.Windows.Forms.Button btnPayCredit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radTwentyPercent;
        private System.Windows.Forms.RadioButton radFifteenPercent;
        private System.Windows.Forms.RadioButton radTenPercent;
        private System.Windows.Forms.RadioButton radFivePercent;
        private System.Windows.Forms.RadioButton radBanana;
        private System.Windows.Forms.RadioButton radCoffee;
        private System.Windows.Forms.RadioButton radSherbert;
        private System.Windows.Forms.RadioButton radStrawberry;
        private System.Windows.Forms.RadioButton radVanilla;
        private System.Windows.Forms.RadioButton radChocolate;
    }
}