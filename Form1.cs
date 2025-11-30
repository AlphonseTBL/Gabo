using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace Gabo
{
    public partial class Form1 : Form
    {
        private const int NodeRadius = 24;
        private const int HorizontalSpacing = 40;
        private const int VerticalSpacing = 90;
        private const int CanvasMargin = 40;

        private TreeNodeModel _currentRoot;

        public Form1()
        {
            InitializeComponent();
            txtNodos.Text = "F,B,G,A,D,I,C,E,H";
            ProcesarEntrada();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ProcesarEntrada();
        }

        private void MetodoRecorrido_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton radioButton) || !radioButton.Checked)
            {
                return;
            }

            ActualizarRecorrido();
        }

        private void ProcesarEntrada()
        {
            try
            {
                var valores = ParseInput();
                if (!valores.Any())
                {
                    ClearCanvas();
                    MostrarEstado("Ingresa al menos un nodo separado por comas.", true);
                    return;
                }

                var valoresUnicos = valores
                    .Distinct(StringComparer.OrdinalIgnoreCase)
                    .ToList();

                bool seOmitieronDuplicados = valoresUnicos.Count != valores.Count;

                var ordenados = valoresUnicos
                    .OrderBy(v => v, StringComparer.OrdinalIgnoreCase)
                    .ToList();

                _currentRoot = BuildBalanced(ordenados, 0, ordenados.Count - 1);
                RenderTree(valoresUnicos.Count, seOmitieronDuplicados);
            }
            catch (Exception ex)
            {
                ClearCanvas();
                MostrarEstado($"Ocurrió un problema al generar el árbol: {ex.Message}", true);
            }
        }

        private List<string> ParseInput()
        {
            return txtNodos.Text
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(token => token.Trim())
                .Where(token => !string.IsNullOrWhiteSpace(token))
                .ToList();
        }

        private TreeNodeModel BuildBalanced(IList<string> valores, int inicio, int fin)
        {
            if (inicio > fin)
            {
                return null;
            }

            int medio = (inicio + fin) / 2;
            var nodo = new TreeNodeModel(valores[medio]);
            nodo.Left = BuildBalanced(valores, inicio, medio - 1);
            nodo.Right = BuildBalanced(valores, medio + 1, fin);
            return nodo;
        }

        private void RenderTree(int totalNodos, bool seOmitieronDuplicados)
        {
            if (_currentRoot == null)
            {
                ClearCanvas();
                MostrarEstado("No hay nodos para dibujar.", true);
                return;
            }

            int altura = GetHeight(_currentRoot);
            int maximoEnNivel = (int)Math.Pow(2, Math.Max(0, altura - 1));
            int espacioNodo = NodeRadius * 2 + HorizontalSpacing;
            int ancho = Math.Max(maximoEnNivel * espacioNodo + CanvasMargin * 2, Math.Max(320, panelLienzo.ClientSize.Width - 20));
            int alto = altura * VerticalSpacing + CanvasMargin * 2;

            AssignPositions(_currentRoot, CanvasMargin, ancho - CanvasMargin, 0);

            var bitmap = new Bitmap(ancho, alto);
            using (var graficos = Graphics.FromImage(bitmap))
            {
                graficos.SmoothingMode = SmoothingMode.AntiAlias;
                graficos.Clear(Color.White);
                DrawEdges(graficos, _currentRoot);
                DrawNodes(graficos, _currentRoot);
            }

            var imagenAnterior = picLienzo.Image;
            picLienzo.Image = bitmap;
            imagenAnterior?.Dispose();

            string mensaje = $"Árbol balanceado con {totalNodos} nodos y {altura} niveles.";
            if (seOmitieronDuplicados)
            {
                mensaje += " Se ignoraron duplicados para conservar la simetría.";
            }

            MostrarEstado(mensaje, false);
            ActualizarRecorrido();
        }

        private void AssignPositions(TreeNodeModel node, float leftBound, float rightBound, int depth)
        {
            if (node == null)
            {
                return;
            }

            float x = (leftBound + rightBound) / 2f;
            float y = CanvasMargin + depth * VerticalSpacing;
            node.Position = new PointF(x, y);

            AssignPositions(node.Left, leftBound, x, depth + 1);
            AssignPositions(node.Right, x, rightBound, depth + 1);
        }

        private void DrawEdges(Graphics graphics, TreeNodeModel node)
        {
            using (var pen = new Pen(Color.DarkGray, 2f))
            {
                pen.StartCap = LineCap.Round;
                pen.EndCap = LineCap.Round;
                DrawEdgesInternal(graphics, node, pen);
            }
        }

        private void DrawEdgesInternal(Graphics graphics, TreeNodeModel node, Pen pen)
        {
            if (node == null)
            {
                return;
            }

            if (node.Left != null)
            {
                graphics.DrawLine(pen, node.Position, node.Left.Position);
                DrawEdgesInternal(graphics, node.Left, pen);
            }

            if (node.Right != null)
            {
                graphics.DrawLine(pen, node.Position, node.Right.Position);
                DrawEdgesInternal(graphics, node.Right, pen);
            }
        }

        private void DrawNodes(Graphics graphics, TreeNodeModel node)
        {
            using (var borde = new Pen(Color.SteelBlue, 2f))
            using (var texto = new SolidBrush(Color.FromArgb(45, 45, 45)))
            using (var fondo = new SolidBrush(Color.White))
            using (var fuente = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point))
            {
                DrawNodesInternal(graphics, node, borde, fondo, texto, fuente);
            }
        }

        private void DrawNodesInternal(Graphics graphics, TreeNodeModel node, Pen borderPen, Brush fillBrush, Brush textBrush, Font font)
        {
            if (node == null)
            {
                return;
            }

            DrawNodesInternal(graphics, node.Left, borderPen, fillBrush, textBrush, font);

            var rect = new RectangleF(node.Position.X - NodeRadius, node.Position.Y - NodeRadius, NodeRadius * 2, NodeRadius * 2);
            graphics.FillEllipse(fillBrush, rect);
            graphics.DrawEllipse(borderPen, rect);

            var size = graphics.MeasureString(node.Value, font);
            var textLocation = new PointF(node.Position.X - size.Width / 2f, node.Position.Y - size.Height / 2f);
            graphics.DrawString(node.Value, font, textBrush, textLocation);

            DrawNodesInternal(graphics, node.Right, borderPen, fillBrush, textBrush, font);
        }

        private int GetHeight(TreeNodeModel node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        private void ClearCanvas()
        {
            if (picLienzo.Image != null)
            {
                picLienzo.Image.Dispose();
                picLienzo.Image = null;
            }

            txtRecorrido.Clear();
        }

        private void MostrarEstado(string mensaje, bool esError)
        {
            lblEstado.Text = mensaje;
            lblEstado.ForeColor = esError ? Color.Firebrick : Color.DimGray;
        }

        private void ActualizarRecorrido()
        {
            if (_currentRoot == null)
            {
                txtRecorrido.Clear();
                return;
            }

            txtRecorrido.Text = ObtenerRecorrido(_currentRoot);
        }

        private string ObtenerRecorrido(TreeNodeModel root)
        {
            var buffer = new List<string>();

            if (rdbInorden.Checked)
            {
                RecorridoInorden(root, buffer);
            }
            else if (rdbPostorden.Checked)
            {
                RecorridoPostorden(root, buffer);
            }
            else
            {
                RecorridoPreorden(root, buffer);
            }

            return string.Join(", ", buffer);
        }

        private void RecorridoPreorden(TreeNodeModel node, IList<string> buffer)
        {
            if (node == null)
            {
                return;
            }

            buffer.Add(node.Value);
            RecorridoPreorden(node.Left, buffer);
            RecorridoPreorden(node.Right, buffer);
        }

        private void RecorridoInorden(TreeNodeModel node, IList<string> buffer)
        {
            if (node == null)
            {
                return;
            }

            RecorridoInorden(node.Left, buffer);
            buffer.Add(node.Value);
            RecorridoInorden(node.Right, buffer);
        }

        private void RecorridoPostorden(TreeNodeModel node, IList<string> buffer)
        {
            if (node == null)
            {
                return;
            }

            RecorridoPostorden(node.Left, buffer);
            RecorridoPostorden(node.Right, buffer);
            buffer.Add(node.Value);
        }

        private sealed class TreeNodeModel
        {
            public TreeNodeModel(string value)
            {
                Value = value;
            }

            public string Value { get; }
            public TreeNodeModel Left { get; set; }
            public TreeNodeModel Right { get; set; }
            public PointF Position { get; set; }
        }
    }
}
