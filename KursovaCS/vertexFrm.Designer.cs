using System.ComponentModel;

namespace KursovaCS;

partial class vertexFrm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        containerView = new System.Windows.Forms.DataGridView();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        figureIndex1 = new System.Windows.Forms.TextBox();
        figureIndex2 = new System.Windows.Forms.TextBox();
        operationBtn = new System.Windows.Forms.Button();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        vertexIndex1 = new System.Windows.Forms.TextBox();
        vertexIndex2 = new System.Windows.Forms.TextBox();
        readFileBtn = new System.Windows.Forms.Button();
        label6 = new System.Windows.Forms.Label();
        scalarBox = new System.Windows.Forms.TextBox();
        label7 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        additionBox = new System.Windows.Forms.TextBox();
        subtractionBox = new System.Windows.Forms.TextBox();
        multiplicationBox = new System.Windows.Forms.TextBox();
        divisionBox = new System.Windows.Forms.TextBox();
        ((System.ComponentModel.ISupportInitialize)containerView).BeginInit();
        SuspendLayout();
        // 
        // containerView
        // 
        containerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        containerView.Location = new System.Drawing.Point(290, 44);
        containerView.Name = "containerView";
        containerView.Size = new System.Drawing.Size(504, 231);
        containerView.TabIndex = 0;
        containerView.Text = "dataGridView1";
        containerView.CellContentClick += containerView_CellContentClick;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(473, 5);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(133, 36);
        label1.TabIndex = 1;
        label1.Text = "Контейнер";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(28, 16);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(219, 25);
        label2.TabIndex = 2;
        label2.Text = "Введіть індекс фігури №1";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(28, 72);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(231, 25);
        label3.TabIndex = 3;
        label3.Text = "Введіть індекс фігури №2";
        // 
        // figureIndex1
        // 
        figureIndex1.Location = new System.Drawing.Point(28, 46);
        figureIndex1.Name = "figureIndex1";
        figureIndex1.Size = new System.Drawing.Size(138, 23);
        figureIndex1.TabIndex = 4;
        // 
        // figureIndex2
        // 
        figureIndex2.Location = new System.Drawing.Point(28, 100);
        figureIndex2.Name = "figureIndex2";
        figureIndex2.Size = new System.Drawing.Size(138, 23);
        figureIndex2.TabIndex = 5;
        // 
        // operationBtn
        // 
        operationBtn.Location = new System.Drawing.Point(28, 327);
        operationBtn.Name = "operationBtn";
        operationBtn.Size = new System.Drawing.Size(138, 26);
        operationBtn.TabIndex = 6;
        operationBtn.Text = "Провести операції";
        operationBtn.UseVisualStyleBackColor = true;
        operationBtn.Click += operationBtn_Click;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(28, 126);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(238, 25);
        label4.TabIndex = 7;
        label4.Text = "Введіть індекс вершини №1";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(28, 185);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(238, 25);
        label5.TabIndex = 8;
        label5.Text = "Введіть індекс вершини №2";
        // 
        // vertexIndex1
        // 
        vertexIndex1.Location = new System.Drawing.Point(28, 159);
        vertexIndex1.Name = "vertexIndex1";
        vertexIndex1.Size = new System.Drawing.Size(138, 23);
        vertexIndex1.TabIndex = 9;
        // 
        // vertexIndex2
        // 
        vertexIndex2.Location = new System.Drawing.Point(28, 213);
        vertexIndex2.Name = "vertexIndex2";
        vertexIndex2.Size = new System.Drawing.Size(138, 23);
        vertexIndex2.TabIndex = 10;
        // 
        // readFileBtn
        // 
        readFileBtn.Location = new System.Drawing.Point(28, 296);
        readFileBtn.Name = "readFileBtn";
        readFileBtn.Size = new System.Drawing.Size(138, 25);
        readFileBtn.TabIndex = 11;
        readFileBtn.Text = "Зчитати з файлу";
        readFileBtn.UseVisualStyleBackColor = true;
        readFileBtn.Click += readFileBtn_Click;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.Location = new System.Drawing.Point(28, 239);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(238, 25);
        label6.TabIndex = 12;
        label6.Text = "Введіть коефіцієнт";
        // 
        // scalarBox
        // 
        scalarBox.Location = new System.Drawing.Point(28, 267);
        scalarBox.Name = "scalarBox";
        scalarBox.Size = new System.Drawing.Size(138, 23);
        scalarBox.TabIndex = 13;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(292, 298);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(111, 22);
        label7.TabIndex = 14;
        label7.Text = "Додавання:";
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(292, 327);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(111, 22);
        label8.TabIndex = 15;
        label8.Text = "Віднімання:";
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(550, 302);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(111, 22);
        label9.TabIndex = 16;
        label9.Text = "Множення:";
        // 
        // label10
        // 
        label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(550, 327);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(111, 22);
        label10.TabIndex = 17;
        label10.Text = "Ділення:";
        // 
        // additionBox
        // 
        additionBox.Location = new System.Drawing.Point(393, 298);
        additionBox.Name = "additionBox";
        additionBox.Size = new System.Drawing.Size(138, 23);
        additionBox.TabIndex = 18;
        // 
        // subtractionBox
        // 
        subtractionBox.Location = new System.Drawing.Point(393, 330);
        subtractionBox.Name = "subtractionBox";
        subtractionBox.Size = new System.Drawing.Size(138, 23);
        subtractionBox.TabIndex = 19;
        // 
        // multiplicationBox
        // 
        multiplicationBox.Location = new System.Drawing.Point(656, 301);
        multiplicationBox.Name = "multiplicationBox";
        multiplicationBox.Size = new System.Drawing.Size(138, 23);
        multiplicationBox.TabIndex = 20;
        // 
        // divisionBox
        // 
        divisionBox.Location = new System.Drawing.Point(656, 330);
        divisionBox.Name = "divisionBox";
        divisionBox.Size = new System.Drawing.Size(138, 23);
        divisionBox.TabIndex = 21;
        // 
        // vertexFrm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(divisionBox);
        Controls.Add(multiplicationBox);
        Controls.Add(subtractionBox);
        Controls.Add(additionBox);
        Controls.Add(label10);
        Controls.Add(label9);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(scalarBox);
        Controls.Add(label6);
        Controls.Add(readFileBtn);
        Controls.Add(vertexIndex2);
        Controls.Add(vertexIndex1);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(operationBtn);
        Controls.Add(figureIndex2);
        Controls.Add(figureIndex1);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(containerView);
        Text = "vertexFrm";
        ((System.ComponentModel.ISupportInitialize)containerView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.TextBox additionBox;
    private System.Windows.Forms.TextBox subtractionBox;
    private System.Windows.Forms.TextBox multiplicationBox;
    private System.Windows.Forms.TextBox divisionBox;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Button readFileBtn;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox scalarBox;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox vertexIndex1;
    private System.Windows.Forms.TextBox vertexIndex2;

    private System.Windows.Forms.Button operationBtn;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox figureIndex1;
    private System.Windows.Forms.TextBox figureIndex2;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.DataGridView containerView;

    #endregion
}