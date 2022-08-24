using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void BttnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BttnConexion_Click(object sender, EventArgs e)
        {
            Conexion();
        }

        private void BttnInsert_Click(object sender, EventArgs e)
        {
            Insertar(txtResA.Text, txtResB.Text, txtCapacitor.Text);
        }

        private void BttnTabla_Click(object sender, EventArgs e)
        {
            CrearTabla();
        }

        private void BttnTruncate_Click(object sender, EventArgs e)
        {
            LimpiarTabla();
        }

        private void BttnDrop_Click(object sender, EventArgs e)
        {
            EliminarTabla();
        }

        //----------------------------------------------------------------------------------------------------------------------------------
        //Métodos

        /// <summary>
        /// Método para probar la conexion con nuestra base de datos
        /// </summary>
        public void Conexion()
        {
            try
            {
                //Instancia de la conexion para la base de datos
                //NOTA: La cadena de conexion debe cambiarse en App.config caso de que se ejecute en otro equipo
                //La cadena de conexion "conexion" debe ser la nos brinda la ventana de propiedades de la base de datos
                using (SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                {
                    //Se abre la conexion
                    conexion.Open();
                    //Mensaje de conexion exitosa
                    MessageBox.Show("Prueba de conexion realizada con exito");
                    //Se cierra la conexion
                    conexion.Close();
                }
            }
            catch (Exception excepcion)
            {
                //Mensaje de error en caso de que algun problema nos impida la conexion o un comando mal ejecutado
                MessageBox.Show(excepcion.Message);
            }
        }

        /// <summary>
        /// Método para crear nuestra tabla en la base de datos local del proyecto
        /// </summary>
        public void CrearTabla()
        {
            try
            {
                //Instancia de la conexion para la base de datos
                //NOTA: La cadena de conexion debe cambiarse en App.config caso de que se ejecute en otro equipo
                //La cadena de conexion "conexion" debe ser la nos brinda la ventana de propiedades de la base de datos
                using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                {
                    //Abrimos la conexion
                    conexion.Open();
                    //Iniciamos una consulta (Query)
                    SqlDataReader consulta1;
                    //Iniciamos una instruccion para SQL Server mediante la clase SQLCommand
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "CREATE TABLE Tabla_Frecuencias (" +
                            "ID int identity(1,1) primary key NOT NULL," +
                            "Resistor_A float NOT NULL," +
                            "Resistor_B float NOT NULL," +
                            "Capacitor float NOT NULL," +
                            "Frecuencia float NOT NULL )";
                        comando.CommandType = CommandType.Text;
                        consulta1 = comando.ExecuteReader();
                        //Una vez ejecutado el comando, terminamos la consulta y el comando
                        comando.Dispose();
                        consulta1.Dispose();
                        //Declaramos un data adapter, para llenar el dataset correspondiente a nuestra tabla en la base de datos
                        using (SqlDataAdapter dataAdapter1 = new SqlDataAdapter())
                        {
                            //Iniciamos otra consulta
                            SqlDataReader consulta2;
                            dataAdapter1.SelectCommand = comando;
                            comando.Connection = conexion;
                            comando.CommandText = "SELECT * FROM Tabla_Frecuencias";
                            comando.CommandType = CommandType.Text;
                            consulta2 = comando.ExecuteReader();
                            //Utilizamos nuestro SQLCommando "comando", para una nueva instruccion
                            //Una vez ejecutado el comando, terminamos la consulta y el comando
                            comando.Dispose();
                            consulta2.Dispose();
                            //Iniciamos nuestro dataset para ser rellenado con nuestro dataAdapter, que proporciona la informacion de nuestra tabla en la base de datos
                            DBfrecuencias555DataSet dataSet1 = new DBfrecuencias555DataSet();
                            dataAdapter1.Fill(dataSet1, "Tabla_Frecuencias");
                            dataGridView1.DataSource = dataSet1.Tables["Tabla_Frecuencias"];
                        }
                        //Cerramos la conexion
                        conexion.Close();
                    }
                }
                MessageBox.Show("Tabla creada con exito");
            }
            catch (Exception excepcion)
            {
                //Mensaje de error en caso de que algun problema nos impida la conexion o un comando mal ejecutado
                MessageBox.Show(excepcion.Message);
            }
        }

        /// <summary>
        /// Insertar nuevo elemento en la tabla
        /// </summary>
        public void Insertar(string a, string b, string c)
        {
            try
            {
                //Instancia de la conexion para la base de datos
                //NOTA: La cadena de conexion debe cambiarse en App.config caso de que se ejecute en otro equipo
                //La cadena de conexion "conexion" debe ser la nos brinda la ventana de propiedades de la base de datos
                using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                {

                    double frec = PulseFrecuene(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c));
                    //Abrimos la conexion
                    conexion.Open();
                    //Iniciamos una consulta
                    SqlDataReader consulta1;
                    //Iniciamos una instruccion para SQL Server mediante la clase SQLCommand
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "INSERT INTO Tabla_Frecuencias (Resistor_A, Resistor_B, Capacitor, Frecuencia)" +
                            "VALUES (" + a + ',' + b + ',' + c + ',' + frec + ')';
                        comando.CommandType = CommandType.Text;
                        consulta1 = comando.ExecuteReader();
                        //Una vez ejecutado el comando, terminamos la consulta y el comando
                        comando.Dispose();
                        consulta1.Dispose();
                        //Declaramos un data adapter, para llenar el dataset correspondiente a nuestra tabla en la base de datos
                        using (SqlDataAdapter dataAdapter1 = new SqlDataAdapter())
                        {
                            //Iniciamos otra consulta
                            SqlDataReader consulta2;
                            dataAdapter1.SelectCommand = comando;
                            comando.Connection = conexion;
                            comando.CommandText = "SELECT * FROM Tabla_Frecuencias";
                            comando.CommandType = CommandType.Text;
                            consulta2 = comando.ExecuteReader();
                            //Utilizamos nuestro SQLCommando "comando", para una nueva instruccion
                            //Una vez ejecutado el comando, terminamos la consulta y el comando
                            comando.Dispose();
                            consulta2.Dispose();
                            //Iniciamos nuestro dataset para ser rellenado con nuestro dataAdapter, que proporciona la informacion de nuestra tabla en la base de datos
                            DBfrecuencias555DataSet dataSet1 = new DBfrecuencias555DataSet();
                            dataAdapter1.Fill(dataSet1, "Tabla_Frecuencias");
                            dataGridView1.DataSource = dataSet1.Tables["Tabla_Frecuencias"];
                        }
                        //Cerramos la conexion
                        conexion.Close();
                    }
                }
                MessageBox.Show("Datos agregados correctamente");
            }
            catch (Exception excepcion)
            {
                //Mensaje de error en caso de que algun problema nos impida la conexion o un comando mal ejecutado
                MessageBox.Show(excepcion.Message);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void LimpiarTabla()
        {
            try
            {
                //Instancia de la conexion para la base de datos
                //NOTA: La cadena de conexion debe cambiarse en App.config caso de que se ejecute en otro equipo
                //La cadena de conexion "conexion" debe ser la nos brinda la ventana de propiedades de la base de datos
                using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                {
                    //Abrimos la conexion
                    conexion.Open();
                    //Iniciamos una consulta
                    SqlDataReader consulta1;
                    //Iniciamos una instruccion para SQL Server mediante la clase SQLCommand
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "TRUNCATE TABLE Tabla_Frecuencias";
                        comando.CommandType = CommandType.Text;
                        consulta1 = comando.ExecuteReader();
                        //Una vez ejecutado el comando, terminamos la consulta y el comando
                        comando.Dispose();
                        consulta1.Dispose();

                        //Declaramos un data adapter, para llenar el dataset correspondiente a nuestra tabla en la base de datos
                        using (SqlDataAdapter dataAdapter1 = new SqlDataAdapter())
                        {
                            //Iniciamos otra consulta
                            SqlDataReader consulta2;
                            dataAdapter1.SelectCommand = comando;
                            comando.Connection = conexion;
                            comando.CommandText = "SELECT * FROM Tabla_Frecuencias";
                            comando.CommandType = CommandType.Text;
                            consulta2 = comando.ExecuteReader();
                            //Utilizamos nuestro SQLCommando "comando", para una nueva instruccion
                            //Una vez ejecutado el comando, terminamos la consulta y el comando
                            comando.Dispose();
                            consulta2.Dispose();
                            //Iniciamos nuestro dataset para ser rellenado con nuestro dataAdapter, que proporciona la informacion de nuestra tabla en la base de datos
                            DBfrecuencias555DataSet dataSet1 = new DBfrecuencias555DataSet();
                            dataAdapter1.Fill(dataSet1, "Tabla_Frecuencias");
                            dataGridView1.DataSource = dataSet1.Tables["Tabla_Frecuencias"];
                        }
                        //Cerramos la conexion
                        conexion.Close();
                    }
                }
                MessageBox.Show("La tabla ahora está vacia");
            }
            catch (Exception excepcion)
            {
                //Mensaje de error en caso de que algun problema nos impida la conexion o un comando mal ejecutado
                MessageBox.Show(excepcion.Message);
            }
        }

        /// <summary>
        /// Elimina completamente la tabla de la base de datos
        /// </summary>
        public void EliminarTabla()
        {
            try
            {
                //Instancia de la conexion para la base de datos
                //NOTA: La cadena de conexion debe cambiarse en App.config caso de que se ejecute en otro equipo
                //La cadena de conexion "conexion" debe ser la nos brinda la ventana de propiedades de la base de datos
                using (var conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString))
                {
                    //Abrimos la conexion
                    conexion.Open();
                    //Iniciamos una consulta
                    SqlDataReader consulta1;
                    //Iniciamos una instruccion para SQL Server mediante la clase SQLCommand
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexion;
                        comando.CommandText = "DROP TABLE Tabla_Frecuencias";
                        comando.CommandType = CommandType.Text;
                        consulta1 = comando.ExecuteReader();
                        //Una vez ejecutado el comando, terminamos la consulta y el comando
                        comando.Dispose();
                        consulta1.Dispose();
                        //Cerramos la conexion
                        conexion.Close();
                    }
                    //Dado que la tabla ya no existe, deja de mostrarse informacion en el dataGridView
                    dataGridView1.DataSource = null;
                }
                MessageBox.Show("La tabla se a eliminado de la base de datos");
            }
            catch (Exception excepcion)
            {
                //Mensaje de error en caso de que algun problema nos impida la conexion o un comando mal ejecutado
                MessageBox.Show(excepcion.Message);
            }
        }

        /// <summary>
        /// Obtiene la frecuencia para la configuración de un CI 555 en configuración astable
        /// </summary>
        /// <param name="resA"> Resistor A </param>
        /// <param name="resB"> Resistor B </param>
        /// <param name="cap"> Capacitor </param>
        /// <returns> Frecuencia </returns>
        public double PulseFrecuene(double resA, double resB, double cap)
        {
            double frecuencia;
            frecuencia = 1.44 / ((resA + (2 * resB)) * (cap * Math.Pow(10, -6)));
            frecuencia = Math.Round(frecuencia, 4);
            return frecuencia;
        }
    }
}
