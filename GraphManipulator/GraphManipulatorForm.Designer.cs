namespace GraphManipulator
{
    partial class GraphManipulatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_adjacencyMatrix = new DataGridView();
            btn_addEdge = new Button();
            btn_exhibitionModeList = new Button();
            btn_exhibitionModeMatrix = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dgv_adjacencyList = new DataGridView();
            btn_av_addVertex = new Button();
            btn_removeEdge = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tb_av_vertexName = new TextBox();
            label7 = new Label();
            cb_rv_selectVertex = new ComboBox();
            label8 = new Label();
            pn_addVertex = new Panel();
            label9 = new Label();
            panel1 = new Panel();
            btn_rv_removeVertex = new Button();
            label10 = new Label();
            panel2 = new Panel();
            lb_edgeReturn = new Label();
            cb_selectSucessorEdge = new ComboBox();
            cb_selectPredecessorEdge = new ComboBox();
            lb_vertexReturn = new Label();
            chb_directedGraph = new CheckBox();
            btn_Start = new Button();
            label11 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyMatrix).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyList).BeginInit();
            pn_addVertex.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgv_adjacencyMatrix
            // 
            dgv_adjacencyMatrix.AllowUserToAddRows = false;
            dgv_adjacencyMatrix.AllowUserToDeleteRows = false;
            dgv_adjacencyMatrix.AllowUserToResizeColumns = false;
            dgv_adjacencyMatrix.AllowUserToResizeRows = false;
            dgv_adjacencyMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgv_adjacencyMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_adjacencyMatrix.Location = new Point(335, 74);
            dgv_adjacencyMatrix.Name = "dgv_adjacencyMatrix";
            dgv_adjacencyMatrix.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_adjacencyMatrix.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_adjacencyMatrix.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgv_adjacencyMatrix.RowTemplate.Height = 25;
            dgv_adjacencyMatrix.Size = new Size(926, 837);
            dgv_adjacencyMatrix.TabIndex = 0;
            dgv_adjacencyMatrix.Visible = false;
            // 
            // btn_addEdge
            // 
            btn_addEdge.Enabled = false;
            btn_addEdge.Location = new Point(7, 91);
            btn_addEdge.Name = "btn_addEdge";
            btn_addEdge.Size = new Size(234, 23);
            btn_addEdge.TabIndex = 4;
            btn_addEdge.Text = "Adicionar aresta";
            btn_addEdge.UseVisualStyleBackColor = true;
            btn_addEdge.Click += btn_addEdge_Click;
            // 
            // btn_exhibitionModeList
            // 
            btn_exhibitionModeList.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_exhibitionModeList.Enabled = false;
            btn_exhibitionModeList.Location = new Point(893, 10);
            btn_exhibitionModeList.Name = "btn_exhibitionModeList";
            btn_exhibitionModeList.Size = new Size(176, 23);
            btn_exhibitionModeList.TabIndex = 5;
            btn_exhibitionModeList.Text = "Lista de Adjacência";
            btn_exhibitionModeList.UseVisualStyleBackColor = true;
            btn_exhibitionModeList.Click += btn_exhibitionModeList_Click;
            // 
            // btn_exhibitionModeMatrix
            // 
            btn_exhibitionModeMatrix.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_exhibitionModeMatrix.Enabled = false;
            btn_exhibitionModeMatrix.Location = new Point(1076, 10);
            btn_exhibitionModeMatrix.Name = "btn_exhibitionModeMatrix";
            btn_exhibitionModeMatrix.Size = new Size(176, 23);
            btn_exhibitionModeMatrix.TabIndex = 6;
            btn_exhibitionModeMatrix.Text = "Matriz de Adjacência";
            btn_exhibitionModeMatrix.UseVisualStyleBackColor = true;
            btn_exhibitionModeMatrix.Click += btn_exhibitionModeMatrix_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(735, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 7;
            label1.Text = "Modo de exibição:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 8;
            label2.Text = "Número de vertices:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 355);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 9;
            label3.Text = "Gerenciar Arestas:";
            // 
            // dgv_adjacencyList
            // 
            dgv_adjacencyList.AllowUserToAddRows = false;
            dgv_adjacencyList.AllowUserToDeleteRows = false;
            dgv_adjacencyList.AllowUserToResizeColumns = false;
            dgv_adjacencyList.AllowUserToResizeRows = false;
            dgv_adjacencyList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_adjacencyList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_adjacencyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_adjacencyList.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_adjacencyList.Location = new Point(335, 74);
            dgv_adjacencyList.Name = "dgv_adjacencyList";
            dgv_adjacencyList.ReadOnly = true;
            dgv_adjacencyList.RowHeadersVisible = false;
            dgv_adjacencyList.RowHeadersWidth = 20;
            dgv_adjacencyList.RowTemplate.Height = 25;
            dgv_adjacencyList.Size = new Size(926, 837);
            dgv_adjacencyList.TabIndex = 12;
            dgv_adjacencyList.Visible = false;
            // 
            // btn_av_addVertex
            // 
            btn_av_addVertex.Enabled = false;
            btn_av_addVertex.Location = new Point(158, 30);
            btn_av_addVertex.Name = "btn_av_addVertex";
            btn_av_addVertex.Size = new Size(78, 23);
            btn_av_addVertex.TabIndex = 13;
            btn_av_addVertex.Text = "Adicionar";
            btn_av_addVertex.UseVisualStyleBackColor = true;
            btn_av_addVertex.Click += btn_av_addVertex_Click;
            // 
            // btn_removeEdge
            // 
            btn_removeEdge.Enabled = false;
            btn_removeEdge.Location = new Point(7, 120);
            btn_removeEdge.Name = "btn_removeEdge";
            btn_removeEdge.Size = new Size(234, 23);
            btn_removeEdge.TabIndex = 14;
            btn_removeEdge.Text = "Remover aresta";
            btn_removeEdge.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 39);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 15;
            label4.Text = "Predecessor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(141, 39);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 16;
            label5.Text = "Sucessor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 121);
            label6.Name = "label6";
            label6.Size = new Size(138, 21);
            label6.TabIndex = 21;
            label6.Text = "Gerenciar Vertices:";
            // 
            // tb_av_vertexName
            // 
            tb_av_vertexName.Enabled = false;
            tb_av_vertexName.Location = new Point(52, 31);
            tb_av_vertexName.Name = "tb_av_vertexName";
            tb_av_vertexName.Size = new Size(100, 23);
            tb_av_vertexName.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 34);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 23;
            label7.Text = "Nome:";
            // 
            // cb_rv_selectVertex
            // 
            cb_rv_selectVertex.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_rv_selectVertex.Enabled = false;
            cb_rv_selectVertex.FormattingEnabled = true;
            cb_rv_selectVertex.Location = new Point(52, 33);
            cb_rv_selectVertex.Name = "cb_rv_selectVertex";
            cb_rv_selectVertex.Size = new Size(100, 23);
            cb_rv_selectVertex.TabIndex = 24;
            cb_rv_selectVertex.DropDown += cb_rv_selectVertex_DropDown;
            cb_rv_selectVertex.SelectedIndexChanged += cb_rv_selectVertex_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 0);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 25;
            label8.Text = "Remover Vertice:";
            // 
            // pn_addVertex
            // 
            pn_addVertex.Controls.Add(label9);
            pn_addVertex.Controls.Add(label7);
            pn_addVertex.Controls.Add(tb_av_vertexName);
            pn_addVertex.Controls.Add(btn_av_addVertex);
            pn_addVertex.Location = new Point(12, 145);
            pn_addVertex.Name = "pn_addVertex";
            pn_addVertex.Size = new Size(258, 68);
            pn_addVertex.TabIndex = 26;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 0);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 24;
            label9.Text = "Adicionar Vertice:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_rv_removeVertex);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(cb_rv_selectVertex);
            panel1.Location = new Point(12, 219);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 68);
            panel1.TabIndex = 27;
            // 
            // btn_rv_removeVertex
            // 
            btn_rv_removeVertex.Enabled = false;
            btn_rv_removeVertex.Location = new Point(158, 32);
            btn_rv_removeVertex.Name = "btn_rv_removeVertex";
            btn_rv_removeVertex.Size = new Size(78, 23);
            btn_rv_removeVertex.TabIndex = 25;
            btn_rv_removeVertex.Text = "Remover";
            btn_rv_removeVertex.UseVisualStyleBackColor = true;
            btn_rv_removeVertex.Click += btn_rv_removeVertex_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 41);
            label10.Name = "label10";
            label10.Size = new Size(43, 15);
            label10.TabIndex = 25;
            label10.Text = "Nome:";
            // 
            // panel2
            // 
            panel2.Controls.Add(lb_edgeReturn);
            panel2.Controls.Add(cb_selectSucessorEdge);
            panel2.Controls.Add(cb_selectPredecessorEdge);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btn_removeEdge);
            panel2.Controls.Add(btn_addEdge);
            panel2.Location = new Point(12, 379);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 251);
            panel2.TabIndex = 28;
            // 
            // lb_edgeReturn
            // 
            lb_edgeReturn.AutoSize = true;
            lb_edgeReturn.ForeColor = Color.Firebrick;
            lb_edgeReturn.Location = new Point(19, 187);
            lb_edgeReturn.Name = "lb_edgeReturn";
            lb_edgeReturn.Size = new Size(49, 15);
            lb_edgeReturn.TabIndex = 28;
            lb_edgeReturn.Text = "Retorno";
            // 
            // cb_selectSucessorEdge
            // 
            cb_selectSucessorEdge.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectSucessorEdge.Enabled = false;
            cb_selectSucessorEdge.FormattingEnabled = true;
            cb_selectSucessorEdge.Location = new Point(141, 57);
            cb_selectSucessorEdge.Name = "cb_selectSucessorEdge";
            cb_selectSucessorEdge.Size = new Size(100, 23);
            cb_selectSucessorEdge.TabIndex = 27;
            cb_selectSucessorEdge.DropDown += cb_selectSucessorEdge_DropDown;
            cb_selectSucessorEdge.SelectedIndexChanged += cb_selectSucessorEdge_SelectedIndexChanged;
            // 
            // cb_selectPredecessorEdge
            // 
            cb_selectPredecessorEdge.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_selectPredecessorEdge.Enabled = false;
            cb_selectPredecessorEdge.FormattingEnabled = true;
            cb_selectPredecessorEdge.Location = new Point(8, 57);
            cb_selectPredecessorEdge.Name = "cb_selectPredecessorEdge";
            cb_selectPredecessorEdge.Size = new Size(100, 23);
            cb_selectPredecessorEdge.TabIndex = 26;
            cb_selectPredecessorEdge.DropDown += cb_selectPredecessorEdge_DropDown;
            cb_selectPredecessorEdge.SelectedIndexChanged += cb_selectPredecessorEdge_SelectedIndexChanged;
            // 
            // lb_vertexReturn
            // 
            lb_vertexReturn.AutoSize = true;
            lb_vertexReturn.ForeColor = Color.Firebrick;
            lb_vertexReturn.Location = new Point(31, 316);
            lb_vertexReturn.Name = "lb_vertexReturn";
            lb_vertexReturn.Size = new Size(49, 15);
            lb_vertexReturn.TabIndex = 29;
            lb_vertexReturn.Text = "Retorno";
            // 
            // chb_directedGraph
            // 
            chb_directedGraph.AutoSize = true;
            chb_directedGraph.Location = new Point(19, 42);
            chb_directedGraph.Name = "chb_directedGraph";
            chb_directedGraph.Size = new Size(122, 19);
            chb_directedGraph.TabIndex = 17;
            chb_directedGraph.Text = "Grafo Direcionado";
            chb_directedGraph.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(166, 9);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(82, 51);
            btn_Start.TabIndex = 30;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 14);
            label11.Name = "label11";
            label11.Size = new Size(73, 15);
            label11.TabIndex = 32;
            label11.Text = "Qtd Vertices:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(98, 10);
            maskedTextBox1.Mask = "0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(32, 23);
            maskedTextBox1.TabIndex = 33;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // GraphManipulatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1273, 923);
            Controls.Add(maskedTextBox1);
            Controls.Add(label11);
            Controls.Add(btn_Start);
            Controls.Add(lb_vertexReturn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(chb_directedGraph);
            Controls.Add(pn_addVertex);
            Controls.Add(label6);
            Controls.Add(dgv_adjacencyList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_exhibitionModeMatrix);
            Controls.Add(btn_exhibitionModeList);
            Controls.Add(dgv_adjacencyMatrix);
            Name = "GraphManipulatorForm";
            Text = "Grafos";
            Load += GraphManipulatorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyMatrix).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_adjacencyList).EndInit();
            pn_addVertex.ResumeLayout(false);
            pn_addVertex.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_adjacencyMatrix;
        private Button btn_addEdge;
        private Button btn_exhibitionModeList;
        private Button btn_exhibitionModeMatrix;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dgv_adjacencyList;
        private Button btn_av_addVertex;
        private Button btn_removeEdge;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox tb_av_vertexName;
        private Label label7;
        private ComboBox cb_rv_selectVertex;
        private Label label8;
        private Panel pn_addVertex;
        private Label label9;
        private Panel panel1;
        private Button btn_rv_removeVertex;
        private Label label10;
        private Panel panel2;
        private Label lb_edgeReturn;
        private ComboBox cb_selectSucessorEdge;
        private ComboBox cb_selectPredecessorEdge;
        private Label lb_vertexReturn;
        private CheckBox chb_directedGraph;
        private Button btn_Start;
        private Label label11;
        private MaskedTextBox maskedTextBox1;
    }
}