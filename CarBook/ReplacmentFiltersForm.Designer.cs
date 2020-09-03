namespace CarBook
{
    partial class ReplacmentFiltersForm
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
            this.textBoxChoice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewCar = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.textBoxTireName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBoxFuel = new System.Windows.Forms.TextBox();
            this.textBoxOil = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRandomName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLPG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRandom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCabin = new System.Windows.Forms.TextBox();
            this.textBoxAir = new System.Windows.Forms.TextBox();
            this.dateTimePickerFuel = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOil = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerLPG = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAir = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCabin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerRandom = new System.Windows.Forms.DateTimePicker();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxChoice
            // 
            this.textBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxChoice.Location = new System.Drawing.Point(287, 7);
            this.textBoxChoice.Name = "textBoxChoice";
            this.textBoxChoice.ReadOnly = true;
            this.textBoxChoice.Size = new System.Drawing.Size(247, 44);
            this.textBoxChoice.TabIndex = 23;
            this.textBoxChoice.Text = "Wybrany pojazd";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "Wybierz pojazd:";
            // 
            // dataGridViewCar
            // 
            this.dataGridViewCar.AllowUserToAddRows = false;
            this.dataGridViewCar.AllowUserToDeleteRows = false;
            this.dataGridViewCar.AllowUserToResizeColumns = false;
            this.dataGridViewCar.AllowUserToResizeRows = false;
            this.dataGridViewCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCar.ColumnHeadersHeight = 35;
            this.dataGridViewCar.Location = new System.Drawing.Point(12, 85);
            this.dataGridViewCar.Name = "dataGridViewCar";
            this.dataGridViewCar.ReadOnly = true;
            this.dataGridViewCar.RowHeadersWidth = 25;
            this.dataGridViewCar.RowTemplate.Height = 30;
            this.dataGridViewCar.RowTemplate.ReadOnly = true;
            this.dataGridViewCar.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewCar.Size = new System.Drawing.Size(556, 429);
            this.dataGridViewCar.TabIndex = 21;
            this.dataGridViewCar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCar_CellClick);
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxID.Location = new System.Drawing.Point(550, 7);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(42, 44);
            this.textBoxID.TabIndex = 24;
            this.textBoxID.Text = "ID";
            this.textBoxID.Visible = false;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHistory.ColumnHeadersHeight = 35;
            this.dataGridViewHistory.Location = new System.Drawing.Point(12, 559);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.RowHeadersWidth = 25;
            this.dataGridViewHistory.RowTemplate.Height = 30;
            this.dataGridViewHistory.RowTemplate.ReadOnly = true;
            this.dataGridViewHistory.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewHistory.Size = new System.Drawing.Size(925, 211);
            this.dataGridViewHistory.TabIndex = 25;
            this.dataGridViewHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHistory_CellClick);
            // 
            // textBoxTireName
            // 
            this.textBoxTireName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxTireName.Location = new System.Drawing.Point(574, 414);
            this.textBoxTireName.Name = "textBoxTireName";
            this.textBoxTireName.ReadOnly = true;
            this.textBoxTireName.Size = new System.Drawing.Size(243, 44);
            this.textBoxTireName.TabIndex = 26;
            this.textBoxTireName.Text = "Filtr kabinowy";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(574, 323);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(243, 44);
            this.textBox1.TabIndex = 27;
            this.textBox1.Text = "Filtr powietrza";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(574, 230);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(243, 44);
            this.textBox2.TabIndex = 28;
            this.textBox2.Text = "Filtr LPG";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(574, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(243, 44);
            this.textBox3.TabIndex = 29;
            this.textBox3.Text = "Filtr oleju";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(574, 50);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(243, 44);
            this.textBox4.TabIndex = 30;
            this.textBox4.Text = "Filtr paliwa";
            // 
            // textBoxFuel
            // 
            this.textBoxFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxFuel.Location = new System.Drawing.Point(832, 50);
            this.textBoxFuel.Name = "textBoxFuel";
            this.textBoxFuel.Size = new System.Drawing.Size(235, 44);
            this.textBoxFuel.TabIndex = 34;
            // 
            // textBoxOil
            // 
            this.textBoxOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOil.Location = new System.Drawing.Point(832, 143);
            this.textBoxOil.Name = "textBoxOil";
            this.textBoxOil.Size = new System.Drawing.Size(235, 44);
            this.textBoxOil.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(832, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 33);
            this.label1.TabIndex = 40;
            this.label1.Text = "Stan licznika(KM):";
            // 
            // textBoxRandomName
            // 
            this.textBoxRandomName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRandomName.Location = new System.Drawing.Point(574, 501);
            this.textBoxRandomName.Name = "textBoxRandomName";
            this.textBoxRandomName.Size = new System.Drawing.Size(243, 44);
            this.textBoxRandomName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 517);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 39);
            this.label2.TabIndex = 42;
            this.label2.Text = "Historia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(832, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 33);
            this.label4.TabIndex = 44;
            this.label4.Text = "Stan licznika(KM):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(832, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 33);
            this.label5.TabIndex = 46;
            this.label5.Text = "Stan licznika(KM):";
            // 
            // textBoxLPG
            // 
            this.textBoxLPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxLPG.Location = new System.Drawing.Point(832, 230);
            this.textBoxLPG.Name = "textBoxLPG";
            this.textBoxLPG.Size = new System.Drawing.Size(235, 44);
            this.textBoxLPG.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(832, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(235, 33);
            this.label6.TabIndex = 52;
            this.label6.Text = "Stan licznika(KM):";
            // 
            // textBoxRandom
            // 
            this.textBoxRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxRandom.Location = new System.Drawing.Point(832, 501);
            this.textBoxRandom.Name = "textBoxRandom";
            this.textBoxRandom.Size = new System.Drawing.Size(235, 44);
            this.textBoxRandom.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(832, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 33);
            this.label7.TabIndex = 50;
            this.label7.Text = "Stan licznika(KM):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(832, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 33);
            this.label8.TabIndex = 49;
            this.label8.Text = "Stan licznika(KM):";
            // 
            // textBoxCabin
            // 
            this.textBoxCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCabin.Location = new System.Drawing.Point(832, 414);
            this.textBoxCabin.Name = "textBoxCabin";
            this.textBoxCabin.Size = new System.Drawing.Size(235, 44);
            this.textBoxCabin.TabIndex = 48;
            // 
            // textBoxAir
            // 
            this.textBoxAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxAir.Location = new System.Drawing.Point(832, 323);
            this.textBoxAir.Name = "textBoxAir";
            this.textBoxAir.Size = new System.Drawing.Size(235, 44);
            this.textBoxAir.TabIndex = 47;
            // 
            // dateTimePickerFuel
            // 
            this.dateTimePickerFuel.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerFuel.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFuel.Location = new System.Drawing.Point(1120, 50);
            this.dateTimePickerFuel.Name = "dateTimePickerFuel";
            this.dateTimePickerFuel.Size = new System.Drawing.Size(198, 44);
            this.dateTimePickerFuel.TabIndex = 53;
            // 
            // dateTimePickerOil
            // 
            this.dateTimePickerOil.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerOil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerOil.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerOil.Location = new System.Drawing.Point(1120, 140);
            this.dateTimePickerOil.Name = "dateTimePickerOil";
            this.dateTimePickerOil.Size = new System.Drawing.Size(198, 44);
            this.dateTimePickerOil.TabIndex = 54;
            // 
            // dateTimePickerLPG
            // 
            this.dateTimePickerLPG.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerLPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerLPG.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerLPG.Location = new System.Drawing.Point(1120, 230);
            this.dateTimePickerLPG.Name = "dateTimePickerLPG";
            this.dateTimePickerLPG.Size = new System.Drawing.Size(198, 44);
            this.dateTimePickerLPG.TabIndex = 55;
            // 
            // dateTimePickerAir
            // 
            this.dateTimePickerAir.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerAir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerAir.Location = new System.Drawing.Point(1120, 323);
            this.dateTimePickerAir.Name = "dateTimePickerAir";
            this.dateTimePickerAir.Size = new System.Drawing.Size(198, 44);
            this.dateTimePickerAir.TabIndex = 56;
            // 
            // dateTimePickerCabin
            // 
            this.dateTimePickerCabin.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerCabin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerCabin.Location = new System.Drawing.Point(1120, 414);
            this.dateTimePickerCabin.Name = "dateTimePickerCabin";
            this.dateTimePickerCabin.Size = new System.Drawing.Size(198, 44);
            this.dateTimePickerCabin.TabIndex = 57;
            // 
            // dateTimePickerRandom
            // 
            this.dateTimePickerRandom.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerRandom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerRandom.Location = new System.Drawing.Point(1120, 501);
            this.dateTimePickerRandom.Name = "dateTimePickerRandom";
            this.dateTimePickerRandom.Size = new System.Drawing.Size(198, 44);
            this.dateTimePickerRandom.TabIndex = 58;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(1155, 611);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(172, 57);
            this.buttonDelete.TabIndex = 65;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(1034, 690);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(234, 57);
            this.buttonClear.TabIndex = 64;
            this.buttonClear.Text = "Wyczyść wiersze";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAdd.Location = new System.Drawing.Point(955, 611);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(172, 57);
            this.buttonAdd.TabIndex = 63;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1111, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 33);
            this.label9.TabIndex = 66;
            this.label9.Text = "Dzień wymiany:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(1111, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 33);
            this.label10.TabIndex = 67;
            this.label10.Text = "Dzień wymiany:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(1111, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 33);
            this.label11.TabIndex = 68;
            this.label11.Text = "Dzień wymiany:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(1111, 281);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(207, 33);
            this.label12.TabIndex = 69;
            this.label12.Text = "Dzień wymiany:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(1111, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(207, 33);
            this.label13.TabIndex = 70;
            this.label13.Text = "Dzień wymiany:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(1111, 461);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 33);
            this.label14.TabIndex = 71;
            this.label14.Text = "Dzień wymiany:";
            // 
            // ReplacmentFiltersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 773);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dateTimePickerRandom);
            this.Controls.Add(this.dateTimePickerCabin);
            this.Controls.Add(this.dateTimePickerAir);
            this.Controls.Add(this.dateTimePickerLPG);
            this.Controls.Add(this.dateTimePickerOil);
            this.Controls.Add(this.dateTimePickerFuel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxRandom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCabin);
            this.Controls.Add(this.textBoxAir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxLPG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRandomName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOil);
            this.Controls.Add(this.textBoxFuel);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBoxTireName);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxChoice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewCar);
            this.MaximizeBox = false;
            this.Name = "ReplacmentFiltersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wymiana filtrów";
            this.Load += new System.EventHandler(this.ReplacmentFiltersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxChoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewCar;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.TextBox textBoxTireName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBoxFuel;
        private System.Windows.Forms.TextBox textBoxOil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRandomName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLPG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRandom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCabin;
        private System.Windows.Forms.TextBox textBoxAir;
        private System.Windows.Forms.DateTimePicker dateTimePickerFuel;
        private System.Windows.Forms.DateTimePicker dateTimePickerOil;
        private System.Windows.Forms.DateTimePicker dateTimePickerLPG;
        private System.Windows.Forms.DateTimePicker dateTimePickerAir;
        private System.Windows.Forms.DateTimePicker dateTimePickerCabin;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandom;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}