using System.Data;

namespace GraphManipulator
{
    public partial class GraphManipulatorForm : Form
    {
        private Graph Graph { get; set; }
        public GraphManipulatorForm()
        {
            Graph = new Graph();

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

        private void UpdateDgvAdjacencyListVertices()
        {
            List<string> vertices = Graph.GetAllVerticesNames();

            dgv_adjacencyListVertices.Rows.Clear();

            foreach (string vertex in vertices)
            {
                dgv_adjacencyListVertices.Rows.Add(vertex);
            }
        }

        private void UpdateDgvAdjacencyListEdges()
        {

        }

        #endregion

        #region Events
        private void btn_exhibitionModeList_Click(object sender, EventArgs e)
        {
            dgv_adjacencyMatrix.Visible = false;

            dgv_adjacencyListVertices.Visible = true;
            dgv_adjacencyListEdges.Visible = true;

            chb_directedGraph.Enabled = true;

            resetVertecesControls(true);
        }
        private void btn_exhibitionModeMatrix_Click(object sender, EventArgs e)
        {
            dgv_adjacencyListVertices.Visible = false;
            dgv_adjacencyListEdges.Visible = false;

            dgv_adjacencyMatrix.Visible = true;

            chb_directedGraph.Enabled = true;

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
                Graph.AddVertex(tb_av_vertexName.Text);

                lb_vertexReturn.Text = $"Vertice {tb_av_vertexName.Text} adicionado";

                tb_av_vertexName.Text = "";

                UpdateDgvAdjacencyListVertices();
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

                UpdateDgvAdjacencyListVertices();
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

                    UpdateDgvAdjacencyListEdges();
                }
                else
                {
                    lb_edgeReturn.Text = $"Erro ao adicionar aresta";
                }
            }
        }
        #endregion
    }
}