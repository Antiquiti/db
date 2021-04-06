namespace BazaDanych
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brandTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.carCB = new System.Windows.Forms.ComboBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.colorTB = new System.Windows.Forms.TextBox();
            this.addCarBtn = new System.Windows.Forms.Button();
            this.addOwnerBtn = new System.Windows.Forms.Button();
            this.carListview = new System.Windows.Forms.ListView();
            this.ownerListview = new System.Windows.Forms.ListView();
            this.editCar = new System.Windows.Forms.Button();
            this.editOwner = new System.Windows.Forms.Button();
            this.deleteCar = new System.Windows.Forms.Button();
            this.deleteOwner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(93, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Samochody";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(376, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Właściciele";
            // 
            // brandTB
            // 
            this.brandTB.Location = new System.Drawing.Point(85, 276);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(121, 20);
            this.brandTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Marka";
            // 
            // modelTB
            // 
            this.modelTB.Location = new System.Drawing.Point(85, 302);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(121, 20);
            this.modelTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kolor";
            // 
            // carCB
            // 
            this.carCB.FormattingEnabled = true;
            this.carCB.Location = new System.Drawing.Point(351, 329);
            this.carCB.Name = "carCB";
            this.carCB.Size = new System.Drawing.Size(121, 21);
            this.carCB.TabIndex = 5;
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(351, 276);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(121, 20);
            this.nameTB.TabIndex = 3;
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(351, 302);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(121, 20);
            this.lastNameTB.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Imie";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nazwisko";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Samochód";
            // 
            // colorTB
            // 
            this.colorTB.Location = new System.Drawing.Point(85, 329);
            this.colorTB.Name = "colorTB";
            this.colorTB.Size = new System.Drawing.Size(121, 20);
            this.colorTB.TabIndex = 3;
            // 
            // addCarBtn
            // 
            this.addCarBtn.Location = new System.Drawing.Point(96, 355);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(75, 23);
            this.addCarBtn.TabIndex = 6;
            this.addCarBtn.Text = "Dodaj";
            this.addCarBtn.UseVisualStyleBackColor = true;
            this.addCarBtn.Click += new System.EventHandler(this.AddCarBtn_Click);
            // 
            // addOwnerBtn
            // 
            this.addOwnerBtn.Location = new System.Drawing.Point(366, 355);
            this.addOwnerBtn.Name = "addOwnerBtn";
            this.addOwnerBtn.Size = new System.Drawing.Size(75, 23);
            this.addOwnerBtn.TabIndex = 6;
            this.addOwnerBtn.Text = "Dodaj";
            this.addOwnerBtn.UseVisualStyleBackColor = true;
            this.addOwnerBtn.Click += new System.EventHandler(this.AddOwnerBtn_Click);
            // 
            // carListview
            // 
            this.carListview.HideSelection = false;
            this.carListview.Location = new System.Drawing.Point(13, 31);
            this.carListview.Name = "carListview";
            this.carListview.Size = new System.Drawing.Size(233, 199);
            this.carListview.TabIndex = 7;
            this.carListview.UseCompatibleStateImageBehavior = false;
            this.carListview.View = System.Windows.Forms.View.List;
            this.carListview.SelectedIndexChanged += new System.EventHandler(this.CarListview_SelectedIndexChanged);
            // 
            // ownerListview
            // 
            this.ownerListview.HideSelection = false;
            this.ownerListview.Location = new System.Drawing.Point(295, 31);
            this.ownerListview.Name = "ownerListview";
            this.ownerListview.Size = new System.Drawing.Size(242, 199);
            this.ownerListview.TabIndex = 8;
            this.ownerListview.UseCompatibleStateImageBehavior = false;
            this.ownerListview.View = System.Windows.Forms.View.Tile;
            this.ownerListview.SelectedIndexChanged += new System.EventHandler(this.OwnerListview_SelectedIndexChanged);
            // 
            // editCar
            // 
            this.editCar.Location = new System.Drawing.Point(96, 385);
            this.editCar.Name = "editCar";
            this.editCar.Size = new System.Drawing.Size(75, 23);
            this.editCar.TabIndex = 9;
            this.editCar.Text = "Edytuj";
            this.editCar.UseVisualStyleBackColor = true;
            this.editCar.Click += new System.EventHandler(this.EditCar_Click);
            // 
            // editOwner
            // 
            this.editOwner.Location = new System.Drawing.Point(366, 385);
            this.editOwner.Name = "editOwner";
            this.editOwner.Size = new System.Drawing.Size(75, 23);
            this.editOwner.TabIndex = 10;
            this.editOwner.Text = "Edytuj";
            this.editOwner.UseVisualStyleBackColor = true;
            this.editOwner.Click += new System.EventHandler(this.EditOwner_Click);
            // 
            // deleteCar
            // 
            this.deleteCar.Location = new System.Drawing.Point(96, 236);
            this.deleteCar.Name = "deleteCar";
            this.deleteCar.Size = new System.Drawing.Size(75, 23);
            this.deleteCar.TabIndex = 11;
            this.deleteCar.Text = "Usuń";
            this.deleteCar.UseVisualStyleBackColor = true;
            this.deleteCar.Click += new System.EventHandler(this.DeleteCar_Click);
            // 
            // deleteOwner
            // 
            this.deleteOwner.Location = new System.Drawing.Point(366, 236);
            this.deleteOwner.Name = "deleteOwner";
            this.deleteOwner.Size = new System.Drawing.Size(75, 23);
            this.deleteOwner.TabIndex = 11;
            this.deleteOwner.Text = "Usuń";
            this.deleteOwner.UseVisualStyleBackColor = true;
            this.deleteOwner.Click += new System.EventHandler(this.DeleteOwner_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 451);
            this.Controls.Add(this.deleteOwner);
            this.Controls.Add(this.deleteCar);
            this.Controls.Add(this.editOwner);
            this.Controls.Add(this.editCar);
            this.Controls.Add(this.ownerListview);
            this.Controls.Add(this.carListview);
            this.Controls.Add(this.addOwnerBtn);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.carCB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.colorTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.modelTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.brandTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Baza danych";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox carCB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox colorTB;
        private System.Windows.Forms.Button addCarBtn;
        private System.Windows.Forms.Button addOwnerBtn;
        private System.Windows.Forms.ListView carListview;
        private System.Windows.Forms.ListView ownerListview;
        private System.Windows.Forms.Button editCar;
        private System.Windows.Forms.Button editOwner;
        private System.Windows.Forms.Button deleteCar;
        private System.Windows.Forms.Button deleteOwner;
    }
}

