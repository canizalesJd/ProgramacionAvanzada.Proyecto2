using CapaEntidades;

/*
 * Universidad Estatal a Distancia (UNED)
 * Cuatrimestre: I Cuatrimestre 2026
 * Proyecto: Proyecto 1 - Programación Avanzada | AutoMarket
 * Descripción: Programa de gestión de ventas de vehículos
 * Estudiante: Jose David Canizales Azocar
 * Fecha: Febrero 2026
 */

namespace CapaAccesoDatos
{
    public class ClienteDAL
    {
        private static Cliente[] clientes = new Cliente[5];
        private static int contador;
 
        // Método para agregar un nuevo cliente
        public static void Guardar(Cliente cliente)
        {
            /* Evitar duplicados: 
              * Antes de agregar un nuevo cliente, verificar que no exista otro cliente con el mismo ID
              * o la misma identificación. Si se encuentra un cliente con el mismo ID o identificación
              * lanzar una excepción indicando que el cliente ya existe.
            */
            if (IdClienteExiste(cliente.IdCliente))
            {
                throw new InvalidOperationException("El cliente con el ID proporcionado ya existe.");
            }

            if (IdentificacionExiste(cliente.Identificacion))
            {
                throw new InvalidOperationException("El cliente con la identificación proporcionada ya existe.");
            }

            // Verificar capacidad: Antes de agregar un nuevo cliente, verificar que el arreglo no haya alcanzado su capacidad máxima de 5 registros. Si se intenta agregar más allá de esta capacidad, lanzar una excepción indicando que no se pueden agregar más clientes.
            if (contador >= clientes.Length)
            {
                throw new InvalidOperationException("No se pueden agregar más clientes, capacidad máxima alcanzada.");
            }
            clientes[contador] = cliente;
            contador++;
        }
        // Método para verificar si un cliente existe por su ID
        private static bool IdClienteExiste(int idCliente)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].IdCliente == idCliente)
                {
                    return true;
                }
            }
            return false;
        }

        // Metodo para verificar si un cliente existe por su identificación
        public static bool IdentificacionExiste(string identificacion)
        {
            for (int i = 0; i < contador; i++)
            {
                if (clientes[i].Identificacion == identificacion)
                {
                    return true;
                }
            }
            return false;
        }

        // Método para obtener todos los clientes
        public static Cliente[] Consultar()
        {
            Cliente[] resultado = new Cliente[contador];
            Array.Copy(clientes, resultado, contador);
            return resultado;
        }
    }
}
