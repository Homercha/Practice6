namespace Lab06App
{
    partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox tbX1;
        private TextBox tbX2;
        private TextBox tbY;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private Label lblX1;
        private Label lblX2;
        private Label lblY;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tbX1 = new TextBox();
            this.tbX2 = new TextBox();
            this.tbY = new TextBox();
            this.btnCalculate = new Button();
            this.btnClear = new Button();
            this.btnExit = new Button();
            this.lblX1 = new Label();
            this.lblX2 = new Label();
            this.lblY = new Label();
            this.SuspendLayout();

            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(30, 20);
            this.lblX1.Text = "Змінна X1";

            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(30, 60);
            this.lblX2.Text = "Змінна X2";

            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(30, 100);
            this.lblY.Text = "Результат розрахунку Y";

            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(180, 20);
            this.tbX1.Size = new System.Drawing.Size(100, 20);

            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(180, 60);
            this.tbX2.Size = new System.Drawing.Size(100, 20);

            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(180, 100);
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.ReadOnly = true;

            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(30, 140);
            this.btnCalculate.Size = new System.Drawing.Size(75, 25);
            this.btnCalculate.Text = "Обчислити";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(120, 140);
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.Text = "Очистити";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(210, 140);
            this.btnExit.Size = new System.Drawing.Size(75, 25);
            this.btnExit.Text = "Вихід";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(320, 190);
            this.Controls.Add(this.lblX1);
            this.Controls.Add(this.lblX2);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Name = "Form1";
            this.Text = "Лабораторна робота №6";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
