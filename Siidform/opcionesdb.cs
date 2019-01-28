using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using System.Collections;
using Telerik.WinControls;

namespace Siidform
{
    class opcionesdb
    {
        private DataTable tabla;
        private SqlDataAdapter adaptador;
        private coneccionAbaseDeDatos con = new coneccionAbaseDeDatos();
        private SqlCommand comando = new SqlCommand();
        private SqlTransaction transaccion;
        Object returnValue;
        public void iniciarTransaccion()
        {
            try
            {

                transaccion = con.ConexBase.BeginTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no se ha podido iniciar en modo de transacciones" + ex.Message);
            }
        }

        public void CommitTransaccion()
        {
            try
            {
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar Commint en Transacciones" + ex.Message);
            }
        }
        public void RollbackTransaccion()
        {
            try
            {
                transaccion.Rollback();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar Rollback en Transacciones" + ex.Message);
            }
        }
        public void EliminarRegistro(String NomTabla, Hashtable crit)
        {
            try
            {

                int x = 0;
                con.conectar();
                string sql = "DELETE FROM " + NomTabla + " WHERE ";
                int i = 1;
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? " AND " : "") + r.Key + " = '" + r.Value + "'";
                    i++;
                }


                comando.Connection = con.ConexBase;
                comando.CommandText = sql;
                x = comando.ExecuteNonQuery();

