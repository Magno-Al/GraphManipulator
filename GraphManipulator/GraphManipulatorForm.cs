using System.Data;

namespace GraphManipulator
{
    public partial class GraphManipulatorForm : Form
    {
        private Graph Graph { get; set; }
        private int startVertices = 0;
        public GraphManipulatorForm()
        {
            InitializeComponent();
        }

        #region Methods
        private void resetVertecesControls(bool turnOn)
        {
            tb_av_vertexName.Enabled = turnOn;
            btn_av_addVertex.Enabled = turnOn;

            cb_rv_selectVertex.Enabled = turnOn;
        }

        private void ResetEdgesSelectionComboBox()
        {
            if (Graph.GetAllVerticesNames().Count > 0)
            {
                cb_selectPredecessorEdge.Enabled = true;
                cb_selectSucessorEdge.Enabled = true;
            }
            else
            {
                cb_selectPredecessorEdge.Enabled = false;
                cb_selectSucessorEdge.Enabled = false;
            }
        }

        private void ResetSelectVertexComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(Graph.GetAllVerticesNames().ToArray());
        }

        private void ResetAddEdgeButton()
        {
            if ((cb_selectPredecessorEdge.Text != null && cb_selectPredecessorEdge.Text != "") &&
                (cb_selectSucessorEdge.Text != null && cb_selectSucessorEdge.Text != ""))
            {
                btn_addEdge.Enabled = true;
            }
            else
            {
                btn_addEdge.Enabled = false;
            }
        }

        private void UpdateDgvAdjacencyList()
        {
            dgv_adjacencyList.Columns.Clear();
            dgv_adjacencyList.Rows.Clear();

            foreach (var vertex in Graph.AdjacencyList.Keys)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = vertex;
                dgv_adjacencyList.Columns.Add(column);
            }

