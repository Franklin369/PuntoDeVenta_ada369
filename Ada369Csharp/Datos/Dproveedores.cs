using Ada369Csharp.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ada369Csharp.CONEXION;
using Ada369Csharp.Logica;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ada369Csharp.Datos
{
  public  class Dproveedores
    {
        public bool insertar_Proveedores(Lproveedores parametros)
        {
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlCommand cmd = new SqlCommand("insertar_Proveedores", CONEXIONMAESTRA.conectar);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@Nombre", parametros.Nombre);
				cmd.Parameters.AddWithValue("@Direccion", parametros.Direccion);
				cmd.Parameters.AddWithValue("@IdentificadorFiscal", parametros.IdentificadorFiscal);
				cmd.Parameters.AddWithValue("@Celular", parametros.Celular);
				cmd.Parameters.AddWithValue("@Estado", "ACTIVO");
				cmd.Parameters.AddWithValue("@Saldo", 0);
				cmd.ExecuteNonQuery();
				return true;

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.StackTrace);
				return false;
			}
			finally
			{
				CONEXIONMAESTRA.cerrar();
			}
		}
		public void buscar_Proveedores(ref DataTable dt, string buscador)
		{
			try
			{
				CONEXIONMAESTRA.abrir();
				SqlDataAdapter da = new SqlDataAdapter("buscar_Proveedores", CONEXIONMAESTRA.conectar);
				da.SelectCommand.CommandType = CommandType.StoredProcedure;
				da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
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

	}
}
