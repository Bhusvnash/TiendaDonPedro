using COMPLETE_FLAT_UI.BackEnd;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
		public partial class FrmMenuPrincipal : Form
		{
				//Constructor
				public FrmMenuPrincipal()
				{
						InitializeComponent();
						//Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
						this.SetStyle(ControlStyles.ResizeRedraw, true);
						this.DoubleBuffered = true;
				}

				//METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
				private int tolerance = 15;

				private const int WM_NCHITTEST = 132;
				private const int HTBOTTOMRIGHT = 17;
				private Rectangle sizeGripRectangle;
				private Usuario sesion = Func_Login.Sesion;

				protected override void WndProc(ref Message m)
				{
						switch (m.Msg)
						{
								case WM_NCHITTEST:
										base.WndProc(ref m);
										var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
										if (sizeGripRectangle.Contains(hitPoint))
												m.Result = new IntPtr(HTBOTTOMRIGHT);
										break;

								default:
										base.WndProc(ref m);
										break;
						}
				}

				//----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL
				protected override void OnSizeChanged(EventArgs e)
				{
						base.OnSizeChanged(e);
						var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

						sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

						region.Exclude(sizeGripRectangle);
						this.panelContenedorPrincipal.Region = region;
						this.Invalidate();
				}

				//----------------COLOR Y GRIP DE RECTANGULO INFERIOR
				protected override void OnPaint(PaintEventArgs e)
				{
						SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
						e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

						base.OnPaint(e);
						ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
				}

				//METODO PARA ARRASTRAR EL FORMULARIO---------------------------------------------------------------------
				[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
				private static extern void ReleaseCapture();

				[DllImport("user32.DLL", EntryPoint = "SendMessage")]
				private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

				private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
				{
						ReleaseCapture();
						SendMessage(this.Handle, 0x112, 0xf012, 0);
				}

				//METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
				private int lx, ly;

				private int sw, sh;

				private void btnMaximizar_Click(object sender, EventArgs e)
				{
						lx = this.Location.X;
						ly = this.Location.Y;
						sw = this.Size.Width;
						sh = this.Size.Height;
						int largopant = Screen.PrimaryScreen.Bounds.Height;
						this.Size = Screen.PrimaryScreen.WorkingArea.Size;
						this.Location = Screen.PrimaryScreen.WorkingArea.Location;
						if (largopant <= 600)
						{
								BtnSalir.Location = new Point(3, 440);
						}
						if (largopant > 600)
						{
								BtnSalir.Location = new Point(3, largopant - 150);
						}
						btnMaximizar.Visible = false;
						btnNormal.Visible = true;
				}

				private void btnNormal_Click(object sender, EventArgs e)
				{
						this.Size = new Size(1100, 550);
						this.Location = new Point(lx, ly);
						int largopant = Screen.PrimaryScreen.Bounds.Height;
						BtnSalir.Location = new Point(3, 440);
						btnNormal.Visible = false;
						btnMaximizar.Visible = true;
				}

				private void btnMinimizar_Click(object sender, EventArgs e)
				{
						this.WindowState = FormWindowState.Minimized;
				}

				private void btnCerrar_Click(object sender, EventArgs e)
				{
						if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
								Application.Exit();
						}
				}

				//METODOS PARA ANIMACION DE MENU SLIDING--
				private void btnMenu_Click(object sender, EventArgs e)
				{
						//-------CON EFECTO SLIDING
						if (panelMenu.Width == 200)
						{
								this.tmContraerMenu.Start();
						}
						else if (panelMenu.Width == 55)
						{
								this.tmExpandirMenu.Start();
						}

						////-------SIN EFECTO
						//if (panelMenu.Width == 55)
						//{
						//    panelMenu.Width = 200;
						//}
						//else

						//    panelMenu.Width = 55;
				}

				private void tmExpandirMenu_Tick(object sender, EventArgs e)
				{
						if (panelMenu.Width >= 200)
								this.tmExpandirMenu.Stop();
						else
								panelMenu.Width = panelMenu.Width + 5;
				}

				private void tmContraerMenu_Tick(object sender, EventArgs e)
				{
						if (panelMenu.Width <= 55)
								this.tmContraerMenu.Stop();
						else
								panelMenu.Width = panelMenu.Width - 5;
				}

				//METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
				private void AbrirFormEnPanel(object formHijo)
				{
						if (this.panelContenedorForm.Controls.Count > 0)
								this.panelContenedorForm.Controls.RemoveAt(0);
						Form fh = formHijo as Form;
						fh.TopLevel = false;
						fh.FormBorderStyle = FormBorderStyle.None;
						fh.Dock = DockStyle.Fill;
						this.panelContenedorForm.Controls.Add(fh);
						this.panelContenedorForm.Tag = fh;
						fh.Show();
				}

				//METODO PARA MOSTRAR FORMULARIO DE LOGO Al INICIAR ----------------------------------------------------------
				private void MostrarFormLogo()
				{
						AbrirFormEnPanel(new FrmLogo());
				}

				private void FormMenuPrincipal_Load(object sender, EventArgs e)
				{
						MostrarFormLogo();
						Lbl_Usuario_Apellido.Text = sesion.apellido_usuario;
						Lbl_Usuario_Nombre.Text = sesion.nombre_usuario;
				}

				//METODO PARA MOSTRAR FORMULARIO DE LOGO Al CERRAR OTROS FORM ----------------------------------------------------------
				private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
				{
						MostrarFormLogo();
				}

				private void BtnUsuarios_Click(object sender, EventArgs e)
				{
						FrmLista fm = new FrmLista();
						fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
						fm.LblTitulo.Text = "Lista de Usuarios";
						fm.verUsuarios();
						AbrirFormEnPanel(fm);
				}

				private void BtnProductos_Click(object sender, EventArgs e)
				{
						FrmLista fm = new FrmLista();
						fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
						fm.LblTitulo.Text = "Lista de Productos";
						AbrirFormEnPanel(fm);
				}

				private void FormMenuPrincipal_Resize(object sender, EventArgs e)
				{
						int largoform = this.Height;
						BtnSalir.Location = new Point(3, largoform - 110);
				}

				private void BtnCategorias_Click(object sender, EventArgs e)
				{
						FrmLista fm = new FrmLista();
						fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
						fm.LblTitulo.Text = "Lista de Categorias";
						AbrirFormEnPanel(fm);
				}

				private void BtnReportes_Click(object sender, EventArgs e)
				{
						//ventas del mes
						//ventas por cajera
						//ventas por fecha
						//Grafica de Ventas
						MessageBox.Show("Se deben hacer estas consultas");
				}

				private void BtnSalir_Click(object sender, EventArgs e)
				{
						if (MessageBox.Show("¿Está seguro de cerrar?", "Alerta¡¡", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
								Application.Exit();
						}
				}

				private void BtnFacturas_Click(object sender, EventArgs e)
				{
						FrmFacturaEnc fm = new FrmFacturaEnc();
						fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
						AbrirFormEnPanel(fm);
				}

				//METODOS PARA ABRIR OTROS FORMULARIOS Y MOSTRAR FORM DE LOGO Al CERRAR ----------------------------------------------------------
				private void btnListaClientes_Click(object sender, EventArgs e)
				{
						FrmLista fm = new FrmLista();
					//	fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
						fm.LblTitulo.Text = "Lista de Clientes";
						fm.DGVDatos.DataSource = Func_Clientes.GetClientes();
						fm.DGVDatos.ReadOnly = true;
						// Ocultar columnas
						fm.DGVDatos.Columns["id_cliente"].Visible = false;
						// Cambiar títulos
						fm.DGVDatos.Columns["nombre_cliente"].HeaderText = "Nombre";
						fm.DGVDatos.Columns["direccion_cliente"].HeaderText = "Direccion";
						fm.DGVDatos.Columns["email_cliente"].HeaderText = "Email";
						fm.DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
						AbrirFormEnPanel(fm);
						
				}

				//METODO PARA HORA Y FECHA ACTUAL ----------------------------------------------------------
				private void tmFechaHora_Tick(object sender, EventArgs e)
				{
						lbFecha.Text = DateTime.Now.ToLongDateString();
						lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
				}
		}
}