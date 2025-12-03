using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Gabo
{
    public partial class Form1 : Form
    {
        private const int NodeRadius = 24;
        private const int HorizontalSpacing = 40;
        private const int VerticalSpacing = 90;
        private const int CanvasMargin = 40;
        private const int AnimationIntervalMs = 650;

        private readonly Timer _animacionTimer;
        private readonly List<TreeNodeModel> _recorridoAnimado = new List<TreeNodeModel>();

        private TreeNodeModel _currentRoot;
        private int _indiceRecorrido = -1;
        private int _canvasWidth;
        private int _canvasHeight;

        private enum TraversalMethod
        {
            Preorden,
            Inorden,
            Postorden
        }

        public Form1()
        { 
            InitializeComponent();

            //esta linea es para poder acceder a picLienzo y puede ejecutar el codigo, debido a que no puedo acceder desde el diseño
            picLienzo.MouseClick += picLienzo_MouseClick;
            picLienzo.MouseMove += picLienzo_MouseMove;
            //termina

            _animacionTimer = new Timer { Interval = AnimationIntervalMs };
            _animacionTimer.Tick += AnimacionTimer_Tick;

            txtNodos.Text = "F,B,G,A,D,I,C,E,H";
            ProcesarEntrada();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _animacionTimer?.Dispose();
            base.OnFormClosed(e);
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            ProcesarEntrada();
        }

        private void MetodoRecorrido_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                ProcesarEntrada();
            }
        }

        private void ProcesarEntrada()
        {
            ResetAnimacion();

            try
            {
                var valores = ParseInput();
                if (!valores.Any())
                {
                    ClearCanvas();
                    MostrarEstado("Ingresa al menos un nodo separado por comas.", true);
                    return;
                }

                var metodo = ObtenerMetodoSeleccionado();

                _currentRoot = BuildBalancedStructure(valores, 0);
                //AsignarValoresPorRecorrido(_currentRoot, valores, metodo);

                RenderTree(valores.Count);

                var recorridoNodos = ObtenerRecorridoNodos(_currentRoot, metodo).ToList();
                ActualizarRecorrido(recorridoNodos);
                IniciarAnimacionVisual(recorridoNodos);
            }
            catch (Exception ex)
            {
                ClearCanvas();
                MostrarEstado($"Ocurrió un problema al generar el árbol: {ex.Message}", true);
            }
        }

        private TraversalMethod ObtenerMetodoSeleccionado()
        {
            if (rdbInorden.Checked)
            {
                return TraversalMethod.Inorden;
            }

            if (rdbPostorden.Checked)
            {
                return TraversalMethod.Postorden;
            }

            return TraversalMethod.Preorden;
        }

        private List<string> ParseInput()
        {
            return txtNodos.Text
                //.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Split(new[] { ',' })
                .Select(token => token.Trim())
                .Where(token => !string.IsNullOrWhiteSpace(token))
                .ToList();
        }

        private TreeNodeModel BuildBalancedStructure(List<string> valores, int index)
        {
            if (index >= valores.Count || valores[index] == "-")
            {
                return null;
            }

            var node = new TreeNodeModel(valores[index]);
            node.Index = index;

            //hijo izquierdo = 2 * indice + 1
            //hijo derecho   = 2 * indice + 2
            node.Left = BuildBalancedStructure(valores, 2 * index + 1);
            node.Right = BuildBalancedStructure(valores, 2 * index + 2);

            return node;
        }
        
        //ya no hace falta este constructor,
        //en el nuevo buildbalancedstructure construye el arbol con los valores del nuevo metodo
        /*private void AsignarValoresPorRecorrido(TreeNodeModel root, IList<string> valores, TraversalMethod metodo)
        {
            int indice = 0;

            switch (metodo)
            {
                case TraversalMethod.Inorden:
                    AsignarInorden(root, valores, ref indice);
                    break;
                case TraversalMethod.Postorden:
                    AsignarPostorden(root, valores, ref indice);
                    break;
                default:
                    AsignarPreorden(root, valores, ref indice);
                    break;
            }
        }

        private void AsignarPreorden(TreeNodeModel node, IList<string> valores, ref int indice)
        {
            if (node == null)
            {
                return;
            }

            node.Index = indice;
            node.Value = valores[indice++];
            AsignarPreorden(node.Left, valores, ref indice);
            AsignarPreorden(node.Right, valores, ref indice);
        }

        private void AsignarInorden(TreeNodeModel node, IList<string> valores, ref int indice)
        {
            if (node == null)
            {
                return;
            }

            AsignarInorden(node.Left, valores, ref indice);
            node.Index = indice;
            node.Value = valores[indice++];
            AsignarInorden(node.Right, valores, ref indice);
        }

        private void AsignarPostorden(TreeNodeModel node, IList<string> valores, ref int indice)
        {
            if (node == null)
            {
                return;
            }

            AsignarPostorden(node.Left, valores, ref indice);
            AsignarPostorden(node.Right, valores, ref indice);
            node.Index = indice;
            node.Value = valores[indice++];
        }*/

        private void RenderTree(int totalNodos)
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

            _canvasWidth = Math.Max(maximoEnNivel * espacioNodo + CanvasMargin * 2, Math.Max(320, panelLienzo.ClientSize.Width - 20));
            _canvasHeight = altura * VerticalSpacing + CanvasMargin * 2;

            AssignPositions(_currentRoot, CanvasMargin, _canvasWidth - CanvasMargin, 0);
            Redibujar();

            MostrarEstado($"Árbol balanceado con {totalNodos} nodos y {altura} niveles.", false);
        }

        private void Redibujar()
        {
            if (_currentRoot == null || _canvasWidth <= 0 || _canvasHeight <= 0)
            {
                ClearCanvas();
                return;
            }

            var bitmap = new Bitmap(_canvasWidth, _canvasHeight);
            using (var graficos = Graphics.FromImage(bitmap))
            {
                graficos.SmoothingMode = SmoothingMode.AntiAlias;
                graficos.Clear(Color.White);
                DrawEdges(graficos, _currentRoot);
                DrawNodes(graficos, _currentRoot);
            }

            var anterior = picLienzo.Image;
            picLienzo.Image = bitmap;
            anterior?.Dispose();
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
            using (var fondoNormal = new SolidBrush(Color.White))
            using (var fondoVisitado = new SolidBrush(Color.FromArgb(207, 226, 255)))
            using (var fondoActual = new SolidBrush(Color.FromArgb(255, 210, 130)))
            using (var fuente = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point))
            {
                DrawNodesInternal(graphics, node, borde, texto, fondoNormal, fondoVisitado, fondoActual, fuente);
            }
        }

        private void DrawNodesInternal(Graphics graphics, TreeNodeModel node, Pen borderPen, Brush textBrush, Brush normalBrush, Brush visitedBrush, Brush currentBrush, Font font)
        {
            if (node == null)
            {
                return;
            }

            DrawNodesInternal(graphics, node.Left, borderPen, textBrush, normalBrush, visitedBrush, currentBrush, font);

            var rect = new RectangleF(node.Position.X - NodeRadius, node.Position.Y - NodeRadius, NodeRadius * 2, NodeRadius * 2);
            var fill = node.IsCurrent ? currentBrush : node.IsVisited ? visitedBrush : normalBrush;
            graphics.FillEllipse(fill, rect);
            graphics.DrawEllipse(borderPen, rect);

            var size = graphics.MeasureString(node.Value, font);
            var textLocation = new PointF(node.Position.X - size.Width / 2f, node.Position.Y - size.Height / 2f);
            graphics.DrawString(node.Value, font, textBrush, textLocation);

            DrawNodesInternal(graphics, node.Right, borderPen, textBrush, normalBrush, visitedBrush, currentBrush, font);
        }

        private int GetHeight(TreeNodeModel node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
        }

        private void AnimacionTimer_Tick(object sender, EventArgs e)
        {
            if (_recorridoAnimado.Count == 0)
            {
                _animacionTimer.Stop();
                return;
            }

            if (_indiceRecorrido >= 0 && _indiceRecorrido < _recorridoAnimado.Count)
            {
                var previo = _recorridoAnimado[_indiceRecorrido];
                previo.IsVisited = true;
                previo.IsCurrent = false;
            }

            _indiceRecorrido++;

            if (_indiceRecorrido >= _recorridoAnimado.Count)
            {
                Redibujar();
                MostrarEstado("Recorrido completado.", false);
                _animacionTimer.Stop();
                return;
            }

            var actual = _recorridoAnimado[_indiceRecorrido];
            actual.IsCurrent = true;
            Redibujar();
            MostrarEstado($"Paso {_indiceRecorrido + 1}/{_recorridoAnimado.Count}: {actual.Value}", false);
        }

        private void IniciarAnimacionVisual(IList<TreeNodeModel> recorrido)
        {
            _animacionTimer.Stop();
            ResetEstados(_currentRoot);
            _recorridoAnimado.Clear();
            _recorridoAnimado.AddRange(recorrido);
            _indiceRecorrido = -1;

            if (_recorridoAnimado.Count == 0)
            {
                Redibujar();
                return;
            }

            _animacionTimer.Start();
            AnimacionTimer_Tick(this, EventArgs.Empty);
        }

        private void ResetEstados(TreeNodeModel node)
        {
            if (node == null)
            {
                return;
            }

            node.IsVisited = false;
            node.IsCurrent = false;

            ResetEstados(node.Left);
            ResetEstados(node.Right);
        }

        private void ResetAnimacion()
        {
            _animacionTimer.Stop();
            _recorridoAnimado.Clear();
            _indiceRecorrido = -1;
            ResetEstados(_currentRoot);
        }

        private IEnumerable<TreeNodeModel> ObtenerRecorridoNodos(TreeNodeModel root, TraversalMethod metodo)
        {
            var lista = new List<TreeNodeModel>();

            switch (metodo)
            {
                case TraversalMethod.Inorden:
                    RecorridoInorden(root, lista);
                    break;
                case TraversalMethod.Postorden:
                    RecorridoPostorden(root, lista);
                    break;
                default:
                    RecorridoPreorden(root, lista);
                    break;
            }

            return lista;
        }

        private void RecorridoPreorden(TreeNodeModel node, IList<TreeNodeModel> lista)
        {
            if (node == null)
            {
                return;
            }

            lista.Add(node);
            RecorridoPreorden(node.Left, lista);
            RecorridoPreorden(node.Right, lista);
        }

        private void RecorridoInorden(TreeNodeModel node, IList<TreeNodeModel> lista)
        {
            if (node == null)
            {
                return;
            }

            RecorridoInorden(node.Left, lista);
            lista.Add(node);
            RecorridoInorden(node.Right, lista);
        }

        private void RecorridoPostorden(TreeNodeModel node, IList<TreeNodeModel> lista)
        {
            if (node == null)
            {
                return;
            }

            RecorridoPostorden(node.Left, lista);
            RecorridoPostorden(node.Right, lista);
            lista.Add(node);
        }

        private void ActualizarRecorrido(IList<TreeNodeModel> recorrido)
        {
            if (recorrido == null || recorrido.Count == 0)
            {
                txtRecorrido.Clear();
                return;
            }

            txtRecorrido.Text = string.Join(", ", recorrido.Select(n => n.Value));
        }

        private void ClearCanvas()
        {
            _animacionTimer.Stop();

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

        private sealed class TreeNodeModel
        {
            public TreeNodeModel(string value)
            {
                Value = value;
            }

            public string Value { get; set; }
            public TreeNodeModel Left { get; set; }
            public TreeNodeModel Right { get; set; }
            public PointF Position { get; set; }
            public bool IsVisited { get; set; }
            public bool IsCurrent { get; set; }

            //index para efectuar los cambios de arbol
            public int Index { get; set; }
        }

        //Lo nuevo que agregue
        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
           
                openFileDialog.Filter = "archivo de texto (*.txt)|*.txt|todos los archivos (*.*)|*.*";
                openFileDialog.Title = "seleccionar archivo de arbol";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string contenido = File.ReadAllText(openFileDialog.FileName);
                     
                        txtNodos.Text = contenido;

                        ProcesarEntrada();

                        MostrarEstado("archivo cargado correctamente.", false);
                    }
                    catch (Exception ex)
                    {
                        MostrarEstado($"error al leer el archivo: {ex.Message}", true);
                    }
                }
            }
        }
     
        private void picLienzo_MouseClick(object sender, MouseEventArgs e)
        {
            var listaNodos = ParseInput();
            if (listaNodos == null) listaNodos = new List<string>();

            var nodoTocado = BuscarNodoClickeado(_currentRoot, e.Location);

            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new ContextMenuStrip();

                if (nodoTocado != null)
                {
                    
                    menu.Items.Add("Editar Valor", null, (s, args) => {
                        int start = 0;
                        for (int i = 0; i < nodoTocado.Index; i++)
                            start += (i < listaNodos.Count ? listaNodos[i].Length : 1) + 1;

                        txtNodos.Focus();
                        if (start < txtNodos.TextLength)
                            txtNodos.Select(start, listaNodos[nodoTocado.Index].Length);
                    });

                    menu.Items.Add("Eliminar", null, (s, args) => {
                        if (nodoTocado.Index < listaNodos.Count)
                        {
                            listaNodos[nodoTocado.Index] = "-"; // Lo volvemos hueco
                            ActualizarArbolDesdeLista(listaNodos); // Esto limpia y actualiza
                        }
                    });

                    menu.Items.Add(new ToolStripSeparator());

                    //agregar izquierda
                    int indiceIzq = 2 * nodoTocado.Index + 1;
                    bool ocupadoIzq = indiceIzq < listaNodos.Count && listaNodos[indiceIzq] != "-";

                    var itemIzq = menu.Items.Add("Agregar Izquierda", null, (s, args) => {
                        AgregarNodoEnIndice(listaNodos, indiceIzq);
                    });
                    itemIzq.Enabled = !ocupadoIzq;

                    //agregar derecha
                    int indiceDer = 2 * nodoTocado.Index + 2;
                    bool ocupadoDer = indiceDer < listaNodos.Count && listaNodos[indiceDer] != "-";

                    var itemDer = menu.Items.Add("Agregar Derecha", null, (s, args) => {
                        AgregarNodoEnIndice(listaNodos, indiceDer);
                    });
                    itemDer.Enabled = !ocupadoDer;
                }
                else
                {
                    //fondo
                    bool arbolVacio = listaNodos.Count == 0 || listaNodos.All(n => n == "-");
                    if (arbolVacio)
                    {
                        menu.Items.Add("Crear Raíz", null, (s, args) => {
                            listaNodos.Clear();
                            listaNodos.Add("A");
                            ActualizarArbolDesdeLista(listaNodos);
                        });
                    }
                    else
                    {
                        menu.Items.Add("Limpiar Huecos (Compactar)", null, (s, args) => {
                            listaNodos.RemoveAll(n => n == "-");
                            ActualizarArbolDesdeLista(listaNodos);
                        });
                    }
                }
                menu.Show(picLienzo, e.Location);
            }
        }

        private void AgregarNodoEnIndice(List<string> lista, int indiceObjetivo)
        {
          
            while (lista.Count <= indiceObjetivo)
            {
                lista.Add("-");
            }

            char nuevaLetra = 'A';

            var nodosReales = lista.Where(x => x != "-" && x.Length > 0).ToList();

            if (nodosReales.Count > 0)
            {
                string ultimo = nodosReales.Last();

                if (int.TryParse(ultimo, out int num))
                {
                    nuevaLetra = (char)('0' + num + 1);
                    if (num >= 9) nuevaLetra = 'A';
                    else lista[indiceObjetivo] = (num + 1).ToString();
                }
                else
                {
                    char ultimaChar = ultimo[0];
                    if (ultimaChar >= 'Z') nuevaLetra = 'A';
                    else nuevaLetra = (char)(ultimaChar + 1);
                }
            }

            if (lista[indiceObjetivo] == "-")
            {
                if (!int.TryParse(nodosReales.LastOrDefault() ?? "0", out _))
                    lista[indiceObjetivo] = nuevaLetra.ToString();
            }

            ActualizarArbolDesdeLista(lista);
        }

        private void TrimLista(List<string> lista)
        { 
            while (lista.Count > 0 && lista[lista.Count - 1] == "-")
            {
                lista.RemoveAt(lista.Count - 1);
            }
        }

        private void ActualizarArbolDesdeLista(List<string> lista)
        {
            TrimLista(lista);
            txtNodos.Text = string.Join(",", lista);
            ProcesarEntrada();
        }

        private TreeNodeModel BuscarNodoClickeado(TreeNodeModel node, PointF mousePos)
        {
            if (node == null) return null;

            float radioSensible = NodeRadius + 5;

            float dx = node.Position.X - mousePos.X;
            float dy = node.Position.Y - mousePos.Y;

            if (dx * dx + dy * dy <= radioSensible * radioSensible)
            {
                return node;
            }

            var izq = BuscarNodoClickeado(node.Left, mousePos);
            if (izq != null) return izq;

            return BuscarNodoClickeado(node.Right, mousePos);
        }

        private void picLienzo_MouseMove(object sender, MouseEventArgs e)
        {
            var nodoBajoMouse = BuscarNodoClickeado(_currentRoot, e.Location);

            if (nodoBajoMouse != null)
            {
                picLienzo.Cursor = Cursors.Hand;
            }
            else
            {
                picLienzo.Cursor = Cursors.Cross;
            }
        }
    }
}