
namespace GasStationOnly
{
    partial class MainView
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
            this.gassStationGrbx = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TimeTxtb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalPaymentTxtb = new System.Windows.Forms.TextBox();
            this.payBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sumTxtb = new System.Windows.Forms.TextBox();
            this.amountTxtb = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sumRbtn = new System.Windows.Forms.RadioButton();
            this.amountRbtn = new System.Windows.Forms.RadioButton();
            this.priceTxtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gasolineComboBox = new System.Windows.Forms.ComboBox();
            this.AllPaymentsListbox = new System.Windows.Forms.ListBox();
            this.loadPaymentsBtn = new System.Windows.Forms.Button();
            this.gassStationGrbx.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gassStationGrbx
            // 
            this.gassStationGrbx.Controls.Add(this.groupBox3);
            this.gassStationGrbx.Controls.Add(this.payBtn);
            this.gassStationGrbx.Controls.Add(this.label4);
            this.gassStationGrbx.Controls.Add(this.label3);
            this.gassStationGrbx.Controls.Add(this.sumTxtb);
            this.gassStationGrbx.Controls.Add(this.amountTxtb);
            this.gassStationGrbx.Controls.Add(this.groupBox2);
            this.gassStationGrbx.Controls.Add(this.priceTxtb);
            this.gassStationGrbx.Controls.Add(this.label2);
            this.gassStationGrbx.Controls.Add(this.label1);
            this.gassStationGrbx.Controls.Add(this.gasolineComboBox);
            this.gassStationGrbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gassStationGrbx.Location = new System.Drawing.Point(26, 25);
            this.gassStationGrbx.Name = "gassStationGrbx";
            this.gassStationGrbx.Size = new System.Drawing.Size(312, 402);
            this.gassStationGrbx.TabIndex = 0;
            this.gassStationGrbx.TabStop = false;
            this.gassStationGrbx.Text = "Gass Station";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TimeTxtb);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.totalPaymentTxtb);
            this.groupBox3.Location = new System.Drawing.Point(6, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 138);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total Payment";
            // 
            // TimeTxtb
            // 
            this.TimeTxtb.Location = new System.Drawing.Point(20, 93);
            this.TimeTxtb.Name = "TimeTxtb";
            this.TimeTxtb.Size = new System.Drawing.Size(100, 26);
            this.TimeTxtb.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Payment Time";
            // 
            // totalPaymentTxtb
            // 
            this.totalPaymentTxtb.Location = new System.Drawing.Point(25, 19);
            this.totalPaymentTxtb.Name = "totalPaymentTxtb";
            this.totalPaymentTxtb.Size = new System.Drawing.Size(100, 26);
            this.totalPaymentTxtb.TabIndex = 10;
            this.totalPaymentTxtb.Text = "0";
            // 
            // payBtn
            // 
            this.payBtn.AutoSize = true;
            this.payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payBtn.Location = new System.Drawing.Point(188, 272);
            this.payBtn.Name = "payBtn";
            this.payBtn.Size = new System.Drawing.Size(100, 35);
            this.payBtn.TabIndex = 9;
            this.payBtn.Text = "Pay";
            this.payBtn.UseVisualStyleBackColor = true;
            this.payBtn.Click += new System.EventHandler(this.payBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "AZN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Litr";
            // 
            // sumTxtb
            // 
            this.sumTxtb.Location = new System.Drawing.Point(150, 191);
            this.sumTxtb.Name = "sumTxtb";
            this.sumTxtb.Size = new System.Drawing.Size(100, 26);
            this.sumTxtb.TabIndex = 6;
            this.sumTxtb.TextChanged += new System.EventHandler(this.sumTxtb_TextChanged);
            // 
            // amountTxtb
            // 
            this.amountTxtb.Location = new System.Drawing.Point(150, 165);
            this.amountTxtb.Name = "amountTxtb";
            this.amountTxtb.Size = new System.Drawing.Size(100, 26);
            this.amountTxtb.TabIndex = 5;
            this.amountTxtb.TextChanged += new System.EventHandler(this.amountTxtb_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sumRbtn);
            this.groupBox2.Controls.Add(this.amountRbtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(125, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // sumRbtn
            // 
            this.sumRbtn.AutoSize = true;
            this.sumRbtn.Location = new System.Drawing.Point(19, 53);
            this.sumRbtn.Name = "sumRbtn";
            this.sumRbtn.Size = new System.Drawing.Size(63, 24);
            this.sumRbtn.TabIndex = 1;
            this.sumRbtn.TabStop = true;
            this.sumRbtn.Text = "Sum";
            this.sumRbtn.UseVisualStyleBackColor = true;
            this.sumRbtn.CheckedChanged += new System.EventHandler(this.sumRbtn_CheckedChanged);
            // 
            // amountRbtn
            // 
            this.amountRbtn.AutoSize = true;
            this.amountRbtn.Location = new System.Drawing.Point(19, 30);
            this.amountRbtn.Name = "amountRbtn";
            this.amountRbtn.Size = new System.Drawing.Size(89, 24);
            this.amountRbtn.TabIndex = 0;
            this.amountRbtn.TabStop = true;
            this.amountRbtn.Text = "Amount";
            this.amountRbtn.UseVisualStyleBackColor = true;
            this.amountRbtn.CheckedChanged += new System.EventHandler(this.amountRbtn_CheckedChanged);
            // 
            // priceTxtb
            // 
            this.priceTxtb.Location = new System.Drawing.Point(150, 69);
            this.priceTxtb.Name = "priceTxtb";
            this.priceTxtb.Size = new System.Drawing.Size(121, 26);
            this.priceTxtb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gasoline";
            // 
            // gasolineComboBox
            // 
            this.gasolineComboBox.FormattingEnabled = true;
            this.gasolineComboBox.Location = new System.Drawing.Point(150, 34);
            this.gasolineComboBox.Name = "gasolineComboBox";
            this.gasolineComboBox.Size = new System.Drawing.Size(121, 28);
            this.gasolineComboBox.TabIndex = 0;
            this.gasolineComboBox.SelectedIndexChanged += new System.EventHandler(this.gasolineComboBox_SelectedIndexChanged);
            // 
            // AllPaymentsListbox
            // 
            this.AllPaymentsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPaymentsListbox.FormattingEnabled = true;
            this.AllPaymentsListbox.ItemHeight = 25;
            this.AllPaymentsListbox.Location = new System.Drawing.Point(365, 34);
            this.AllPaymentsListbox.Name = "AllPaymentsListbox";
            this.AllPaymentsListbox.Size = new System.Drawing.Size(239, 204);
            this.AllPaymentsListbox.TabIndex = 1;
            // 
            // loadPaymentsBtn
            // 
            this.loadPaymentsBtn.AutoSize = true;
            this.loadPaymentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadPaymentsBtn.Location = new System.Drawing.Point(365, 276);
            this.loadPaymentsBtn.Name = "loadPaymentsBtn";
            this.loadPaymentsBtn.Size = new System.Drawing.Size(239, 35);
            this.loadPaymentsBtn.TabIndex = 12;
            this.loadPaymentsBtn.Text = "Load Payments";
            this.loadPaymentsBtn.UseVisualStyleBackColor = true;
            this.loadPaymentsBtn.Click += new System.EventHandler(this.loadPaymentsBtn_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 479);
            this.Controls.Add(this.loadPaymentsBtn);
            this.Controls.Add(this.AllPaymentsListbox);
            this.Controls.Add(this.gassStationGrbx);
            this.Name = "MainView";
            this.Text = "Form1";
            this.gassStationGrbx.ResumeLayout(false);
            this.gassStationGrbx.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gassStationGrbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sumTxtb;
        private System.Windows.Forms.TextBox amountTxtb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sumRbtn;
        private System.Windows.Forms.RadioButton amountRbtn;
        private System.Windows.Forms.TextBox priceTxtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox gasolineComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox totalPaymentTxtb;
        private System.Windows.Forms.Button payBtn;
        private System.Windows.Forms.ListBox AllPaymentsListbox;
        private System.Windows.Forms.Button loadPaymentsBtn;
        private System.Windows.Forms.TextBox TimeTxtb;
        private System.Windows.Forms.Label label5;
    }
}

