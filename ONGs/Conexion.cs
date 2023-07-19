using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONGs
{
    internal class Conexion
    {
        public SqlConnection connect = new SqlConnection();
        string passwordd;
        public Conexion(String user, String pass)
        {

            try
            {

                connect = new SqlConnection("Server=localhost;Database=ONGs;UID=" + user + ";PWD=" + pass);
                //connect = new SqlConnection("Server=localhost;Database=ONGs;UID=" + "sa" + ";PWD=" + "123456");
                connect.Open();

                passwordd = pass;

            }
            catch (Exception)
            {


            }

        }
        protected SqlConnection GetConection()
        {
            return new SqlConnection(connect.ConnectionString + "PWD = " + passwordd);
        }
        public void ListarAsociaciones(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarAsociaciones";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void NuevaAsociacion(DataGridView GridView1, String denominacion, String dir, String provincia, String tipo, int dup)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Denominacion", SqlDbType.VarChar);
            param[0].Value = denominacion;
            param[1] = new SqlParameter("@direccion", SqlDbType.VarChar);
            param[1].Value = dir;
            param[2] = new SqlParameter("@provincia", SqlDbType.VarChar);
            param[2].Value = provincia;
            param[3] = new SqlParameter("@tipo", SqlDbType.VarChar);
            param[3].Value = tipo;
            param[4] = new SqlParameter("@declarada_utilidad_publica", SqlDbType.Bit);
            param[4].Value = dup;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarAsociacion";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ListarSocios(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarSocios";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void NuevoSocio(DataGridView GridView1, String dni, String nombre, String dir, String provincia, String cuota, String idasociacion)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = dni;
            param[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@direccion", SqlDbType.VarChar);
            param[2].Value = dir;
            param[3] = new SqlParameter("@provincia", SqlDbType.VarChar);
            param[3].Value = provincia;
            param[4] = new SqlParameter("@cuota_mensual", SqlDbType.Decimal);
            param[4].Value = cuota;
            param[5] = new SqlParameter("@id_asociacion", SqlDbType.Int);
            param[5].Value = idasociacion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarSocio";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ListarTrabajadores(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarTrabajadores";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void ListarVoluntarios(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListaVon";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void NuevoTrabajador(DataGridView GridView1, String dni, String nombre, String tipo, String edad, 
            String salario, String cantes,String prof, String horasde, String pir)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = dni;
            param[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@tipo", SqlDbType.VarChar);
            param[2].Value = tipo;
            param[3] = new SqlParameter("@edad", SqlDbType.Int);
            param[3].Value = edad;
            param[4] = new SqlParameter("@SalarioB", SqlDbType.Decimal);
            param[4].Value = salario;
            param[5] = new SqlParameter("@cantidad_essalud", SqlDbType.Decimal);
            param[5].Value = cantes;
            param[6] = new SqlParameter("@profesion", SqlDbType.VarChar);
            param[6].Value = prof;
            param[7] = new SqlParameter("@horasdedicadas", SqlDbType.Int);
            param[7].Value = horasde;
            param[8] = new SqlParameter("@porcentaje_impuesto_renta", SqlDbType.Decimal);
            param[8].Value = pir;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertarTrabajador";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ListarProyectos(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarProyectos";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }

        public void ListarSubProyectos(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            SqlDataReader leer;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ListarSubProyectos";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }


        public void NuevoProyecto(DataGridView GridView1, String cod, String pais, String zona, String objetivo,
           String beneficiarios, String dni)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@codigo_asociacion", SqlDbType.Char);
            param[0].Value = cod;
            param[1] = new SqlParameter("@pais", SqlDbType.VarChar);
            param[1].Value = pais;
            param[2] = new SqlParameter("@zona", SqlDbType.VarChar);
            param[2].Value = zona;
            param[3] = new SqlParameter("@objetivo", SqlDbType.VarChar);
            param[3].Value = objetivo;
            param[4] = new SqlParameter("@beneficiarios", SqlDbType.Int);
            param[4].Value = beneficiarios;
            param[5] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[5].Value = dni;
        
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertar_proyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void NuevoSubProyecto(DataGridView GridView1, String idp, String nombre, String pais, String zona,
           String objetivo, String beneficiarios)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@idProyecto", SqlDbType.Int);
            param[0].Value = idp;
            param[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@pais", SqlDbType.VarChar);
            param[2].Value = pais;
            param[3] = new SqlParameter("@zona", SqlDbType.VarChar);
            param[3].Value = zona;
            param[4] = new SqlParameter("@objetivo_sub", SqlDbType.VarChar);
            param[4].Value = objetivo;
            param[5] = new SqlParameter("@num_beneficiarios_subproyecto", SqlDbType.Int);
            param[5].Value = beneficiarios;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "insertar_subproyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ModificarAsociacion(DataGridView GridView1,String id, String denominacion, String dir, String provincia, String tipo, int dup)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            param[1] = new SqlParameter("@denominacion", SqlDbType.VarChar);
            param[1].Value = denominacion;
            param[2] = new SqlParameter("@direccion", SqlDbType.VarChar);
            param[2].Value = dir;
            param[3] = new SqlParameter("@provincia", SqlDbType.VarChar);
            param[3].Value = provincia;
            param[4] = new SqlParameter("@tipo", SqlDbType.VarChar);
            param[4].Value = tipo;
            param[5] = new SqlParameter("@declarada_utilidad_publica", SqlDbType.Bit);
            param[5].Value = dup;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarAsociacion";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void EliminarAsociacion(DataGridView GridView1, String idp )
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarAsociacion";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ModificarSocio(DataGridView GridView1, String dni, String nombre, String dir, String provincia, String cuota, String idasociacion)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = dni;
            param[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@direccion", SqlDbType.VarChar);
            param[2].Value = dir;
            param[3] = new SqlParameter("@provincia", SqlDbType.VarChar);
            param[3].Value = provincia;
            param[4] = new SqlParameter("@cuota_mensual", SqlDbType.Decimal);
            param[4].Value = cuota;
            param[5] = new SqlParameter("@id_asociacion", SqlDbType.Int);
            param[5].Value = idasociacion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarSocio";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void EliminarSocio(DataGridView GridView1, String idp)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarSocio";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ModificarTrabajador(DataGridView GridView1, String dni, String nombre, String tipo, String edad,
          String salario, String cantes, String prof, String horasde, String pir)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[9];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = dni;
            param[1] = new SqlParameter("@nombre", SqlDbType.VarChar);
            param[1].Value = nombre;
            param[2] = new SqlParameter("@tipo", SqlDbType.VarChar);
            param[2].Value = tipo;
            param[3] = new SqlParameter("@edad", SqlDbType.Int);
            param[3].Value = edad;
            param[4] = new SqlParameter("@SalarioB", SqlDbType.Decimal);
            param[4].Value = salario;
            param[5] = new SqlParameter("@cantidad_essalud", SqlDbType.Decimal);
            param[5].Value = cantes;
            param[6] = new SqlParameter("@profesion", SqlDbType.VarChar);
            param[6].Value = prof;
            param[7] = new SqlParameter("@horasdedicadas", SqlDbType.Int);
            param[7].Value = horasde;
            param[8] = new SqlParameter("@porcentaje_impuesto_renta", SqlDbType.Decimal);
            param[8].Value = pir;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ModificarTrabajador";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void EliminarTrabajador(DataGridView GridView1, String idp)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarTrabajador";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ModificarProyecto(DataGridView GridView1, String idp, String cod, String pais, String zona, String objetivo,
           String beneficiarios, String dni)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@id_proyecto", SqlDbType.Int);
            param[0].Value = idp;
            param[1] = new SqlParameter("@codigo_asociacion", SqlDbType.Char);
            param[1].Value = cod;
            param[2] = new SqlParameter("@pais", SqlDbType.VarChar);
            param[2].Value = pais;
            param[3] = new SqlParameter("@zona", SqlDbType.VarChar);
            param[3].Value = zona;
            param[4] = new SqlParameter("@objetivo", SqlDbType.VarChar);
            param[4].Value = objetivo;
            param[5] = new SqlParameter("@beneficiarios", SqlDbType.Int);
            param[5].Value = beneficiarios;
            param[6] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[6].Value = dni;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "modificar_proyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void EliminarProyecto(DataGridView GridView1, String idp)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarProyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void ModificarSubProyecto(DataGridView GridView1,String ids, String idp, String name, String pais, String zona, String objetivo,
          String beneficiarios)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@idSubproyecto", SqlDbType.Int);
            param[0].Value = ids;
            param[1] = new SqlParameter("@id_proyecto", SqlDbType.Int);
            param[1].Value = idp;
            param[2] = new SqlParameter("@nombre", SqlDbType.Char);
            param[2].Value = name;
            param[3] = new SqlParameter("@pais", SqlDbType.VarChar);
            param[3].Value = pais;
            param[4] = new SqlParameter("@zona", SqlDbType.VarChar);
            param[4].Value = zona;
            param[5] = new SqlParameter("@objetivo_sub", SqlDbType.VarChar);
            param[5].Value = objetivo;
            param[6] = new SqlParameter("@num_beneficiarios_subproyecto", SqlDbType.Int);
            param[6].Value = beneficiarios;
           

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "modificar_subproyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(ds);


        }

        public void EliminarSubProyecto(DataGridView GridView1, String idp)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "EliminarSubProyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);
            
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);


        }

        public void SocioTrabajador(String idp,Label response)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SocioTrabajador";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            if(ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
            {
                response.Text = "empty";
            }
            else
            {
                response.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            
        }

        public void ValidarAcceso(String User, String Pass, Label response)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Usuario", SqlDbType.VarChar);
            param[0].Value = User;
            param[1] = new SqlParameter("@Contraseña", SqlDbType.VarChar);
            param[1].Value = Pass;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Validar_Acceso";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            if (ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
            {
                //response.Text = "empty";
            }
            else
            {
                MessageBox.Show(ds.Tables[0].Rows[0][0].ToString());
                response.Text = ds.Tables[0].Rows[0][0].ToString();
            }

        }
        public void ValidarAsociacion(String idp, Label response)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ValidarAsociacion";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            if (ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
            {
                response.Text = "empty";
            }
            else
            {
                response.Text = ds.Tables[0].Rows[0][0].ToString();
            }

        }

        public void ValidarAsalariado(String idp, Label response)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ValidarTrabajadorA";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            if (ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
            {
                response.Text = "empty";
            }
            else
            {
                response.Text = ds.Tables[0].Rows[0][0].ToString();
            }

        }

        public void ValidarVoluntario(String idp, Label response)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@dni", SqlDbType.VarChar);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ValidarTrabajadorV";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            if (ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
            {
                response.Text = "empty";
            }
            else
            {
                response.Text = ds.Tables[0].Rows[0][0].ToString();
            }

        }

        public void ValidarProyecto(String idp, Label response)
        {

            SqlCommand cmd = new SqlCommand();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = idp;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ValidarProyecto";
            cmd.Connection = connect;
            cmd.Parameters.AddRange(param);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(ds);
            if (ds.Tables[0].Rows == null || ds.Tables[0].Rows.Count == 0)
            {
                response.Text = "empty";
            }
            else
            {
                response.Text = ds.Tables[0].Rows[0][0].ToString();
            }

        }
    }
}
