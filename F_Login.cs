using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//System.Data.SqlClient.dl agregar en ensamblado

namespace Login
{
    public partial class F_Login : Form
    {
        public F_Login()
        {
            InitializeComponent();
            txt_ContraseñaLogin.PasswordChar = '•';
        }

        private void F_Login_Load(object sender, EventArgs e)
        {
            // -- Tamaño
            //this.Size = new Size(960, 600); //-- Estandar
            this.Size = new Size(360, 480);          //--Solo login
            //this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(450, 80);
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre, la contraseña y el rol ingresados por el usuario
            string usuario = txtUsuarioLogin.Text;
            string contraseña = txt_ContraseñaLogin.Text;
            string rol = cb_rolLogin.SelectedItem.ToString();

            ConexionBD D = new ConexionBD(); //lo que reconoce a la conexion con la base de datos
            D.abrir();

            // Llamar al método Login para obtener el resultado de la consulta
            SqlDataReader result = D.Login(usuario, contraseña, rol);

            // Verificar si la consulta devolvió algún resultado
            if (result.Read())
            {
                // El usuario existe y es válido
                // Obtener el rol del usuario
                rol = result["Rol_Usuario"].ToString();
                // Cerrar la conexión
                D.cerrar();
                // Abrir el formulario según el rol
                switch (rol)
                {
                    case "Administrador":

                        A1._1Adm_Inicio.F_admInicio fa = new A1._1Adm_Inicio.F_admInicio(); // namespace.nombredespuesdePublicpartialclass x
                        fa.Show();        // Muestra el formulario
                        this.Hide();     // Cierra el formulario actual
                        break;

                    case "Médico":
                        MedInicio.F_MedInicio fm = new MedInicio.F_MedInicio();
                        fm.Show();          // Muestra el formulario para inicio medico
                        this.Hide();
                        break;
                    case "Recepcionista":
                        RecepInicio.F_RecepInicio fr = new RecepInicio.F_RecepInicio();
                        fr.Show();        //Muestra el formulario para recepcionista
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Rol no válido.");
                        break;
                }

            }
            else
            {
                // El usuario no existe o es inválido
                MessageBox.Show("Nombre de usuario, contraseña o rol incorrectos.");
                // Limpiar los campos de texto
                txtUsuarioLogin.Clear();
                txt_ContraseñaLogin.Clear();
                cb_rolLogin.SelectedIndex = -1;
                // Enfocar el campo de nombre de usuario
                txtUsuarioLogin.Focus();
            }
        }
    }
}
