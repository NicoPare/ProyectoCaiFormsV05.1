using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoCaiFormsV05._1.Entidades;
using System.Text.RegularExpressions;

namespace ProyectoCaiFormsV05._1.Modulos
{
    public class Validaciones
    {
        // Método para validar el código de la ciudad ingresado por el usuario
        public static bool ValidarCodigoCiudad(string codCiudad)
        {
            // Leer el archivo JSON de ciudades
            string jsonCiudades = File.ReadAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Ciudades.json");

            // Deserializar JSON a una lista de objetos Ciudad
            List<Ciudad> ciudades = JsonConvert.DeserializeObject<List<Ciudad>>(jsonCiudades);

            // Verificar si el código de la ciudad ingresado existe en la lista
            foreach (Ciudad ciudad in ciudades)
            {
                if (ciudad.Codigo == codCiudad)
                {
                    return true; // El código de la ciudad es válido
                }
            }

            Console.WriteLine("Error: El código de la ciudad ingresado no es válido.");
            return false; // El código de la ciudad no es válido
        }

        // Método para validar el código del aeropuerto ingresado por el usuario
        public static bool ValidarCodigoAeropuerto(string codAeropuerto)
        {
            // Leer el archivo JSON de aeropuertos
            string jsonAeropuertos = File.ReadAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Aeropuertos.json");

            // Deserializar JSON a una lista de objetos Aeropuerto
            List <Aeropuerto> aeropuertos = JsonConvert.DeserializeObject<List<Aeropuerto>>(jsonAeropuertos);

            // Verificar si el código del aeropuerto ingresado existe en la lista
            foreach (Aeropuerto aeropuerto in aeropuertos)
            {
                if (aeropuerto.Codigo == codAeropuerto)
                {
                    return true; // El código del aeropuerto es válido
                }
            }

            Console.WriteLine("Error: El código del aeropuerto ingresado no es válido.");
            return false; // El código del aeropuerto no es válido
        }
        public static bool ValidarFecha(string fecha)
        {
            DateTime fechaActual = DateTime.Now;

            // Verificar si la fecha es mayor o igual a la fecha actual
            if (!DateTime.TryParse(fecha, out DateTime fechaIngresada) || fechaIngresada < fechaActual.Date)
            {
                Console.WriteLine("Error: La fecha debe ser igual o mayor a la fecha actual.");
                return false;
            }

            return true;
        }

        public static bool ValidarFechas(string fechaInicio, string fechaFin)
        {
            // Verificar si las fechas son válidas
            if (!DateTime.TryParse(fechaInicio, out DateTime fechaInicioIngresada) ||
                !DateTime.TryParse(fechaFin, out DateTime fechaFinIngresada))
            {
                Console.WriteLine("Error: Las fechas ingresadas son inválidas.");
                return false;
            }

            // Verificar si la fecha de fin es mayor a la fecha de inicio
            if (fechaFinIngresada < fechaInicioIngresada)
            {
                Console.WriteLine("Error: La fecha de fin debe ser mayor a la fecha de inicio.");
                return false;
            }

            return true;
        }

        public static bool ValidarCantidadPasajerosAdultos(int cantidad)
        {
            // Verificar si la cantidad de pasajeros adultos es mayor a 0
            if (cantidad <= 0)
            {
                Console.WriteLine("Error: La cantidad de pasajeros adultos debe ser mayor a 0.");
                return false;
            }

            return true;
        }
        public static bool ValidarCalificacion(int calificacion)
        {
            // Verificar si la calificación está dentro del rango válido (1-5)
            if (calificacion < 1 || calificacion > 5)
            {
                Console.WriteLine("Error: La calificación debe estar entre 1 y 5.");
                return false;
            }

            return true;
        }
        public static bool ValidarNombreApellido(string nombre, string apellido)
        {
            // Verificar si el nombre y/o apellido están vacíos o contienen valores numéricos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                nombre.Any(char.IsDigit) || apellido.Any(char.IsDigit))
            {
                Console.WriteLine("Error: No ha ingresado correctamente los datos solicitados. Por favor, vuelva a intentarlo.");
                return false;
            }

            return true;
        }

