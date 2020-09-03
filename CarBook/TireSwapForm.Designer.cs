namespace CarBook
{
    partial class TairSwapForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTireName = new System.Windows.Forms.TextBox();
            this.dateTimePickerSwapTire = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTire = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxTireSize = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxChoice = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTire)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(66, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa opony";
            // 
            // textBoxTireName
            // 
            this.textBoxTireName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTireName.Location = new System.Drawing.Point(66, 78);
            this.textBoxTireName.Name = "textBoxTireName";
            this.textBoxTireName.Size = new System.Drawing.Size(345, 44);
            this.textBoxTireName.TabIndex = 1;
            // 
            // dateTimePickerSwapTire
            // 
            this.dateTimePickerSwapTire.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerSwapTire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerSwapTire.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSwapTire.Location = new System.Drawing.Point(956, 75);
            this.dateTimePickerSwapTire.Name = "dateTimePickerSwapTire";
            this.dateTimePickerSwapTire.Size = new System.Drawing.Size(241, 44);
            this.dateTimePickerSwapTire.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(956, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dzień wymiany:";
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.AllowUserToAddRows = false;
            this.dataGridViewCar.AllowUserToDeleteRows = false;
            this.dataGridViewCar.AllowUserToResizeColumns = false;
            this.dataGridViewCar.AllowUserToResizeRows = false;
            this.dataGridViewCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCar.ColumnHeadersHeight = 35;
            this.dataGridViewCar.Location = new System.Drawing.Point(12, 269);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.ReadOnly = true;
            this.dataGridViewCar.RowHeadersWidth = 25;
            this.dataGridViewCar.RowTemplate.Height = 30;
            this.dataGridViewCar.RowTemplate.ReadOnly = true;
            this.dataGridViewCar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCar.Size = new System.Drawing.Size(556, 492);
            this.dataGridViewCar.TabIndex = 6;
            this.dataGridViewCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCar_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Wybierz pojazd:";
            // 
            // dataGridViewTire
            // 
            this.dataGridViewTire.AllowUserToAddRows = false;
            this.dataGridViewTire.AllowUserToDeleteRows = false;
            this.dataGridViewTire.AllowUserToResizeColumns = false;
            this.dataGridViewTire.AllowUserToResizeRows = false;
            this.dataGridViewTire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTire.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTire.ColumnHeadersHeight = 35;
            this.dataGridViewTire.Location = new System.Drawing.Point(635, 269);
            this.dataGridViewTire.Name = "dataGridViewTire";
            this.dataGridViewTire.ReadOnly = true;
            this.dataGridViewTire.RowHeadersWidth = 27;
            this.dataGridViewTire.RowTemplate.Height = 30;
            this.dataGridViewTire.RowTemplate.ReadOnly = true;
            this.dataGridViewTire.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewTire.Size = new System.Drawing.Size(669, 492);
            this.dataGridViewTire.TabIndex = 8;
            this.dataGridViewTire.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTire_CellClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEdit.Location = new System.Drawing.Point(839, 172);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(172, 57);
            this.buttonEdit.TabIndex = 17;
            this.buttonEdit.Text = "Edytuj";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(1023, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 57);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(652, 172);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 57);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxTireSize
            // 
            this.textBoxTireSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTireSize.Location = new System.Drawing.Point(519, 75);
            this.textBoxTireSize.Name = "textBoxTireSize";
            this.textBoxTireSize.Size = new System.Drawing.Size(345, 44);
            this.textBoxTireSize.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(519, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Wymiary opony:";
            // 
            // textBoxChoice
            // 
            this.textBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChoice.Location = new System.Drawing.Point(89, 144);
            this.textBoxChoice.Name = "textBoxChoice";
            this.textBoxChoice.ReadOnly = true;
            this.textBoxChoice.Size = new System.Drawing.Size(345, 44);
            this.textBoxChoice.TabIndex = 20;
            this.textBoxChoice.Text = "Wybrany pojazd";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(574, 286);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(42, 44);
            this.textBoxID.TabIndex = 5;
            this.textBoxID.Text = "ID";
            this.textBoxID.Visible = false;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(474, 172);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(131, 57);
            this.buttonClear.TabIndex = 21;
            this.buttonClear.Text = "Wyczyść";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TairSwapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 773);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxChoice);
            this.Controls.Add(this.textBoxTireSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerSwapTire);
            this.Controls.Add(this.textBoxTireName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TairSwapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TairSwap";
            this.Load += new System.EventHandler(this.TairSwapForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTireName;
        private System.Windows.Forms.DateTimePicker dateTimePickerSwapTire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTire;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxTireSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxChoice;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button buttonClear;
    }
}