using Newtonsoft.Json;
using ProyectoCaiFormsV05._1.Archivos;
using ProyectoCaiFormsV05._1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProyectoCaiFormsV05._1.Modulos
{
    public class ModuloProductos
    {

        public void ProcesarVuelosYAlojamientos()
        {
            // Leo los vuelos desde el archivo JSON
            List<Vuelo> vuelos = VuelosArchivo.ObtenerTodas();

            // Leo los alojamientos desde el archivo JSON
            List<Alojamiento> alojamientos = AlojamientosArchivo.ObtenerTodas();

            // Proceso los vuelos
            List<Producto> productos = new List<Producto>();

            foreach (Vuelo vuelo in vuelos)
            {
                string codigoProducto = GenerarCodigoAleatorio();
                Producto producto = new Producto(codigoProducto, vuelo, null);
                productos.Add(producto);
            }

            // Procesar los alojamientos
            foreach (Alojamiento alojamiento in alojamientos)
            {
                string codigoProducto = GenerarCodigoAleatorio();
                Producto producto = new Producto(codigoProducto, null, alojamiento);
                productos.Add(producto);
            }

            // Guardar los productos en el archivo JSON
            GuardarProductosEnArchivo(productos);
        }


        private void GuardarProductosEnArchivo(List<Producto> productos)
        {
            string productosJson = JsonConvert.SerializeObject(productos, Newtonsoft.Json.Formatting.Indented);

            // Guardar los productos en el archivo JSON
            File.WriteAllText("Productos.json", productosJson);
            
        }

        public static string GenerarCodigoAleatorio()
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        // CONSULTAS DE DATOS

        private List<Producto> productos;

        public ModuloProductos()
        {
            productos = new List<Producto>();
        }

        

        //CONSULTA DE VUELOS
        public List<dynamic> ConsultarVuelos(string origen, string destino, DateTime fechaIda, DateTime? fechaVuelta,
        int cantidadAdultos, int cantidadMenores, int cantidadInfantes)
        {
            string jsonFilePath = "Productos.json";

            string jsonContent = File.ReadAllText(jsonFilePath);
            List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(jsonContent);
            List<dynamic> vuelosDisponibles = new List<dynamic>();

            foreach (Producto producto in productos)
            {
                if (producto.Vuelo != null)
                {
                    if (producto.Vuelo.Origen == origen && producto.Vuelo.Destino == destino)
                    {
                        DateTime fechaHoraSalida = producto.Vuelo.FechaHoraSalida.Date;

                        if ((fechaVuelta == null || fechaIda.Date == fechaHoraSalida.Date || fechaVuelta.Value.Date == fechaHoraSalida.Date) &&
                            (!fechaVuelta.HasValue || fechaVuelta.Value.Date >= fechaIda.Date))
                        {
                            var vueloSimplificado = new
                            {
                                CodVuelo = producto.Vuelo.CodVuelo,
                                Origen = producto.Vuelo.Origen,
                                Destino = producto.Vuelo.Destino,
                                FechaHoraSalida = producto.Vuelo.FechaHoraSalida,
                                FechaHoraArribo = producto.Vuelo.FechaHoraArribo,
                                Aerolinea = producto.Vuelo.Aerolinea,
                                Tarifas = producto.Vuelo.Tarifa
                                    .Where(t => (cantidadMenores == 0 && cantidadInfantes == 0 && t.TipoPasajero == "Adulto") ||
                                                (cantidadMenores > 0 && cantidadInfantes == 0 &&
                                                 (t.TipoPasajero == "Adulto" || t.TipoPasajero == "Menor")) ||
                                                (cantidadMenores == 0 && cantidadInfantes > 0 &&
                                                 (t.TipoPasajero == "Adulto" || t.TipoPasajero == "Infante")) ||
                                                (cantidadMenores > 0 && cantidadInfantes > 0))
                                    .Select(t => new
                                    {
                                        Precio = t.Precio,
                                        ClaseVuelo = t.ClaseVuelo,
                                        TipoPasajero = t.TipoPasajero
                                    }).ToList()
                            };

                            vuelosDisponibles.Add(vueloSimplificado);
                        }
                    }
                    else if (fechaVuelta.HasValue && producto.Vuelo.Origen == destino && producto.Vuelo.Destino == origen)
                    {
                        DateTime fechaHoraSalida = producto.Vuelo.FechaHoraSalida.Date;
                        DateTime fechaHoraArribo = producto.Vuelo.FechaHoraArribo.Date;

                        if (fechaHoraSalida >= fechaIda.Date && fechaHoraArribo <= fechaVuelta.Value.Date &&
                            (!fechaVuelta.HasValue || fechaHoraSalida.Date <= fechaVuelta.Value.Date))
                        {
                            var vueloSimplificado = new
                            {
                                CodVuelo = producto.Vuelo.CodVuelo,
                                Origen = producto.Vuelo.Origen,
                                Destino = producto.Vuelo.Destino,
                                FechaHoraSalida = producto.Vuelo.FechaHoraSalida,
                                FechaHoraArribo = producto.Vuelo.FechaHoraArribo,
                                Aerolinea = producto.Vuelo.Aerolinea,
                                Tarifas = producto.Vuelo.Tarifa
                                    .Where(t => (cantidadMenores == 0 && cantidadInfantes == 0 && t.TipoPasajero == "Adulto") ||
                                                (cantidadMenores > 0 && cantidadInfantes == 0 &&
                                                 (t.TipoPasajero == "Adulto" || t.TipoPasajero == "Menor")) ||
                                                (cantidadMenores == 0 && cantidadInfantes > 0 &&
                                                 (t.TipoPasajero == "Adulto" || t.TipoPasajero == "Infante")) ||
                                                (cantidadMenores > 0 && cantidadInfantes > 0))
                                    .Select(t => new
                                    {
                                        Precio = t.Precio,
                                        ClaseVuelo = t.ClaseVuelo,
                                        TipoPasajero = t.TipoPasajero
                                    }).ToList()
                            };

                            vuelosDisponibles.Add(vueloSimplificado);
                        }
                    }
                }
            }

            return vuelosDisponibles;
        }

        // CONSULTA DE ALOJAMIENTOS

        public List<dynamic> ConsultarAlojamiento(string destino, DateTime fechaIngreso, DateTime fechaEgreso,
        int cantidadAdultos, int cantidadMenores, int cantidadInfantes, int calificacion)
        {
            string jsonFilePath = "Productos.json";        

            // Leer el contenido del archivo JSON
            string jsonContent = File.ReadAllText(jsonFilePath);

            // Deserializar el contenido JSON a una lista de objetos Producto
            List<Producto> productos = JsonConvert.DeserializeObject<List<Producto>>(jsonContent);

            // Filtrar los productos que coinciden con el destino y la calificación
            List<Producto> productosFiltrados = productos.Where(p =>
                p.Alojamiento != null && p.Alojamiento.CodCiudad == destino && p.Alojamiento.Calificacion >= calificacion).ToList();

            // Filtrar las habitaciones disponibles dentro del rango de fechas
            List<dynamic> alojamientosDisponibles = new List<dynamic>();

            foreach (var producto in productosFiltrados)
            {
                foreach (var habitacion in producto.Alojamiento.HabitacionAlojamiento)
                {
                    bool habitacionDisponible = habitacion.DisponibilidadHabitacion.Any(d =>
                        d.Fecha >= fechaIngreso && d.Fecha <= fechaEgreso && d.CantidadDisponible > 0);

                    if (habitacionDisponible && habitacion.CapacidadAdultos >= cantidadAdultos &&
                        habitacion.CapacidadMenores >= cantidadMenores && habitacion.CapacidadInfantes >= cantidadInfantes)
                    {
                        var alojamientoSimplificado = new
                        {
                            CodCiudad = producto.Alojamiento.CodCiudad,
                            alojamiento = producto.Alojamiento.NombreAlojamiento,
                            FechaIngreso = fechaIngreso,
                            FechaSalida = fechaEgreso,
                            NombreAlojamiento = producto.Alojamiento.NombreAlojamiento,
                            Tarifa = habitacion.Tarifa,
                            NombreHabitacion = habitacion.NombreHabitacion,
                            Calificacion = producto.Alojamiento.Calificacion
                        };

                        alojamientosDisponibles.Add(alojamientoSimplificado);
                    }
                }
            }

            return alojamientosDisponibles;
        }


    }
}