        public static bool ValidarPais(string pais)
        {
            // Cargar los datos del archivo Paises.json
            //string paisesJson = File.ReadAllText("Paises.json");
            string paisesJson = File.ReadAllText("C:\\Users\\npare\\source\\repos\\ProyectoCaiFormsV05.1\\ProyectoCaiFormsV05.1\\Datos\\Paises.json");

            // Deserializar el archivo JSON a una lista de países
            var paises = JsonConvert.DeserializeObject<string[]>(paisesJson);
            

            // Verificar si el país está en la lista de países
            if (!paises.Any(p => p.Equals(pais, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Error: País no encontrado, por favor, revise la ortografía del país ingresado.");
                return false;
            }

            return true;
        }

        public static bool ValidarTipoDocumento(string tipoDocumento)
        {
            // Cargar los tipos de documentos permitidos desde algún origen de datos
            var tiposDocumentoPermitidos = new List<string> { "DNI", "Pasaporte", "Cédula" };

            // Verificar si el tipo de documento está en la lista de tipos permitidos
            if (!tiposDocumentoPermitidos.Contains(tipoDocumento, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("Error: Tipo de documento inválido, por favor, revise la ortografía.");
                return false;
            }

            return true;
        }

        public static bool ValidarDocumento(string documento)
        {
            // Verificar si el documento contiene caracteres especiales o es un valor en formato string
            if (documento.Any(c => !char.IsDigit(c)) || int.TryParse(documento, out _))
            {
                Console.WriteLine("Error: Documento ingresado inválido, por favor, vuelva a ingresar.");
                return false;
            }

            return true;
        }

        public static bool ValidarFechaNacimiento(string fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            // Verificar si la fecha de nacimiento es mayor a la fecha actual
            if (!DateTime.TryParse(fechaNacimiento, out DateTime fechaNacimientoIngresada) || fechaNacimientoIngresada > fechaActual)
            {
                Console.WriteLine("Error: Su fecha de nacimiento ingresada es posterior al día de la fecha. Por favor, ingrese nuevamente su fecha de nacimiento.");
                return false;
            }

            return true;
        }

        public static bool ValidarCantidadPasajerosVuelo(int cantidadAdultos, int cantidadMenores, int cantidadInfantes)
        {
            // Verificar si la cantidad de pasajeros adultos es mayor o igual a la suma de menores e infantes
            if (cantidadAdultos < cantidadMenores + cantidadInfantes)
            {
                Console.WriteLine("Error: La cantidad de pasajeros adultos debe ser igual o mayor a la suma de menores e infantes.");
                return false;
            }

            // Verificar si la cantidad de pasajeros adultos es mayor a 0
            if (cantidadAdultos <= 0)
            {
                MessageBox.Show("La cantidad de pasajeros adultos debe ser mayor a 0.", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si la cantidad de menores es mayor o igual a 0
            if (cantidadMenores < 0)
            {
                Console.WriteLine("Error: La cantidad de pasajeros menores debe ser mayor o igual a 0.");
                return false;
            }

            // Verificar si la cantidad de infantes es mayor o igual a 0
            if (cantidadInfantes < 0)
            {
                Console.WriteLine("Error: La cantidad de pasajeros infantes debe ser mayor o igual a 0.");
                return false;
            }

            return true;
        }

        public static bool ValidarCorreoElectronico(string correoElectronico)
        {
            // Expresión regular para validar el formato del correo electrónico
            string patronCorreoElectronico = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            // Verificar si el correo electrónico cumple con el formato válido
            if (!Regex.IsMatch(correoElectronico, patronCorreoElectronico))
            {
                Console.WriteLine("Error: Correo electrónico ingresado inválido, por favor, vuelva a ingresar.");
                return false;
            }

            return true;
        }
        public static bool ValidarNumeroCelular(string numeroCelular)
        {
            // Verificar si el número de celular contiene solo dígitos numéricos y no tiene espacios en blanco
            if (!numeroCelular.All(char.IsDigit) || string.IsNullOrWhiteSpace(numeroCelular))
            {
                Console.WriteLine("Error: El número de celular debe contener solo dígitos numéricos y no debe tener espacios en blanco.");
                return false;
            }

            return true;
        }



    }
}