            int columnIndex = 0;
            foreach (var vertex in Graph.AdjacencyList.Keys)
            {
                int rowIndex = 0;
                foreach (var neighbor in Graph.AdjacencyList[vertex])
                {
                    if (dgv_adjacencyList.Rows.Count < rowIndex + 1)
                        dgv_adjacencyList.Rows.Add();

                    dgv_adjacencyList.Rows[rowIndex].Cells[columnIndex].Value = neighbor;

                    rowIndex++;
                }
                columnIndex++;
            }
        }

        #endregion

        #region Events
        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (btn_Start.Text == "Start")
            {
                chb_directedGraph.Enabled = false;

                dgv_adjacencyList.Columns.Clear();
                dgv_adjacencyList.Rows.Clear();

                maskedTextBox1.Text = maskedTextBox1.Text.Length > 0 ? maskedTextBox1.Text : "0";

                int vertices = int.Parse(maskedTextBox1.Text);
                
                Graph = new Graph(vertices, chb_directedGraph.Checked);

                btn_exhibitionModeList.Enabled = true;
                btn_exhibitionModeMatrix.Enabled = true;

                if (vertices > 0)
                {
                    UpdateDgvAdjacencyList();
                    ResetEdgesSelectionComboBox();

                    dgv_adjacencyList.Visible = true;
                    dgv_adjacencyMatrix.Visible = false;

                    resetVertecesControls(true);
                }



                btn_Start.Text = "Reset";
            }
            else if (btn_Start.Text == "Reset")
            {
                chb_directedGraph.Checked = false;
                chb_directedGraph.Enabled = true;
                btn_Start.Text = "Start";

                btn_exhibitionModeList.Enabled = false;
                btn_exhibitionModeMatrix.Enabled = false;

                dgv_adjacencyList.Visible = false;
                dgv_adjacencyMatrix.Visible = false;

                tb_av_vertexName.Enabled = false;
                btn_av_addVertex.Enabled = false;

                maskedTextBox1.Text = "";

                cb_rv_selectVertex.Enabled = false;
                cb_rv_selectVertex.Items.Clear();
                cb_selectPredecessorEdge.Items.Clear();
                cb_selectSucessorEdge.Items.Clear();
            }

        }
        private void btn_exhibitionModeList_Click(object sender, EventArgs e)
        {
            dgv_adjacencyList.Visible = true;
            dgv_adjacencyMatrix.Visible = false;

            resetVertecesControls(true);
        }
        private void btn_exhibitionModeMatrix_Click(object sender, EventArgs e)
        {
            dgv_adjacencyList.Visible = false;
            dgv_adjacencyMatrix.Visible = true;

            resetVertecesControls(true);
        }

        private void btn_av_addVertex_Click(object sender, EventArgs e)
        {
            if (tb_av_vertexName.Text == null || tb_av_vertexName.Text == "")
            {
                lb_vertexReturn.Text = "Nome invalido";
            }
            else
            {
                Graph.AddVertex(tb_av_vertexName.Text, chb_directedGraph.Checked);

                lb_vertexReturn.Text = $"Vertice {tb_av_vertexName.Text} adicionado";

                tb_av_vertexName.Text = "";

                UpdateDgvAdjacencyList();
                ResetEdgesSelectionComboBox();
            }
        }

        private void cb_rv_selectVertex_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_rv_selectVertex);
        }
        private void cb_rv_selectVertex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_rv_selectVertex.Text != null && cb_rv_selectVertex.Text != "")
                btn_rv_removeVertex.Enabled = true;
        }

        private void btn_rv_removeVertex_Click(object sender, EventArgs e)
        {
            if (Graph.RemoveVertex(cb_rv_selectVertex.Text))
            {
                lb_vertexReturn.Text = $"Vertice {cb_rv_selectVertex.Text} removido";

                ResetSelectVertexComboBox(cb_rv_selectVertex);

                UpdateDgvAdjacencyList();
                ResetEdgesSelectionComboBox();
            }

            btn_rv_removeVertex.Enabled = false;
        }

        private void cb_selectPredecessorEdge_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_selectPredecessorEdge);
            ResetAddEdgeButton();
        }

        private void cb_selectSucessorEdge_DropDown(object sender, EventArgs e)
        {
            ResetSelectVertexComboBox(cb_selectSucessorEdge);
            ResetAddEdgeButton();
        }

        private void cb_selectPredecessorEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAddEdgeButton();
        }

        private void cb_selectSucessorEdge_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetAddEdgeButton();
        }

        private void btn_addEdge_Click(object sender, EventArgs e)
        {
            if (cb_selectPredecessorEdge.Text == null || cb_selectPredecessorEdge.Text == "")
            {
                lb_vertexReturn.Text = "Vertice predecessor invalido";
            }
            else if (cb_selectSucessorEdge.Text == null || cb_selectSucessorEdge.Text == "")
            {
                lb_vertexReturn.Text = "Vertice sucessor invalido";
            }
            else
            {
                if (Graph.AddEdge(cb_selectPredecessorEdge.Text, cb_selectSucessorEdge.Text))
                {
                    lb_edgeReturn.Text = $"Aresta {{{cb_selectPredecessorEdge.Text}, {cb_selectSucessorEdge.Text}}} adicionada";

                    ResetSelectVertexComboBox(cb_selectPredecessorEdge);
                    ResetSelectVertexComboBox(cb_selectSucessorEdge);

                    UpdateDgvAdjacencyList();
                }
                else
                {
                    lb_edgeReturn.Text = $"Erro ao adicionar aresta";
                }
            }
        }
        #endregion

        private void GraphManipulatorForm_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (int.TryParse(maskedTextBox1.Text, out int valor))
            {
                // Se a conversão for bem-sucedida, atualiza o valorDigitado
               startVertices = valor;
            }
            else
            {
                // Se a conversão falhar, pode lidar com isso aqui, se necessário
                // Por exemplo, pode definir um valor padrão ou exibir uma mensagem de erro
            }
        }
    }
}