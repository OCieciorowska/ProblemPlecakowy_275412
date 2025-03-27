using System.Drawing;
using System.Windows.Forms;


namespace AppProjektPlecakowy2
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnSolve;
        private TextBox txtSeed;
        private TextBox txtNumItems;
        private TextBox txtCapacity;
        private ListBox lstResults;
        private ListBox lstInstance;
        private Label lblSeed;
        private Label lblNumItems;
        private Label lblCapacity;

        private void InitializeComponent()
        {
            btnSolve = new Button();
            txtSeed = new TextBox();
            txtNumItems = new TextBox();
            txtCapacity = new TextBox();
            lstResults = new ListBox();
            lstInstance = new ListBox();
            lblSeed = new Label();
            lblNumItems = new Label();
            lblCapacity = new Label();
            SuspendLayout();
            // 
            // btnSolve
            // 
            btnSolve.Location = new Point(203, 74);
            btnSolve.Name = "btnSolve";
            btnSolve.Size = new Size(75, 23);
            btnSolve.TabIndex = 5;
            btnSolve.Text = "Solve";
            btnSolve.Click += btnSolve_Click;
            // 
            // txtSeed
            // 
            txtSeed.Location = new Point(38, 32);
            txtSeed.Name = "txtSeed";
            txtSeed.Size = new Size(100, 23);
            txtSeed.TabIndex = 0;
            // 
            // txtNumItems
            // 
            txtNumItems.Location = new Point(190, 32);
            txtNumItems.Name = "txtNumItems";
            txtNumItems.Size = new Size(100, 23);
            txtNumItems.TabIndex = 1;
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(339, 32);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.Size = new Size(100, 23);
            txtCapacity.TabIndex = 2;
            // 
            // lstResults
            // 
            lstResults.ItemHeight = 15;
            lstResults.Location = new Point(38, 138);
            lstResults.Name = "lstResults";
            lstResults.Size = new Size(188, 154);
            lstResults.TabIndex = 3;
            // 
            // lstInstance
            // 
            lstInstance.ItemHeight = 15;
            lstInstance.Location = new Point(255, 138);
            lstInstance.Name = "lstInstance";
            lstInstance.Size = new Size(222, 154);
            lstInstance.TabIndex = 4;
            // 
            // lblSeed
            // 
            lblSeed.AutoSize = true;
            lblSeed.Location = new Point(38, 14);
            lblSeed.Name = "lblSeed";
            lblSeed.Size = new Size(35, 15);
            lblSeed.TabIndex = 6;
            lblSeed.Text = "Seed:";
            // 
            // lblNumItems
            // 
            lblNumItems.AutoSize = true;
            lblNumItems.Location = new Point(190, 14);
            lblNumItems.Name = "lblNumItems";
            lblNumItems.Size = new Size(100, 15);
            lblNumItems.TabIndex = 7;
            lblNumItems.Text = "Number of Items:";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Location = new Point(339, 14);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(56, 15);
            lblCapacity.TabIndex = 8;
            lblCapacity.Text = "Capacity:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 450);
            Controls.Add(txtSeed);
            Controls.Add(txtNumItems);
            Controls.Add(txtCapacity);
            Controls.Add(lstResults);
            Controls.Add(lstInstance);
            Controls.Add(btnSolve);
            Controls.Add(lblSeed);
            Controls.Add(lblNumItems);
            Controls.Add(lblCapacity);
            Name = "Form1";
            Text = "Problem Plecakowy";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
