using Ada369Csharp.CONEXION;
using Ada369Csharp.Logica;
using RestCsharp.Presentacion.Licencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ada369Csharp.Datos
{
    public class Dusuarios
    {
        //public void mostrarUsuario(ref DataTable dt)
        //{
        //    try
        //    {
        //        CONEXIONMAESTRA.abrir();
        //        SqlDataAdapter da = new SqlDataAdapter("mostrar_usuario", CONEXIONMAESTRA.conectar);
        //        da.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.StackTrace);
        //    }
        //    finally
        //    {
        //        CONEXIONMAESTRA.cerrar();
        //    }
        //}
        //public bool InsertarUsuarios(Lusuarios parametros)
        //{
        //    try
        //    {
        //        CONEXIONMAESTRA.abrir();
        //        SqlCommand cmd = new SqlCommand("insertar_usuario", CONEXIONMAESTRA.conectar);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@nombres", parametros.Nombres_y_Apellidos);
        //        cmd.Parameters.AddWithValue("@Login", parametros.Login);
        //        cmd.Parameters.AddWithValue("@Password", parametros.Password);
        //        cmd.Parameters.AddWithValue("@Nombre_de_icono", parametros.Nombre_de_icono);
        //        cmd.Parameters.AddWithValue("@Correo", "-");
        //        cmd.Parameters.AddWithValue("@Rol", parametros.Rol);
        //        cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
        //        cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        CONEXIONMAESTRA.cerrar();
        //    }
        //}
        //public bool editarUsuario(Lusuarios parametros)
        //{
        //    try
        //    {
        //        CONEXIONMAESTRA.abrir();
        //        SqlCommand cmd = new SqlCommand("editar_usuario", CONEXIONMAESTRA.conectar);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idUsuario", parametros.idUsuario);
        //        cmd.Parameters.AddWithValue("@nombres", parametros.Nombres_y_Apellidos);
        //        cmd.Parameters.AddWithValue("@Login", parametros.Login);
        //        cmd.Parameters.AddWithValue("@Password", parametros.Password);
        //        cmd.Parameters.AddWithValue("@Nombre_de_icono", parametros.Nombre_de_icono);
        //        cmd.Parameters.AddWithValue("@Correo", parametros.Correo);
        //        cmd.Parameters.AddWithValue("@Rol", parametros.Rol);
        //        cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        CONEXIONMAESTRA.cerrar();
        //    }
        //}
        //public bool eliminarUsuario(Lusuarios parametros)
        //{
        //    try
        //    {
        //        CONEXIONMAESTRA.abrir();
        //        SqlCommand cmd = new SqlCommand("eliminar_usuario", CONEXIONMAESTRA.conectar);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@idusuario", parametros.idUsuario);
        //        cmd.Parameters.AddWithValue("@login", parametros.Login);

        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        CONEXIONMAESTRA.cerrar();
        //    }
        //}
        //public void buscarUsuario(ref DataTable dt,string buscador)
        //{
        //    try
        //    {
        //        CONEXIONMAESTRA.abrir();
        //        SqlDataAdapter da = new SqlDataAdapter("buscar_usuario", CONEXIONMAESTRA.conectar);
        //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
        //        da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
        //        da.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.StackTrace);
        //    }
        //    finally
        //    {
        //        CONEXIONMAESTRA.cerrar();
        //    }
        //}
        int idusuario;
        string resultadoLic;
        string tipocaja;
        public bool editar_Usuarios(Lusuarios parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("editar_usuario", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdUsuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Login", parametros.Login);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
                cmd.Parameters.AddWithValue("@Correo", parametros.Correo);
                cmd.Parameters.AddWithValue("@Rol", parametros.Rol);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool eliminar_Usuarios(Lusuarios parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("eliminar_usuario", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", parametros.IdUsuario);
                cmd.Parameters.AddWithValue("@login", parametros.Login);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public bool restaurar_usuario(Lusuarios parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("restaurar_usuario", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idusuario", parametros.IdUsuario);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        public void mostrar_Usuarios(ref DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("mostrar_Usuarios", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void buscar_usuarios(ref DataTable dt, string buscador)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscar_usuarios", CONEXIONMAESTRA.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@buscador", buscador);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void ObtenerIdUsuario(ref int idusuario, string Login)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("ObtenerIdUsuario", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@Login", Login);
                idusuario = Convert.ToInt32(da.ExecuteScalar());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public bool InsertarUsuarios(Lusuarios parametros)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("insertar_Usuarios", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
                cmd.Parameters.AddWithValue("@Login", parametros.Login);
                cmd.Parameters.AddWithValue("@Password", parametros.Password);
                cmd.Parameters.AddWithValue("@Icono", parametros.Icono);
                cmd.Parameters.AddWithValue("@Correo", parametros.Correo);
                cmd.Parameters.AddWithValue("@Rol", parametros.Rol);
                cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }

        }
        private void Mostrartipocaja()
        {
            var funcion = new Dcaja();
            var dt = new DataTable();
            funcion.mostrarCajaSerialTable(ref dt);
            tipocaja = dt.Rows[0][1].ToString();

        }
        public void licenciasExtras(ref string resultado, ref Panel panel)
        {
            var funcion = new Dlicencias();
            Mostrartipocaja();
            if (tipocaja != "PRINCIPAL")
            {
                resultado = "NO APLICA";
            }
            else
            {
                if (funcion.ValidarLicencias(ref resultadoLic) == true)
                {
                    resultado = resultadoLic;
                }
                else
                {
                    var ctl = new Licencias();
                    ctl.Dock = DockStyle.Fill;
                    panel.Dock = DockStyle.Fill;
                    panel.Controls.Add(ctl);
                    panel.BringToFront();
                }
            }

        }
        public void dibujarUsuarios(ref DataTable dt, ref string resultado, ref Panel panel)
        {
            var funcion = new Dlicencias();
            Mostrartipocaja();
            if (tipocaja != "PRINCIPAL")
            {
                mostrarUsuarios(dt);
            }
            else
            {
                if (funcion.ValidarLicencias(ref resultadoLic) == true)
                {
                    resultado = resultadoLic;
                    mostrarUsuarios(dt);
                }
                else
                {
                    var ctl = new Licencias();
                    ctl.Dock = DockStyle.Fill;
                    panel.Dock = DockStyle.Fill;
                    panel.Controls.Add(ctl);
                    panel.BringToFront();
                }
            }


        }
        private void mostrarUsuarios(DataTable dt)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlDataAdapter da = new SqlDataAdapter("Select * from USUARIO2 where Estado='ACTIVO' and Rol<>'Cliente'", CONEXIONMAESTRA.conectar);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }
        public void validarUsuario(Lusuarios parametros, ref int id)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand cmd = new SqlCommand("validar_usuario", CONEXIONMAESTRA.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@password", parametros.Password);
                cmd.Parameters.AddWithValue("@login", parametros.Login);
                id = Convert.ToInt32(cmd.ExecuteScalar());


            }
            catch (Exception ex)
            {
                id = 0;

            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }
        }

        public void mostrarRoles(Lusuarios parametros, ref string rol)
        {
            try
            {
                CONEXIONMAESTRA.abrir();
                SqlCommand da = new SqlCommand("mostrarRoles", CONEXIONMAESTRA.conectar);
                da.CommandType = CommandType.StoredProcedure;
                da.Parameters.AddWithValue("@idusario", parametros.IdUsuario);
                rol = da.ExecuteScalar().ToString();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                CONEXIONMAESTRA.cerrar();
            }


        }
    }
}
