namespace cashRegister
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pencilLabel = new System.Windows.Forms.Label();
            this.binderLabel = new System.Windows.Forms.Label();
            this.backpackLabel = new System.Windows.Forms.Label();
            this.inputPencil = new System.Windows.Forms.TextBox();
            this.inputBinders = new System.Windows.Forms.TextBox();
            this.inputBackpacks = new System.Windows.Forms.TextBox();
            this.totalsButton = new System.Windows.Forms.Button();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.changeLabel = new System.Windows.Forms.Label();
            this.receiptButton = new System.Windows.Forms.Button();
            this.outputSubTotal = new System.Windows.Forms.Label();
            this.outputTax = new System.Windows.Forms.Label();
            this.outputTotal = new System.Windows.Forms.Label();
            this.inputTendered = new System.Windows.Forms.TextBox();
            this.outputChange = new System.Windows.Forms.Label();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.decorationLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pencilLabel
            // 
            this.pencilLabel.AutoSize = true;
            this.pencilLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencilLabel.ForeColor = System.Drawing.Color.Maroon;
            this.pencilLabel.Location = new System.Drawing.Point(24, 135);
            this.pencilLabel.Name = "pencilLabel";
            this.pencilLabel.Size = new System.Drawing.Size(148, 19);
            this.pencilLabel.TabIndex = 1;
            this.pencilLabel.Text = "Number of Pencils";
            // 
            // binderLabel
            // 
            this.binderLabel.AutoSize = true;
            this.binderLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.binderLabel.ForeColor = System.Drawing.Color.Maroon;
            this.binderLabel.Location = new System.Drawing.Point(24, 164);
            this.binderLabel.Name = "binderLabel";
            this.binderLabel.Size = new System.Drawing.Size(152, 19);
            this.binderLabel.TabIndex = 2;
            this.binderLabel.Text = "Number of Binders";
            // 
            // backpackLabel
            // 
            this.backpackLabel.AutoSize = true;
            this.backpackLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backpackLabel.ForeColor = System.Drawing.Color.Maroon;
            this.backpackLabel.Location = new System.Drawing.Point(24, 198);
            this.backpackLabel.Name = "backpackLabel";
            this.backpackLabel.Size = new System.Drawing.Size(175, 19);
            this.backpackLabel.TabIndex = 3;
            this.backpackLabel.Text = "Number of Backpacks";
            // 
            // inputPencil
            // 
            this.inputPencil.Location = new System.Drawing.Point(229, 134);
            this.inputPencil.Name = "inputPencil";
            this.inputPencil.Size = new System.Drawing.Size(100, 20);
            this.inputPencil.TabIndex = 4;
            // 
            // inputBinders
            // 
            this.inputBinders.Location = new System.Drawing.Point(229, 165);
            this.inputBinders.Name = "inputBinders";
            this.inputBinders.Size = new System.Drawing.Size(100, 20);
            this.inputBinders.TabIndex = 5;
            // 
            // inputBackpacks
            // 
            this.inputBackpacks.Location = new System.Drawing.Point(229, 199);
            this.inputBackpacks.Name = "inputBackpacks";
            this.inputBackpacks.Size = new System.Drawing.Size(97, 20);
            this.inputBackpacks.TabIndex = 6;
            // 
            // totalsButton
            // 
            this.totalsButton.BackColor = System.Drawing.Color.Brown;
            this.totalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.totalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalsButton.Font = new System.Drawing.Font("Machine BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsButton.ForeColor = System.Drawing.Color.White;
            this.totalsButton.Location = new System.Drawing.Point(28, 244);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(298, 39);
            this.totalsButton.TabIndex = 7;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = false;
            this.totalsButton.Click += new System.EventHandler(this.TotalsButton_Click);
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.subtotalLabel.Location = new System.Drawing.Point(25, 302);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(80, 19);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.Color.Maroon;
            this.taxLabel.Location = new System.Drawing.Point(24, 333);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(102, 19);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax Amount";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.Color.Maroon;
            this.totalLabel.Location = new System.Drawing.Point(25, 372);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(47, 19);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.Color.Maroon;
            this.tenderedLabel.Location = new System.Drawing.Point(24, 440);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(147, 19);
            this.tenderedLabel.TabIndex = 11;
            this.tenderedLabel.Text = "Amount Tendered";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Brown;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Machine BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.White;
            this.changeButton.Location = new System.Drawing.Point(28, 482);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(297, 40);
            this.changeButton.TabIndex = 12;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.Color.Maroon;
            this.changeLabel.Location = new System.Drawing.Point(25, 545);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(67, 19);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "Change";
            // 
            // receiptButton
            // 
            this.receiptButton.BackColor = System.Drawing.Color.Brown;
            this.receiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.receiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receiptButton.Font = new System.Drawing.Font("Machine BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptButton.ForeColor = System.Drawing.Color.White;
            this.receiptButton.Location = new System.Drawing.Point(29, 584);
            this.receiptButton.Name = "receiptButton";
            this.receiptButton.Size = new System.Drawing.Size(300, 49);
            this.receiptButton.TabIndex = 14;
            this.receiptButton.Text = " Print Receipt";
            this.receiptButton.UseVisualStyleBackColor = false;
            this.receiptButton.Click += new System.EventHandler(this.ReceiptButton_Click);
            // 
            // outputSubTotal
            // 
            this.outputSubTotal.AutoSize = true;
            this.outputSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputSubTotal.Location = new System.Drawing.Point(232, 302);
            this.outputSubTotal.Name = "outputSubTotal";
            this.outputSubTotal.Size = new System.Drawing.Size(0, 16);
            this.outputSubTotal.TabIndex = 15;
            this.outputSubTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // outputTax
            // 
            this.outputTax.AutoSize = true;
            this.outputTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTax.Location = new System.Drawing.Point(240, 333);
            this.outputTax.Name = "outputTax";
            this.outputTax.Size = new System.Drawing.Size(0, 16);
            this.outputTax.TabIndex = 16;
            this.outputTax.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // outputTotal
            // 
            this.outputTotal.AutoSize = true;
            this.outputTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputTotal.Location = new System.Drawing.Point(232, 374);
            this.outputTotal.Name = "outputTotal";
            this.outputTotal.Size = new System.Drawing.Size(0, 16);
            this.outputTotal.TabIndex = 17;
            this.outputTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // inputTendered
            // 
            this.inputTendered.Location = new System.Drawing.Point(226, 439);
            this.inputTendered.Name = "inputTendered";
            this.inputTendered.Size = new System.Drawing.Size(100, 20);
            this.inputTendered.TabIndex = 18;
            // 
            // outputChange
            // 
            this.outputChange.AutoSize = true;
            this.outputChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputChange.Location = new System.Drawing.Point(232, 545);
            this.outputChange.Name = "outputChange";
            this.outputChange.Size = new System.Drawing.Size(0, 16);
            this.outputChange.TabIndex = 19;
            this.outputChange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiptOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Image = ((System.Drawing.Image)(resources.GetObject("receiptOutput.Image")));
            this.receiptOutput.Location = new System.Drawing.Point(414, 98);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(353, 463);
            this.receiptOutput.TabIndex = 20;
            this.receiptOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // newButton
            // 
            this.newButton.BackColor = System.Drawing.Color.Brown;
            this.newButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newButton.Font = new System.Drawing.Font("Machine BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newButton.ForeColor = System.Drawing.Color.White;
            this.newButton.Location = new System.Drawing.Point(412, 584);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(354, 48);
            this.newButton.TabIndex = 22;
            this.newButton.Text = "New Order";
            this.newButton.UseVisualStyleBackColor = false;
            this.newButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Brown;
            this.titleLabel.Font = new System.Drawing.Font("Machine BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(0, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(801, 67);
            this.titleLabel.TabIndex = 23;
            this.titleLabel.Text = "----------------- Funky\'s School Supply Shop -----------------";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.TitleLabel_Click);
            // 
            // decorationLabel
            // 
            this.decorationLabel.BackColor = System.Drawing.Color.Transparent;
            this.decorationLabel.Font = new System.Drawing.Font("Machine BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decorationLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.decorationLabel.Location = new System.Drawing.Point(367, 76);
            this.decorationLabel.Name = "decorationLabel";
            this.decorationLabel.Size = new System.Drawing.Size(10, 582);
            this.decorationLabel.TabIndex = 24;
            this.decorationLabel.Text = "IIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIII";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(793, 645);
            this.Controls.Add(this.decorationLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.outputChange);
            this.Controls.Add(this.inputTendered);
            this.Controls.Add(this.outputTotal);
            this.Controls.Add(this.outputTax);
            this.Controls.Add(this.outputSubTotal);
            this.Controls.Add(this.receiptButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.inputBackpacks);
            this.Controls.Add(this.inputBinders);
            this.Controls.Add(this.inputPencil);
            this.Controls.Add(this.backpackLabel);
            this.Controls.Add(this.binderLabel);
            this.Controls.Add(this.pencilLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "School Supply Store Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label pencilLabel;
        private System.Windows.Forms.Label binderLabel;
        private System.Windows.Forms.Label backpackLabel;
        private System.Windows.Forms.TextBox inputPencil;
        private System.Windows.Forms.TextBox inputBinders;
        private System.Windows.Forms.TextBox inputBackpacks;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button receiptButton;
        private System.Windows.Forms.Label outputSubTotal;
        private System.Windows.Forms.Label outputTax;
        private System.Windows.Forms.Label outputTotal;
        private System.Windows.Forms.TextBox inputTendered;
        private System.Windows.Forms.Label outputChange;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label decorationLabel;
    }
}