                if (x > 0)
                {
                    //       MessageBox.Show("El registro ha sido eliminado exitosamente");
                }
                else
                {

                    MessageBox.Show("El registro  no ha sido eliminado exitosamente " + sql);
                    con.desconectar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro  no ha sido eliminado exitosamente " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }


        }
        public void InsertarRegistro(String nomTabla, Hashtable crit)
        {
            try
            {

                int x = 0;
                int i = 1;
                con.conectar();
                String sql = "INSERT INTO " + nomTabla + " (";
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? "," : "") + r.Key;
                    i++;
                }
                i = 1;
                sql = sql + ")VALUES(";
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? "," : "") + "'" + r.Value + "'";
                    i++;
                }
                sql += ")";
                //      MessageBox.Show("" + sql);

                comando.Connection = con.ConexBase;
                comando.CommandText = sql;
                x = comando.ExecuteNonQuery();
                if (x > 0)
                {
                    //       MessageBox.Show("El registro ha sido guardado exitosamente");
                }
                else
                {
                    MessageBox.Show("El registro  no ha sido guardado exitosamente");
                    con.desconectar();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("El registro  no ha sido guardado exitosamente " + ex.Message);
            }
            finally
            {

                con.desconectar();
            }

        }

        public void InsertarATabla(String nomTabla, Hashtable crit)
        {

            RadMessageBox.SetThemeName("TelerikMetroBlue");
            try
            {

                int x = 0;
                int i = 1;
                con.conectar();
                String sql = "INSERT INTO " + nomTabla + " (";
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? "," : "") + r.Key;
                    i++;
                }
                i = 1;
                sql = sql + ")VALUES(";
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? "," : "") + "'" + r.Value + "'";
                    i++;
                }
                sql += ")";


                comando.Connection = con.ConexBase;
                comando.CommandText = sql;
                x = comando.ExecuteNonQuery();
                Telerik.WinControls.RadMessageBox.Show("Informacion Registrada Exitosamente ");
                if (x > 0)
                {

                }
                else
                {
                    //MessageBox.Show("El registro  no ha sido guardado exitosamente");
                    con.desconectar();
                }

            }
            catch (Exception ex)
            {
                //RadMessageBox.SetThemeName("TelerikMetroBlue");
                //Telerik.WinControls.RadMessageBox.Show("El Dato que trata de agregar ya  existe ");
            }
            finally
            {

                con.desconectar();
            }

        }
        public void ModificarRegistro(String nomTabla, Hashtable crit, Hashtable reg)
        {
            RadMessageBox.SetThemeName("TelerikMetroBlue");
            try
            {
                int x = 0;
                int i = 1;
                con.conectar();
                String sql = "UPDATE " + nomTabla + " SET ";
                foreach (DictionaryEntry r in reg)
                {
                    sql += ((i > 1) ? "," : "") + r.Key + "=" + "'" + r.Value + "'";
                    i++;
                }
                i = 1;
                sql = sql + " WHERE ";
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? " AND " : "") + r.Key + " = " + "'" + r.Value + "'";
                    i++;
                }

                //MessageBox.Show("" + sql);
                comando.Connection = con.ConexBase;
                comando.CommandText = sql;
                x = comando.ExecuteNonQuery();

                if (x > 0)
                {


                }
                else
                {
                    //Telerik.WinControls.RadMessageBox.Show("El registro  no ha sido modificado exitosamente");
                    con.desconectar();
                }

            }
            catch (Exception ex)
            {


                //Telerik.WinControls.RadMessageBox.Show("El registro  no ha sido modificado exitosamente" + ex.Message);
            }
            finally
            {
                con.desconectar();

            }

        }

        public DataTable BuscarRegistro(String nomTabla, Hashtable crit, Hashtable reg)
        {
            try
            {
                int x = 0;
                int i = 1;
                con.conectar();
                String sql = "SELECT ";
                foreach (DictionaryEntry r in reg)
                {
                    sql += ((i > 1) ? "," : "") + r.Value;
                    i++;
                }
                sql += " FROM " + nomTabla + " WHERE ";
                i = 1;
                foreach (DictionaryEntry r in crit)
                {
                    sql += ((i > 1) ? " AND " : "") + r.Key + "=" + "'" + r.Value + "'";
                    i++;
                }
                //    MessageBox.Show("" + sql);
                tabla = new System.Data.DataTable();

                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);


                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no fue encontrado" + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }

        }
        public DataTable obtenerCorrelativo(String nomTabla, string codigoBarra)
        {
            try
            {
                // Select top(1) Correlativo from inventario where codigoBarra='asd-10' order by correlativo desc
                int x = 0;
                int i = 1;
                con.conectar();
                //                String sql = "Select top(1) Correlativo from inventario where codigoBarra='asd-10' order by correlativo desc";

                String sql = "Select top(1) Correlativo FROM " + nomTabla + " where codigoBarra=" + "'" + codigoBarra + "' order by correlativo desc";
                //                MessageBox.Show("" + sql);
                tabla = new System.Data.DataTable();
                // MessageBox.Show(sql);
                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }
        }
        public DataTable obtenerNVenta(String nomTabla, string campo)
        {
            try
            {
                // Select top(1) Correlativo from inventario where codigoBarra='asd-10' order by correlativo desc
                int x = 0;
                int i = 1;
                con.conectar();
                //                String sql = "Select top(1) Correlativo from inventario where codigoBarra='asd-10' order by correlativo desc";
                // Select top(1) id_compra FROM compras order by id_compra desc
                String sql = "Select top(1) " + campo + " FROM " + nomTabla + "  order by " + campo + " desc";
                //                MessageBox.Show("" + sql);
                tabla = new System.Data.DataTable();
                // MessageBox.Show(sql);
                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }
        }
        public DataTable productoJOIN()
        {
            try
            {
                con.conectar();
                String sql = "SELECT Inv.CodigoBarra, Inv.Correlativo, p.Nombre, Inv.Gravado, pr.Nombre as NombreP FROM Inventario Inv " +
                               " JOIN Productos p on p.CodigoBarra = Inv.CodigoBarra" +
                                " JOIN Compras com on com.id_compra = Inv.id_compra" +
                                " JOIN Proveedores pr on pr.CodigoProvedor = com.CodigoProveedor";
                tabla = new System.Data.DataTable();
                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }
        }
        public DataTable productoJOINFiltro(int idSucursal, string nombre)
        {
            String sql = "";
            try
            {
                con.conectar();
                if (nombre != "")
                {
                    sql = "SELECT Inv.CodigoBarra, Inv.Correlativo, p.Nombre, Inv.Gravado, pr.Nombre as NombreP FROM Inventario Inv " +
                                    " JOIN Productos p on p.CodigoBarra = Inv.CodigoBarra" +
                                     " JOIN Compras com on com.id_compra = Inv.id_compra" +
                                     " JOIN Proveedores pr on pr.CodigoProvedor = com.CodigoProveedor" +
                                     " WHERE com.CodigoSucursal = '" + idSucursal + "'  AND p.Nombre like '%" + nombre + "%'";
                }
                else
                {
                    sql = "SELECT Inv.CodigoBarra, Inv.Correlativo, p.Nombre, Inv.Gravado, pr.Nombre as NombreP FROM Inventario Inv " +
                                    " JOIN Productos p on p.CodigoBarra = Inv.CodigoBarra" +
                                     " JOIN Compras com on com.id_compra = Inv.id_compra" +
                                     " JOIN Proveedores pr on pr.CodigoProvedor = com.CodigoProveedor" +
                                     " WHERE com.CodigoSucursal = '" + idSucursal + "'";
                }

                tabla = new System.Data.DataTable();
                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }
        }
        public DataTable obtenerIdCompra()
        {
            try
            {
                con.conectar();
                String sql = "SELECT MAX(id_compra) as idComp  FROM Compras";
                tabla = new System.Data.DataTable();
                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }
        }


        public object ObtenerTipoCompra2()
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                con.conectar();
                cmd.CommandText = "SELECT SUM(Gravado) as Credito FROM Compras WHERE TipoCompra=2";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con.ConexBase;


                returnValue = cmd.ExecuteScalar();
                // con.desconectar();
                return returnValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return returnValue;
            }
            finally
            {
                con.desconectar();

            }



        }


        public DataTable ObtenerTodasTuplas(String nomTabla)
        {
            try
            {
                int x = 0;
                int i = 1;
                con.conectar();
                String sql = "SELECT * FROM " + nomTabla;
                //                MessageBox.Show("" + sql);
                tabla = new System.Data.DataTable();

                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los registros no fueron encontrados. " + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }
        }

        public DataTable BuscarRegistroAutoincremetable(String nomTabla, String nomCampo, ArrayList reg, String texto)
        {
            try
            {
                int x = 0;
                int i = 1;
                con.conectar();
                String sql = "SELECT ";
                foreach (String r in reg)
                {
                    sql += ((i > 1) ? "," : "") + r;
                    i++;
                }
                sql += " FROM " + nomTabla + " WHERE " + nomCampo + " LIKE '%" + texto + "%'";
                i = 1;
                //MessageBox.Show("" + sql);
                tabla = new System.Data.DataTable();

                adaptador = new SqlDataAdapter(sql, con.ConexBase);
                adaptador.Fill(tabla);


                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR con el registro no fue encontrado" + ex.Message);
                return tabla;
            }
            finally
            {
                con.desconectar();

            }

        }
    }
}
