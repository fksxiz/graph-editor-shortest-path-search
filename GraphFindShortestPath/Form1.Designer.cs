﻿namespace GraphFindShortestPath
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddVertexButton = new System.Windows.Forms.Button();
            this.addEdgeButton = new System.Windows.Forms.Button();
            this.srcTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.dstTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FindShortestPathButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shortestDstTextBox = new System.Windows.Forms.TextBox();
            this.shortestSrcTextBox = new System.Windows.Forms.TextBox();
            this.stateButton = new System.Windows.Forms.Button();
            this.EventsListBox = new System.Windows.Forms.ListBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.SoundsButton = new System.Windows.Forms.Button();
            this.RemoveEdgeButton = new System.Windows.Forms.Button();
            this.RemoveVertexButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EdgeModeButton = new System.Windows.Forms.Button();
            this.DeleteModeButton = new System.Windows.Forms.Button();
            this.graphEditor1 = new Graph.GraphEditor();
            this.label7 = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddVertexButton
            // 
            this.AddVertexButton.Location = new System.Drawing.Point(13, 41);
            this.AddVertexButton.Name = "AddVertexButton";
            this.AddVertexButton.Size = new System.Drawing.Size(79, 23);
            this.AddVertexButton.TabIndex = 0;
            this.AddVertexButton.Text = "vertex mode";
            this.AddVertexButton.UseVisualStyleBackColor = true;
            this.AddVertexButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // addEdgeButton
            // 
            this.addEdgeButton.Location = new System.Drawing.Point(14, 70);
            this.addEdgeButton.Name = "addEdgeButton";
            this.addEdgeButton.Size = new System.Drawing.Size(63, 23);
            this.addEdgeButton.TabIndex = 2;
            this.addEdgeButton.Text = "Add Edge";
            this.addEdgeButton.UseVisualStyleBackColor = true;
            this.addEdgeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // srcTextBox
            // 
            this.srcTextBox.Location = new System.Drawing.Point(98, 99);
            this.srcTextBox.Name = "srcTextBox";
            this.srcTextBox.Size = new System.Drawing.Size(159, 20);
            this.srcTextBox.TabIndex = 7;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(98, 151);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(159, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // dstTextBox
            // 
            this.dstTextBox.Location = new System.Drawing.Point(98, 125);
            this.dstTextBox.Name = "dstTextBox";
            this.dstTextBox.Size = new System.Drawing.Size(159, 20);
            this.dstTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "src vertex name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "dst vertex name";
            // 
            // FindShortestPathButton
            // 
            this.FindShortestPathButton.Location = new System.Drawing.Point(13, 177);
            this.FindShortestPathButton.Name = "FindShortestPathButton";
            this.FindShortestPathButton.Size = new System.Drawing.Size(245, 23);
            this.FindShortestPathButton.TabIndex = 13;
            this.FindShortestPathButton.Text = "Find Shortest Path";
            this.FindShortestPathButton.UseVisualStyleBackColor = true;
            this.FindShortestPathButton.Click += new System.EventHandler(this.FindShortestPathButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "dst vertex name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "src vertex name";
            // 
            // shortestDstTextBox
            // 
            this.shortestDstTextBox.Location = new System.Drawing.Point(97, 232);
            this.shortestDstTextBox.Name = "shortestDstTextBox";
            this.shortestDstTextBox.Size = new System.Drawing.Size(160, 20);
            this.shortestDstTextBox.TabIndex = 15;
            // 
            // shortestSrcTextBox
            // 
            this.shortestSrcTextBox.Location = new System.Drawing.Point(97, 206);
            this.shortestSrcTextBox.Name = "shortestSrcTextBox";
            this.shortestSrcTextBox.Size = new System.Drawing.Size(160, 20);
            this.shortestSrcTextBox.TabIndex = 14;
            // 
            // stateButton
            // 
            this.stateButton.Location = new System.Drawing.Point(12, 12);
            this.stateButton.Name = "stateButton";
            this.stateButton.Size = new System.Drawing.Size(245, 23);
            this.stateButton.TabIndex = 18;
            this.stateButton.Text = "State";
            this.stateButton.UseVisualStyleBackColor = true;
            this.stateButton.Click += new System.EventHandler(this.stateButton_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(12, 362);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(245, 108);
            this.EventsListBox.TabIndex = 20;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Red;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Location = new System.Drawing.Point(12, 307);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(245, 23);
            this.ResetButton.TabIndex = 21;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "path";
            // 
            // pathTextBox
            // 
            this.pathTextBox.Location = new System.Drawing.Point(97, 258);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(160, 20);
            this.pathTextBox.TabIndex = 23;
            // 
            // SoundsButton
            // 
            this.SoundsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SoundsButton.Location = new System.Drawing.Point(12, 284);
            this.SoundsButton.Name = "SoundsButton";
            this.SoundsButton.Size = new System.Drawing.Size(245, 23);
            this.SoundsButton.TabIndex = 24;
            this.SoundsButton.Text = "On/Off sounds";
            this.SoundsButton.UseVisualStyleBackColor = true;
            this.SoundsButton.Click += new System.EventHandler(this.SoundsButton_Click);
            // 
            // RemoveEdgeButton
            // 
            this.RemoveEdgeButton.Location = new System.Drawing.Point(83, 70);
            this.RemoveEdgeButton.Name = "RemoveEdgeButton";
            this.RemoveEdgeButton.Size = new System.Drawing.Size(84, 23);
            this.RemoveEdgeButton.TabIndex = 25;
            this.RemoveEdgeButton.Text = "Remove Edge";
            this.RemoveEdgeButton.UseVisualStyleBackColor = true;
            this.RemoveEdgeButton.Click += new System.EventHandler(this.RemoveEdgeButton_Click);
            // 
            // RemoveVertexButton
            // 
            this.RemoveVertexButton.Location = new System.Drawing.Point(173, 70);
            this.RemoveVertexButton.Name = "RemoveVertexButton";
            this.RemoveVertexButton.Size = new System.Drawing.Size(84, 23);
            this.RemoveVertexButton.TabIndex = 27;
            this.RemoveVertexButton.Text = "Remove ver";
            this.RemoveVertexButton.UseVisualStyleBackColor = true;
            this.RemoveVertexButton.Click += new System.EventHandler(this.RemoveVertexButton_Click);
            // 
            // EdgeModeButton
            // 
            this.EdgeModeButton.Location = new System.Drawing.Point(98, 41);
            this.EdgeModeButton.Name = "EdgeModeButton";
            this.EdgeModeButton.Size = new System.Drawing.Size(74, 23);
            this.EdgeModeButton.TabIndex = 29;
            this.EdgeModeButton.Text = "edge mode";
            this.EdgeModeButton.UseVisualStyleBackColor = true;
            this.EdgeModeButton.Click += new System.EventHandler(this.EdgeModeButton_Click);
            // 
            // DeleteModeButton
            // 
            this.DeleteModeButton.Location = new System.Drawing.Point(178, 41);
            this.DeleteModeButton.Name = "DeleteModeButton";
            this.DeleteModeButton.Size = new System.Drawing.Size(79, 23);
            this.DeleteModeButton.TabIndex = 31;
            this.DeleteModeButton.Text = "delete mode";
            this.DeleteModeButton.UseVisualStyleBackColor = true;
            this.DeleteModeButton.Click += new System.EventHandler(this.DeleteModeButton_Click);
            // 
            // graphEditor1
            // 
            this.graphEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphEditor1.BackColor = System.Drawing.Color.AliceBlue;
            this.graphEditor1.DarkColor = System.Drawing.Color.DarkGray;
            this.graphEditor1.EdgeColor = System.Drawing.Color.Gray;
            this.graphEditor1.IsDeleteMode = false;
            this.graphEditor1.IsEdgeAddMode = false;
            this.graphEditor1.IsVertexAddMode = false;
            this.graphEditor1.LightColor = System.Drawing.Color.Gray;
            this.graphEditor1.Location = new System.Drawing.Point(264, 12);
            this.graphEditor1.Name = "graphEditor1";
            this.graphEditor1.ObjState = Graph.GraphEditor.ObjStates.osConvex;
            this.graphEditor1.ShortestPathColor = System.Drawing.Color.Green;
            this.graphEditor1.Size = new System.Drawing.Size(524, 458);
            this.graphEditor1.SoundsOn = true;
            this.graphEditor1.TabIndex = 30;
            this.graphEditor1.Text = "graphEditor1";
            this.graphEditor1.TextColor = System.Drawing.Color.Red;
            this.graphEditor1.VertexColor = System.Drawing.Color.Black;
            this.graphEditor1.VertexSize = 20;
            this.graphEditor1.ChangeState += new System.EventHandler(this.graphEditor1_ChangeState);
            this.graphEditor1.VertexAdd += new System.EventHandler(this.graphEditor1_VertexAdd);
            this.graphEditor1.VertexRemove += new System.EventHandler(this.graphEditor1_VertexRemove);
            this.graphEditor1.EdgeAdd += new System.EventHandler(this.graphEditor1_EdgeAdd);
            this.graphEditor1.EdgeRemove += new System.EventHandler(this.graphEditor1_EdgeRemove);
            this.graphEditor1.FindedShortestPath += new System.EventHandler(this.graphEditor1_FindedShortestPath);
            this.graphEditor1.ResetGraph += new System.EventHandler(this.graphEditor1_ResetGraph);
            this.graphEditor1.Click += new System.EventHandler(this.graphEditor1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "mode:";
            // 
            // modeLabel
            // 
            this.modeLabel.AutoSize = true;
            this.modeLabel.Location = new System.Drawing.Point(98, 340);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(10, 13);
            this.modeLabel.TabIndex = 33;
            this.modeLabel.Text = "-";
            this.modeLabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.modeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DeleteModeButton);
            this.Controls.Add(this.graphEditor1);
            this.Controls.Add(this.EdgeModeButton);
            this.Controls.Add(this.RemoveVertexButton);
            this.Controls.Add(this.RemoveEdgeButton);
            this.Controls.Add(this.SoundsButton);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.EventsListBox);
            this.Controls.Add(this.stateButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.shortestDstTextBox);
            this.Controls.Add(this.shortestSrcTextBox);
            this.Controls.Add(this.FindShortestPathButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dstTextBox);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.srcTextBox);
            this.Controls.Add(this.addEdgeButton);
            this.Controls.Add(this.AddVertexButton);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddVertexButton;
        private System.Windows.Forms.Button addEdgeButton;
        private System.Windows.Forms.TextBox srcTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox dstTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FindShortestPathButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox shortestDstTextBox;
        private System.Windows.Forms.TextBox shortestSrcTextBox;
        private System.Windows.Forms.Button stateButton;
        private System.Windows.Forms.ListBox EventsListBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button SoundsButton;
        private System.Windows.Forms.Button RemoveEdgeButton;
        private System.Windows.Forms.Button RemoveVertexButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button EdgeModeButton;
        private Graph.GraphEditor graphEditor1;
        private System.Windows.Forms.Button DeleteModeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label modeLabel;
    }
}

