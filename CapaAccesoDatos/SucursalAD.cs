using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: José David Cañizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaAccesoDatos
{
    /// <summary>
    /// Clase de acceso a datos para la entidad Sucursal. Esta clase proporciona métodos para almacenar y consultar sucursales en un arreglo estático.
    /// </summary>
    public class SucursalAD
    {
        // Arreglo estático para almacenar sucursales, con una capacidad máxima de 5 registros
        private static Sucursal[] sucursales = new Sucursal[5];
        private static int contador;

        /// <summary>
        /// Método para guardar una nueva sucursal en el arreglo.
        /// </summary>
        public static void Guardar(Sucursal sucursal)
        {
            // Evitar duplicados
            if (SucursalExiste(sucursal.IdSucursal))
            {
                throw new InvalidOperationException("La sucursal con el ID proporcionado ya existe.");
            }
            // Verificar capacidad
            if (contador >= sucursales.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más sucursales, capacidad máxima alcanzada.");
            }
            sucursales[contador] = sucursal;
            contador++;
        }

        /// <summary>
        /// Método para verificar si una sucursal existe por su ID
        /// </summary>
        public static bool SucursalExiste(int idSucursal)
        {
            for (int i = 0; i < contador; i++)
            {
                if (sucursales[i].IdSucursal == idSucursal)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Método para obtener todas las sucursales. Retorna solo las sucursales agregadas.
        /// </summary>
        public static Sucursal[] Consultar()
        {
            Sucursal[] resultado = new Sucursal[contador];
            Array.Copy(sucursales, resultado, contador);
            return resultado;
        }

        /// <summary>
        /// Método para obtener solo las sucursales activas. Retorna solo las sucursales que tienen el atributo Activa en true.
        /// </summary>
        public static Sucursal[] ConsultarActivas()
        {
            // Contar cuántas sucursales activas hay para crear un arreglo del tamaño correcto
            int totalActivas = 0;
            for (int i = 0; i < contador; i++)
            {
                if (sucursales[i].Activa) {
                    totalActivas++;
                }
            }

            // Crear el arreglo con el tamaño exacto necesario
            Sucursal[] resultado = new Sucursal[totalActivas];

            // Llenar el arreglo con las sucursales activas
            int indice = 0;
            for (int i = 0; i < contador; i++)
            {
                if (sucursales[i].Activa)
                {
                    resultado[indice] = sucursales[i];
                    indice++;
                }
            }

            return resultado;
        }
    }
}
