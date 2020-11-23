namespace Test
{
    partial class OrderTab
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radMedium = new System.Windows.Forms.RadioButton();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkCereal = new System.Windows.Forms.CheckBox();
            this.chkOreos = new System.Windows.Forms.CheckBox();
            this.chkChocolateChip = new System.Windows.Forms.CheckBox();
            this.chkCookie = new System.Windows.Forms.CheckBox();
            this.chkSprinkles = new System.Windows.Forms.CheckBox();
            this.grpMenuFlavors = new System.Windows.Forms.GroupBox();
            this.chkSherbert = new System.Windows.Forms.CheckBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkBanana = new System.Windows.Forms.CheckBox();
            this.chkStrawberry = new System.Windows.Forms.CheckBox();
            this.chkVanilla = new System.Windows.Forms.CheckBox();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblFlavor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblsubTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpMenuFlavors.SuspendLayout();
            this.grpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(687, 615);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(141, 59);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(834, 615);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(141, 59);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Ice Cream";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radMedium);
            this.grpSize.Controls.Add(this.radLarge);
            this.grpSize.Controls.Add(this.radSmall);
            this.grpSize.Location = new System.Drawing.Point(533, 12);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(442, 121);
            this.grpSize.TabIndex = 1;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // radMedium
            // 
            this.radMedium.Appearance = System.Windows.Forms.Appearance.Button;
            this.radMedium.Location = new System.Drawing.Point(153, 35);
            this.radMedium.Name = "radMedium";
            this.radMedium.Size = new System.Drawing.Size(131, 64);
            this.radMedium.TabIndex = 1;
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
            this.radLarge.TabIndex = 2;
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
            this.radSmall.TabIndex = 0;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "Small";
            this.radSmall.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radSmall.UseVisualStyleBackColor = true;
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
            this.grpToppings.TabIndex = 3;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkNuts
            // 
            this.chkNuts.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkNuts.Location = new System.Drawing.Point(300, 96);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(131, 64);
            this.chkNuts.TabIndex = 5;
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
            this.chkCereal.TabIndex = 4;
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
            this.chkOreos.TabIndex = 3;
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
            this.chkChocolateChip.TabIndex = 2;
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
            this.chkCookie.TabIndex = 1;
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
            this.chkSprinkles.TabIndex = 0;
            this.chkSprinkles.Text = "Sprinkles";
            this.chkSprinkles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSprinkles.UseVisualStyleBackColor = true;
            // 
            // grpMenuFlavors
            // 
            this.grpMenuFlavors.Controls.Add(this.chkSherbert);
            this.grpMenuFlavors.Controls.Add(this.chkCoffee);
            this.grpMenuFlavors.Controls.Add(this.chkBanana);
            this.grpMenuFlavors.Controls.Add(this.chkStrawberry);
            this.grpMenuFlavors.Controls.Add(this.chkVanilla);
            this.grpMenuFlavors.Controls.Add(this.chkChocolate);
            this.grpMenuFlavors.Location = new System.Drawing.Point(533, 139);
            this.grpMenuFlavors.Name = "grpMenuFlavors";
            this.grpMenuFlavors.Size = new System.Drawing.Size(442, 232);
            this.grpMenuFlavors.TabIndex = 2;
            this.grpMenuFlavors.TabStop = false;
            this.grpMenuFlavors.Text = "Menu Flavors";
            // 
            // chkSherbert
            // 
            this.chkSherbert.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkSherbert.Location = new System.Drawing.Point(300, 97);
            this.chkSherbert.Name = "chkSherbert";
            this.chkSherbert.Size = new System.Drawing.Size(131, 64);
            this.chkSherbert.TabIndex = 5;
            this.chkSherbert.Text = "Sherbert";
            this.chkSherbert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkSherbert.UseVisualStyleBackColor = true;
            // 
            // chkCoffee
            // 
            this.chkCoffee.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkCoffee.Location = new System.Drawing.Point(153, 97);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(131, 64);
            this.chkCoffee.TabIndex = 4;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkBanana
            // 
            this.chkBanana.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkBanana.Location = new System.Drawing.Point(6, 97);
            this.chkBanana.Name = "chkBanana";
            this.chkBanana.Size = new System.Drawing.Size(131, 64);
            this.chkBanana.TabIndex = 3;
            this.chkBanana.Text = "Banana";
            this.chkBanana.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBanana.UseVisualStyleBackColor = true;
            // 
            // chkStrawberry
            // 
            this.chkStrawberry.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkStrawberry.Location = new System.Drawing.Point(300, 27);
            this.chkStrawberry.Name = "chkStrawberry";
            this.chkStrawberry.Size = new System.Drawing.Size(131, 64);
            this.chkStrawberry.TabIndex = 2;
            this.chkStrawberry.Text = "Strawberry";
            this.chkStrawberry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkStrawberry.UseVisualStyleBackColor = true;
            // 
            // chkVanilla
            // 
            this.chkVanilla.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkVanilla.Location = new System.Drawing.Point(153, 27);
            this.chkVanilla.Name = "chkVanilla";
            this.chkVanilla.Size = new System.Drawing.Size(131, 64);
            this.chkVanilla.TabIndex = 1;
            this.chkVanilla.Text = "Vanilla";
            this.chkVanilla.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkVanilla.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            this.chkChocolate.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkChocolate.Location = new System.Drawing.Point(6, 27);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(131, 64);
            this.chkChocolate.TabIndex = 0;
            this.chkChocolate.Text = "Chocolate";
            this.chkChocolate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkChocolate.UseVisualStyleBackColor = true;
            // 
            // grpOrder
            // 
            this.grpOrder.Controls.Add(this.lblSize);
            this.grpOrder.Controls.Add(this.label9);
            this.grpOrder.Controls.Add(this.lblToppings);
            this.grpOrder.Controls.Add(this.lblFlavor);
            this.grpOrder.Controls.Add(this.label4);
            this.grpOrder.Controls.Add(this.label5);
            this.grpOrder.Controls.Add(this.lblTotal);
            this.grpOrder.Controls.Add(this.lblTax);
            this.grpOrder.Controls.Add(this.label8);
            this.grpOrder.Controls.Add(this.label7);
            this.grpOrder.Controls.Add(this.lblsubTotal);
            this.grpOrder.Controls.Add(this.label2);
            this.grpOrder.Controls.Add(this.lstCart);
            this.grpOrder.Controls.Add(this.btnCancel);
            this.grpOrder.Controls.Add(this.btnPay);
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(515, 662);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            this.grpOrder.Text = "Order";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(299, 428);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(35, 13);
            this.lblSize.TabIndex = 35;
            this.lblSize.Text = "label6";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 428);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Size:";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Location = new System.Drawing.Point(299, 472);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(35, 13);
            this.lblToppings.TabIndex = 33;
            this.lblToppings.Text = "label1";
            // 
            // lblFlavor
            // 
            this.lblFlavor.AutoSize = true;
            this.lblFlavor.Location = new System.Drawing.Point(299, 450);
            this.lblFlavor.Name = "lblFlavor";
            this.lblFlavor.Size = new System.Drawing.Size(35, 13);
            this.lblFlavor.TabIndex = 32;
            this.lblFlavor.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Toppings:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 450);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Flavor:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(69, 472);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(41, 13);
            this.lblTotal.TabIndex = 29;
            this.lblTotal.Text = "label11";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(69, 450);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(41, 13);
            this.lblTax.TabIndex = 28;
            this.lblTax.Text = "label10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Total Due:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tax:";
            // 
            // lblsubTotal
            // 
            this.lblsubTotal.AutoSize = true;
            this.lblsubTotal.Location = new System.Drawing.Point(69, 428);
            this.lblsubTotal.Name = "lblsubTotal";
            this.lblsubTotal.Size = new System.Drawing.Size(35, 13);
            this.lblsubTotal.TabIndex = 25;
            this.lblsubTotal.Text = "label5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sub Total:";
            // 
            // lstCart
            // 
            this.lstCart.FormattingEnabled = true;
            this.lstCart.Location = new System.Drawing.Point(6, 69);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(503, 329);
            this.lstCart.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(230, 620);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 36);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel Order";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(368, 597);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(141, 59);
            this.btnPay.TabIndex = 11;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // OrderTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 697);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpMenuFlavors);
            this.Controls.Add(this.grpOrder);
            this.Name = "OrderTab";
            this.Text = "OrderTab";
            this.grpSize.ResumeLayout(false);
            this.grpToppings.ResumeLayout(false);
            this.grpMenuFlavors.ResumeLayout(false);
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radMedium;
        private System.Windows.Forms.RadioButton radLarge;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkNuts;
        private System.Windows.Forms.CheckBox chkCereal;
        private System.Windows.Forms.CheckBox chkOreos;
        private System.Windows.Forms.CheckBox chkChocolateChip;
        private System.Windows.Forms.CheckBox chkCookie;
        private System.Windows.Forms.CheckBox chkSprinkles;
        private System.Windows.Forms.GroupBox grpMenuFlavors;
        private System.Windows.Forms.CheckBox chkSherbert;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkBanana;
        private System.Windows.Forms.CheckBox chkStrawberry;
        private System.Windows.Forms.CheckBox chkVanilla;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblFlavor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblsubTotal;
        private System.Windows.Forms.Label label2;
    }
}